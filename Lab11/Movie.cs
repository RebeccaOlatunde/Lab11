using System;
namespace Lab11
{
    public class Movie
    {
        private string Title;
        private string Category;
        
        private Movie (string title, string category)
        {
            Title = title;
            Category = category;
        }

            public string GetTitle()

        {
            return Title;
        }
            
            public string GetCategory()
        {
            return Category;
        }

        
    
    }

}
