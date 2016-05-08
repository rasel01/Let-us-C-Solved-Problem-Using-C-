using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_basic_Problem_solve
{
    public class Arrays
    {
        public void searchNumber()
        {
            int i = 0;
            int[] arr = new int[25];
            Console.WriteLine("Enter the number for array");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());



            }
            //Console.WriteLine(arr[i]);
            Console.WriteLine("Enter your number for seraching");
            int input = Convert.ToInt32(Console.ReadLine());
            findNumber(arr, input);


        }

        private void findNumber(int[] arr, int input)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == input)
                {
                    count++;
                }

            }
            Console.WriteLine("Your input is  : " + input + " and  it got " + count + "times");

        }


        public void BubbleSort()
        {
            Console.WriteLine("Enter 25 number for sorting");
            int[] numbers = new int[5];
            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            SortingResult(numbers);

        }

        private void SortingResult(int[] numbers)
        {
            int temp;


            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }


            }
            //Console.WriteLine("Now your sorting : " + numbers[i]);
            for (int k = 0; k < numbers.Length; k++)
            {
                Console.WriteLine("sorting result from bubble sort ");

                Console.WriteLine(" " + numbers[k]);
                //Console.Write(numbers[j] + ",");

            }


        }


        public void InsertionSort()
        {
            Console.WriteLine("Enter how many number you want sort ?");
            int input = Convert.ToInt32(Console.ReadLine());

            int[] number = new int[input];

            Console.WriteLine("Enter your numbers ?");
            for (int i = 0; i < number.Length; i++)
            {

                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            InsertSortingResult(number);
        }

        private void InsertSortingResult(int[] number)
        {
            int temp;
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (number[j - 1] > number[j])
                    {
                        temp = number[j - 1];
                        number[j - 1] = number[j];
                        number[j] = temp;
                    }
                }

            }
            Console.WriteLine("Sorting using insertion sort :");
            for (int k = 0; k < number.Length; k++)
            {
                Console.WriteLine(number[k]);
            }
        }

        public void SelectionSort()
        {
            Console.WriteLine("Enter how many number you want sort ?");
            int input = Convert.ToInt32(Console.ReadLine());

            int[] number = new int[input];

            Console.WriteLine("Enter your numbers :");
            for (int i = 0; i < number.Length; i++)
            {

                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            SelectionSortResult(number);
        }

        private void SelectionSortResult(int[] number)
        {
            int temp, min;

            for (int i = 0; i < number.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[j] < number[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = number[i];
                    number[i] = number[min];
                    number[min] = temp;
                }

            }

            Console.WriteLine("Sorted value using selection sort");
            for (int k = 0; k < number.Length; k++)
            {
                Console.WriteLine(number[k]);
            }
        }


        public void SieveOfEratoshenes()
        {
            Console.WriteLine("Enter how many number you want to check for prime");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill your numbers");
            int[] num = new int[input];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            ImplementProcedure(num);
        }

        private void ImplementProcedure(int[] num)
        {

        }

        public void CheckNumber()
        {
            Console.WriteLine("Enter how many number you want to check ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill your numbers");
            int[] num = new int[input];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            NumberChecker(num);
        }

        private void NumberChecker(int[] num)
        {
            int posCount = 0;
            int negCount = 0;
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                {
                    Console.WriteLine(num[i] + "is postive number");
                    posCount++;

                }
                if (num[i] < 0)
                {
                    Console.WriteLine(num[i] + "is negetive number");
                    negCount++;

                }
                if (Math.Abs(num[i]) % 2 == 0)
                {

                    Console.WriteLine(num[i] + "is even number");
                    evenCount++;

                }
                if (Math.Abs(num[i]) % 2 != 0)
                {
                    Console.WriteLine(num[i] + "is odd number");
                    oddCount++;

                }
            }

            Console.WriteLine("Positive number total" + posCount
                +
                " Negetive total " + negCount
                +
                " Even Number Total " + evenCount
                +
                "Odd Number Total " + oddCount);
        }

        public void InterChangeNumber()
        {
            Console.WriteLine("Enter how many number you want to check ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fill your numbers");
            int[] num = new int[input];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            GetOddEvenInterChange(num);

        }

        private void GetOddEvenInterChange(int[] num)
        {
            int temp1, temp2;
            Console.WriteLine("so Your give:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Position:  " + i + " value  " + num[i]);


            }

            for (int k = 0; k < num.Length - 1; k++)
            {
                if (num[k] % 2 == 0)
                {
                    temp1 = num[k];
                    temp2 = num[k + 1];
                    num[k] = temp2;
                    num[k + 1] = temp1;
                }
            }

            Console.WriteLine("Now your result");
            for (int j = 0; j < num.Length; j++)
            {
                Console.WriteLine("Position:  " + j + " value  " + num[j]);
            }
        }

        public void DeclareTwoDimension()
        {

            Console.WriteLine("Enter how many row and column you need");
            int rownumber = Convert.ToInt32(Console.ReadLine());
            int colnumber = Convert.ToInt32(Console.ReadLine());

            int[,] numbers = new int[rownumber, colnumber];
            Console.WriteLine("Enter  values :");
            for (int i = 0; i < rownumber; i++)
            {
                for (int j = 0; j < colnumber; j++)
                {
                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            SumTwoDArray(numbers, rownumber, colnumber);

        }

        private void SumTwoDArray(int[,] numbers, int rownumber, int colnumber)
        {
            int sum = 0;
            Console.WriteLine("Numbers are :");
            for (int i = 0; i < rownumber; i++)
            {
                for (int j = 0; j < colnumber; j++)
                {
                    Console.WriteLine(numbers[i, j]);
                    sum = sum + numbers[i, j];
                }
                Console.WriteLine("Sum result :" + sum);
                sum = 0;
                Console.Write("\n ");
            }
        }

        public void TransposeMatrix()
        {
            Console.WriteLine("Enter the matrix row size ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the matrix column size ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[row, col];
            int[,] transpose = new int[row, col];

            Console.WriteLine("Enter user values for transpose");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    transpose[i, j] = matrix[j, i];
                }
            }

            Console.WriteLine("Now matrix become :");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine(transpose[i, j]);
                }
                Console.WriteLine(" \t ");
            }
        }





        public void LargestNumnberOfMatrix()
        {
            Console.WriteLine("Enter the row number of the matrix");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the column number of the matrix");
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] number = new int[row, column];
            Console.WriteLine("Enter the values");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    number[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int big = number[0, 0];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (number[i, j] > big)
                    {
                        big = number[i, j];
                    }
                }
            }

            Console.WriteLine("Maximum value is  : " + big);

        }

        public void SymanticsMatrix()
        {
            Console.WriteLine("Enter row of matrix ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column no of  the matrix");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] transposeMatrix = new int[row, col];

            transposeMatrix = GetTransposeMatrix(matrix, row, col);

            bool symantic = true;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i, j] != transposeMatrix[i, j])
                    {
                        symantic = false;
                    }
                }
            }
            if (symantic)
            {
                Console.WriteLine("your given matrix is symantic");
            }
            else
            {
                Console.WriteLine("your given matrix is not symantic");

            }
        }

        private int[,] GetTransposeMatrix(int[,] matrix, int row, int col)
        {
            int[,] transpose = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    transpose[i, j] = matrix[j, i];

                }
            }
            return transpose;
        }

        public void SumOfMatrix()
        {
            Console.WriteLine("Enter row no of the matrix");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter column no of the matrix");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] matrixA = new int[row, col];
            int[,] matrixB = new int[row, col];
            int[,] matrixResult = new int[row, col];

            Console.WriteLine("Enter the first matrix value");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the second matrix value");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("sum of Matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixResult[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.WriteLine(matrixResult[i, j]);
                }
            }



        }

        public void MultiplicationMatrix()
        {
            Console.WriteLine("Enter row no of the matrix");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter column no of the matrix");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] matrixA = new int[row, col];
            int[,] matrixB = new int[row, col];
            int[,] matrixResult = new int[row, col];

            Console.WriteLine("Enter the first matrix value");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the second matrix value");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Multiplication of Matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixResult[i, j] = matrixA[i, j] * matrixB[i, j];
                    Console.WriteLine(matrixResult[i, j]);
                }
            }

        }


        public void MeanDeviation()
        {
            Console.WriteLine("Enter how many number for sum");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[input];
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            double mean = GetMean(numbers);
            double sd = 0;
            double sub;
            for (int i = 0; i < numbers.Length; i++)
            {
                sub = (numbers[i] - mean) * (numbers[i] - mean);
                sd = (Math.Sqrt(sub)) / numbers.Length;
            }
            Console.WriteLine("Mean is : " + mean + "Standard Deviation is " + sd);
        }

        private double GetMean(int[] numbers)
        {
            int sum = 0;
            double mean;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            mean = Convert.ToDouble(sum / numbers.Length);

            return mean;
        }

        public void AreaTriangle()
        {
            // area = (.5)* a*b* sin(angles)

            //double degree = .5*(Math.PI/180);
            //double degree = Math.Asin(.5);
            // Console.WriteLine(degree);
            // Console.WriteLine(Math.Sin((.5 * (Math.PI / 180))));






            Console.WriteLine("Enter How many plot for Area");
            int input = Convert.ToInt32(Console.ReadLine());
            double[] area = new double[input];
            double[] sideOne = new double[input];
            double[] sideTwo = new double[input];
            double[] angles = new double[input];

            Console.WriteLine("Enter first side");

            for (int i = 0; i < sideOne.Length; i++)
            {

                sideOne[i] = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine("Enter second side");
            for (int j = 0; j < sideTwo.Length; j++)
            {

                sideTwo[j] = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine("Enter angles");
            for (int a = 0; a < angles.Length; a++)
            {
                angles[a] = Convert.ToDouble(Console.ReadLine());
            }

            area = findAreaTriangle(sideOne, sideTwo, angles,input);
            double max = area[0]; 
            for (int i = 0; i < area.Length; i++)
            {
                if (area[i] > max)
                {
                    max = area[i];
                }
            }

            for (int k = 0; k < area.Length; k++)
            {
                Console.WriteLine("Area's are :" + area[k]);
            }

            Console.WriteLine("Maximum area :" + max);

            


        }

        private double[] findAreaTriangle(double[] sideOne, double[] sideTwo, double[] angles,int input)
        {
         
            double [] area = new double[input];
            for (int i = 0; i < area.Length; i++)
            {
                area[i] = (.5)*sideOne[i]*sideTwo[i]*(Math.Sin(angles[i]));
            }

            return area;
        }
    }
}
