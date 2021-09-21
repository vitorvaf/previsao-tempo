using Xunit;

namespace PrevisaoTempo.Test._Utils
{
     public static class AssertExtensions
    {
        public static void WithMessage(this DomainExceptionValidation exception, string message)
        {
            if(exception.Message == message)
                Assert.True(true);
            else
                Assert.False(true, $"Expected message '{message}'");
            
        }
        
    }
}