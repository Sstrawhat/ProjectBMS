using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMS.UserInterface.Pages.Admin.UserSecurity.UserAccount
{
    public class _PageActionModel : PageModel
    {
        public PartialViewResult OnGetList()
        {
            return Partial("../Admin/UserSecurity/UserAccount/List");
        }
    }
}
