Console.Write("Enter quantity: ");
int arr_qty = int.Parse(Console.ReadLine());
int[] array = new int[arr_qty];

for (int i = 0; i < arr_qty; i++){
    Console.Write("Enter element[{0}]: ",i);
    array[i] = int.Parse(Console.ReadLine());
            
}
Console.Write("Reversed Array = ");
for (int i = arr_qty - 1; i >= 0; i--){
    Console.Write("{0} ",array[i]);
}
Console.ReadKey();
