using Xunit;
using PasswordLib;

namespace PasswordLib.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
       public void ineligible(){
         string password = "@*()";
         string result = PasswordChecker.checkPassword(password); 
         Assert.Equal("INELIGIBLE", result);
       }
       
       public void weak(){
         string password = "Cherno";
         string result = PasswordChecker.checkPassword(password);
          Assert.Equal("WEAK", result);
       }
       
        public void medium(){
            string password = "Cherno1";
         string result = PasswordChecker.checkPassword(password);
          Assert.Equal("MEDIUM", result);
        }

        public void strong(){
            string password ="Cherno123!";
            string result = PasswordChecker.checkPassword(password);
            Assert.Equal("SRONG", result)
        }

    } 

}