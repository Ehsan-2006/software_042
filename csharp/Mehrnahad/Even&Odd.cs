bool check_num(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (check_num(number))
            {
                Console.WriteLine("{0} is Even", number);
            }
            else
            {
                Console.WriteLine("{0} is Odd", number);
            }
            Console.ReadKey();
