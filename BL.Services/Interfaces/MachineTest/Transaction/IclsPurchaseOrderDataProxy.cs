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
    public partial interface IclsPurchaseOrderDataProxy : IXpertCommonDataProxyDomain<clsPurchaseOrder> 
    {
         IEnumerable<clsPurchaseOrder> GetData(string Doc_No);

         IEnumerable<clsPurchaseOrder> GetAll(int start, int pageSize);

         Task<clsPurchaseOrder> GetDataAsync(string Doc_No);

         Task< IEnumerable<clsPurchaseOrder>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "");

         Task<IEnumerable<FinderData>> GetPOVCodeList(string FinderType, string WhereExpression);
    }
}
