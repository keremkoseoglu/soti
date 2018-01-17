using Mind2Biz.DM.ClientMatter;
using System;
using System.Collections.Generic;
using System.Text;

namespace soti
{
    public class OpenText
    {
        public Mind2Biz.DM.ClientMatter.Manager manager;

        private const string ERROR_DUPLICATE = "Cannot insert duplicate key";
        private const string ERROR_MISSING_CLIENT = "Client record couldn't be found in Database";
        private const string ERROR_MISSING_MATTER = "Matter record couldn't be found in Database";

        public OpenText()
        {
        }

        public void connect()
        {
            if (Program.settings.otUsername != null && Program.settings.otUsername.Trim().Length > 0)
            {
                manager = new Manager(Program.settings.otServer, Program.settings.otDatabase, Program.settings.otUsername, Program.settings.otPassword);
            }
            else
            {
                manager = new Manager(Program.settings.otServer, Program.settings.otDatabase);
            }
        }

        public void setMasterData(Sapservice.ZLAW_I_GET_MASTER_DATAResponse Res)
        {
            for (int n = 0; n < Res.E_CUSTOMERS.Length; n++)
            {
                switch (Res.E_CUSTOMERS[n].ACTIO)
                {
                    case "I":
                        createClient(Res.E_CUSTOMERS[n]);
                        break;
                    case "U":
                        updateClient(Res.E_CUSTOMERS[n]);
                        break;
                    case "D":
                        deleteClient(Res.E_CUSTOMERS[n]);
                        break;
                }
            }

            for (int n = 0; n < Res.E_MATTERS.Length; n++)
            {
                switch (Res.E_MATTERS[n].ACTIO)
                {
                    case "I":
                        createMatter(Res.E_MATTERS[n]);
                        break;
                    case "U":
                        updateMatter(Res.E_MATTERS[n]);
                        break;
                    case "D":
                        deleteMatter(Res.E_MATTERS[n]);
                        break;
                }
            }

            Program.sap.setMasterDataTransferred(Res);
        }

        private void createClient(soti.Sapservice.ZLAW_S_CUSTOMERI C)
        {
            try
            {
                manager.CreateClient(C.KUNNR, C.NAME1);
            } 
            catch (Exception ex)
            {
                if (isClientDuplicate(ex)) return;

                appendErrorObjectToLog(C, "Update");
                throw ex;
            }
        }

        private void updateClient(soti.Sapservice.ZLAW_S_CUSTOMERI C)
        {
            try
            {
                manager.UpdateClientName(C.KUNNR, C.NAME1);
            } 
            catch (Exception ex)
            {
                if (isClientMissing(ex))
                {
                    createClient(C);
                    return;
                }

                appendErrorObjectToLog(C, "Update");
                throw ex;
            }
        }

        private void deleteClient(soti.Sapservice.ZLAW_S_CUSTOMERI C)
        {
            try
            {
                manager.DeleteClient(C.KUNNR);
            }
            catch (Exception ex)
            {
                appendErrorObjectToLog(C, "Delete");
            }
        }

        private void createMatter(soti.Sapservice.ZLAW_S_MATTERI M)
        {
            try
            {
                manager.CreateMatter(M.MATNO, M.MATNM, M.KUNNR);
            }
            catch (Exception ex)
            {
                if (isMatterDuplicate(ex))
                {
                    updateMatter(M);
                    return;
                }

                if (isClientMissing(ex))
                {
                    createClient(extractClientFromMatter(M));
                    createMatter(M);
                    return;
                }

                appendErrorObjectToLog(M, "Update");
                throw ex;
            }
        }

        private void updateMatter(soti.Sapservice.ZLAW_S_MATTERI M)
        {
            try
            {
                manager.UpdateClientOfMatter(M.MATNO, M.KUNNR);
            }
            catch (Mind2Biz.DM.ClientMatter.DuplicatedRecordException)
            {
                // Buraya düþtüysek, aslýnda herþey yolundadýr
            }
            catch (Exception ex)
            {
                if (isMatterMissing(ex))
                {
                    createMatter(M);
                }
                else if (isClientMissing(ex))
                {
                    createClient(extractClientFromMatter(M));
                    updateMatter(M);
                }
                else
                {
                    appendErrorObjectToLog(M, "Update");
                    throw ex;
                }
            }

            try
            {
                manager.UpdateMatterName(M.MATNO, M.MATNM);
            }
            catch (Exception ex)
            {
                if (isMatterMissing(ex))
                {
                    createMatter(M);
                }
                else if (isClientMissing(ex))
                {
                    createClient(extractClientFromMatter(M));
                    updateMatter(M);
                }
                else
                {
                    appendErrorObjectToLog(M, "Update");
                    throw ex;
                }
            }
        }

        private void deleteMatter(soti.Sapservice.ZLAW_S_MATTERI M)
        {
            try
            {
                manager.DeleteMatter(M.MATNO);
            }
            catch (Exception ex)
            {
                appendErrorObjectToLog(M, "Delete");
            }
        }

        private bool isClientMissing(Exception E)
        {
            return E.ToString().IndexOf(ERROR_MISSING_CLIENT) >= 0;
        }

        private bool isClientDuplicate(Exception E)
        {
            return E.ToString().IndexOf(ERROR_DUPLICATE) >= 0;
        }

        private bool isMatterMissing(Exception E)
        {
            return E.ToString().IndexOf(ERROR_MISSING_MATTER) >= 0;
        }

        private bool isMatterDuplicate(Exception E)
        {
            return E.ToString().IndexOf(ERROR_DUPLICATE) >= 0;
        }

        private soti.Sapservice.ZLAW_S_CUSTOMERI extractClientFromMatter(soti.Sapservice.ZLAW_S_MATTERI M)
        {
            soti.Sapservice.ZLAW_S_CUSTOMERI c = new soti.Sapservice.ZLAW_S_CUSTOMERI();
            c.ACTIO = "I";
            c.KUNNR = M.KUNNR;
            c.NAME1 = M.NAME1;
            c.ONAM1 = M.ONAM1;
            c.ONAM2 = M.ONAM2;
            return c;
        }

        private void appendErrorObjectToLog(soti.Sapservice.ZLAW_S_CUSTOMERI C, string Operation)
        {
            appendErrorObjectToLog("Customer", C.KUNNR, C.NAME1, Operation);
        }

        private void appendErrorObjectToLog(soti.Sapservice.ZLAW_S_MATTERI M, string Operation)
        {
            appendErrorObjectToLog("Matter", M.MATNO, M.MATNM, Operation);
        }

        private void appendErrorObjectToLog(string ObjectType, string Key, string Text, string Operation)
        {
            Program.appendLog(Operation + " error for " + ObjectType + " " + Key + " - " + Text + ": ");
        }
        
    }
}
