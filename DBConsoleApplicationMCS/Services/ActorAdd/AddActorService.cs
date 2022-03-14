using System;
using DataBaseConnection;
using DBConsoleApplicationMCS;
using Models;

namespace Services.ActorAdd
{
    public class AddActorService
    {
        protected AddActorService() { }

        public static bool InsertActor(string? firstName, string? lastName)
        {
            var conn = new DbConnection();
            bool status = true;
            try
            {
                Console.WriteLine("Inserting Data...");
                //SQL Query to execute
                /*string sql = "INSERT INTO actor (first_name,last_name) VALUES ('" + firstName + "','" + lastName + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();*/
                var actor = new ActorModel();
                actor.FirstName = firstName;
                actor.LastName = lastName;
                
                conn.Actor.Add(actor);
                conn.SaveChanges();
                
                //insert the data
                Console.WriteLine("Actor Added");
                Program.ReturnToMainMenu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Can Not Add Actor" + e);
                status = false;
            }

            return status;
        }

    }
}