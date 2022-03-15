using System;

namespace Controllers.Category.Search
{
    public class SearchCategoriesController
    {
        public static void SearchCategories()
        {
            bool success = true;

            Console.WriteLine("Search Category");
            Console.WriteLine("Enter Part Or Full Category Name To Search");
            string category = Console.ReadLine();

            if (category != null || "".Equals(category))
            {
                SearchCategoryService.SearchCategory(category);
            }
            else
            {
                Console.WriteLine("Empty Category Or");
                Console.WriteLine("Null Category");
            }
            
        }
    }
}