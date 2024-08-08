using  System;
using  System.Collections.Generic;
using  System.ComponentModel;
using  XpertStudio.Framework.Domain;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  XpertStudio.Common.Data;
using  XpertStudio.Common.Enums;
using  XpertStudio.Common.Attributes;
using  MachineTest.Domain.Entities;

namespace MachineTest.Services.Interfaces
{
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial interface IclsEmployeeDataProxy : IXpertCommonDataProxyDomain<clsEmployee> 
    {
         IEnumerable<clsEmployee> GetData(string Doc_No);

         IEnumerable<clsEmployee> GetAll(int start, int pageSize);

         Task<clsEmployee> GetDataAsync(string Doc_No);

         Task< IEnumerable<clsEmployee>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "");

         Task<IEnumerable<FinderData>> GetPAYMENT_TYPEList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetDESIGNATIONList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetCategory_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetPF_Phone_Number_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetESI_Phone_Number_TypeList(string FinderType, string WhereExpression);
    }
}
