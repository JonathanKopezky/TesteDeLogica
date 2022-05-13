namespace ExtractDataList
{
    public class Extraction
    {
        private readonly List<int> list = new List<int> { -3, 8, 12, -5, 1, 4, 21, 13, 7 };

        public double ReturnAverageFromList()
        {
            var total = list.Count;
            var result = 0;

            foreach (int item in list)
            {
                result += item;
            }

            return result / total;
        }

        public double ReturnTheLargestInTheList()
        {
            var result = list.Max();

            return result;
        }

        public double ReturnTheMinimumtInTheList()
        {
            var result = list.Min();

            return result;
        }
    }
}