using System.Net.Http;
using System.Text;
using Authorization_service;
using Authorization_service.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Authorization.UnitTest
{
    public class TokenControllerTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsTokenNull_When_InvalidUserCredentialsAreUsed()
        {
            //Arrange
            Mock<IConfiguration> config= new Mock<IConfiguration>();
            //Act
            var TokenObj = new TokenController(config.Object);
            
            var response =TokenObj.Login(new Authenticate(){Name = "wronginput",Password = "wronginput"});
            var result = response as UnauthorizedResult;
            //Assert
            Assert.AreEqual(401,result.StatusCode);
            
        }

    }
}