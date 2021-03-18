using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lesson07.Components
{
    public class MovieListViewComponent : ViewComponent
    {
        string[] movieList = { "One Flew Over the Cuckoo's Nest", "Schindler's List", "Before Sunrise", "Blue Ruin", "To Kill a Mockingbird","Star Wars"};
            
        public IViewComponentResult Invoke(int items = 3) { 
            return View(movieList.Take(items));
        }
    }
}





