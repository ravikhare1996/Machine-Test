using GenericCrudApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using XpertStudio.Common.Attributes;
using XpertStudio.Common.Enums;
using MachineTest.Domain.Entities;
using MachineTest.Services.DomainServices;
using MachineTest.Services.Interfaces;

namespace BlazorPWA.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Policy =Policies.IsAnonymousUser)]
    [XSProgram(Module= "MachineTest", Program= "Company_Master")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class Company_MasterController : XpertControllerBase<clsCompanyMaster>
    {
        private IclsCompanyMasterService _Service;

        public Company_MasterController(IclsCompanyMasterService service) : base(service)
        {
            _Service = service;
        }


        [HttpPost]
        [Route("Create")]
        public async override Task<IActionResult> Create(clsCompanyMaster entity)
        {
            try
            {
            return await base.Create(entity);
            }
            catch (Exception)
            {
            throw;
            }
        }

        [HttpPut]
        [Route("Edit")]
        public async override Task<IActionResult> Update([FromQuery] string  id, clsCompanyMaster entity)
        {
            try
            {
            return await base.Update(id, entity);
            }
            catch (Exception)
            {
            throw;
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public async override Task<IActionResult> Delete([FromQuery] string  id)
        {
            try
            {
            return await base.Delete(id);
            }
            catch (Exception ex)
            {
            throw;
            }
        }

        [HttpGet]
        [Route("Count")]
        public async override Task<IActionResult> GetCount([FromQuery] string?  WhereExpression)
        {
            try
            {
            return await base.GetCount(WhereExpression);
            }
            catch (Exception ex)
            {
            throw;
            }
        }

        [HttpGet]
        [Route("GetCompany_TypeList")]
        public async virtual Task<IActionResult> GetCompany_TypeList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetCompany_TypeList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetBranch_TypeList")]
        public async virtual Task<IActionResult> GetBranch_TypeList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetBranch_TypeList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProductList")]
        public async virtual Task<IActionResult> GetProductList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetProductList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetStateList")]
        public async virtual Task<IActionResult> GetStateList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetStateList(FinderType,WhereExpression);
            return Ok(data);
        }
    }
}
