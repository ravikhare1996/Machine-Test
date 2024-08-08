using common.OFM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpertStudio.Common.Database;
using XpertStudio.Framework.Domain;

namespace BL.Services
{
    public class XpertServiceBase : ICommonDBMethods
    {
        public Task<bool> ExecuteNonQuery(string Query)
        {
            return Task.FromResult(XSDBFunctionality.ExecuteNonQuery(Query));
        }

        public Task<DataTable> GetDataTable(string Query)
        {
            return Task.FromResult(XSDBFunctionality.GetDataTable(Query));
        }
        public async Task<DataTable> GetDataTableAsync(string Query)
        {
            return await XSDBFunctionality.GetDataTableAsync(Query);
        }
        public async Task<DataTable> GetDataTablePaginated(string Query, int PageNo, int PageSize, string SearchString = "", string OrderBy = "")
        {
            try
            {
                return await XSDBFunctionality.GetDataTablePaginated(Query, PageNo, PageSize, SearchString, OrderBy);
            }
            catch (Exception ex)
            {
                Serilog.Log.Fatal(ex.ToString());
                throw;
            }
        }
        public async Task<object> getSingleValue(string Query)
        {
            return await Task.Run(() =>
            {
                var data = XSDBFunctionality.getSingleValue(Query);
                return data;
            });
            
        }

        public Task<bool> UpdateImage(string strColName, byte[] LogoImg, string strTableName, string strWhrCls)
        {
            return Task.FromResult(XSDBFunctionality.UpdateImage(strColName, LogoImg, strTableName, strWhrCls));
        }
    }
}
