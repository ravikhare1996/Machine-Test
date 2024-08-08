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
    [XSProgram(Module= "MachineTest", Program= "ItemMaster")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class ItemMasterController : XpertControllerBase<clsItemMaster>
    {
        private IclsItemMasterService _Service;

        public ItemMasterController(IclsItemMasterService service) : base(service)
        {
            _Service = service;
        }


        [HttpPost]
        [Route("Create")]
        public async override Task<IActionResult> Create(clsItemMaster entity)
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
        public async override Task<IActionResult> Update([FromQuery] string  id, clsItemMaster entity)
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
    }
}
