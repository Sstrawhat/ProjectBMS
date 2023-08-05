using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMS.UserInterface.Pages.Admin.Configuration.Notification
{
    public class _PageActionModel : PageModel
    {
        public PartialViewResult OnGetForm()
        {
            return Partial("../Admin/Configuration/Notification/Form");
        }
    }
}
