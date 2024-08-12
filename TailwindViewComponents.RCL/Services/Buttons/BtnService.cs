using TailwindViewComponents.RCL.Models;

namespace TailwindViewComponents.RCL.Services.Buttons
{
    public class BtnService : IBtnService
    {
        public BtnModel GetCancelBtn(string BtnId, string BtnContent)
        {
            var res = CreateBtn(BtnId, BtnContent);
            return res;
        }

        public BtnModel GetConfirmBtn(string BtnId, string BtnContent)
        {
            var res = CreateBtn(BtnId, BtnContent);
            return res;            
        }

        private BtnModel CreateBtn(string BtnId, string BtnContent)
        {
            return new BtnModel
            {
                BtnId = BtnId,
                BtnContent = BtnContent
            };
        }
    }
}
