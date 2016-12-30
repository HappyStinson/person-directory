namespace PersonDirectory
{
    internal class BodyMassIndex
    {
        public string Category { get; }
        public double Score { get; }

        public BodyMassIndex() : this(0) { }

        public BodyMassIndex(double score)
        {
            Score = score;

            if (score < 19)
                Category = "Underweight";
            else if (score > 19 && score <= 25)
                Category = "Normal (healthy weight)";
            else if (score > 25 && score <= 30)
                Category = "Overweight";
            else if (score > 30)
                Category = "Obese";
        }
    }
}