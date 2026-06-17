            int[,] sum_two_matrix(int[,] matrix_1, int[,] matrix_2){
            int rows = matrix_1.GetLength(0);
            int cols = matrix_1.GetLength(1);

            int[,] matrix_c = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix_c[i, j] = matrix_1[i, j] + matrix_2[i, j];
                }
            }
            return matrix_c;
        }
        
        
            int[,] matrix_a = new int[,] {
                {11,21,33,14,65},
                {12,21,30,49,57}
            };

            int[,] matrix_b = new int[,] {
                {15,62,73,34,65},
                {21,62,43,46,53}
            };
            int[,] result = sum_two_matrix(matrix_a, matrix_b);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
