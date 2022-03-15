using System;
using Services.Category.Search;

namespace Controllers.Category.Search
{
    public class SearchCategoriesController
    {
        public static bool SearchCategories()
        {
            bool success = true;

            Console.WriteLine("Search Category");
            Console.WriteLine("Enter Part Or Full Category Name To Search");
            string category = Console.ReadLine();

            if (category != null || "".Equals(category))
            {
                success = SearchCategoryService.GetCategory(category);
            }
            else
            {
                Console.WriteLine("Empty Category Or");
                Console.WriteLine("Null Category");
                success = false;
            }
            return success;
        }
    }
}