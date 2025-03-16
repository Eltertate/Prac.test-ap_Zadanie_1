namespace Prac_test_ap_Zadanie_1
{
    internal class Program
    {
        static void Zadanie1i2()
        {
            Console.WriteLine("\n\n\tZADANIE I i II\n\n");
            Console.WriteLine("Wpisuj dowolne liczby, żeby skończyć wpisz 0");
            int a = 1;
            List<int> list = new List<int> { };
            while (a != 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if(a == 0)
                {
                    break;
                }
                list.Add(a);
            }
            Console.WriteLine("Najmniejsza liczba: " + list.Min());
            Console.WriteLine("Największa liczba: " + list.Max());
        }

        static void Zadanie3() 
        {
            Console.WriteLine("\n\n\tZADANIE III\n\n");
            Console.WriteLine("Wpisuj dowolne liczby, żeby skończyć wpisz liczbę podzielną przez 13");
            int a = 1;
            List<int> list = new List<int> { };
            while (a % 13 != 0)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 13 == 0)
                {
                    break;
                }
                list.Add(a);
            }
            Console.WriteLine("Suma: " + list.Sum());
        }
        static void Zadanie4()
        {
            Console.WriteLine("\n\n\tZADANIE IV\n\n");
            Console.WriteLine("Wpisuj dowolne znaki, żeby skończyć wpisz znak '*'");
            string a = "";
            List<string> list = new List<string> { };
            while (a != "*")
            {
                a = Console.ReadLine();
                if (a == "*")
                {
                    Console.WriteLine("Chcesz przerwać wczytywanie? Tak: T/t Nie: inna klawisza");
                    string b = Console.ReadLine();
                    if (b == "t" || b == "T")
                    {
                        break;
                    }
                }
                list.Add(a);
            }
            Console.WriteLine("Twoje notatki" + list);
        }
        static void Zadanie5()
        {
            Console.WriteLine("\n\n\tZADANIE V\n\n");

            Console.WriteLine("Wpisuj dowolne liczby, żeby skończyć wpisz liczby suma których równa się 100");
            int a = 1;
            List<int> list = new List<int> { };
            bool sprawdzenie = true;
            while (sprawdzenie)
            {
                a = Convert.ToInt32(Console.ReadLine());
                list.Add(a);
                Console.WriteLine("Suma:" + list.Sum());
                if(list.Sum() >= 100)
                {
                    sprawdzenie = false; 
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie Domowe:");
            Zadanie1i2();
            Zadanie3();
            Zadanie4();
            Zadanie5();
        }
    }
}
