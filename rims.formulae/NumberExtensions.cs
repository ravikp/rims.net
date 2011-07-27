using ExcelDna.Integration;

namespace rims.formulae
{
    public class NumberExtensions
    {
        [ExcelFunction
            ("Converts figures into words.", 
            Category = FunctionNames.Category,
            Name = FunctionNames.SpellNumber,
            IsThreadSafe = true
            )]

        public static string SpellNumber(double figure)
        {
            var value = ConstructWords(new WordData((long)figure));
            var rupees = value + " " + ((long) figure == 1 ? "rupee" : "rupees");

            //handle zero
            var paise = ConstructWords(new WordData((long)(figure*100)%100));
            if (paise != string.Empty) paise = " and " + paise + " paise";

            return rupees + paise;

        }

        private static string ConstructWords(WordData wordData)
        {
            ApplyDenominator(wordData,10000000,"crore");
            ApplyDenominator(wordData,100000,"lakh");
            ApplyDenominator(wordData,1000,"thousand" );
            ApplyDenominator(wordData,100,"hundred" );
            
            if(wordData.figure > 20)
            {
                wordData.word += " " + GetNumbers()[wordData.figure/10*10];
                wordData.figure %= 10;               
            }

            if(wordData.figure > 0) wordData.word+=" " + GetNumbers()[wordData.figure];


            return wordData.word.Trim();
        }

        private static void ApplyDenominator(WordData wordData, int denominator, string denominatorWord)
        {
            if (wordData.figure >= denominator)
            {
//                wordData.word += " " + SpellNumber(wordData.figure/denominator * 1) + " " + denominatorWord;
                var figure = wordData.figure/denominator;                
                wordData.word += " " + ConstructWords(new WordData(figure)) + " " + denominatorWord;
                wordData.figure %= denominator;
            }
        }

        private static string[] GetNumbers()
        { 
            var numbers = new string[101];
            numbers[1]  = "one";
            numbers[2]  = "two";
            numbers[3]  = "three";
            numbers[4]  = "four";
            numbers[5]  = "five";
            numbers[6]  = "six";
            numbers[7]  = "seven";
            numbers[8]  = "eight";
            numbers[9]  = "nine";
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
            return numbers;
        }
    }    
}