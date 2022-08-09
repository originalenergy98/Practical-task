string[] array = {"654", "hello", "*&K^$#", "@", "7", "dex"};
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length < 4){
            Console.WriteLine(array[i]);
        }
    }