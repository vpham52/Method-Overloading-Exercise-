namespace MethodOverloading
{
    public class Program
    {
        // Add 2 Integers
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //Add 2 decimals
        public static decimal Add(decimal num1, int num2)
        {
            return num1 + num2;

        }

        // 2 Integers and 1 Boolean
        public static string Add(decimal num1, decimal num2, bool checkTrue)
        {
            var sum = num1 + num2;

            if (checkTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (checkTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }

            else if (checkTrue == true && sum < 1 && sum > 0)
            {
                return $"{sum} cents";
            }

            else
            {
                return sum.ToString();
            }
        }


        static void Main(string[] args)
        {
            //2 Int
            //var addAnswer = Add(5, 8);
            //Console.WriteLine(addAnswer);

            //2 decimal
            //var decimalAnswer = Add(5.8d, 6.2d);
            //Console.WriteLine(decimalAnswer);

            //2 dec + 1 Boolean
            var answer = Add(.5m,.25m,true);
            Console.WriteLine(answer);
        }
    }
}
