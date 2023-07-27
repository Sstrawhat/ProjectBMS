using BMS.Application.Dtos.security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMS.UserInterface.Pages
{
    public class RegistrationModel : PageModel
    {

        public RegistrationDto registrationDto { get; set; }


        public void OnGet()
        {
            
        }
    }
}