using System;
using Xunit;
using CICDWebApp;


namespace CICDWebApp.Test
{
    public class UnitTest_Authenticate
    {
        public string user_name;
        public string pass_word;

        public UnitTest_Authenticate()
        {
            
        }
        [Fact]
        public void TestAuthenticate()
        {
            // Given
            Authentication auth = new Authentication();
            // When
            var result = auth.AuthenticateUser("vinay","password");
            // Then
            Assert.Equal(result,true); 
        }
    }
    
}