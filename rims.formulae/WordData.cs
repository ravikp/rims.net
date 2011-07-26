namespace rims.formulae
{
    internal class WordData

    {
        internal long figure;
        internal string word;
        internal long roundedDecimalValue;

        public WordData(long figure, string word, double decimalValue)
        {
            this.figure = figure;
            this.word = word;
            roundedDecimalValue = (long)(decimalValue*100);
        }
    }
}