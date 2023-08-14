using EnviroBank.Helpers;
using EnviroBank.Models;
using EnviroBank.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnviroBank.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EnviroBankController : ControllerBase
    {

        private readonly EnviroBankRepository _repository;

        public EnviroBankController(EnviroBankRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] Login login)
        {

            var response = _repository.Login(login);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("accounts/{accountHolder}")]
        [Authorize]
        public IActionResult GetAccountsByHolder(int accountHolder)
        {
            var response = _repository.GetAccountsByHolder(accountHolder);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }


        [HttpGet("account/{accountNumber}")]
        [Authorize]
        public IActionResult GetAccountByAccountNumber(int accountNumber)
        {
            var response = _repository.GetAccountByAccountNumber(accountNumber);
            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }


        [HttpPatch("account/{accountNumber}/withdraw/{amount}")]
        [Authorize]
        public IActionResult Withdraw(int accountNumber, decimal amount)
        {
            var response = _repository.Withdraw(accountNumber, amount);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
