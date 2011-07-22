using System;
using ExcelDna.Integration;

namespace rims.formulae
{
    public class StringExtensions
    {
        [ExcelFunction(
            Description = "Given the age in years, the function then calculates the Birth year.", 
            Category = "RIMS.NET")]
        public static int YearOfBirth(int ageInYears)
        {
            return DateTime.Now.Year - ageInYears;
        }
    }
}
