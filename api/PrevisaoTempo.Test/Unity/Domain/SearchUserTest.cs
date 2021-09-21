using System;
using Xunit;
using PrevisaoTempo.Domain.Entities;
using PrevisaoTempo.Domain.Validation;
using PrevisaoTempo.Test._Utils;

namespace PrevisaoTempo.Test.Unity.Domain
{
   public class SearchUserTest
   {
       [Fact]
       public void CreateSearchUser_WithValidParameters_ResultVaidObject()
       {
           var newSearchUser = 
                new SearchUser("Rio de Janeiro", 25, "Clear", "25", "01d");

           Assert.IsType<SearchUser>(newSearchUser);
          
       }

       [Fact]
       public void CreateSearchUser_WithInvalidParameters_ReturnDomainExceptionValidation()
       {               

            Assert.Throws<DomainExceptionValidation>(() =>
                new SearchUser("", 25, "Clear", "25", "01d"))
                .WithMessage("Invalid name, Name is required");
          
       }

       [Fact]
       public void CreateSearchUser_WithInvalidTemperatureParameters_ReturnDomainExceptionValidation()
       {               

            Assert.Throws<DomainExceptionValidation>(() =>
                new SearchUser("Rio de Janeiro", null, "Clear", "25", "01d"))
                .WithMessage("Invalid temperature, Temp is required");

               
          
       }

       [Fact]
       public void CreateSearchUser_WithInvalidWeatherParameters_ReturnDomainExceptionValidation()
       {               

            Assert.Throws<DomainExceptionValidation>(() =>
                new SearchUser("Rio de Janeiro", 25, null, "25", "01d"))
                .WithMessage( "Invalid weather, Weather is required");
          
       }

       [Fact]
       public void CreateSearchUser_WithInvalidHumidityParameters_ReturnDomainExceptionValidation()
       {               

            Assert.Throws<DomainExceptionValidation>(() =>
                new SearchUser("Rio de Janeiro", 25, "Clear", null, "01d"))
                .WithMessage(  "Invalid humidity, Humidity is required");
          
       }

       [Fact]
       public void CreateSearchUser_WithInvalidIconParameters_ReturnDomainExceptionValidation()
       {               

            Assert.Throws<DomainExceptionValidation>(() =>
                new SearchUser("Rio de Janeiro", 25, "Clear", "25", ""))
                .WithMessage("Invalid icon, Icon is required");
          
       }
   }
}