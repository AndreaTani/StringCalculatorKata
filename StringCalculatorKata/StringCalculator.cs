namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            bool isOk;
            int result;

            isOk = int.TryParse(numbers, out result);
            if (isOk)
                return result;

            string[] numbersArray = numbers.Split(',');
            int total = 0;
            foreach (string number in numbersArray)
            {
                isOk = int.TryParse(number, out result);
                if (isOk)
                {
                    total += result;
                }
                else
                {
                    break;
                }
            }

            if (isOk)
                return total;

            return -1;
        }
    }
}
