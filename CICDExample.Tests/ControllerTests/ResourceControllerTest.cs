using CICDExample.Controllers;
using CICDExample.Services.Interfaces;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CICDExample.Tests.ControllerTests
{
    public class ResourceControllerTest
    {

        private readonly Mock<ICatanService> _mockCatanService;
        private readonly ResourceController _resourceController;

        public ResourceControllerTest()
        {
            _mockCatanService = new();
            _resourceController = new ResourceController(_mockCatanService.Object);
        }

        [Fact]
        public void GetResourcesShouldReturnValidResources()
        {
            // Arrange
            var resources = new List<string>() { "wheat", "wool", "wood", "ore", "brick" };
            _mockCatanService.Setup(service => service.GetResources()).Returns(resources);

            // Act
            var result = _resourceController.GetResources();

            // Assert
            var okResult = result as OkObjectResult;
            okResult.Should().NotBeNull();
            okResult.StatusCode.Should().Be(200);
            okResult.Value.Should().BeEquivalentTo(resources);
        }
    }
}
