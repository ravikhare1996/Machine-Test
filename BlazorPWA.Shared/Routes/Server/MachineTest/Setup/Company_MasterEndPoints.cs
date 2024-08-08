using System.Linq;
using System.ComponentModel;
using BlazorPWA.Shared.VMs;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Attributes;

namespace BlazorPWA.Shared.Routes
{
    [Description("End Points")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public static partial class Company_MasterEndPoints
    {
        public static string GetAllPaged(int pageNumber, int pageSize, string Name, string[] orderBy)
        {
            var url = $"api/Company_Master/Search?pageno={pageNumber}&pagesize={pageSize}&name={Name}&orderby=";
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
            return $"api/Company_Master";
        }

        public static string GetFinder(string? FinderName, string? WhereExpression)
        {
            return $"api/Company_Master/Finder?FinderName={FinderName}&WhereExpression={WhereExpression}";
        }

        public static string GetCount(string? WhereExpression)
        {
            return $"api/Company_Master/Count?WhereExpression={WhereExpression}";
        }

        public static string GetData(string ID)
        {
            return $"api/Company_Master/{ID}";
        }

        public static string GetImage(string ID)
        {
            return $"api/Company_Master/image/{ID}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{ExportData}?searchString={searchString}";
        }

        public static string SaveData()
        {
            return $"api/Company_Master/Create?";
        }

        public static string EditData(string ID)
        {
            return $"api/Company_Master/Edit?ID={ID}";
        }

        public static string DeleteData(string ID)
        {
            return $"api/Company_Master/Delete?ID={ID}";
        }

        public static string ExportData()
        {
            return $"api/Company_Master/Export";
        }

        public static string GetDefault()
        {
            return $"api/Company_Master/Default";
        }

        public static string GetCompany_TypeList(clsCompanyMasterVM entity)
        {
            return $"api/Company_Master/GetCompany_TypeList?type={GetCompany_TypeFinderType(entity)}&whereClause={GetCompany_TypeFinderWhereClause(entity)}";
        }

        public static string GetProductList(clsCompanyMasterVM entity)
        {
            return $"api/Company_Master/GetProductList?type={GetProductFinderType(entity)}&whereClause={GetProductFinderWhereClause(entity)}";
        }

        public static string GetStateList(clsCompanyMasterVM entity)
        {
            return $"api/Company_Master/GetStateList?type={GetStateFinderType(entity)}&whereClause={GetStateFinderWhereClause(entity)}";
        }

        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetCompany_TypeFinderType(clsCompanyMasterVM entity)
        {
            return null;
        }




        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetCompany_TypeFinderWhereClause(clsCompanyMasterVM entity)
        {
            return null;
        }




        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetProductFinderType(clsCompanyMasterVM entity)
        {
            return null;
        }




        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetProductFinderWhereClause(clsCompanyMasterVM entity)
        {
            return null;
        }




        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetStateFinderType(clsCompanyMasterVM entity)
        {
            return null;
        }




        [XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetStateFinderWhereClause(clsCompanyMasterVM entity)
        {
            return null;
        }

    }
}
