Console.Write("Enter quantity: ");
int sum=0,arr_qty = int.Parse(Console.ReadLine());
int[] array = new int[arr_qty];
string result = "";

for (int i = 0; i < arr_qty; i++){
    Console.Write("Enter element[{0}]: ",i);
        array[i] = int.Parse(Console.ReadLine());
        sum += array[i];
        result += array[i] + " ";
    }
Console.WriteLine("Array = {0}",result);
Console.WriteLine("Sum = {0}",sum);
Console.ReadKey();
