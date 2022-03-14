/*using System;
using DataBaseConnection;
using DBConsoleApplicationMCS;

namespace ActorViewTables
{
    public class ViewTablesClass
    {
        protected ViewTablesClass() { }

        public static void ViewTables(DbConnection conn)
        {
            try
            {
                Console.WriteLine("Getting Data...");
                //SQL Query to execute
                //selecting only first 10 rows for demo
                /*string sql = "SELECT table_name FROM sys.schema_table_statistics_with_buffer WHERE table_schema = 'sakila';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
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

                rdr.Close();#1#
                
                var actors = conn.Actors.Where(a=> a.FirstName.Contains(searchName)).ToList();
                foreach (var actor in actors)
                {
                    Console.WriteLine(actor.Id +" -- "+ actor.FirstName +" -- " + actor.LastName);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            
            Program.ReturnToMainMenu();
        }

    }
}*/