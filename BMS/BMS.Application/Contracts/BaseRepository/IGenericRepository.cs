using BMS.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Contracts.BaseRepository
{
    public interface IGenericRepository<T> 
        where T : class
    {
        public Task<BaseResponse> SaveRecordAsync(T model);

        public Task<BaseResponse> DeleteRecordAsync(int id);

        public Task<BaseResponse> RetrieveRecordAsync(int id);

        public Task<BaseResponse> RetrieveListRecordAsync();

        public Task<BaseResponse> SPRetrieveListRecordAsync(string SpName);
    }
}
