using DBConsoleApplicationMCS;
using System;
using Services.Actors.ActorView;

namespace Controllers.Actors.ActorView
{
    public class ViewActorsController
    {

        public ViewActorsController() { }

        public static void ViewActors()
        {
            try
            {
                Console.WriteLine("Getting Data...");
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
               ViewActorsClass.ViewActors();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }
            
            Program.ReturnToMainMenu();
        }

    }
}