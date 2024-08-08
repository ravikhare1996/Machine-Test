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
    public partial interface IclsUser_MasterDataProxy : IXpertCommonDataProxyDomain<clsUser_Master> 
    {
         IEnumerable<clsUser_Master> GetData(string Doc_No);

         IEnumerable<clsUser_Master> GetAll(int start, int pageSize);

         Task<clsUser_Master> GetDataAsync(string Doc_No);

         Task< IEnumerable<clsUser_Master>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "");

         Task<IEnumerable<FinderData>> GetUser_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetClientList(string FinderType, string WhereExpression);
    }
}
