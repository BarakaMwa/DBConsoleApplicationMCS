using System;
using DBConsoleApplicationMCS;
using Services.ActorAdd;

namespace Controllers.ActorAdd
{
    public class AddActorController
    {
        protected AddActorController() { }
        public static void AddActor()
        {
            Console.WriteLine("Add Actor Enter First Name");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Add Actor Enter Last Name");
            string? lastName = Console.ReadLine();

            bool status = AddActorService.InsertActor(firstName, lastName);
            if (!status)
            {
                Program.ReturnToMainMenu();
            }

        }


    }
}