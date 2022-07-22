// Функции
Console.WriteLine("Задача № 29");
Console.WriteLine("-------------------------------");
int lenght = 8;
int[] digitsArr = new int[8];
Random rnd = new Random();

for (int i = 0; i < lenght; i++) {
    digitsArr[i] = rnd.Next(-100, 100);
    Console.Write(digitsArr[i] + ' ');
}