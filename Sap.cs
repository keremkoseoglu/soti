using System;
using System.Collections.Generic;
using System.Text;

namespace soti
{
    public class Sap
    {
        private Sapservice.ZLAW_I6 serv;

        public Sap()
        {
            serv = new soti.Sapservice.ZLAW_I6();
            System.Net.NetworkCredential nc = new System.Net.NetworkCredential(Program.settings.sapUser, Program.settings.sapPassword);
            serv.UseDefaultCredentials = false;
            serv.Credentials = nc;
        }

        public void setUsers(System.Collections.Generic.IList<Mind2Biz.DM.ClientMatter.People> P)
        {
            Sapservice.ZLAW_DM_04[] p = new soti.Sapservice.ZLAW_DM_04[P.Count];
            for (int n = 0; n < P.Count; n++)
            {
                p[n] = new soti.Sapservice.ZLAW_DM_04();
                p[n].USRID = P[n].UserId;
                p[n].FNAME = P[n].FullName;
            }

            Sapservice.ZLAW_I_SET_DM_USERS z = new soti.Sapservice.ZLAW_I_SET_DM_USERS();
            z.I_USER = p;
            serv.ZLAW_I_SET_DM_USERS(z);
        }


        public void setDepartments(System.Collections.Generic.IList<Mind2Biz.DM.ClientMatter.Department> D)
        {
            Sapservice.ZLAW_S_DEPARTMENT[] d = new soti.Sapservice.ZLAW_S_DEPARTMENT[D.Count];
            for (int n = 0; n < D.Count; n++)
            {
                d[n] = new soti.Sapservice.ZLAW_S_DEPARTMENT();
                d[n].EDPRT = D[n].DepartmentCode;
                d[n].DPRTX = D[n].DepartmentName;
            }
            
            Sapservice.ZLAW_I_SET_DEPARTMENTS z = new soti.Sapservice.ZLAW_I_SET_DEPARTMENTS();
            z.I_DEPARTMENTS = d;
            serv.ZLAW_I_SET_DEPARTMENTS(z);
        }

        public void setDocumentTypes(System.Collections.Generic.IList<Mind2Biz.DM.ClientMatter.DocumentType> D)
        {
            Sapservice.ZLAW_S_DOCTYPE[] d = new soti.Sapservice.ZLAW_S_DOCTYPE[D.Count];
            for (int n = 0; n < D.Count; n++)
            {
                d[n] = new Sapservice.ZLAW_S_DOCTYPE();
                d[n].TYPEI = D[n].TypeId;
                d[n].DESCR = D[n].Description;
            }

            Sapservice.ZLAW_I_SET_DOCUMENT_TYPES z = new soti.Sapservice.ZLAW_I_SET_DOCUMENT_TYPES();
            z.I_DOCTYPES = d;
            serv.ZLAW_I_SET_DOCUMENT_TYPES(z);
        }

        public Sapservice.ZLAW_I_GET_MASTER_DATAResponse getMasterData()
        {
            Sapservice.ZLAW_I_GET_MASTER_DATA z = new soti.Sapservice.ZLAW_I_GET_MASTER_DATA();
            return serv.ZLAW_I_GET_MASTER_DATA(z);
        }

        public void setMasterDataTransferred(Sapservice.ZLAW_I_GET_MASTER_DATAResponse Res)
        {
            Sapservice.ZLAW_I_SET_MASTER_DATA_OK z = new soti.Sapservice.ZLAW_I_SET_MASTER_DATA_OK();
            z.I_ERDAT = Res.E_ERDAT;
            z.I_ERZET = Res.E_ERZET;
            serv.ZLAW_I_SET_MASTER_DATA_OK(z);
        }



    }
}
