namespace FizzBuzz
{
    /**
     * A class representing the FizzBuzzManager.
     * 
    **/
    public class FizzBuzzManager
    {
        private int mLimit;

        /**
         * Constructs a new FizzBuzzManager.
         * 
         * @param limit The limit of the FizzBuzz.
         */
        public FizzBuzzManager(int limit)
        {
            mLimit = limit;
        }

        /**
         * Checks if a number is a Fizz.
         * 
         * @param number The number to check.
         * @return True if the number is a Fizz, false otherwise.
         */
        private bool isFizz(int number)
        {
            return number % 3 == 0;
        }

        /**
         * Checks if a number is a Buzz.
         * 
         * @param number The number to check.
         * @return True if the number is a Buzz, false otherwise.
         */
        private bool isBuzz(int number)
        {
            return number % 5 == 0;
        }

        /**
         * Checks if a number is a Fizz and a Buzz.
         * 
         * @param number The number to check.
         * @return True if the number is a Fizz and a Buzz, false otherwise.
         */
        private bool isFizzAndBuzz(int number)
        {
            return this.isFizz(number) && this.isBuzz(number);
        }

        /**
         * Starts the FizzBuzz.
         */
        public void start()
        {
            string text;

            for (int i = 0; i <= mLimit; i++)
            {
                text = "is a number";

                if (this.isFizzAndBuzz(i))
                {
                    text = "is FizzBuzz";
                }

                else if (this.isFizz(i))
                {
                    text = "is Fizz";
                }

                else if (this.isBuzz(i))
                {
                    text = "is Buzz";
                }

                Console.WriteLine($"{i} {text}");
            }

            Console.ReadLine();
        }
    }
}
