using Application.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Dtos.security
{
    public class UserCredentialDto
    {
        [Identifier("txtUsername")]
        [RequiredAttribute]
        [FormCSS("form-control")]
        [PlaceHolder("Username")]
        public string Username { get; set; }

        [Identifier("txtPassword")]
        [RequiredAttribute]
        [FormCSS("form-control")]
        [PlaceHolder("Password")]
        public string Password { get; set; }

        [Identifier("chkRememberMe")]
        [FormCSS("form-check-input")]
        public bool RememberMe { get; set; }
    }
}
