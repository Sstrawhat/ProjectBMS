using AutoMapper;
using BMS.Application.Models.security;
using BMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Profiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            #region Security
            CreateMap<UserAccountModel, UserAccount>().ReverseMap();
            #endregion

        }
        
      
    }
}
