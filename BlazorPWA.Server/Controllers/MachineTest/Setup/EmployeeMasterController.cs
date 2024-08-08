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
    [XSProgram(Module= "MachineTest", Program= "EmployeeMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class EmployeeMasterController : XpertControllerBase<clsEmployee>
    {
        private IclsEmployeeService _Service;

        public EmployeeMasterController(IclsEmployeeService service) : base(service)
        {
            _Service = service;
        }


        [HttpPost]
        [Route("Create")]
        public async override Task<IActionResult> Create(clsEmployee entity)
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
        public async override Task<IActionResult> Update([FromQuery] string  id, clsEmployee entity)
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
        [Route("GetPAYMENT_TYPEList")]
        public async virtual Task<IActionResult> GetPAYMENT_TYPEList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetPAYMENT_TYPEList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetDESIGNATIONList")]
        public async virtual Task<IActionResult> GetDESIGNATIONList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetDESIGNATIONList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetCategory_TypeList")]
        public async virtual Task<IActionResult> GetCategory_TypeList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetCategory_TypeList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetPF_Phone_Number_TypeList")]
        public async virtual Task<IActionResult> GetPF_Phone_Number_TypeList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetPF_Phone_Number_TypeList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetESI_Phone_Number_TypeList")]
        public async virtual Task<IActionResult> GetESI_Phone_Number_TypeList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetESI_Phone_Number_TypeList(FinderType,WhereExpression);
            return Ok(data);
        }
    }
}
