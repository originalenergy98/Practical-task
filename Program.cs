string[] GenerateArray(int N){ //Запрашивает элементы массива
    string[] RandomArray = new string[N];
    for (int i = 0; i < N; i++){
        Console.WriteLine($"Введите {i + 1} элемент массива");
        RandomArray[i] = Convert.ToString(Console.ReadLine());}
    return RandomArray;}

void ShowArray(string[] array){ // Выводит элементы в консоль
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");}
    Console.WriteLine();}

Console.WriteLine("Введите количество элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());

string[] myArray = GenerateArray(num);
ShowArray(myArray);

// Console.WriteLine("--------------");
// int count = 0;
// for (int i = 0; i < myArray.Length; i++){
//     if (myArray[i].Length < 4){
//         }}

string[] NewArray = new string[num];

Console.WriteLine("--------------");
for (int i = 0; i < myArray.Length; i++){
    if (myArray[i].Length < 4){
        for (int j = 0; j < NewArray.Length; j++){
            NewArray[j] = myArray[i];
            Console.Write(NewArray[j] + " ");}}}