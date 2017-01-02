namespace PersonDirectory
{
    internal class BodyMassIndex
    {
        public string Category { get; private set; }
        public double Score { get; }

        public BodyMassIndex(double weight, double height)
        {
            if (height > 0)
            {
                height /= 100;
                Score = weight / (height * height);
            }

            SetCategory();
        }

        private void SetCategory()
        {
            if (Score < 19)
                Category = "Underweight";
            else if (Score > 19 && Score <= 25)
                Category = "Normal (healthy weight)";
            else if (Score > 25 && Score <= 30)
                Category = "Overweight";
            else if (Score > 30)
                Category = "Obese";
        }
    }
}