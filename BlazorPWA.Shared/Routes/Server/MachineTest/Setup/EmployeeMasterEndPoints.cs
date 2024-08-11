using System.Linq;
using System.ComponentModel;
using BlazorPWA.Shared.VMs;
using XpertStudio.Common.Enums;
using XpertStudio.Common.Attributes;

namespace BlazorPWA.Shared.Routes
{
    [Description("End Points")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public static partial class EmployeeMasterEndPoints
    {
        public static string GetAllPaged(int pageNumber, int pageSize, string Name, string[] orderBy)
        {
            var url = $"api/EmployeeMaster/Search?pageno={pageNumber}&pagesize={pageSize}&name={Name}&orderby=";
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
            return $"api/EmployeeMaster";
        }

        public static string GetFinder(string? FinderName, string? WhereExpression)
        {
            return $"api/EmployeeMaster/Finder?FinderName={FinderName}&WhereExpression={WhereExpression}";
        }

        public static string GetCount(string? WhereExpression)
        {
            return $"api/EmployeeMaster/Count?WhereExpression={WhereExpression}";
        }

        public static string GetData(string ID)
        {
            return $"api/EmployeeMaster/{ID}";
        }

        public static string GetImage(string ID)
        {
            return $"api/EmployeeMaster/image/{ID}";
        }

        public static string ExportFiltered(string searchString)
        {
            return $"{ExportData}?searchString={searchString}";
        }

        public static string SaveData()
        {
            return $"api/EmployeeMaster/Create?";
        }

        public static string EditData(string ID)
        {
            return $"api/EmployeeMaster/Edit?ID={ID}";
        }

        public static string DeleteData(string ID)
        {
            return $"api/EmployeeMaster/Delete?ID={ID}";
        }

        public static string ExportData()
        {
            return $"api/EmployeeMaster/Export";
        }

        public static string GetDefault()
        {
            return $"api/EmployeeMaster/Default";
        }

        public static string GetPAYMENT_TYPEList(clsEmployeeVM entity)
        {
            return $"api/EmployeeMaster/GetPAYMENT_TYPEList?type={GetPAYMENT_TYPEFinderType(entity)}&whereClause={GetPAYMENT_TYPEFinderWhereClause(entity)}";
        }

        public static string GetDESIGNATIONList(clsEmployeeVM entity)
        {
            return $"api/EmployeeMaster/GetDESIGNATIONList?type={GetDESIGNATIONFinderType(entity)}&whereClause={GetDESIGNATIONFinderWhereClause(entity)}";
        }

        public static string GetCategory_TypeList(clsEmployeeVM entity)
        {
            return $"api/EmployeeMaster/GetCategory_TypeList?type={GetCategory_TypeFinderType(entity)}&whereClause={GetCategory_TypeFinderWhereClause(entity)}";
        }

        public static string GetPF_Phone_Number_TypeList(clsEmployeeVM entity)
        {
            return $"api/EmployeeMaster/GetPF_Phone_Number_TypeList?type={GetPF_Phone_Number_TypeFinderType(entity)}&whereClause={GetPF_Phone_Number_TypeFinderWhereClause(entity)}";
        }

        public static string GetESI_Phone_Number_TypeList(clsEmployeeVM entity)
        {
            return $"api/EmployeeMaster/GetESI_Phone_Number_TypeList?type={GetESI_Phone_Number_TypeFinderType(entity)}&whereClause={GetESI_Phone_Number_TypeFinderWhereClause(entity)}";
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetCategory_TypeFinderType(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetCategory_TypeFinderWhereClause(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPAYMENT_TYPEFinderType(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPAYMENT_TYPEFinderWhereClause(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetDESIGNATIONFinderType(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetDESIGNATIONFinderWhereClause(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPF_Phone_Number_TypeFinderType(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetPF_Phone_Number_TypeFinderWhereClause(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetESI_Phone_Number_TypeFinderType(clsEmployeeVM entity)
        {
            return null;
        }
[XSCodeType(Type= XSCodeType.Custom)]
        public static string? GetESI_Phone_Number_TypeFinderWhereClause(clsEmployeeVM entity)
        {
            return null;
        }
    }
}
