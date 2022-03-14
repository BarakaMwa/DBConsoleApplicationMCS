using System;
using DataBaseConnection;

namespace Services.ActorDelete
{
    public class DeleteActorService
    {
        protected DeleteActorService() { }

        public static bool DeleteActorQuery(int actorId)
        {
            var conn = new DbConnection();
            bool status = true;
            try
            {
                /*string sql = "DELETE FROM actor WHERE actor_id=" + actorId;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object result = cmd.ExecuteNonQuery();*/
                var actor = conn.Actor.Find(actorId);
                conn.Actor.Remove(actor);
                conn.SaveChanges();
                
                Console.WriteLine(" Actor Deleted ");
               
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