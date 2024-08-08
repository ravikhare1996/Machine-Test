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
    [XSProgram(Module= "MachineTest", Program= "User_Master")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class User_MasterController : XpertControllerBase<clsUser_Master>
    {
        private IclsUser_MasterService _Service;

        public User_MasterController(IclsUser_MasterService service) : base(service)
        {
            _Service = service;
        }


        [HttpPost]
        [Route("Create")]
        public async override Task<IActionResult> Create(clsUser_Master entity)
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
        public async override Task<IActionResult> Update([FromQuery] string  id, clsUser_Master entity)
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
        [Route("GetUser_TypeList")]
        public async virtual Task<IActionResult> GetUser_TypeList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetUser_TypeList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetClientList")]
        public async virtual Task<IActionResult> GetClientList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetClientList(FinderType,WhereExpression);
            return Ok(data);
        }
    }
}
