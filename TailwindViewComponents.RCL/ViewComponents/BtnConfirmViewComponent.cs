using Microsoft.AspNetCore.Mvc;
using TailwindViewComponents.RCL.Services.Buttons;

namespace TailwindViewComponents.RCL.ViewComponents;
public class BtnConfirmViewComponent(IBtnService btnService) : ViewComponent
{
    private readonly IBtnService _btnService = btnService;

    public IViewComponentResult Invoke(string btnId, string btnContent)
    {
        var model = _btnService.GetConfirmBtn(btnId, btnContent);
        return View(model);
    }
}
