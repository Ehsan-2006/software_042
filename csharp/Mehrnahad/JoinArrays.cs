Console.Write("Enter first array quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        int[] array1 = new int[quantity];
        for (int i = 0; i < quantity; i++)
        {
            Console.Write("Enter element [" + (i + 1) + "]: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter second array quantity: ");
        int quantity2 = int.Parse(Console.ReadLine());

        int[] array2 = new int[quantity2];
        for (int i = 0; i < quantity2; i++)
        {
            Console.Write("Enter element [" + (i + 1) + "]: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        int[] mergedArray = new int[quantity + quantity2];

        for (int i = 0; i < quantity; i++)
        {
            mergedArray[i] = array1[i];
        }

        for (int i = 0; i < quantity2; i++)
        {
            mergedArray[quantity + i] = array2[i];
        }

        Console.WriteLine("Merged array:");
        for (int i = 0; i < mergedArray.Length; i++)
        {
            Console.Write(mergedArray[i] + " ");
        }
        Console.ReadKey();
