using Singleton;
using System.Data;
using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        DBConnection conn1 = DBConnection.getConnection();
        DBConnection conn2 = DBConnection.getConnection();

        conn1.connect();
        conn1.close();
        conn2.connect();

        DBConnection conn3 = DBConnection.getConnection();

        if (conn2 == conn3)
            Console.WriteLine("Same connection");
        else
            Console.WriteLine("Not same connection");
    }
}