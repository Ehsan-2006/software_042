int[,] array = new int[2,3];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter scores of student[{0}]",i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter score[{0}]: ",j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Student[{0}] scores: ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}, ",array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
