using TailwindViewComponents.RCL.Models;

namespace TailwindViewComponents.RCL.Services.Buttons
{
    public interface IBtnService
    {
        BtnModel GetCancelBtn(string BtnId, string BtnContent);
        BtnModel GetConfirmBtn(string BtnId, string BtnContent);
    }
}
