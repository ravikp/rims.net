using ExcelDna.Integration;

namespace rims.formulae
{
    public class NumberExtensions
    {
        [ExcelFunction
            ("Converts figures into words.", 
            Category = FunctionNames.Category,
            Name = FunctionNames.SpellNumber
            )]
        public static string SpellNumber(double figure)
        {
            var numbers = new string[101];
            numbers[1] = "one";
            numbers[2] = "two";
            numbers[3] = "three";
            numbers[4] = "four";
            numbers[5] = "five";
            numbers[6] = "six";
            numbers[7] = "seven";
            numbers[8] = "eight";
            numbers[9] = "nine";
            numbers[10] = "ten";
            numbers[11] = "eleven";
            numbers[12] = "twelve";
            numbers[13] = "thirteen";
            numbers[14] = "fourteen";
            numbers[15] = "fifteen";
            numbers[16] = "sixteen";
            numbers[17] = "seventeen";
            numbers[18] = "eighteen";
            numbers[19] = "nineteen";
            numbers[20] = "twenty";
            numbers[30] = "thirty";
            numbers[40] = "fourty";
            numbers[50] = "fifty";
            numbers[60] = "sixty";
            numbers[70] = "seventy";
            numbers[80] = "eighty";
            numbers[90] = "ninty";

            return numbers[(int) figure];
            

            
        }
    }
}