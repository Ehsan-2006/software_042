        int[,] multiply_matrices(int[,] matrix_1, int[,] matrix_2)
        {
            int rows_a = matrix_1.GetLength(0);
            int cols_a = matrix_1.GetLength(1);
            int cols_b = matrix_2.GetLength(1);

            int[,] result = new int[rows_a, cols_b];

            for (int i = 0; i < rows_a; i++)
            {
                for (int j = 0; j < cols_b; j++)
                {
                    for (int k = 0; k < cols_a; k++)
                    {
                        result[i, j] += matrix_1[i, k] * matrix_2[k, j];
                    }
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
        
            Console.WriteLine();
            int[,] matrix_a = new int[,] {
                {1,2,3},
                {4,5,6}
            };

            int[,] matrix_b = new int[,] {
                {7,8},
                {9,10},
                {11,12}
            };
            print_matrix(multiply_matrices(matrix_a, matrix_b));
            Console.ReadKey();
