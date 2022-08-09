// string[] array = [3];
//     for (int i = 0; i < array.Length; i++){
//         if (array[i].Length < 4){
//             Console.WriteLine(array[i]);
//         }
//     }

int[] GenerateArray(int N, int start, int end){ // Запрашивает случайные элементы
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        RandomArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return RandomArray;
}

void ShowArray(int[] array){ // Выводит элементы в консоль
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}