using System;
using System.Linq;
using DBConsoleApplicationMCS;
using DataBaseConnection;

namespace Services.ActorView
{
    public class ViewActorsClass{

       protected ViewActorsClass() { }

        public static void ViewActors()
        {
            try
            {
                int startRow = 0;
                //SQL Query to execute
                //selecting only first 10 rows for demo
                /*string sql = "select * from sakila.actor limit " + startRow + ",10;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
                    }
                }
                else
                {
                    Console.WriteLine("Can Not Find Actors");
                }


                rdr.Close();*/

                //read the data
                var conn = new DbConnection();
                var actor = conn.Actor.Where(a => a.Id < 20 ).ToList();
                foreach (var actors in actor)
                {
                    Console.WriteLine(actors.Id +" -- "+ actors.FirstName +" -- " + actors.LastName);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            
            Program.ReturnToMainMenu();
        }

    }
}