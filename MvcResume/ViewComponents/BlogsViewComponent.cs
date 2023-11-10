using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class BlogsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ResumeContext context = new ResumeContext();    
            var blogs  = context.Blogs.ToList();
                return View("_Blogs",blogs);
        }
    }
}
