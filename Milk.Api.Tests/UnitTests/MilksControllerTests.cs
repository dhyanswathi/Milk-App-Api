using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Milk.Api.Controllers;
using Milk.Api.Models;
using Milk.Api.Tests.MockData;
using Moq;
using Xunit;

namespace Milk.Api.Tests.UnitTests
{
    public class MilksControllerTests
    {
        [Fact]
        public void GetAll_shouldReturn200Status()
        {
            ///Arrange
            var milkRepo = new Mock<IMilkRepository>();
            milkRepo.Setup(x => x.GetAll()).Returns(MilkMockData.GetmockMilk());
            var sut = new MilksController(milkRepo.Object);

            ///Act
            var result = (OkObjectResult) sut.GetMilks();

            ///Assert
            result.StatusCode.Should().Be(200);
        }
    }
}
