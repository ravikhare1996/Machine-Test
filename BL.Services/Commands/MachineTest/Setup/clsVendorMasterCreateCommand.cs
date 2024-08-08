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
    [Description("CreateCommand")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class clsVendorMasterCreateCommand : Command<clsVendorMaster>
    {
        protected IclsVendorMasterDataProxy _DataProxy;

        public clsVendorMasterCreateCommand(clsVendorMaster objDomain, IclsVendorMasterDataProxy objDomainDataProxy)
        {
            currObjDomain = objDomain;
            _DataProxy = objDomainDataProxy;
        }

        private clsVendorMaster currObjDomain { get; set; }

        protected override clsVendorMaster OnExecute()
        {
            try
            {
            return _DataProxy.Insert(currObjDomain);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        protected override async Task<clsVendorMaster> OnExecuteAsync()
        {
            try
            {
            return await _DataProxy.InsertAsync(currObjDomain);
            }
            catch (Exception ex)
            {
             Serilog.Log.Fatal(ex.ToString());
             throw;
            }
        }

        protected override IEnumerable<IRule> GetRules()
        {
            yield return new clsVendorMasterRules(currObjDomain);
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
