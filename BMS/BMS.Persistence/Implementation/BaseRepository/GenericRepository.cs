using BMS.Application.Contracts.BaseRepository;
using BMS.Common.Base;
using BMS.Common.Helpers;
using BMS.Persistence.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace BMS.Persistence.Implementation.BaseRepository
{
    public class GenericRepository<T,TList> : IGenericRepository<T, TList>
        where T : class
        where TList : class
    {
        private readonly BMSContext context_;

        public GenericRepository(BMSContext context)
        {
            this.context_ = context;
        }

        public async Task<BaseResponse> DeleteRecordAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includeProperties)
        {
            var response = new BaseResponse();

            try
            {
                var query = context_.Set<T>().AsQueryable();

                foreach (var includeProperty in includeProperties)
                    query = query.Include(includeProperty);

                this.context_.Remove(await query.FirstOrDefaultAsync(expression));

                await this.context_.SaveChangesAsync();

                response.Message.Add("Record has been remove.");
            }
            catch (Exception ex)
            {

                response.IsSuccess = false;
                response.Message.Add(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse> RetrieveRecordAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includeProperties)
        {
            var response = new BaseResponse();
            var query = context_.Set<T>().AsQueryable();

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            response.Response = await query.FirstOrDefaultAsync(expression);

            return response;
        }

        public async Task<BaseResponse> SaveRecordAsync(T model)
        {
            var response = new BaseResponse();

            try
            {
                var entityType = model.GetType();
                PropertyInfo[] properties = entityType.GetProperties();

                var primaryKeyValue = 0;

                foreach (PropertyInfo property in properties)
                {
                    if (Attribute.IsDefined(property, typeof(KeyAttribute)))
                    {
                        primaryKeyValue = (int)property.GetValue(model);
                        break;
                    }
                }

                if (primaryKeyValue == 0)
                {
                    await context_.AddAsync(model);
                }
                else
                {
                    context_.Update(model);
                }

                await context_.SaveChangesAsync();
                response.Message.Add("Record successfully saved.");
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message.Add(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse> SPRetrieveListRecordAsync(string SpName, params SpParams[] spParams)
        {

            var response = new BaseResponse();

            try
            {

                var parameters = new List<string>();

                foreach (var parameter in spParams)
                {
                    parameters.Add($"""
                            "@{parameter.ParamterName} = {parameter.ParamterValue}
                            """);
                }

                response.Response = await this.context_.Database.SqlQuery<TList>($"""
                            EXEC {SpName} {((parameters.Count > 0) ? string.Join(",", parameters) : "")}
                            """).ToListAsync();

            }
            catch (Exception ex)
            {

                response.IsSuccess = false;
                response.Message.Add(ex.Message);
            }

            return response;

        }
    }




}
