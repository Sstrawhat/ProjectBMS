using Application.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Dtos.security
{
    public class ForgotPasswordDto
    {
        [Identifier("txtUsername")]
        [RequiredAttribute]
        [FormCSS("form-control")]
        [PlaceHolder("Username")]
        public string Username { get; set; }

        [Identifier("txtEmail")]
        [RequiredAttribute]
        [FormCSS("form-control")]
        [PlaceHolder("Email")]
        public string Email { get; set; }
    }
}
 