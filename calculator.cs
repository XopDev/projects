            while (true) 
                {
                Console.WriteLine("[!] Добро пожаловать в калькулятоp!");

                Console.Write("Введи первое число: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введи второе число: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());

                Console.Write("[!] Выбери операцию: ");
                Console.WriteLine(" 1. + | 2. - | 3. * | 4. /");
                int operation = Convert.ToInt32(Console.ReadLine());
                int sumone = numberOne + numberTwo;
                int sumtwo = numberOne - numberTwo;
                int sumthree = numberOne * numberTwo;
                int sumfour = numberOne / numberTwo;
                if (operation == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"{numberOne} + {numberTwo} = {sumone}");
                }
                if (operation == 2)
                {
                    Console.Clear();
                    Console.WriteLine($"{numberOne} - {numberTwo} = {sumtwo}");
                }
                if (operation == 3)
                {
                    Console.Clear();
                    Console.WriteLine($"{numberOne} * {numberTwo} = {sumthree}");
                }
                if (operation == 4)
                {
                    Console.Clear();
                    Console.WriteLine($"{numberOne} / {numberTwo} = {sumfour}");
                }
                break;
            }
