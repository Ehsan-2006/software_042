        int[,] change_matrix(int[,] matrix) {
            int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = matrix[j, i];
                }
            }
            return result;
        }

        void print_matrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        
            int[,] matrix = new int[,]{
                {1,2},
                {3,4},
                {5,6}
            };
            print_matrix(change_matrix(matrix));
            Console.ReadKey();
        
