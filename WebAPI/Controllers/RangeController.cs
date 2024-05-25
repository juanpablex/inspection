using Business.Repositories.RangeRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RangesController : ControllerBase
    {
        private readonly IRangeService _rangeService;

        public RangesController(IRangeService rangeService)
        {
            _rangeService = rangeService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>Add(Entities.Concrete.Range range)
        {
            var result = await _rangeService.Add(range);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(Entities.Concrete.Range range)
        {
            var result = await _rangeService.Update(range);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(Entities.Concrete.Range range)
        {
            var result = await _rangeService.Delete(range);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _rangeService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _rangeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
