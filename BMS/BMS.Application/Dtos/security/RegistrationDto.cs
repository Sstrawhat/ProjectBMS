using Application.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Dtos.security
{
    public class RegistrationDto
    {
        [Identifier("txtFirstname")]
        [RequiredAttribute]
        [FormCSS("form-control")]
        [PlaceHolder("Firstname")]
        public string Firstname { get; set; }

        [Identifier("txtLastname")]
        [RequiredAttribute]
        [FormCSS("form-control")]
        [PlaceHolder("Lastname")]
        public string Lastname { get; set; }

        [Identifier("txtEmailAddress")]
        [RequiredAttribute]
        [FormCSS("form-control")]
        [PlaceHolder("Email Address")]
        public string EmailAddress { get; set; }

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

        [Identifier("txtConfirmPassword")]
        [RequiredAttribute]
        [FormCSS("form-control")]
        [PlaceHolder("Confirm Password")]
        public string ConfirmPassword { get; set; }
        public short Usertype { get; set; }

        [Identifier("chkAdminAccess")]
        [FormCSS("form-check-input")]
        public bool AdminAccess { get; set; }

        [Identifier("chkBarangayAccess")]
        [FormCSS("form-check-input")]
        public bool BarangayAccess { get; set; }
    }
}
 