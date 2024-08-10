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
    public partial class clsPurchaseOrderService : XpertCommonServiceDomainBase<clsPurchaseOrder>, IclsPurchaseOrderService
    {
        protected IclsPurchaseOrderDataProxy _DataProxy;

        public clsPurchaseOrderService(IclsPurchaseOrderDataProxy dataProxy) : base((dataProxy))
        {
            _DataProxy = dataProxy;
        }

        public IclsPurchaseOrderDataProxy DomainDataProxy
        {
            get { return DataProxy as IclsPurchaseOrderDataProxy; }
        }

        protected override void OnInsertCommandInitialization(clsPurchaseOrder entity, ExecutionContext<clsPurchaseOrder> context)
        {
            entity.CreatedDatetime = DateTime.Now; 
            entity.CreatedBy = CurrentLoginData.CurrentUserCode;
        }

        protected override async Task OnInsertCommandInitializationAsync(clsPurchaseOrder entity, ExecutionContext<clsPurchaseOrder> context)
        {
            await Task.Run(() => { OnInsertCommandInitialization(entity, context); });
        }

        protected override IEnumerable<IRule> GetBusinessRulesForUpdate(clsPurchaseOrder entity, ExecutionContext<clsPurchaseOrder> context)
        {
            yield return new clsPurchaseOrderRules(entity);
        }

        protected override async Task<IEnumerable<IRule>> GetBusinessRulesForUpdateAsync(clsPurchaseOrder entity, ExecutionContext<clsPurchaseOrder> context)
        {
            IEnumerable <IRule> rules=null;
            await Task.Run(() => { rules = new clsPurchaseOrderRules(entity).ToArray();});
            return rules;
        }

        public ICommand<IEnumerable<clsPurchaseOrder>> GetAllCommand(int start, int pageSize)
        {
            return new ServiceCommand<IEnumerable<clsPurchaseOrder>>
            (
            executeMethod: () => DomainDataProxy.GetAll(start, pageSize),
            executeAsyncMethod: () => DomainDataProxy.GetAllAsync(start, pageSize)
            );
        }

        public override ICommand<clsPurchaseOrder> InsertCommand(clsPurchaseOrder entity)
        {
            return new clsPurchaseOrderCreateCommand(entity, _DataProxy);
        }

        public override ICommand<clsPurchaseOrder> UpdateCommand(clsPurchaseOrder entity)
        {
            return new clsPurchaseOrderUpdateCommand(entity, _DataProxy);
        }

        public override ICommand DeleteCommand(string Doc_No)
        {
            return new clsPurchaseOrderDeleteCommand(Doc_No, _DataProxy);
        }

        public ExecutionResult SaveData(clsPurchaseOrder obj, bool IsNew, string Program_Code)
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

        public IEnumerable<clsPurchaseOrder> GetData(string Doc_No, string Program_Code)
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

        public IEnumerable<clsPurchaseOrder> GetAllData(int start, int pageSize, string Program_Code)
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

        public async Task Insert(clsPurchaseOrder obj)
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

        public async Task Update(clsPurchaseOrder obj)
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

        public async Task<clsPurchaseOrder> Get(params object[] keys)
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

        public async Task<IEnumerable<clsPurchaseOrder>> GetAll()
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

        public async Task<clsPurchaseOrder> GetData(string Doc_No)
        {
            try
            {
             return (clsPurchaseOrder)await DomainDataProxy.GetDataAsync(Doc_No);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        public async Task<IEnumerable<clsPurchaseOrder>> GetAllPaginated(int PageNo, int PageSize, string SearchString = "", string OrderBy = "")
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

        public async virtual Task< IEnumerable<FinderData>> GetPOVCodeList(string FinderType, string WhereExpression)
        {
            try
            {
            return await  DomainDataProxy.GetPOVCodeList(FinderType,WhereExpression);
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }

        public async virtual Task< IEnumerable<FinderData>> GetPOItemListList(string FinderType, string WhereExpression)
        {
            try
            {
            return await  DomainDataProxy.GetPOItemListList(FinderType,WhereExpression);
            }
            catch (Exception ex)
            {
            Serilog.Log.Fatal(ex.ToString());
            throw;
            }
        }
    }
}
