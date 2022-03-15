using System;
using Controllers.Actors.ActorSearch;
using DBConsoleApplicationMCS;
using Services.Actors.ActorEdit;

namespace Controllers.Actors.ActorEdit
{
    public class EditActorController
    {
        public EditActorController() { }
        public static void EditActor()
        {
            bool status = true;
            SearchActorsController.SearchActors();
            Console.WriteLine("Enter Actor Number You Want To Edit");
            int actorId = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Are You Sure?Y/N");
            string choice = Console.ReadLine();
            choice = choice.ToLower();
            switch (choice)
            {
                case "y":
                    Console.WriteLine(" Editing Data");
                    status = EditActorService.GetActorEditor(actorId);
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
                Console.WriteLine("Can Not Edit Or Find Actor");
            }
        }
        
    }
}