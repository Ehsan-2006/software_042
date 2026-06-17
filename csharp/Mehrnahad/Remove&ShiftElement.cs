Console.Write("Enter quantity: ");
            int qty = int.Parse(Console.ReadLine());

            int[] default_array = new int[qty];

            for (int i = 0; i < default_array.Length; i++)
            {
                Console.Write("Enter element[{0}]: ", i + 1);
                default_array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Which element you want to remove? ");
            int count = 0, target_to_remove = int.Parse(Console.ReadLine());

            for (int i = 0; i < default_array.Length; i++)
            {
                if (default_array[i] != target_to_remove)
                {
                    count++;
                }
            }

            int[] edited_array = new int[count];
            int new_index = 0;

            for (int i = 0; i < default_array.Length; i++)
            {
                if (default_array[i] != target_to_remove)
                {
                    edited_array[new_index] = default_array[i];
                    new_index++;
                }
            }

            Console.Write("Default array: ");
            for (int i = 0; i < default_array.Length; i++)
            {
                Console.Write("{0} ", default_array[i]);
            }
            Console.WriteLine();
            Console.Write("Edited array: ");
            for (int i = 0; i < edited_array.Length; i++)
            {
                Console.Write("{0} ", edited_array[i]);
            }

            Console.ReadKey();
