Задача 41 - 
Console.WriteLine("Сколько всего чисел вы введете ");
int get = int.Parse(Console.ReadLine());
double[]array = new double [get];
for(int i=0; i<array.Length;i++){
Console.Write("Введите числа по порядку ");

array[i] = double.Parse (Console.ReadLine());
}
double count = 0;

for (int i=0; i<array.Length;i++){
    if (array[i]>0){
        count += 1;
    }
    
}

Console.WriteLine ("["+ string.Join(",", array)+ "]" +"=>"+ (count));
