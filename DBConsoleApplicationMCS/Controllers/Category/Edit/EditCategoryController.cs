using Controllers.Category.Search;

namespace Controllers.Category.Edit
{
    public class EditCategoryController
    {
        protected EditCategoryController(){}
        public static bool EditCategory()
        {
            bool success = true;
            
            success = SearchCategoriesController.SearchCategories();

            return success;
        }
    }
}