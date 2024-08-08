using  System;
using  System.Collections.Generic;
using  System.ComponentModel;
using  System.IO;
using  Newtonsoft.Json;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  XpertStudio.Framework.Attributes;
using  XpertStudio.Framework;
using  XpertStudio.Framework.Exceptions;
using  XpertStudio.Framework.Domain;
using  XpertStudio.Common.Data;
using  XpertStudio.Common.Enums;
using  XpertStudio.Common.Attributes;
using  XpertStudio.Common.Globals;
using  MachineTest.Domain.Entities;
using  MachineTest.Domain.Rules;
using  MachineTest.Services.Interfaces;
using  MachineTest.Services.Commands;

namespace MachineTest.Services.DomainServices
{
    [Description("Domain Service Class")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsVendorMasterService : XpertCommonServiceDomainBase<clsVendorMaster>, IclsVendorMasterService
    {
        protected IclsVendorMasterDataProxy _DataProxy;

        public clsVendorMasterService(IclsVendorMasterDataProxy dataProxy) : base((dataProxy))
        {
            _DataProxy = dataProxy;
        }

        public IclsVendorMasterDataProxy DomainDataProxy
        {
            get { return DataProxy as IclsVendorMasterDataProxy; }
        }

        protected override void OnInsertCommandInitialization(clsVendorMaster entity, ExecutionContext<clsVendorMaster> context)
        {
            entity.CreatedDatetime = DateTime.Now; 
            entity.CreatedBy = CurrentLoginData.CurrentUserCode;
        }

        protected override async Task OnInsertCommandInitializationAsync(clsVendorMaster entity, ExecutionContext<clsVendorMaster> context)
        {
            await Task.Run(() => { OnInsertCommandInitialization(entity, context); });
        }

        protected override IEnumerable<IRule> GetBusinessRulesForUpdate(clsVendorMaster entity, ExecutionContext<clsVendorMaster> context)
        {
            yield return new clsVendorMasterRules(entity);
        }

        protected override async Task<IEnumerable<IRule>> GetBusinessRulesForUpdateAsync(clsVendorMaster entity, ExecutionContext<clsVendorMaster> context)
        {
            IEnumerable <IRule> rules=null;
            await Task.Run(() => { rules = new clsVendorMasterRules(entity).ToArray();});
            return rules;
        }

        public ICommand<IEnumerable<clsVendorMaster>> GetAllCommand(int start, int pageSize)
        {
            return new ServiceCommand<IEnumerable<clsVendorMaster>>
            (
            executeMethod: () => DomainDataProxy.GetAll(start, pageSize),
            executeAsyncMethod: () => DomainDataProxy.GetAllAsync(start, pageSize)
            );
        }

        public override ICommand<clsVendorMaster> InsertCommand(clsVendorMaster entity)
        {
            return new clsVendorMasterCreateCommand(entity, _DataProxy);
        }

        public override ICommand<clsVendorMaster> UpdateCommand(clsVendorMaster entity)
        {
            return new clsVendorMasterUpdateCommand(entity, _DataProxy);
        }

        public override ICommand DeleteCommand(string Doc_No)
        {
            return new clsVendorMasterDeleteCommand(Doc_No, _DataProxy);
        }

        public ExecutionResult SaveData(clsVendorMaster obj, bool IsNew, string Program_Code)
        {
            try
            {
            ExecutionResult result;
            if (IsNew)
            {
            result = InsertCommand(obj).Execute();
            }
            else
            {
            result = UpdateCommand(obj).Execute();
            }
            if (result.Success)
            {
            return result;
            }
            else
            {
            throw new Exception(result.Errors.First().ToString());
            }
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public ExecutionResult DeleteData(string Doc_No, string Program_Code)
        {
            try
            {
            ExecutionResult result;
            result = DeleteCommand(Doc_No).Execute();
            if (result.Success)
            {
            return result;
            }
            else
            {
            throw new Exception(result.Errors.First().ToString());
            }
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public IEnumerable<clsVendorMaster> GetData(string Doc_No, string Program_Code)
        {
            try
            {
             return DomainDataProxy.GetData(Doc_No);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public IEnumerable<clsVendorMaster> GetAllData(int start, int pageSize, string Program_Code)
        {
            try
            {
             return DomainDataProxy.GetAll(start, pageSize);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task Insert(clsVendorMaster obj)
        {
            try
            {
            var result = await InsertCommand(obj).ExecuteAsync();
            if (!result.Success)
            {
            throw new Exception(result.Errors.First().ToString());
            }
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task Update(clsVendorMaster obj)
        {
            try
            {
            var result = await UpdateCommand(obj).ExecuteAsync();
            if (!result.Success)
            {
            throw new Exception(result.Errors.First().ToString());
            }
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task Delete(params object[] keys)
        {
            try
            {
            string Doc_No = string.Empty;
            if (keys != null)
            {
            Doc_No = keys[0].ToString();
            }
            else
            {
            throw new Exception("Key Document No is required to delete!!");
            }
            var result = await DeleteCommand(Doc_No).ExecuteAsync();
            if (!result.Success)
            {
            throw new Exception(result.Errors.First().ToString());
            }
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task<clsVendorMaster> Get(params object[] keys)
        {
            try
            {
            string Doc_No = string.Empty;
            if (keys != null)
            {
            Doc_No = keys[0].ToString();
            }
            else
            {
            throw new Exception("Key Document No is required to Get!!");
            }
            return await DomainDataProxy.GetByIDAsync(Doc_No);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task<IEnumerable<clsVendorMaster>> GetAll()
        {
            try
            {
            return await DomainDataProxy.GetAllAsync();
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task<clsVendorMaster> GetData(string Doc_No)
        {
            try
            {
             return (clsVendorMaster)await DomainDataProxy.GetDataAsync(Doc_No);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task<IEnumerable<clsVendorMaster>> GetAllPaginated(int PageNo, int PageSize, string SearchString = "", string OrderBy = "")
        {
            try
            {
            return await DomainDataProxy.GetAllAsync(PageNo, PageSize, SearchString, OrderBy);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task<IEnumerable<IFinderData>> GetFinder(string FinderName, string whereExpression)
        {
            try
            {
            string filePath = "Data\\Finder\\"+ FinderName  + ".json";
            if (File.Exists(filePath)==true)
            {
            string jsonContent = File.ReadAllText(filePath);
            var finderConfig = JsonConvert.DeserializeObject<IXpertDataSource>(jsonContent);
            var data = base.GetFinder(finderConfig);
            return data;
            }
            else
            {
            return await DomainDataProxy.GetFinder(whereExpression);
            }
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task<int> GetCount(string whereExpression)
        {
            try
            {
            return await DomainDataProxy.GetCount(whereExpression);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }
    }
}
