using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _FooterCompanentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
