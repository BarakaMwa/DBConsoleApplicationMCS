using System;
using DBConsoleApplicationMCS;
using Services.Category.Add;

namespace Controllers.Category.Add
{
    public class AddCategoryController
    {
        protected AddCategoryController(){}

        public static void  AddCategory()
        {
            bool success = true;
            
            Console.WriteLine("Adding New Category"); 
            string? category = Console.ReadLine();

            if (category != null || "".Equals(category))
            {
                success = AddCategoryService.AddCategory(category);
            }
            else
            { 
                Console.WriteLine("Null First Or Last Name");
                Console.WriteLine("Empty First Or Last Name");
                success = false;
            }

            if (!success)
            {
                Program.ReturnToMainMenu();
            }
            
        }
    }
}