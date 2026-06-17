            Console.Write("Enter number of elements for array: ");
            int number = int.Parse(Console.ReadLine());
 
            int[] num_array = new int[number];
 
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write("element[{0}] = ",i);
                num_array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < number / 2; i++)
            {
                int temp = num_array[i];
                num_array[i] = num_array[number - 1 - i];
                num_array[number - 1 - i] = temp;
            }
 
            Console.WriteLine("\nReversed array: ");
            for (int i = 0; i < num_array.Length; i++)
            {
                Console.Write("{0}, ",num_array[i]);
            }

            Console.ReadKey();
