using System;

namespace Algorithms {
    class Program {
        static void RotateArrayLeft(int[] input) {
            int t = input[0];

            for (int i = 0; i < input.Length - 1; i++) {
                input[i] = input[i + 1];
            }

           

            input[input.Length - 1] = t;
        }

        static void RotateArrayRight(int[] input) {

            int t = input[input.Length - 1];

            for (int i = input.Length - 1; i > 0; i--) {
                input[i] = input[i - 1];
            }

           
            input[0] = t;
        }

        static void Main(string[] args) {
            int[] arr = { 2,3,4,5,6,1 };
            RotateArrayLeft(arr); //  array will rotate towards left
            RotateArrayRight(arr); // array will rotate towards right
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}
