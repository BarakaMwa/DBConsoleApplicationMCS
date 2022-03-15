/*using DataBaseConnection;
using DBConsoleApplicationMCS;
using System;

namespace Controllers.Actors.ActorViewTables
{
    public class ViewTablesController
    {
        public ViewTablesController() { }

        public static void ViewTables(DbConnection conn)
        {
            try
            {
                Console.WriteLine("Getting Data...");
                //SQL Query to execute
                //selecting only first 10 rows for demo
                /*string sql = "SELECT table_name FROM sys.schema_table_statistics_with_buffer WHERE table_schema = 'sakila';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();#1#
                if (rdr.HasRows)
                {
                    //read the data
                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0]);
                    }
                }
                else
                {
                    Console.WriteLine("No tables found");
                }

                rdr.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            Program.ReturnToMainMenu();
        }

    }
}*/