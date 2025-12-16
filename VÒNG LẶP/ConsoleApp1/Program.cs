using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // Bai_1();
        // Bai_2();
        // Bai_3();
        // Bai_4();
        // Bai_5();
        // Bai_6();
        // Bai_7();
        // Bai_8();
        // Bai_9();
        // Bai_10();
        // Bai_11();
        // Bai_12();
        // Bai_13();
        // Bai_14();
        // Bai_15();
        // Bai_16();
        // Bai_17();
        // Bai_18();
        // Bai_19();
        // Bai_20();
        // Bai_21();
        // Bai_22();
        // Bai_23();
        // Bai_24();
        // Bai_25();
        // Bai_26();
         Bai_27();
    }
    
    static void Bai_1()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);

        for(int i = 1; i <= n ; i++)
        {
            if(i%2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }

    static void Bai_2()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int sum = 0;
        for(int i = 1; i <= n ; i++)
        {
            sum += i;
        }
        Console.Write(sum);
    }

    static void Bai_3()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);

        for(int i = 1; i <= n ; i++)
        {
            int Pow = i * i;
            {
                Console.Write(Pow + " ");
            }
        }
    }

    static void Bai_4()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int factorial = 1;

        for(int i = 1; i <= n ; i++)
        {
            factorial *= i;
        }
        Console.Write(factorial);
    }

    static void Bai_5()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);

        for(int i = 1; i <= n ; i++)
        {
            bool Prime = true;
            for(int j = 2; j <= Math.Sqrt(i); j++)
            {
                if(i % j == 0)
                {
                    Prime = false;
                    break;
                }
            }
            if(Prime && i > 1)
            {
                Console.Write(i + " ");
            }
        }
    }

    static void Bai_6()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int a = 0, b = 1, c;

        for(int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }

    static void Bai_7()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        
        for (int i = 1; i <= n; i++)
        {
            if(i % 3 == 0 && i % 5 !=0)
            {
                Console.Write(i + " ");
            }
        }
    }

    static void Bai_8()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int prod = 1;

        for (int i = 1; i <= n; i++)
        {
            if(i % 2 != 0)
            {
                prod *= i;
            }
        }
        Console.Write(prod);
    }

    static void Bai_9()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Bai_10()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int i = n;
        while(i >= 1)
        {
            Console.Write(i + " ");
            i--;
        }
    }

    static void Bai_11()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int sum = 0;
        while(n >= 9)
        {
            sum += n % 10;
            n /= 10;
        }
        sum += n;
        Console.Write(sum);
    }

    static void Bai_12()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        bool isPrime = true;
        int i  = 1;
        while(i*i <= n)
        {
            if(n % i == 0 && i != 1)
            {
                isPrime = false;
                break;
            }
            i++;
        }
        if(isPrime)
        {
            Console.WriteLine($"{n} là số nguyên tố");
        }
        else
        {
            Console.WriteLine($"{n} không phải số nguyên tố");
        }
    }

    static void Bai_13()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int i = 0;

        while (i<=n)
        {
            if(i%7 == 0)
            {
                Console.Write(i + " ");
            }
            i++;
        }
    }

    static void Bai_14()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int count = 0, digit = 0;

        while(n>=9)
        {
            digit = n%10;
            if(digit % 2 == 0)
            {
                count++;
            }
            n /= 10;
        }
        
        if (n%2 == 0)
        {
            count ++;
        }

        Console.Write(count);
    }

    static void Bai_15()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int i =  1;
        while(i<=n)
        {
            if(n%i==0)
            {
                Console.Write(i + " ");
            }
            i++;
        }
    }

    static void Bai_16()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int i = 1;
        while(i*i<=n)
        {
            if(i*i == n)
            {
                Console.WriteLine($"{n} là số chính phương");
                break;
            }
            i++;
        }
    }

    static void Bai_17()
    {
        Console.WriteLine("Nhập n và m: ");
        int n = int.Parse(Console.ReadLine()!);
        int m = int.Parse(Console.ReadLine()!);
        int r = 0;

        while(n!=m)
        {
            r=n%m;
            n=m;
            m=r;

            if (r == 0)
            {
                break;
            }
        }
        Console.Write(n);
    }

    static void Bai_18()
    {
        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);
        int rev = 0;
        while(n>0)
        {
            int digit = n % 10;
            rev = rev*10 + digit;
            n /= 10;
        }
        Console.Write(rev);
    }

    static void Bai_19()
    {
        int num, sum = 0;
        do
        {
            Console.Write("Nhập số: ");
            num = int.Parse(Console.ReadLine()!);
            sum += num;

        } while (num != 0);

        Console.Write(sum);
    }

    static void Bai_20()
    {
        int pos, res = 1;
        do
        {
            Console.Write("Nhập số dương: ");
            pos = int.Parse(Console.ReadLine()!);
            if(pos <0) break;

            res *= pos;

        } 
        while(pos > 0);
        Console.Write(res);
    }

    static void Bai_21()
    {
        int num, max = 0;
        do
        {
            Console.Write("Nhập số: ");
            num = int.Parse(Console.ReadLine()!);
            if(num >= max)
            {
                max = num;
            }
        }
        while(num % 5 != 0);
        Console.Write(max);
    }

    static void Bai_22()
    {
        int num, min = int.MaxValue;
        do
        {
            Console.Write("Nhập số: ");
            num = int.Parse(Console.ReadLine()!);

            if(num < 0) break;
    
            if(num < min)
            {
                min = num;
            }
        }
        while(num >= 0);
        Console.Write(min);
    }

    static void Bai_23()
    {
        char kyTu;
        int count = 0;
        do
        {
            Console.Write("Nhập ký tự ");
            string input = Console.ReadLine()!;

            kyTu = input[0];

            if(kyTu == '#') break; 

            if(char.IsLetter(kyTu)) count++;
            
        }
        while(true);

        Console.Write(count);
    }

    static void Bai_24()
    {
        int even = 0, odd = 0;
        do
        {
            Console.Write("Nhập số ");
            int num = int.Parse(Console.ReadLine()!);

            if(num == 0) break;

            if(num % 2 == 0) even++;
            else odd++;
        }
        while(true);

        Console.WriteLine(even);
        Console.WriteLine(odd);
    }

    static void Bai_25()
    {
        int count = 0, sum = 0;
        do
        {
            Console.Write("Nhập số: ");
            int num = int.Parse(Console.ReadLine()!);

            if(num < 0) break;
            
            if(num % 2 != 0) continue;

            count++;
            sum += num;
        }
        while(true);

        double res= sum / count;
        Console.Write(res);
    }

    static void Bai_26()
    {
        int count = 0;
        do
        {
            Console.Write("Nhập số: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num == 0) break; 

            if (num < 2) continue; 

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break; 
                }
            }

            if (isPrime)
            {
                count++;
            }

        } while (true);
        
        Console.WriteLine($"Tổng số nguyên tố đã nhập: {count}");
    }

    static void Bai_27()
    {
        int sum = 0, num = 0;
        do
        {
            Console.Write("Nhập số: ");
            num = int.Parse(Console.ReadLine()!);

            if(num == 0) break;
            
            if(num % 2 == 0) continue;

            sum += num;
        }
        while(num != 0);

        Console.Write(sum);
    }
}