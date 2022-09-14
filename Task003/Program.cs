double [] arrayNumbers = new double[10]{1.2, 3.1, 5, 76, 8.23, 67, 2.55, 8, 2.666, 7};
double max = arrayNumbers[0];
double min = arrayNumbers[0];
for(int i = 0; i < arrayNumbers.Length-1; i++){
    if(arrayNumbers[i] > max){
        max = arrayNumbers[i];
    }
     if(arrayNumbers[i] < min){
        min = arrayNumbers[i];
    }
}
Console.WriteLine("min "+min);
Console.WriteLine("max "+max);
Console.WriteLine("Разница между максимальным и минимальным = "+(max-min));
