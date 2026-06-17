            Console.Write("Enter the number of elements for array: ");
            int number = int.Parse(Console.ReadLine());
 
            int[] array = new int[number];
 
            Console.WriteLine("Enter array Elements: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write("element[{0}] = ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
 
            int sumEvenIndex = 0;
            int sumOddIndex  = 0;
 
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    sumEvenIndex += array[i];
                }else {
                    sumOddIndex += array[i];
                }
            }

            int diff;
            if (sumEvenIndex > sumOddIndex)
            {
                diff = sumEvenIndex - sumOddIndex;
            }
            else {
                diff = sumOddIndex - sumEvenIndex;
            }
 
            Console.WriteLine("\nResult:");
            Console.WriteLine("Sum of even elements: {0}",sumEvenIndex);
            Console.WriteLine("Sum of odd elements: {0}",sumOddIndex);
            Console.WriteLine("Difference of even & odd numbers: {0}",diff);

            Console.ReadKey();
