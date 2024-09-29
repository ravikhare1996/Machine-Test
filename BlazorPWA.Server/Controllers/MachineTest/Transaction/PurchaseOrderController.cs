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
    [XSProgram(Module= "MachineTest", Program= "PurchaseOrder")]
    [XSCodeType(Type= XSCodeType.Standard)]
    public partial class PurchaseOrderController : XpertControllerBase<clsPurchaseOrder>
    {
        private IclsPurchaseOrderService _Service;

        public PurchaseOrderController(IclsPurchaseOrderService service) : base(service)
        {
            _Service = service;
        }


        [HttpPost]
        [Route("Create")]
        public async override Task<IActionResult> Create(clsPurchaseOrder entity)
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
        public async override Task<IActionResult> Update([FromQuery] string  id, clsPurchaseOrder entity)
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
            catch (Exception)
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
            catch (Exception)
            {
            throw;
            }
        }

        [HttpGet]
        [Route("GetPO_ItemListList")]
        public async virtual Task<IActionResult> GetPO_ItemListList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetPO_ItemListList(FinderType,WhereExpression);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetPOICodeList")]
        public async virtual Task<IActionResult> GetPOICodeList([FromQuery] string? FinderType, string? WhereExpression)
        {
            var data = await _Service.GetPOICodeList(FinderType,WhereExpression);
            return Ok(data);
        }
    }
}
