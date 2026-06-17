Console.Write("Enter quantity: ");
            int qty = int.Parse(Console.ReadLine());
            int[] array = new int[qty];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter Element[{0}]: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int second_biggest=0,counter;

            for (int i = 0; i < array.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[i])
                    {
                        counter++;
                    }
                }
                if (counter == 1)
                {
                    second_biggest = array[i];
                    break;
                }
            }
            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Second Biggest: {0}",second_biggest);
            Console.ReadKey();
