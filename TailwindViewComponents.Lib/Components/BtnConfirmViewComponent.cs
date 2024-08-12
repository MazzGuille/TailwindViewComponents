using Microsoft.AspNetCore.Mvc;
using TailwindViewComponents.Lib.Models;

namespace TailwindViewComponents.Lib.Components;
public class BtnConfirmViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(BtnModel model)
    {
        return View(model);
    }
}
