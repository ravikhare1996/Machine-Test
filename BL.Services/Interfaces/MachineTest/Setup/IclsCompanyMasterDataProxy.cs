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
    public partial interface IclsCompanyMasterDataProxy : IXpertCommonDataProxyDomain<clsCompanyMaster> 
    {
         IEnumerable<clsCompanyMaster> GetData(string Doc_No);

         IEnumerable<clsCompanyMaster> GetAll(int start, int pageSize);

         Task<clsCompanyMaster> GetDataAsync(string Doc_No);

         Task< IEnumerable<clsCompanyMaster>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "");

         Task<IEnumerable<FinderData>> GetCompany_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetBranch_TypeList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetProductList(string FinderType, string WhereExpression);

         Task<IEnumerable<FinderData>> GetStateList(string FinderType, string WhereExpression);
    }
}
