using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class TestimonialsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ResumeContext context = new ResumeContext();
            var Testimonials = context.Testimonials.ToList();
            return View("_Testimonials", Testimonials);  
        }
    }
}
