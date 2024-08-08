using System.Linq;
using System.ComponentModel;
using BlazorPWA.Shared.VMs;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Attributes;

namespace BlazorPWA.Shared.Routes
{
    [Description("End Points")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public static partial class User_MasterEndPoints
    {
        public static string GetAllPaged(int pageNumber, int pageSize, string Name, string[] orderBy)
        {
            var url = $"api/User_Master/Search?pageno={pageNumber}&pagesize={pageSize}&name={Name}&orderby=";
            if (orderBy?.Any() == true)
            {
            foreach (var orderByPart in orderBy)
            {
              url += $"{ orderByPart},";
            }
            url = url[..^1];
            }
            return url;
        }

        public static string GetAll()
        {
            return $"api/User_Master";
        }

        public static string GetFinder(string? FinderName, string? WhereExpression)
        {
            return $"api/User_Master/Finder?FinderName={FinderName}&WhereExpression={WhereExpression}";
        }

        public static string GetCount(string? WhereExpression)
        {
            return $"api/User_Master/Count?WhereExpression={WhereExpression}";
        }

        public static string GetData(string ID)
        {
            return $"api/User_Master/{ID}";
        }

        public static string GetImage(string ID)
        {
            return $"api/User_Master/image/{ID}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{ExportData}?searchString={searchString}";
        }

        public static string SaveData()
        {
            return $"api/User_Master/Create?";
        }

        public static string EditData(string ID)
        {
            return $"api/User_Master/Edit?ID={ID}";
        }

        public static string DeleteData(string ID)
        {
            return $"api/User_Master/Delete?ID={ID}";
        }

        public static string ExportData()
        {
            return $"api/User_Master/Export";
        }

        public static string GetDefault()
        {
            return $"api/User_Master/Default";
        }

        public static string GetUser_TypeList(clsUser_MasterVM entity)
        {
            return $"api/User_Master/GetUser_TypeList?type={GetUser_TypeFinderType(entity)}&whereClause={GetUser_TypeFinderWhereClause(entity)}";
        }

        public static string GetClientList(clsUser_MasterVM entity)
        {
            return $"api/User_Master/GetClientList?type={GetClientFinderType(entity)}&whereClause={GetClientFinderWhereClause(entity)}";
        }

        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetUser_TypeFinderType(clsUser_MasterVM entity)
        {
            return null;
        }














































        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetUser_TypeFinderWhereClause(clsUser_MasterVM entity)
        {
            return null;
        }














































        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetClientFinderType(clsUser_MasterVM entity)
        {
            return null;
        }














































        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetClientFinderWhereClause(clsUser_MasterVM entity)
        {
            return null;
        }

    }
}
