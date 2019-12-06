using System;
using Xunit;
using FluentAssertions;

namespace Orxe_Rover.Tests
{
    public class RoverFixtures
    {
        [Fact]
        public void Rover_should_set_position()
        {
            Rover rover = new Rover();

            rover.SetPosition("5,6,N");
            rover.GetPosition().Should().Be("5,6,N");
        }

        [Fact]
        public void Rover_should_change_direction()
        {
            Rover rover = new Rover();

            rover.SetPosition("1,2,W");
            rover.ProcessInstructions("L");
            rover.GetPosition().Should().Be("1,2,S");
        }


        [Fact]
        public void Rover_should_move_forward()
        {
            Rover rover = new Rover();

            rover.SetPosition("1,2,W");
            rover.ProcessInstructions("M");
            rover.GetPosition().Should().Be("0,2,W");
        }

       
        [Fact]
        public void Rover_should_process_test1()
        {
            Rover rover = new Rover();
            //(0, 0, N) -- "MMM" -- (0, 3, N)
            rover.SetPosition("0,0,N");
            rover.ProcessInstructions("MMM");
            rover.GetPosition().Should().Be("0,3,N");
        }

        [Fact]
        public void Rover_should_process_test2()
        {
            Rover rover = new Rover();
            //(0, 1, E) -- "MML" -- (2, 1, N)
            rover.SetPosition("0,1,E");
            rover.ProcessInstructions("MML");
            rover.GetPosition().Should().Be("2,1,N");
        }

        [Fact]
        public void Rover_should_process_test3()
        {
            Rover rover = new Rover();
            //(10, 5, N) -- "MMLMRMML" -- (9, 9, W)
            rover.SetPosition("10,5,N");
            rover.ProcessInstructions("MMLMRMML");
            rover.GetPosition().Should().Be("9,9,W");
        }
    }
}
