namespace PasswordLib
{
    public class PasswordChecker
    {
       public class string CheckPasswordStrength(string(password))
       { //If the passwrd is Empty
           if (string.IsEmpty(password))

            return "INELIGIBLE";
          // Criteria For Passwords
            bool hasUpper = passwordChecker.Any(char.IsUpper);
            bool hasLower = passwordChecker.Any(char.IsLower); 
            bool hasDigit = passwordChecker.Any(char.IsDigit); 
            bool hasSymbol = PasswordChecker.Any(char => !char.IsLetterOrDigit(c));
         // Score Based on Criteria
            int score = 0;
            if (hasUpper) score++
            if (hasLower) score++
            if (hasDigit) score++
            if (hasSymbol) score++
        // Strength of Passwords by #

        return score switch 
        {
            0=>"INELIGIBLE"
            1=> "WEAK"
            2 or 3 => "Middle"
            4=> "STRONG"
        }
       }

       

    }
}