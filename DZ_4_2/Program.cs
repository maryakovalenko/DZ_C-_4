// Функции
Console.WriteLine("Задача № 27 ");
Console.WriteLine("-----------------------------");
int digitsSum(int A) {
    int sum = 0;
    while(A != 0) {
        sum = sum + A % 10;
        A = A / 10;
    }
    
    Console.WriteLine(sum);
    return sum;
        
}

int sum = digitsSum(452);
digitsSum(82);
digitsSum(9012);
