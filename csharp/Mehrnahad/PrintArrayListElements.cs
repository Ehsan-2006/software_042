using System.Collections;
        void print_list(ArrayList list) {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0}, ",list[i]);
            }
        }
        void get_list(int num, ArrayList list) {
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter item[{0}]: ",i+1);
                list.Add(int.Parse(Console.ReadLine()));
            }
        }

            Console.Write("Enter number of list items: ");
            int num = int.Parse(Console.ReadLine());

            ArrayList MyList = new ArrayList();

            get_list(num, MyList);
            var uniqueList = MyList.Cast<object>().Distinct().ToList();
            MyList.Clear();
            MyList.AddRange(uniqueList);

            Console.WriteLine();
            print_list(MyList);

            Console.ReadKey();
        
