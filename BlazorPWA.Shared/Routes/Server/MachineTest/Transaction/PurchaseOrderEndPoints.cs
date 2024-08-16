using System.Linq;
using System.ComponentModel;
using BlazorPWA.Shared.VMs;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Attributes;

namespace BlazorPWA.Shared.Routes
{
    [Description("End Points")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public static partial class PurchaseOrderEndPoints
    {
        public static string GetAllPaged(int pageNumber, int pageSize, string Name, string[] orderBy)
        {
            var url = $"api/PurchaseOrder/Search?pageno={pageNumber}&pagesize={pageSize}&name={Name}&orderby=";
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
            return $"api/PurchaseOrder";
        }

        public static string GetFinder(string? FinderName, string? WhereExpression)
        {
            return $"api/PurchaseOrder/Finder?FinderName={FinderName}&WhereExpression={WhereExpression}";
        }

        public static string GetCount(string? WhereExpression)
        {
            return $"api/PurchaseOrder/Count?WhereExpression={WhereExpression}";
        }

        public static string GetData(string ID)
        {
            return $"api/PurchaseOrder/{ID}";
        }

        public static string GetImage(string ID)
        {
            return $"api/PurchaseOrder/image/{ID}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{ExportData}?searchString={searchString}";
        }

        public static string SaveData()
        {
            return $"api/PurchaseOrder/Create?";
        }

        public static string EditData(string ID)
        {
            return $"api/PurchaseOrder/Edit?ID={ID}";
        }

        public static string DeleteData(string ID)
        {
            return $"api/PurchaseOrder/Delete?ID={ID}";
        }

        public static string ExportData()
        {
            return $"api/PurchaseOrder/Export";
        }

        public static string GetDefault()
        {
            return $"api/PurchaseOrder/Default";
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPOItemListFinderType(clsPurchaseOrderVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPOItemListFinderWhereClause(clsPurchaseOrderVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetStatusFinderType(clsPurchaseOrderVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetStatusFinderWhereClause(clsPurchaseOrderVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPOVCodeFinderType(clsPurchaseOrderVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPOVCodeFinderWhereClause(clsPurchaseOrderVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPOICodeFinderType(clsPO_ItemVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPOICodeFinderWhereClause(clsPO_ItemVM entity)
        {
            return null;
        }
    }
}
