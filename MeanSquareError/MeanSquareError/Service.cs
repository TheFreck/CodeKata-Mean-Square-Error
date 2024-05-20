using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanSquareError
{
    public class Service
    {
        public static double AverageSquares(int[] input)
        {
            return (double)input.Sum() / input.Length;
        }

        public static int[] FindDifferences(int[] inputArray1, int[] inputArray2)
        {
            if (inputArray1.Length != inputArray2.Length)
                throw new ArgumentException("Input arrays must be of equal length");
            var differenceArray = new int[inputArray1.Length];
            for(var i=0; i<inputArray1.Length; i++)
            {
                var diff = inputArray1[i] - inputArray2[i];
                differenceArray[i] = diff > 0 ? diff : -diff;
            }

            return differenceArray;
        }

        public static double SolutionV1(int[] input1, int[] input2) => AverageSquares(SquareDifferences(FindDifferences(input1, input2)));
        public static double SolutionV2(int[] input1, int[] input2) =>  input1.Select((s, i) => (input1[i] - input2[i]) * (input1[i] - input2[i])).Average();

        public static int[] SquareDifferences(int[] input)
        {
            var squares = new int[input.Length];
            for(var i=0; i<input.Length; i++)
            {
                squares[i] = input[i] * input[i];
            }

            return squares;
        }
    }
}
