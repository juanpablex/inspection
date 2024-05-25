using Business.Repositories.PaymentMethodRepository;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IPaymentMethodService _paymentmethodService;

        public PaymentMethodsController(IPaymentMethodService paymentmethodService)
        {
            _paymentmethodService = paymentmethodService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>Add(PaymentMethod paymentmethod)
        {
            var result = await _paymentmethodService.Add(paymentmethod);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Update(PaymentMethod paymentmethod)
        {
            var result = await _paymentmethodService.Update(paymentmethod);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Delete(PaymentMethod paymentmethod)
        {
            var result = await _paymentmethodService.Delete(paymentmethod);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _paymentmethodService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _paymentmethodService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
