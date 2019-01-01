using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задачи: ");
            Console.WriteLine();
            Console.WriteLine("1. Объявить одномерный (5 элементов ) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.");
            Console.WriteLine(" 1) Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов."); 
            Console.WriteLine(" 2) Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы.");
            Console.WriteLine(" 3) Найти в данных массивах общий максимальный элемент");
            Console.WriteLine(" 4) Найти в данных массивах общий минимальный элемент");
            Console.WriteLine(" 5) Oбщую сумму всех элементов");
            Console.WriteLine(" 6) Oбщее произведение всех элементов");
            Console.WriteLine(" 7) Cумму четных элементов массива А");
            Console.WriteLine(" 8) Cумму нечетных столбцов массива В");
            Console.WriteLine();
            Console.WriteLine("2. Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.");
            Console.WriteLine();
            Console.WriteLine("3. Пользователь вводит строку. Проверить, является ли эта строка палиндромом. Палиндромом называется строка, которая одинаково читается слева направо и справа налево.");
            Console.WriteLine();
            Console.WriteLine("4. Подсчитать количество слов во введенном предложении.");
            Console.WriteLine();
            Console.WriteLine("5. Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.");

            int taskNumber;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("На какую из задач хотели бы получить ответ (1-5): ");

            taskNumber = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            switch (taskNumber)
            {
                case 1:
                    /*----1----*/
                    //инициализация
                    const int NUMBER_OF_ELEMENTS_IN_THE_ARRAY = 5;
                    const int NUMBER_OF_ROWS_OF_ARRAY = 3, NUMBER_OF_COLUMNS_OF_ARRAY = 4;

                    double[] oneDimensionalArrayNamedA = new double[NUMBER_OF_ELEMENTS_IN_THE_ARRAY];
                    double[,] twoDimensionalArrayNamedB = new double[NUMBER_OF_ROWS_OF_ARRAY, NUMBER_OF_COLUMNS_OF_ARRAY];

                    //ввод данных в массив
                    for (int i = 0; i < NUMBER_OF_ELEMENTS_IN_THE_ARRAY; i++)
                    {
                        Console.WriteLine("Введите элемент: ");
                        oneDimensionalArrayNamedA[i] = double.Parse(Console.ReadLine());
                    }

                    //отображение
                    Console.WriteLine("1. Значения одномерного массива в одну строку:  ");
                    Console.WriteLine();

                    for (int i = 0; i < NUMBER_OF_ELEMENTS_IN_THE_ARRAY; i++)
                    {
                        Console.Write(oneDimensionalArrayNamedA[i]);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                    Console.WriteLine();


                    //рандомная инициализация

                    for (int i = 0; i < NUMBER_OF_ROWS_OF_ARRAY; i++)

                        for (int j = 0; j < NUMBER_OF_COLUMNS_OF_ARRAY; j++)

                            twoDimensionalArrayNamedB[i, j] = 1 + rnd.NextDouble() * (10 + 1);

                    //отображение

                    Console.WriteLine("2. Значения двумерного массива в виде матрицы: ");
                    Console.WriteLine();

                    for (int i = 0; i < NUMBER_OF_ROWS_OF_ARRAY; i++)
                    {
                        for (int j = 0; j < NUMBER_OF_COLUMNS_OF_ARRAY; j++)
                        {
                            Console.Write(twoDimensionalArrayNamedB[i, j]);
                            Console.Write("     ");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    //для нахождения общего максимального и минимального значения сортировка элементов массивов
                    Array.Sort(oneDimensionalArrayNamedA);

                    double minValue = 0;
                    for (int k = 0; k < NUMBER_OF_ELEMENTS_IN_THE_ARRAY; k++)
                    {
                        for (int i = 0; i < NUMBER_OF_ROWS_OF_ARRAY; i++)
                        {
                            for (int j = 0; j < NUMBER_OF_COLUMNS_OF_ARRAY; j++)
                            {
                                if (oneDimensionalArrayNamedA[k] == twoDimensionalArrayNamedB[i, j])
                                {
                                    minValue = oneDimensionalArrayNamedA[k];
                                    j = NUMBER_OF_COLUMNS_OF_ARRAY;
                                    i = NUMBER_OF_ROWS_OF_ARRAY;
                                    k = NUMBER_OF_ELEMENTS_IN_THE_ARRAY;
                                }
                            }
                        }
                    }

                    if (minValue == 0)
                        Console.WriteLine("3. Общего минимального элемента в анализируемых массивах нет");

                    else
                    {
                        Console.Write("3. Общий минимальный элемент в анализируемых массивах: ");
                        Console.WriteLine(minValue);
                    }

                    double maxValue = 0;
                    for (int k = NUMBER_OF_ELEMENTS_IN_THE_ARRAY - 1; k >= 0; k--)
                    {
                        for (int i = 0; i < NUMBER_OF_ROWS_OF_ARRAY; i++)
                        {
                            for (int j = 0; j < NUMBER_OF_COLUMNS_OF_ARRAY; j++)
                            {
                                if (oneDimensionalArrayNamedA[k] == twoDimensionalArrayNamedB[i, j])
                                {
                                    maxValue = oneDimensionalArrayNamedA[k];
                                    j = NUMBER_OF_COLUMNS_OF_ARRAY;
                                    i = NUMBER_OF_ROWS_OF_ARRAY;
                                    k = -1;
                                }
                            }
                        }
                    }

                    if (maxValue == 0)
                        Console.WriteLine("4. Общего максимального элемента в анализируемых массивах нет");

                    else
                    {
                        Console.Write("4. Общий максимальный элемент в анализируемых массивах: ");
                        Console.WriteLine(maxValue);
                    }

                    //сумма элементов массивов

                    double theSum = 0;
                    for (int i = 0; i < NUMBER_OF_ELEMENTS_IN_THE_ARRAY; i++)
                    {
                        theSum += oneDimensionalArrayNamedA[i];
                    }

                    for (int i = 0; i < NUMBER_OF_ROWS_OF_ARRAY; i++)
                    {
                        for (int j = 0; j < NUMBER_OF_COLUMNS_OF_ARRAY; j++)
                        {
                            theSum += twoDimensionalArrayNamedB[i, j];
                        }
                    }

                    Console.WriteLine();
                    Console.Write("5. Сумма элемментов 2-х массивов: ");
                    Console.WriteLine(theSum);

                    //сумма элементов массивов

                    double multiplication = 1;
                    for (int i = 0; i < NUMBER_OF_ELEMENTS_IN_THE_ARRAY; i++)
                    {
                        multiplication *= oneDimensionalArrayNamedA[i];
                    }

                    for (int i = 0; i < NUMBER_OF_ROWS_OF_ARRAY; i++)
                    {
                        for (int j = 0; j < NUMBER_OF_COLUMNS_OF_ARRAY; j++)
                        {
                            multiplication *= twoDimensionalArrayNamedB[i, j];
                        }
                    }
                    Console.WriteLine();
                    Console.Write("6. Произведение элемментов 2-х массивов: ");
                    Console.WriteLine(multiplication);

                    // Сумма элементов массива А

                    double sumOfTheEvenElementsOfArrayA = 0;

                    for (int i = 0; i < NUMBER_OF_ELEMENTS_IN_THE_ARRAY; i++)
                    {
                        if (oneDimensionalArrayNamedA[i] % 2 == 0)
                            sumOfTheEvenElementsOfArrayA += oneDimensionalArrayNamedA[i];
                    }
                    Console.WriteLine();
                    Console.Write("7. Cумма четных элементов одномерного массива: ");
                    Console.WriteLine(sumOfTheEvenElementsOfArrayA);

                    //сумму нечетных столбцов массива В

                    double sumOfTheEvenColumnsOfArrayB = 0;

                    for (int i = 0; i < NUMBER_OF_ROWS_OF_ARRAY; i++)
                    {
                        for (int j = 0; j < NUMBER_OF_COLUMNS_OF_ARRAY; j++)
                        {
                            if (j % 2 != 0)
                            {
                                sumOfTheEvenColumnsOfArrayB += twoDimensionalArrayNamedB[i, j];
                            }
                        }
                    }

                    Console.WriteLine();
                    Console.Write("8. Cумма нечетных столбцов массива В: ");
                    Console.WriteLine(sumOfTheEvenColumnsOfArrayB);

                    break;


                case 2:

                    /*----2----*/

                    const int FIRST_M_ARRAY_SIZE = 5, SECOND_N_ARRAY_SIZE = 10;

                    int[] firstArray = new int[FIRST_M_ARRAY_SIZE];
                    int[] secondArray = new int[SECOND_N_ARRAY_SIZE];

                    for (int i = 0; i < firstArray.Length; i++)
                    {
                        firstArray[i] = rnd.Next(0, 10);
                    }

                    for (int i = 0; i < secondArray.Length; i++)
                    {
                        secondArray[i] = rnd.Next(0, 10);
                    }

                    int[] thirdArray = new int[0];

                    for (int i = 0, k = 0; i < FIRST_M_ARRAY_SIZE; i++)
                    {
                        for (int j = 0; j < SECOND_N_ARRAY_SIZE; j++)
                        {
                            if (firstArray[i] == secondArray[j])
                            {
                                Array.Resize<int>(ref thirdArray, thirdArray.Length + 1);
                                thirdArray[k] = firstArray[i];
                                ++k;
                            }
                        }
                    }

                    Console.WriteLine("Первый массив имеет вид:");
                    for (int i = 0; i < FIRST_M_ARRAY_SIZE; i++)
                    {
                        Console.Write(firstArray[i]);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Второй массив имеет вид:");
                    for (int i = 0; i < SECOND_N_ARRAY_SIZE; i++)
                    {
                        Console.Write(secondArray[i]);
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Третий массив имеет вид:");
                    foreach (int element in thirdArray)
                    {
                        Console.Write(element);
                        Console.Write(" ");
                    }

                    break;


                case 3:

                    /*----3----*/

                    Console.WriteLine("Введите выражение для проверки палимдромности: ");

                    string inputString = Console.ReadLine();

                    var charSymbol = new[] { ' ', ',', '.', ';', '!', '?', '\'' };
                    inputString = string.Concat(inputString.Where(c => !charSymbol.Contains(c)));

                    inputString = inputString.ToLower();

                    char[] inputArray = inputString.ToCharArray();

                    Array.Reverse(inputArray);

                    string checkString = new string (inputArray);

                    if (checkString==inputString)
                    {
                    Console.WriteLine("Введеная стока является палиндромом");
                    }
                    else
                    {
                    Console.WriteLine("Введенная строка не является палиндромом");
                    }

                    break;

                case 4:

                    /*----4----*/
                    Console.WriteLine("Введите предложение: ");
                    string textString = Console.ReadLine();

                    char[] wordCountingArray = textString.ToCharArray();

                    int counter = 1;

                    for (int i = 0; i < wordCountingArray.Length; i++)
                    {
                        if(wordCountingArray[i]==' ')
                        {
                            ++counter;
                        }
                    }

                    Console.Write("количество слов в предложении: ");
                    Console.WriteLine(counter);

                    break;

                case 5:
                    /*----5----*/

                    const int sizeArrayX = 5;
                    const int sizeArrayY = 5;

                    int[,] twoDimensionalArray = new int[sizeArrayX, sizeArrayY];

                    int minimumValue, maximumValue;
                    
                    for (int i = 0; i < sizeArrayX; i++)
                    {
                        for (int j = 0; j < sizeArrayY; j++)
                        {
                            twoDimensionalArray[i, j] = rnd.Next(-100, 100);
                        }
                    }

                    int sumOfRangeValues = 0;

                    maximumValue = minimumValue = twoDimensionalArray[0, 0];

                    int iMin=0, jMin=0;

                    int iMax=0, jMax=0;

                    for (int i = 0; i < sizeArrayX; i++)
                    {
                        for (int j = 0; j < sizeArrayY; j++)
                        {
                            if (maximumValue < twoDimensionalArray[i, j])
                            {
                                maximumValue = twoDimensionalArray[i, j];

                                iMax = i;
                                jMax = j;
                            }
                            if (minimumValue > twoDimensionalArray[i, j])
                            {
                                minimumValue = twoDimensionalArray[i, j];

                                iMin = i;
                                jMin = j;
                            }
                        }
                    }

                    if (iMin == iMax)//мин. и макс. на одной строке
                    {
                        if (jMin < jMax)
                        {
                            for (int i = iMin; i <iMax ; i++)
                            {
                                for (int j = jMin; j <= jMax; j++)
                                {
                                    sumOfRangeValues += twoDimensionalArray[i, j];
                                }
                            }
                        }
                        else if (jMin > jMax)
                        {
                            for (int i = iMin; i <= iMax; i++)
                            {
                                for (int j = jMax; j <= jMin; j--)
                                {
                                    sumOfRangeValues += twoDimensionalArray[i, j];
                                }
                            }
                        }
                    }
                    else if(iMin<iMax)
                    {
                       
                            for (int i = iMin; i <= iMax; i++)
                            {
                                for (int j = jMin; j <= jMax; j++)
                                {
                                    sumOfRangeValues += twoDimensionalArray[i, j];
                                }
                            }
                       
                    }

                    else if (iMin > iMax)
                    {
                            for (int i = iMax; i <= iMin; i++)
                            {
                                for (int j = jMin; j <= jMax; j--)
                                {
                                    sumOfRangeValues += twoDimensionalArray[i, j];
                                }
                            }
                    }
                        

                    for (int i = 0; i < sizeArrayX; i++)
                    {
                        for (int j = 0; j < sizeArrayY; j++)
                        {
                            Console.Write(twoDimensionalArray[i,j]);
                            Console.Write("  ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("минимальное значение массива: ");
                    Console.WriteLine(minimumValue);
                    Console.WriteLine();
                    Console.Write("максимальное значение массива: ");
                    Console.WriteLine(maximumValue);
                    Console.Write("Сумма элементов диапозона между минимумом и максимумом: ");
                    Console.WriteLine(sumOfRangeValues);
                    break;
            }
            Console.ReadLine();
        }
    }
}
