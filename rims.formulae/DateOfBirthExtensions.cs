using System;
using ExcelDna.Integration;

namespace rims.formulae
{
    public class DateOfBirthExtensions
    {
        [ExcelFunction(
            Description = "Given the age in years, the function then calculates the Birth year.", 
            Category = FunctionNames.Category,
            Name = FunctionNames.YearOfBirth
            )]

        public static int YearOfBirth(int ageInYears)
        {
            return DateTime.Now.Year - ageInYears;
        }
    }
}
