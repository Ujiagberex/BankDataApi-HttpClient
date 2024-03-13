using BankDataApi.Infrastructure.BankApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankDataController : ControllerBase
    {
        private readonly IBankData _bankdata;

        public BankDataController(IBankData bankdata)
        {
            _bankdata = bankdata;
        }

        //public IBankData Get_bankData()
        //{
        //    return _bankdata;
        //}

        [HttpGet]
        [Route("Get")]

        public async Task<IActionResult> GetNews()
        {
            await _bankdata.GetData();
            return Ok();
        }
    }
}
