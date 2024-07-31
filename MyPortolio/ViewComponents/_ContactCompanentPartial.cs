using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _ContactCompanentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
