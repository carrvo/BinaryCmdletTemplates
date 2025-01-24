using FluentAssertions;
using System;
using System.Linq;
using Xunit;

namespace $safeprojectname$.UnitTests
{
    public sealed class UnitTest1
    {
        private GetCmdletCommand Sut { get; }

        public UnitTest1()
        {
            Sut = new GetCmdletCommand()
            {
                Parameter1 = nameof(UnitTest1),
            };
        }

        [Fact]
        public void Test1()
        {
            var output = Sut.Invoke<String>();
            Assert.Equal("Hello UnitTest1", output.Single());
            output.Single().Should().Be("Hello UnitTest1");
        }
    }
}
