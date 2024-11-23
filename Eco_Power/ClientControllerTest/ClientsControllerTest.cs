﻿using Microsoft.AspNetCore.Mvc;
using Eco_Power.Controllers;
using Eco_Power.Models;
using Xunit;
using Moq;
using Eco_Power.Services;

namespace Eco_Power .ClientsControllerTest
{
    public class ClientsControllerTests
    {
        [Fact]
        public async Task Register_ShouldReturnOk_WhenClientIsValid()
        {
            // Arrange
            var client = new Client { Name = "Joao pedro", Email = "jaaao@gmail.com", Password = "senha" };
            var mockService = new Mock<IClientService>();
            mockService.Setup(s => s.RegisterUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
           .Returns(Task.CompletedTask);
            var controller = new ClientsController(mockService.Object);

            // Act
            var result = await controller.Register(client);

            // Assert
            Assert.IsType<OkResult>(result);
        }
    }

}
