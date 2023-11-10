using Microsoft.AspNetCore.Mvc;
using MvcResume.Models;

namespace MvcResume.ViewComponents
{
    public class PriceViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ResumeContext context = new ResumeContext();
            var model = context.Pricings.ToList();
            return View("_Price",model);
        }
    }
}
