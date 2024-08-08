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
using  XpertStudio.Framework.Extensions;
using  XpertStudio.Common.Enums;
using  XpertStudio.Common.Attributes;
using  MachineTest.Domain.Entities;
using  MachineTest.Services.Interfaces;
using  MachineTest.Domain.Rules;

namespace MachineTest.Services.Commands
{
    [Description("DeleteCommand")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsEmployeeDeleteCommand : Command
    {
        protected IclsEmployeeDataProxy _DataProxy;

        public clsEmployeeDeleteCommand(string ID, IclsEmployeeDataProxy DataProxy)
        {
            CurrentDocNo = ID;
            _DataProxy = DataProxy;
        }

        private string CurrentDocNo { get; set; }

        protected override void OnExecute()
        {
            try
            {
             _DataProxy.Delete(CurrentDocNo);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        protected override async Task OnExecuteAsync()
        {
            try
            {
             await _DataProxy.DeleteAsync(CurrentDocNo); 
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        protected override IEnumerable<IRule> GetRules()
        {
            var currObjDomain = _DataProxy.GetByID(CurrentDocNo);
            yield return new clsEmployeeRules(currObjDomain);
        }

        public override IEnumerable<ValidationResult> GetErrors()
        {
            var rule = CurrentDocNo.CreateValueRequiredRule("ID").Validate();
            if (!rule.IsValid)
            yield return new ValidationResult(rule.ErrorMessage);
            else
            {
            foreach (var error in GetRules().GetValidationResults())
            yield return error;
            }
        }

        public override async Task<IEnumerable<ValidationResult>> GetErrorsAsync()
        {
            return await Task.Run(()=> GetErrors());
        }
    }
}
