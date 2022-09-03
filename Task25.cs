// ЗАДАЧА №25____________________________________________________________

int GetNumber(int nA, int nB){
    int res = 1;
    for(int i=0; i<nB; i++){
        res = res * nA;
    }
        return res;
}

Console.Write("Введите число A: ");
bool isNumberA = int.TryParse(Console.ReadLine(), out int numberA);
Console.Write("Введите число B: ");
bool isNumberB = int.TryParse(Console.ReadLine(), out int numberB);

if(!isNumberA || !isNumberB){
    Console.WriteLine("Введите число!");
}
else{
    int result = GetNumber(numberA, numberB);
    Console.WriteLine(result);
}
