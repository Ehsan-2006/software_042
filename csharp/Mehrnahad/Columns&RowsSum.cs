        void print_add_rows(int[,] matrix) {
            int sum;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.Write(sum + ", ");
            }
        }

            void print_add_cols(int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + matrix[i+1,j] + ", ");
                }
                break;
            }
        }
        
        
            int[,] matrix = new int[,]{
                {1,2,3},
                {4,5,6}
            };
            Console.WriteLine("Rows: ");
            print_add_rows(matrix);
            Console.WriteLine("\nCols: ");
            print_add_cols(matrix);
            Console.ReadKey();
        
