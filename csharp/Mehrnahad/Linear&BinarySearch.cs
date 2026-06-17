        void print_array(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
        }
        void print_reversed_array(int[] array) {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ",array[i]);
            }
        }
        int linear_search(int[] array, int target){
            for (int i = 0; i < array.Length; i++)
      {
          if (array[i] == target){
                    return i;
              }
      }
      return -1;
        }
        int binary_search(int[] array, int target) {
            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }
                if (array[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

            Console.Write("Enter quantity: ");
            int qty = int.Parse(Console.ReadLine());
            int[] array = new int[qty];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element[{0}]: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array:");
            print_array(array);
            Console.WriteLine();
            Console.WriteLine("Reversed Array:");
            print_reversed_array(array);
            Console.WriteLine();

            Console.Write("Enter your target in array: ");
            int target = int.Parse(Console.ReadLine());

            int result = linear_search(array, target);

            Console.WriteLine("Linear Search: ");
            if (result != -1)
            {
                Console.WriteLine("Element found at index {0}", result);
            }
            Console.WriteLine("Binary Search: ");
            result = binary_search(array, target);
            if (result != -1)
            {
                Console.WriteLine("Element found at index {0}", result);
            }
            
            Console.ReadLine();
