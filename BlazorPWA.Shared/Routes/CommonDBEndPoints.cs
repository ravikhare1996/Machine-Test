using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPWA.Shared.Routes
{
    public class CommonDBEndPoints
    {
        public static string GetDataTable(string? Query)
        {
            return $"api/CommonDB/GetDataTable?Query={Query}";
        }
        public static string GetDataTablePaginated(string Query, int pageNumber, int pageSize, string Name, string[]? orderBy)
        {
            var url = $"api/CommonDB/Search?Query={Query}&pageno={pageNumber}&pagesize={pageSize}&name={Name}&orderby=";
            if (orderBy?.Any() == true)
            {
                foreach (var orderByPart in orderBy)
                {
                    url += $"{orderByPart},";
                }
                url = url[..^1];
            }
            return url;
        }
        public static string getSingleValue(string? Query)
        {
            return $"api/CommonDB/getSingleValue?Query={Query}";
        }
        
        public static string ExecuteNonQuery(string? Query)
        {
            return $"api/CommonDB/ExecuteNonQuery?Query={Query}";
        }
        public static string UpdateImage(string strColName, byte[] LogoImg, string strTableName, string strWhrCls)
        {
            return $"api/CommonDB/UpdateImage?strColName={strColName}&LogoImg={LogoImg}&strTableName={strTableName}&strWhrCls={strWhrCls}";
        }
        public static string GetServerDate()
        {
            return $"api/CommonDB/ServerDate?";
        }
    }
}
