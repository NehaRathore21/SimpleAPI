using System;
using Xunit;
using simpleAPI.Controllers;

namespace simpleAPI.Test
{
    public class UnitTest1
    {
        //Arrange
        WeatherForecastController wController= new WeatherForecastController();
        
        [Fact]
        public void Test1()
        {
            //Act
           var output= wController.FetchData(1);
           //Assert
           Assert.Equal("Neha Rathore",output);
        }
    }
}
