using Microsoft.AspNetCore.Mvc;

namespace TailwindViewComponents.UI.Controllers
{
    [Route("Btn")]
    public class BtnController : Controller
    {
        [HttpGet("GetCancelBtn")]
        public IActionResult GetCancelBtn(string btnId, string btnContent)
        {
            try
            {
                var viewComponentResult = ViewComponent("BtnCancel", new { btnId = btnId, btnContent = btnContent });
                return viewComponentResult;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        [HttpGet("GetConfirmBtn")]
        public IActionResult GetConfirmBtn(string btnId, string btnContent)
        {
            try
            {
                var viewComponentResult = ViewComponent("BtnConfirm", new { btnId = btnId, btnContent = btnContent });
                return viewComponentResult;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
