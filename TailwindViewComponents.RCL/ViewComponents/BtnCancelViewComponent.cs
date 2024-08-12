using Microsoft.AspNetCore.Mvc;
using TailwindViewComponents.RCL.Services.Buttons;

namespace TailwindViewComponents.RCL.ViewComponents;
public class BtnCancelViewComponent : ViewComponent
{
    private readonly IBtnService _btnService;

    public BtnCancelViewComponent(IBtnService btnService)
    {
        _btnService = btnService;
    }

    public IViewComponentResult Invoke(string btnId, string btnContent)
    {
        var model = _btnService.GetCancelBtn(btnId, btnContent);
        return View(model);
    }
}
