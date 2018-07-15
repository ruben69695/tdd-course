using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public FizzBuzzService() {}

        public string Print(int n) {

            if(IsDivisibleByThree(n) && IsDivisibleByFive(n)) {
                return "FizzBuzz";
            }else if(IsDivisibleByFive(n)) {
                return "Buzz";
            }else if(IsDivisibleByThree(n)) {
                return "Fizz";
            } else {
                return n.ToString();
            }
        }

        public bool IsDivisibleByThree(int n) {
            return n % 3 == 0;
        }

        public bool IsDivisibleByFive(int n) {
            return n % 5 == 0;
        }
    }
}
