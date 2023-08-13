using BMS.Application.Contracts.BaseRepository;
using BMS.Common.Base;
using BMS.Persistence.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Persistence.Implementation.BaseRepository
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        private readonly BMSContext context_;

        public GenericRepository(BMSContext context)
        {
            this.context_ = context;
        }
        public async Task<BaseResponse> DeleteRecordAsync(int id)
        {
            var response = new BaseResponse();

            try
            {

            }
            catch (Exception ex)
            {

               response.Message.Add(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse> RetrieveListRecordAsync()
        {
            var response = new BaseResponse();

            try
            {
               
            }
            catch (Exception ex)
            {

                response.Message.Add(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse> RetrieveRecordAsync(int id, params Expression<Func<T, object>>[] includes)
        {
            var response = new BaseResponse();
            try
            {

                IQueryable<T> query = context_.Set<T>();

                foreach (var include in includes)
                {
                    query = query.Include(include);
                }

                response.Response = query.FirstOrDefault(e => e.Key == id);
            }
            catch (Exception ex)
            {

                response.Message.Add(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse> SaveRecordAsync(T model)
        {
            var response = new BaseResponse();

            try
            {

            }
            catch (Exception ex)
            {

                response.Message.Add(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse> SPRetrieveListRecordAsync(string SpName)
        {
            var response = new BaseResponse();

            try
            {

            }
            catch (Exception ex)
            {

                response.Message.Add(ex.Message);
            }

            return response;
        }
    }
}
