using System;
using Services.Actors.ActorSearch;

namespace Controllers.Actors.ActorSearch
{
    public class SearchActorsController
    {
        public SearchActorsController() { }

        public static void SearchActors()
        {
            
            Console.WriteLine("To Search Actor");
            Console.WriteLine("Enter Part of First Or Last Name");
            string? searchName = Console.ReadLine();

            Console.WriteLine(" Getting Data");
            bool status = SearchActorsService.GetActors(searchName);
            if (!status)
            {
                Console.WriteLine("Can Not Search Or Find Actor");
            }
        }

    }
}