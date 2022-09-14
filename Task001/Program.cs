int [] arrayNumbers = new int[123];
int count = 0;
Random random = new Random();
for(int i = 0; i < 123; i++){
    arrayNumbers[i] = random.Next(0,200);
    if(arrayNumbers[i] >= 10 && arrayNumbers[i] <= 99){
        count++;
    }
}
Console.WriteLine("В нашем массиве "+count+" элементов из отрезка [10,99]");
foreach(int a in arrayNumbers){
    Console.WriteLine(a);
}