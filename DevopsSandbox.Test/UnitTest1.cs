using DevopsSandbox.Controllers;
using System;
using Xunit;

namespace DevopsSandbox.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            WeatherForecastController ctrls = new WeatherForecastController();
            var response = ctrls.Get();
        }
    }
}
