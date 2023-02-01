using System.Text.RegularExpressions;

namespace test_crud.Libs
{
  public static class ValidationEmail
  {
    public static bool ValidEmail(string email)
    {

      string pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" +
                       "@" +
                       @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

      return Regex.IsMatch(email, pattern);
    }
  }
}
