using Microsoft.AspNetCore.Mvc;
using TailwindViewComponents.RCL.Models;

namespace TailwindViewComponents.RCL.ViewComponents;
public class BtnConfirmViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(BtnModel model)
    {
        return View(model);
    }
}
