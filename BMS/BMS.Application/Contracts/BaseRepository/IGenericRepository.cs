using BMS.Common.Base;
using BMS.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Application.Contracts.BaseRepository
{
    public interface IGenericRepository<T, TList>
        where T : class
         where TList : class
    {
        public Task<BaseResponse> SaveRecordAsync(T model);

        public Task<BaseResponse> DeleteRecordAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includeProperties);

        public Task<BaseResponse> RetrieveRecordAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includeProperties);

        public Task<BaseResponse> SPRetrieveListRecordAsync(string SpName, params SpParams[] spParams);
    }
}
