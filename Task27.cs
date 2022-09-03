// ЗАДАЧА №27____________________________________________________________

int ReceiveSum(int n){
    int remainder = 0;
    int length = Convert.ToString(n).Length;
    int sum = 0;
    for(int i=0; i<length; i++) {
        remainder = n - n%10;
        sum = sum + (n - remainder);
        n = n/10;
    }
    return sum;
}

Console.Write("Введите число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if(!isNumber){
    Console.WriteLine("Введите число!");
}
else{
    int result = ReceiveSum(number);
    Console.WriteLine($"Сумма цифр в числе равна {result}.");
}
