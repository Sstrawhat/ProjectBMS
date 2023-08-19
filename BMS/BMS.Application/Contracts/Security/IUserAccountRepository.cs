using BMS.Application.Contracts.BaseRepository;
using BMS.Application.Models.security;
using BMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Contracts.Security
{
    public interface IUserAccountRepository : IGenericRepository<UserAccount,UserAccountListModel>
    {

    }
}
