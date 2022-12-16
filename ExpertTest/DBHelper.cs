using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using System.IO;

namespace ExpertTest
{
    class DBHelper
    {
        private static OracleConnection conn = null;
        public static string DBConnString
        {
            get;
            private set;
        }

        public DBHelper() { }
        public static OracleConnection DBConn
        {
            get
            {
                if (!ConnectToDB())
                {
                    return null;
                }
                return conn;
            }
        }
        public static bool bDBConnCheck = false;
        private static int errorBoxCount = 0;

        public static bool ConnectToDB()
        {
            if (conn == null)
            {
                DBConnString = String.Format("Data Source=(DESCRIPTION="

              + "(ADDRESS=(PROTOCOL=TCP)(HOST=121.254.150.82)(PORT=6505))"

              + "(CONNECT_DATA=(SERVICE_NAME=BARISTA)));"

              + "User Id=USER_GLOBAL;Password=USER_GLOBAL1!");

                conn = new OracleConnection(DBConnString);
            }

            try
            {
                if (!IsDBConnected)
                {
                    conn.Open();

                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        bDBConnCheck = true;
                    }
                    else
                    {
                        bDBConnCheck = false;
                    }
                }
            }
            catch (Exception e)
            {
                errorBoxCount++;

                if (errorBoxCount == 1)
                {
                    MessageBox.Show(e.Message, "DBHelper - ConnectToDB()");
                }
                // FormSendConnectCheckEvent(bDBConnCheck);
                return false;
            }
            //FormSendConnectCheckEvent(bDBConnCheck);
            return true;
        }
        /// <summary>
        /// Database Open 여부 확인
        /// </summary>
        public static bool IsDBConnected
        {
            get
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    return false;
                }
                return true;
            }
        }
        /// <summary>
        /// Database 해제
        /// </summary>

        public static void Close()
        {
            if (IsDBConnected)
                DBConn.Close();
        }
    }
}
