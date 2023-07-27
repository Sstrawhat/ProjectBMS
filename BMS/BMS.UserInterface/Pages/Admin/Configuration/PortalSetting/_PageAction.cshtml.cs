using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMS.UserInterface.Pages.Admin.Configuration.PortalSetting
{
    public class _PageActionModel : PageModel
    {
        public PartialViewResult OnGetList()
        {
            return Partial("../Admin/Configuration/PortalSetting/Form");
        }
    }
}
