int [] arrayNumbers = new int[10];
int count = 0;
Random random = new Random();
for(int i = 0; i < 10; i++){
    arrayNumbers[i] = random.Next(0,200);
    Console.WriteLine(arrayNumbers[i]);
}
for( int i = 0; i < arrayNumbers.Length/2; i++){
    Console.WriteLine("Произведение "+i+" элемента и "+(arrayNumbers.Length-i-1)+"-го = "+(arrayNumbers[i]*arrayNumbers[arrayNumbers.Length-i-1]));
}
