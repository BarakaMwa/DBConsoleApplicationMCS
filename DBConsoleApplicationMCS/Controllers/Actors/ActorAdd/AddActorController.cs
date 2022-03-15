using System;
using DBConsoleApplicationMCS;
using Services.Actors.ActorAdd;

namespace Controllers.Actors.ActorAdd
{
    public class AddActorController
    {
        protected AddActorController() { }
        public static void AddActor()
        {
            bool status = true;
            Console.WriteLine("Add Actor Enter First Name");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Add Actor Enter Last Name");
            string? lastName = Console.ReadLine();
            if (lastName != null || firstName != null)
            {
                if ("".Equals(lastName) || "".Equals(firstName))
                {
                    status = AddActorService.InsertActor(firstName, lastName);
                }
                else
                {
                    Console.WriteLine("Empty First Or Last Name");
                    status = false;
                }
            }
            else
            {
                Console.WriteLine("Null First Or Last Name");
                status = false;
            }
            
            if (!status)
            {
                Program.ReturnToMainMenu();
            }

        }


    }
}