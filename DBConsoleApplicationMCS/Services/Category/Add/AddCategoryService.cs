using System;
using DataBaseConnection;
using Models;

namespace Services.Category.Add
{
    public class AddCategoryService
    {
        protected AddCategoryService(){}
        public static bool AddCategory(string categoryName)
        {
            bool success = true;
            try
            {
                var conn = new DbConnection();
            
                Console.WriteLine("Inserting Data...");
                var category = new CategoryModel();
                category.Category = categoryName;
                
                conn.Category.Add(category);
                conn.SaveChanges();
                
                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("UnSuccessFully Inserted Data...");
                Console.WriteLine(ex);
                success = false;
            }
            
            
            Console.WriteLine("SuccessFully Inserting Data...");
            return success;

        }
    }
}