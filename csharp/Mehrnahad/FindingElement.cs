Console.Write("Enter quantity: ");
int element, arr_qty = int.Parse(Console.ReadLine());
int[] array = new int[arr_qty];

for (int i = 0; i < arr_qty; i++){
    Console.Write("Enter element [{0}]: ",i);
    array[i] = int.Parse(Console.ReadLine());
    }

Console.Write("Enter the element to search: ");
element = int.Parse(Console.ReadLine());

for (int i = 0; i < arr_qty; i++)
    {
        if (element == array[i]){
            Console.WriteLine("Element exists at index {0}",i);
        }
    }

Console.ReadKey();
