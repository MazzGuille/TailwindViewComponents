using Microsoft.AspNetCore.Mvc;
using TailwindViewComponents.UI.Models;

namespace TailwindViewComponents.UI.ViewComponents
{
    public class BtnCancelViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(BtnLocalModel model)
        {
            return View(model);
        }
    }
}
