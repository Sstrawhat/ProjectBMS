using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMS.UserInterface.Pages.Admin.UserSecurity.RegisterAccount
{
    public class _PageAccountModel : PageModel
    {
        public PartialViewResult OnGetList()
        {
            return Partial("../Admin/UserSecurity/RegisterAccount/List");
        }
    }
}
