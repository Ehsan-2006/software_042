Console.Write("Enter quantity: ");
int temp=0,arr_qty = int.Parse(Console.ReadLine());
int[] array = new int[arr_qty];

for (int i = 0; i < arr_qty; i++){
    Console.Write("Enter element[{0}]: ",i);
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > temp)
    {
        temp = array[i];
    }
        }
Console.Write("The biggest elemnt: {0}",temp);
Console.ReadKey();
