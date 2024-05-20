using Machine.Specifications;

namespace MeanSquareError.Specs
{
    public class When_Finding_Differences_In_Array_Elements
    {
        Establish context = () =>
        {
            inputArray1 = new int[] { 1, 2, 3 };
            inputArray2 = new int[] { 4, 5, 6 };
            expect = new int[] { 3, 3, 3 };
        };

        Because of = () => answer = Service.FindDifferences(inputArray1, inputArray2);

        It Should_Return_Expected_Differences = () =>
        {
            for (var i = 0; i < answer.Length; i++)
            {
                answer[i].ShouldEqual(expect[i]);
            }
        };

        private static int[] inputArray1;
        private static int[] inputArray2;
        private static int[] expect;
        private static int[] answer;
    }

    public class When_Squaring_Differences
    {
        Establish context = () =>
        {
            input = new int[] { 3, 3, 3 };
            expect = new int[] { 9, 9, 9 };
        };

        Because of = () => answer = Service.SquareDifferences(input);

        It Should_Return_An_Array_Containing_Square_Of_Each_Input = () =>
        {
            for (var i = 0; i < answer.Length; i++)
            {
                answer[i].ShouldEqual(expect[i]);
            }
        };

        private static int[] input;
        private static int[] expect;
        private static int[] answer;
    }

    public class When_Averaging_Squares
    {
        Establish context = () =>
        {
            input = new int[] { 9, 9, 9, 8 };
            expect = 8.75;
        };

        Because of = () => answer = Service.AverageSquares(input);

        It Should_Return_The_Average_Of_The_Squared_Array = () => answer.ShouldEqual(expect);

        private static int[] input;
        private static double expect;
        private static double answer;
    }

    public class When_Finding_The_Average_Of_The_Squared_Differences_Between_Two_Arrays
    {
        Establish context = () =>
        {
            input1 = new int[] { 1, 2, 3 };
            input2 = new int[] { 4, 5, 6 };
            expect = 9;
        };

        Because of = () => answer = Service.Solution(input1, input2);

        It Should_Return_The_Correct_Double = () => answer.ShouldEqual(expect);

        private static int[] input1;
        private static int[] input2;
        private static double expect;
        private static double answer;
    }
}