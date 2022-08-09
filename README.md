# Описание решения задачи

**1. Вносим колличество строк в массиве из консоли**

int num = Convert.ToInt32(Console.ReadLine()); 

**2. Запрашиваем элементы массива**

string[] GenerateArray(int N)

**3. Выводи образовавшийся массив**

void ShowArray(string[] array)

**4. Задаем пустой массив**

string[] NewArray = new string[1];

**5. Проводим первый массив через цикл for**

i < myArray.Length


**6. Задаем условие: длинна эллементов массива неболее 3-ех**

myArray[i].Length < 4. 

**7. Проводим второй массив через цикл for**

j < NewArray.Length

**8. Присваиваем второму массиву новые элементы меньше 3-ех**

NewArray[j] = myArray[i]

**9. Выводим новый массив согласно условию**

Console.WriteLine(NewArray[j] + " ");