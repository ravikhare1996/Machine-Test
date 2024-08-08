using System.Linq;
using System.ComponentModel;
using BlazorPWA.Shared.VMs;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Attributes;

namespace BlazorPWA.Shared.Routes
{
    [Description("End Points")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public static partial class ItemMasterEndPoints
    {
        public static string GetAllPaged(int pageNumber, int pageSize, string Name, string[] orderBy)
        {
            var url = $"api/ItemMaster/Search?pageno={pageNumber}&pagesize={pageSize}&name={Name}&orderby=";
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
            return $"api/ItemMaster";
        }

        public static string GetFinder(string? FinderName, string? WhereExpression)
        {
            return $"api/ItemMaster/Finder?FinderName={FinderName}&WhereExpression={WhereExpression}";
        }

        public static string GetCount(string? WhereExpression)
        {
            return $"api/ItemMaster/Count?WhereExpression={WhereExpression}";
        }

        public static string GetData(string ID)
        {
            return $"api/ItemMaster/{ID}";
        }

        public static string GetImage(string ID)
        {
            return $"api/ItemMaster/image/{ID}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{ExportData}?searchString={searchString}";
        }

        public static string SaveData()
        {
            return $"api/ItemMaster/Create?";
        }

        public static string EditData(string ID)
        {
            return $"api/ItemMaster/Edit?ID={ID}";
        }

        public static string DeleteData(string ID)
        {
            return $"api/ItemMaster/Delete?ID={ID}";
        }

        public static string ExportData()
        {
            return $"api/ItemMaster/Export";
        }

        public static string GetDefault()
        {
            return $"api/ItemMaster/Default";
        }
    }
}
