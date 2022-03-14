using DataBaseConnection;
using System;
using System.Linq;

namespace Services.ActorEdit
{
    public class EditActorService
    {
        protected EditActorService()
        {
        }

        public static bool GetActorEditor(int actorId)
        {
            bool status = true;
            Console.WriteLine("Editing...");
            Console.WriteLine("Enter New Actor First Name");
            Console.WriteLine("Or Zero To Skip");
            string? value = Console.ReadLine();
            string column = "first_name";
                
            status = CheckValueQueryStatus(actorId, value, column, status);

            Console.WriteLine("Enter New Actor Last Name");
            Console.WriteLine("Or Zero To Skip");
            value = Console.ReadLine();
            column = "last_name";

            status = CheckValueQueryStatus(actorId, value, column, status);

            return status;
        }

        public static bool CheckValueQueryStatus(int actorId, string? value, string column,
            bool status)
        {
            
            switch (value)
            {
                case "0":
                    Console.WriteLine(column + " Skipped");
                    break;
                case "":
                    Console.WriteLine(column + " Skipped");
                    break;
                default:
                    status = QueryEditActorNames(column, value, actorId);
                    if (!status)
                    {
                        Console.WriteLine(column + " Failed to Update");
                    }
                    break;
            }
            return status;
        }

        private static bool QueryEditActorNames(string? column, string? value, int actorId)
        {
            bool status = true;
            var conn = new DbConnection();
            try
            {
                /*string sql = "UPDATE actor SET " + column + "='" + value + "' WHERE actor_id=" + actorId;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object result = cmd.ExecuteNonQuery();if (result == null)
                {
                    status = false;
                }
                else
                {
                    Console.WriteLine(column + "  Updated ");
                }*/
                var actor = conn.Actor.FirstOrDefault(a => a.Id == actorId);
                
                if (column != null && column == "first_name")
                {
                    if (actor != null)
                    {
                        actor.FirstName = value;
                        conn.SaveChanges();
                    }
                    Console.WriteLine(column + " UpDated");
                }
                else if (column != null && column == "last_name")
                {
                    if (actor != null)
                    {
                        actor.LastName = value;
                        conn.SaveChanges();
                    }
                    Console.WriteLine(column + " UpDated");
                }
                else
                {
                    status = false;
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