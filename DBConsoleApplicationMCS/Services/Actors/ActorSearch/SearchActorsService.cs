using System;
using System.Linq;
using DataBaseConnection;

namespace Services.Actors.ActorSearch
{
    public class SearchActorsService
    {
        protected SearchActorsService() { }

        public static bool GetActors(string? searchName)
        {
            bool status = true;
            try
            {
                var conn = new DbConnection();
                //SQL Query to execute
                /*string statementLike = " '%" + searchName + "%' or last_name LIKE '%" + searchName + "%' ";
                string sql = "SELECT * FROM actor WHERE first_name LIKE " + statementLike + " ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (!rdr.HasRows)
                {
                    status = false;
                }
                else
                {
                    //read the data
                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
                    }
                }

                rdr.Close();*/

                var actors = conn.Actor.Where(a=> a.FirstName.Contains(searchName)).ToList();
                foreach (var actor in actors)
                {
                    Console.WriteLine(actor.Id +" -- "+ actor.FirstName +" -- " + actor.LastName);
                }
                actors = conn.Actor.Where(a => a.LastName.Contains(searchName)).ToList();
                foreach (var actor in actors)
                {
                    Console.WriteLine(actor.Id +" -- "+ actor.FirstName +" -- " + actor.LastName);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                status = false;
            }

            return status;
        }

    }
}