using BMS.Application.Dtos.security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMS.UserInterface.Pages
{
    public class ForgotPasswordModel : PageModel
    {
        public ForgotPasswordDto forgotPasswordDto { get; set; }

        public void OnGet()
        {
            
        }
    }
}