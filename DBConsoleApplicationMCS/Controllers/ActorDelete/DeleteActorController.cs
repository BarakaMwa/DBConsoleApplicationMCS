using Controllers.ActorSearch;
using Services.ActorDelete;
using System;
using DBConsoleApplicationMCS;

namespace Controllers.ActorDelete
{
    public class DeleteActorController
    {
        protected DeleteActorController() { }

        public static void DeleteActor()
        {
            bool status = true;
            SearchActorsController.SearchActors();
            Console.WriteLine("Enter Actor Number You Want To Delete");
            int actorId = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Are You Sure?Y/N");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            switch (choice)
            {
                case "y":
                    Console.WriteLine(" Deleting Data");
                    status = DeleteActorService.DeleteActorQuery(actorId);
                    break;
                case "n":
                    Program.ReturnToMainMenu();
                    status =false;
                    break;
                default:
                    Console.WriteLine("Invalid Response");
                    Program.ReturnToMainMenu();
                    status =false;
                    break;
            }
            
            if (!status)
            {
                Console.WriteLine("Could Not Delete Actor");
            }

        }


    }
}