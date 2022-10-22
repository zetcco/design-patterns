using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class DBConnection
    {
        private static DBConnection? conn = null;
        private DBConnection()
        {

        }

        public static DBConnection getConnection()
        {
            if (conn == null)
            {
                conn = new DBConnection();
            }
            return conn;
        }
        public void connect()
        {
            if (conn != null)
                Console.WriteLine("Got connection");
            else
                Console.WriteLine("Error! Connection has already closed");
        }

        public void close()
        {
            conn = null;
        }
    }
}
