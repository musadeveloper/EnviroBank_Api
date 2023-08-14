using NUnit.Framework;
using Moq;
using EnviroBank.Repositories;
using EnviroBank.Models;
using EnviroBank.Helpers;
using System;
using System.Linq;
using EnviroBank.Data;
using Newtonsoft.Json;
using EnviroBank.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnviroBank.Tests
{
    [TestFixture]
    [TestFixture]
    public class EnviroBankControllerTests
    {
        private Mock<EnviroBankRepository> _repositoryMock;
        private EnviroBankController _controller;

        [SetUp]
        public void Setup()
        {
            _repositoryMock = new Mock<EnviroBankRepository>();
            _controller = new EnviroBankController(_repositoryMock.Object);
        }

        [Test]
        public void Login_ValidLogin_ReturnsOk()
        {
           
            var login = new Login { EmailAddress = "john@example.com", Password = "paasword1" };
            var successResponse = new BaseResponse { Success = true };
            _repositoryMock.Setup(r => r.Login(login)).Returns(successResponse);

            
            var result = _controller.Login(login) as ObjectResult;

   
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
            Assert.AreEqual(successResponse, result.Value);
        }

        [Test]
        public void GetAccountsByHolder_Authorized_ReturnsOk()
        {

            var accountHolder = 1;
            var successResponse = new BaseResponse { Success = true };
            _repositoryMock.Setup(r => r.GetAccountsByHolder(accountHolder)).Returns(successResponse);

           
            var result = _controller.GetAccountsByHolder(accountHolder) as ObjectResult;

       
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
            Assert.AreEqual(successResponse, result.Value);
        }

        [Test]
        public void GetAccountByAccountNumber_Authorized_ReturnsOk()
        {
            
            var accountNumber = 1234567895;
            var successResponse = new BaseResponse { Success = true };
            _repositoryMock.Setup(r => r.GetAccountByAccountNumber(accountNumber)).Returns(successResponse);

            
            var result = _controller.GetAccountByAccountNumber(accountNumber) as ObjectResult;

          
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
            Assert.AreEqual(successResponse, result.Value);
        }

        [Test]
        public void Withdraw_ValidRequest_ReturnsOk()
        {
     
            var accountNumber = 1234567895;
            var amount = 50;
            var successResponse = new BaseResponse { Success = true };
            _repositoryMock.Setup(r => r.Withdraw(accountNumber, amount)).Returns(successResponse);

          
            var result = _controller.Withdraw(accountNumber, amount) as ObjectResult;

           
            Assert.IsNotNull(result);
            Assert.AreEqual(StatusCodes.Status200OK, result.StatusCode);
            Assert.AreEqual(successResponse, result.Value);
        }
    }
}
