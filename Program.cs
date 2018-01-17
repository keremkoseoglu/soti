using System;
using System.Collections.Generic;
using System.Text;

namespace soti
{
    class Program
    {
        private static string VERSION = "1.0.8";
        private static OpenText openText;
        public static Sap sap;

        public static Settings1 settings;


        static void Main(string[] args)
        {
            appendLog("================================");
            appendLog("SOTI " + VERSION);
            appendLog("SAP OpenText Integration Program");
            appendLog("Çözümevi Consulting");
            appendLog("================================");

            try
            {
                settings = new Settings1();
                openText = new OpenText();
                openText.connect();
                sap = new Sap();

                appendLog("Transferring departments OpenText -> SAP");
                sap.setDepartments(openText.manager.GetDepartments());

                appendLog("Transferring document types OpenText -> SAP");
                sap.setDocumentTypes(openText.manager.GetDocumentTypes());

                appendLog("Transferring users OpenText -> SAP");
                sap.setUsers(openText.manager.GetPeoples());

                appendLog("Transferring master data SAP -> Opentext");
                openText.setMasterData(sap.getMasterData());

                appendLog("Integration completed");
            }
            catch (Exception ex)
            {
                appendLog(ex.ToString());
            }
        }

        public static void appendLog(string S)
        {
            string year = System.DateTime.Now.Year.ToString();
            string month = System.DateTime.Now.Month.ToString();
            if (month.Length == 1) month = "0" + month;
            string day = System.DateTime.Now.Day.ToString();
            if (day.Length == 1) day = "0" + day;
            string hour = System.DateTime.Now.Hour.ToString();
            if (hour.Length == 1) hour = "0" + hour;
            string minute = System.DateTime.Now.Minute.ToString();
            if (minute.Length == 1) minute = "0" + minute;
            string second = System.DateTime.Now.Second.ToString();
            if (second.Length == 1) second = "0" + second;

            Console.WriteLine("[" + year + month + day + hour + minute + second + "] " + S);
        }
    }
}
