using  System;
using  System.Collections.Generic;
using  System.ComponentModel;
using  System.ComponentModel.DataAnnotations;
using  System.Linq;
using  System.Text;
using  System.Threading.Tasks;
using  XpertStudio.Framework;
using  XpertStudio.Framework.Domain;
using  XpertStudio.Framework.Attributes;
using  XpertStudio.Common.Enums;
using  XpertStudio.Common.Attributes;
using  MachineTest.Domain.Entities;
using  MachineTest.Services.Interfaces;
using  MachineTest.Domain.Rules;

namespace MachineTest.Services.Commands
{
    [Description("UpdateCommand")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsPurchaseOrderUpdateCommand : Command<clsPurchaseOrder>
    {
        protected IclsPurchaseOrderDataProxy _DataProxy;

        public clsPurchaseOrderUpdateCommand(clsPurchaseOrder objDomain, IclsPurchaseOrderDataProxy objDomainDataProxy)
        {
            currObjDomain = objDomain;
            _DataProxy = objDomainDataProxy;
        }

        private clsPurchaseOrder currObjDomain { get; set; }

        protected override clsPurchaseOrder OnExecute()
        {
            try
            {
            return _DataProxy.Update(currObjDomain);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        protected override async Task<clsPurchaseOrder> OnExecuteAsync()
        {
            try
            {
            return await _DataProxy.UpdateAsync(currObjDomain);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        protected override IEnumerable<IRule> GetRules()
        {
            yield return new clsPurchaseOrderRules(currObjDomain);
        }

        public override IEnumerable<ValidationResult> GetErrors()
        {
            foreach (var error in GetRules().GetValidationResults())
            yield return error;
        }

        public override async Task<IEnumerable<ValidationResult>> GetErrorsAsync()
        {
            return await Task.Run(()=> GetErrors());
        }
    }
}
