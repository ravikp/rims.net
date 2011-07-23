using ExcelDna.Integration;

namespace rims.formulae
{
    public class FinancialExtensions
    {
        [ExcelFunction
            ("Converts figures into words.", 
            Category = FunctionNames.Category,
            Name = FunctionNames.SpellNumber
            )]
        public static string SpellNumber(double figure)
        {
            return "number: " + figure;
        }
    }
}