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
    public partial class clsCompanyMasterService : XpertCommonServiceDomainBase<clsCompanyMaster>, IclsCompanyMasterService
    {
        protected IclsCompanyMasterDataProxy _DataProxy;

        public clsCompanyMasterService(IclsCompanyMasterDataProxy dataProxy) : base((dataProxy))
        {
            _DataProxy = dataProxy;
        }

        public IclsCompanyMasterDataProxy DomainDataProxy
        {
            get { return DataProxy as IclsCompanyMasterDataProxy; }
        }

        protected override void OnInsertCommandInitialization(clsCompanyMaster entity, ExecutionContext<clsCompanyMaster> context)
        {
            entity.CreatedDatetime = DateTime.Now; 
            entity.CreatedBy = CurrentLoginData.CurrentUserCode;
        }

        protected override async Task OnInsertCommandInitializationAsync(clsCompanyMaster entity, ExecutionContext<clsCompanyMaster> context)
        {
            await Task.Run(() => { OnInsertCommandInitialization(entity, context); });
        }

        protected override IEnumerable<IRule> GetBusinessRulesForUpdate(clsCompanyMaster entity, ExecutionContext<clsCompanyMaster> context)
        {
            yield return new clsCompanyMasterRules(entity);
        }

        protected override async Task<IEnumerable<IRule>> GetBusinessRulesForUpdateAsync(clsCompanyMaster entity, ExecutionContext<clsCompanyMaster> context)
        {
            IEnumerable <IRule> rules=null;
            await Task.Run(() => { rules = new clsCompanyMasterRules(entity).ToArray();});
            return rules;
        }

        public ICommand<IEnumerable<clsCompanyMaster>> GetAllCommand(int start, int pageSize)
        {
            return new ServiceCommand<IEnumerable<clsCompanyMaster>>
            (
            executeMethod: () => DomainDataProxy.GetAll(start, pageSize),
            executeAsyncMethod: () => DomainDataProxy.GetAllAsync(start, pageSize)
            );
        }

        public override ICommand<clsCompanyMaster> InsertCommand(clsCompanyMaster entity)
        {
            return new clsCompanyMasterCreateCommand(entity, _DataProxy);
        }

        public override ICommand<clsCompanyMaster> UpdateCommand(clsCompanyMaster entity)
        {
            return new clsCompanyMasterUpdateCommand(entity, _DataProxy);
        }

        public override ICommand DeleteCommand(string Doc_No)
        {
            return new clsCompanyMasterDeleteCommand(Doc_No, _DataProxy);
        }

        public ExecutionResult SaveData(clsCompanyMaster obj, bool IsNew, string Program_Code)
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

        public IEnumerable<clsCompanyMaster> GetData(string Doc_No, string Program_Code)
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

        public IEnumerable<clsCompanyMaster> GetAllData(int start, int pageSize, string Program_Code)
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

        public async Task Insert(clsCompanyMaster obj)
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

        public async Task Update(clsCompanyMaster obj)
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

        public async Task<clsCompanyMaster> Get(params object[] keys)
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

        public async Task<IEnumerable<clsCompanyMaster>> GetAll()
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

        public async Task<clsCompanyMaster> GetData(string Doc_No)
        {
            try
            {
             return (clsCompanyMaster)await DomainDataProxy.GetDataAsync(Doc_No);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task<IEnumerable<clsCompanyMaster>> GetAllPaginated(int PageNo, int PageSize, string SearchString = "", string OrderBy = "")
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

        public async virtual Task< IEnumerable<FinderData>> GetCompany_TypeList(string FinderType, string WhereExpression)
        {
            try
            {
            return await  DomainDataProxy.GetCompany_TypeList(FinderType,WhereExpression);
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task< IEnumerable<FinderData>> GetBranch_TypeList(string FinderType, string WhereExpression)
        {
            try
            {
            return await  DomainDataProxy.GetBranch_TypeList(FinderType,WhereExpression);
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task< IEnumerable<FinderData>> GetProductList(string FinderType, string WhereExpression)
        {
            try
            {
            return await  DomainDataProxy.GetProductList(FinderType,WhereExpression);
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task< IEnumerable<FinderData>> GetStateList(string FinderType, string WhereExpression)
        {
            try
            {
            return await  DomainDataProxy.GetStateList(FinderType,WhereExpression);
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }
    }
}
