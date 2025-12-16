using System.Text;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Bai_1();
        Bai_2();
        Bai_3();
        Bai_4();
        Bai_5();
        Bai_6();
        Bai_7();
        Bai_8();
        Bai_9();
        Bai_10();
    }

    static void Bai_1()
    {
        Console.WriteLine("Giải hệ phương trình");
        Console.WriteLine("Nhập hệ số a1, b1, c1 của phương trình thứ nhất (a1*x + b1*y = c1):");
        double a1 = double.Parse(Console.ReadLine()!);
        double b1 = double.Parse(Console.ReadLine()!);
        double c1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Nhập hệ số a2, b2, c2 của phương trình thứ hai (a2*x + b2*y = c2):");
        double a2 = double.Parse(Console.ReadLine()!);
        double b2 = double.Parse(Console.ReadLine()!);
        double c2 = double.Parse(Console.ReadLine()!);
        double D = a1 * b2 - a2 * b1;
        double Dx = c1 * b2 - c2 * b1;
        double Dy = a1 * c2 - a2 * c1;
        if (D != 0)
        {
            double x = Dx / D;
            double y = Dy / D;
            Console.WriteLine($"Hệ phương trình có nghiệm duy nhất: x = {x}, y = {y}");
        }
        else
        {
            if (Dx == 0 && Dy == 0)
            {
                Console.WriteLine("Hệ phương trình có vô số nghiệm.");
            }
            else
            {
                Console.WriteLine("Hệ phương trình vô nghiệm.");
            }
        }
    }

    static void Bai_2()
    {
        Console.WriteLine("Chương trình mô phỏng trờ chơi Kéo-Búa-Bao");
        string[] choices = { "Kéo", "Búa", "Bao" };
        Random rand = new Random();
        while (true)
        {
            Console.WriteLine("Nhập lựa chọn của bạn (Kéo, Búa, Bao)");
            string userInput = Console.ReadLine()!;
            string computerChoice = choices[rand.Next(choices.Length)];
            Console.WriteLine($"Máy chọn: {computerChoice}");
            if (userInput == computerChoice)
            {
                Console.WriteLine("Hòa!");
            }
            else if ((userInput == "Kéo" && computerChoice == "Bao") ||
                     (userInput == "Búa" && computerChoice == "Kéo") ||
                     (userInput == "Bao" && computerChoice == "Búa"))
            {
                Console.WriteLine("Bạn thắng!");
            }
            else
            {
                Console.WriteLine("Máy thắng!");
            }
        }
    }

    static void Bai_3()
    {
        Console.WriteLine("Nhập số nguyên dương N");
        int n = int.Parse(Console.ReadLine()!);
        if(n % 3 == 0 && n % 5 == 0)
        {
            Console.WriteLine("N là bội số của cả 3 và 5");
        }
        else if(n % 3 == 0)
        {
            Console.WriteLine("N là bội số của 3");
        }
        else if(n % 5 == 0)
        {
            Console.WriteLine("N là bội số của 5");
        }
        else
        {
            Console.WriteLine("N không là bội số của 3 hoặc 5");
        }
    }

    static void Bai_4()
    {
        Console.WriteLine("Giải phương trình trùng phương");
        Console.WriteLine("Nhập hệ số a, b, c của phương trình ax^4 + bx^2 + c = 0");
        double a = double.Parse(Console.ReadLine()!);   
        double b = double.Parse(Console.ReadLine()!);
        double c = double.Parse(Console.ReadLine()!);

        double delta = b * b - 4 * a * c;

        double t1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double t2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine("Nghiem:");

        if (t1 >= 0)
            Console.WriteLine($"x = ±{Math.Sqrt(t1)}");

        if (t2 >= 0 && t2 != t1)
            Console.WriteLine($"x = ±{Math.Sqrt(t2)}");

    }

    static void Bai_5()
    {   
        Console.WriteLine("Tính các góc của tam giác khi biết độ dài ba cạnh");
        Console.WriteLine("Nhập độ dài ba cạnh a, b, c của tam giác");
        double a = double.Parse(Console.ReadLine()!);   
        double b = double.Parse(Console.ReadLine()!);
        double c = double.Parse(Console.ReadLine()!);

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Không phải tam giác");
            return;
        }

        double A = Math.Acos((b*b + c*c - a*a) / (2*b*c)) * 180 / Math.PI;
        double B = Math.Acos((a*a + c*c - b*b) / (2*a*c)) * 180 / Math.PI;
        double C = 180 - A - B;

        Console.WriteLine($"Góc A = {A:F2}");
        Console.WriteLine($"Góc B = {B:F2}");
        Console.WriteLine($"Góc C = {C:F2}");
    }

    static void Bai_6()
    {
        // This is a placeholder for Bai_6 implementation
    }

    static void Bai_7()
    {
        Console.WriteLine("Tính cạnh huyền và các góc của tam giác vuông khi biết hai cạnh góc vuông");
        Console.WriteLine("Nhập độ dài hai cạnh góc vuông a, b của tam giác");
        double a = double.Parse(Console.ReadLine()!);   
        double b = double.Parse(Console.ReadLine()!);

        double c = Math.Sqrt(a * a + b * b);

        double A = Math.Atan(a / b) * 180 / Math.PI;
        double B = 90 - A;

        Console.WriteLine($"Canh huyền c = {c:F2}");
        Console.WriteLine($"Góc A = {A:F2}");
        Console.WriteLine($"Góc B = {B:F2}");
    }

    static void Bai_8()
    {
        Console.WriteLine("Tính bán kính hình cầu khi biết thể tích và chiều cao của hình trụ");
        Console.WriteLine("Nhập thể tích R và chiều cao h của hình trụ");
        double R = double.Parse(Console.ReadLine()!);
        double h = double.Parse(Console.ReadLine()!);

        double r = Math.Pow((3 * R * R * h) / 4, 1 / 3);

        Console.WriteLine($"Ban kính hình cầu = {r:F2}");
    }

    static void Bai_9()
    {
        Console.WriteLine("Tính bán kính hình cầu khi biết thể tích và chiều cao của hình hộp chữ nhật");
        Console.WriteLine("Nhập 3 cạnh của hình hộp chữ nhật");
        double a = double.Parse(Console.ReadLine()!);   
        double b = double.Parse(Console.ReadLine()!);
        double c = double.Parse(Console.ReadLine()!);

        double r = Math.Pow((3 * a * b * c) / (4 * Math.PI), 1.0 / 3);

        Console.WriteLine($"Bán kính hình cầu = {r:F2}");
    }

    static void Bai_10()
    {
        
    }
}