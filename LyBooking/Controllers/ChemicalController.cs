﻿using Microsoft.AspNetCore.Mvc;
using LyBooking.DTO;
using LyBooking.Helpers;
using LyBooking.Services;
using Syncfusion.JavaScript;
using System.Threading.Tasks;

namespace LyBooking.Controllers
{
    public class ChemicalController : ApiControllerBase
    {
        private readonly IChemicalService _service;

        public ChemicalController(IChemicalService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet]
        public async Task<ActionResult> LoadDataBySite(string siteID)
        {
            return Ok(await _service.LoadDataBySite(siteID));
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] ChemicalDto model)
        {
            return StatusCodeResult(await _service.AddAsync(model));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateAsync([FromBody] ChemicalDto model)
        {
            return StatusCodeResult(await _service.UpdateAsync(model));
        }

        [HttpPost]
        public async Task<ActionResult> DeleteAsync(decimal id)
        {
            return StatusCodeResult(await _service.DeleteAsync(id));
        }

        [HttpGet]
        public async Task<ActionResult> GetByIDAsync(decimal id)
        {
            return Ok(await _service.GetByIDAsync(id));
        }

        [HttpGet]
        public async Task<ActionResult> GetWithPaginationsAsync(PaginationParams paramater)
        {
            return Ok(await _service.GetWithPaginationsAsync(paramater));
        }
        [HttpPost]
        public async Task<ActionResult> LoadData([FromBody] DataManager request, [FromQuery] string farmGuid)
        {

            var data = await _service.LoadData(request, farmGuid);
            return Ok(data);
        }
        [HttpGet]
        public async Task<ActionResult> GetAudit(decimal id)
        {
            return Ok(await _service.GetAudit(id));
        }
    }
}
