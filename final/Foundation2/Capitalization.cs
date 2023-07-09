
using System;
 
public static class Capitalization
{
    public static string Capitalize(this string s)
    {
        if (String.IsNullOrEmpty(s)) {
            throw new ArgumentException("String is mull or empty");
        }
 
        return s[0].ToString().ToUpper() + s.Substring(1);
    }
}
 