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
    public partial interface IclsItemMasterDataProxy : IXpertCommonDataProxyDomain<clsItemMaster> 
    {
         IEnumerable<clsItemMaster> GetData(string Doc_No);

         IEnumerable<clsItemMaster> GetAll(int start, int pageSize);

         Task<clsItemMaster> GetDataAsync(string Doc_No);

         Task< IEnumerable<clsItemMaster>> GetAllAsync(int start, int pageSize, string SearchString = "", string OrderBy = "");
    }
}
