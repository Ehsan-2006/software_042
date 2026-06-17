Console.Write("Enter quantity:");
        int quantity = int.Parse(Console.ReadLine());


        int[] allNumbers = new int[quantity];       
       
        int odd_Counter = 0;
        int even_Counter = 0;

        int[] odds = new int[quantity];
        int[] evens = new int[quantity];


        for (int i = 0; i < quantity; i++)
        {
            Console.Write("Enter element[{0}]: ",i);
            allNumbers[i] = int.Parse(Console.ReadLine());

            
            if (allNumbers[i] % 2 == 0)
            {
                evens[even_Counter] = allNumbers[i];
                even_Counter++;                      
            }
            else
            {
                odds[odd_Counter] = allNumbers[i];
                odd_Counter++;                       
            }
        }
  
        Console.WriteLine("\nodd numbers:");
        for (int i = 0; i < odd_Counter; i++) 
        {
            Console.Write(odds[i] + " ");
        }
        Console.WriteLine("\neven numbers:");
        for (int i = 0; i < even_Counter; i++) 
        {
            Console.Write(evens[i] + " ");
        }
        Console.ReadKey();
