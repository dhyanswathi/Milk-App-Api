using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Milk.Api.Controllers;

namespace Milk.Api.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        await using var application = new WebApplicationFactory<MilksController>();
        using var client = application.CreateClient();

        var response = await client.GetAsync("/Milks");
        response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);

    }
}