using System.Linq;
using System.ComponentModel;
using BlazorPWA.Shared.VMs;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Attributes;

namespace BlazorPWA.Shared.Routes
{
    [Description("End Points")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public static partial class VendorMasterEndPoints
    {
        public static string GetAllPaged(int pageNumber, int pageSize, string Name, string[] orderBy)
        {
            var url = $"api/VendorMaster/Search?pageno={pageNumber}&pagesize={pageSize}&name={Name}&orderby=";
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
            return $"api/VendorMaster";
        }

        public static string GetFinder(string? FinderName, string? WhereExpression)
        {
            return $"api/VendorMaster/Finder?FinderName={FinderName}&WhereExpression={WhereExpression}";
        }

        public static string GetCount(string? WhereExpression)
        {
            return $"api/VendorMaster/Count?WhereExpression={WhereExpression}";
        }

        public static string GetData(string ID)
        {
            return $"api/VendorMaster/{ID}";
        }

        public static string GetImage(string ID)
        {
            return $"api/VendorMaster/image/{ID}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{ExportData}?searchString={searchString}";
        }

        public static string SaveData()
        {
            return $"api/VendorMaster/Create?";
        }

        public static string EditData(string ID)
        {
            return $"api/VendorMaster/Edit?ID={ID}";
        }

        public static string DeleteData(string ID)
        {
            return $"api/VendorMaster/Delete?ID={ID}";
        }

        public static string ExportData()
        {
            return $"api/VendorMaster/Export";
        }

        public static string GetDefault()
        {
            return $"api/VendorMaster/Default";
        }
    }
}
