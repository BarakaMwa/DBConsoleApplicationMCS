using System;
using Controllers.Actors.ActorAdd;
using Controllers.Actors.ActorDelete;
using Controllers.Actors.ActorEdit;
using Controllers.Actors.ActorSearch;
using Controllers.Actors.ActorView;
using DataBaseConnection;
using Controllers.Category.Add;
using Controllers.Category.Delete;
using Controllers.Category.Edit;
using Controllers.Category.Search;
using Controllers.Category.View;

namespace DBConsoleApplicationMCS
{
    public class Program
    {
        protected Program(){}

        public static int Main()
        {

            var conn = new DbConnection();
            
            int showMenu = 1;
            while (showMenu != 0)
            {
                showMenu = MainMenu(showMenu);
            }

            return showMenu;
        }

        private static int MainMenu(int showMenu)
        {
            
            Console.WriteLine("Welcome To Sakila Database");
            // Console.WriteLine("Enter 1 to View Tables");
            Console.WriteLine("Enter 2 to Add Actor");
            Console.WriteLine("Enter 3 to Edit Actor");
            Console.WriteLine("Enter 4 to Delete Actor");
            Console.WriteLine("Enter 5 to View Actors");
            Console.WriteLine("Enter 6 to Search Actor");
            Console.WriteLine("Enter 7 to Add Category");
            Console.WriteLine("Enter 8 to Edit Category");
            Console.WriteLine("Enter 9 to Delete Category");
            Console.WriteLine("Enter 10 to View Categorys");
            Console.WriteLine("Enter 11 to Search Category");
            Console.WriteLine("Enter 0 to Exit Program");

            // Create a string variable and get user input from the keyboard and store it in the variable
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                /*case 1:
                    ViewTablesController.ViewTables();
                    break;*/
                case 2:
                    AddActorController.AddActor();
                    break;
                case 3:
                    EditActorController.EditActor();
                    break;
                case 4:
                    DeleteActorController.DeleteActor();
                    break;
                case 5:
                    ViewActorsController.ViewActors();
                    break;
                case 6:
                    SearchActorsController.SearchActors();
                    ReturnToMainMenu();
                    break;
                case 7:
                    AddCategoryController.AddCategory();
                    break;
                case 8:
                    EditCategoryController.EditCategory();
                    break;
                case 9:
                    DeleteCategoryController.DeleteCategory();
                    break;
                case 10:
                    ViewCategoriesController.ViewCategorys();
                    break;
                case 11:
                    SearchCategoriesController.SearchCategories();
                    ReturnToMainMenu();
                    break;
                case 0:
                    showMenu = choice;
                    Console.WriteLine("Exiting Program");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            return showMenu;
        }

        public static void ReturnToMainMenu()
        {
            Console.WriteLine("Enter 1-Return To Menu...");
            // Create a string variable and get user input from the keyboard and store it in the variable
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Main();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    ReturnToMainMenu();
                    break;
            }
        }
    }
}