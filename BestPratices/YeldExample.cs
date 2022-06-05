namespace BestPratices
{
    /// <summary>
    /// In order to prevent the temporary collection from being used, developers can use yield.
    /// Yield gives out results according to the result set enumeration. When using yield, use this code
    /// </summary>
    internal static class YeldExample
    {
        public static IEnumerable<int> GetValuesGreaterThan100Old(List<int> masterCollection)
        {
            List<int> tempResult = new List<int>();

            foreach (var value in masterCollection)
            {
                if (value > 100)
                    tempResult.Add(value);
            }

            return tempResult;
        }

        public static IEnumerable<int> GetValuesGreaterThan100New(List<int> masterCollection)
        {
            foreach (var value in masterCollection)
                if (value > 100)
                    yield return value;
        }
    }
}
