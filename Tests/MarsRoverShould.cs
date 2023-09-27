using Core;
using FluentAssertions;

namespace Tests;

public class MarsRoverShould
{
    [Fact]
    public void Return_Rover_Location()
    {
        MarsRoverApi marsRoverApi = new MarsRoverApi();

        var roverLocation = marsRoverApi.Execute("");

        roverLocation.Should().Be("0:0:N");
    }
}
