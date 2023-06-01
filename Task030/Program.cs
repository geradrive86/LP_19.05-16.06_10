// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]




// int[] array = new int[8]; // 0 1 2 3 4 5 6 7
// FillArray(array);
// PrintArray(array);

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine(arr[i]);
//     }
// }
// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }
// }
// // Задача 30: Напишите программу, которая
// // выводит массив из 8 элементов, заполненный
// // нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]





void FillArray(int[] array)
            {
                var rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(9);
                }
            }


            void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }

            int[] array1 = new int[8];
            FillArray(array1);
            PrintArray(array1);