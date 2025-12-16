using System.Text;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

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
    }

    static void Bai_1()
    {
        Console.WriteLine("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];
        for(int i = 0 ; i < n ; i++)
        {
            Console.Write($"Nhập phần tử arr[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Nhập x: ");
        int x = int.Parse(Console.ReadLine()!);

        Console.Write("Vị trí các phần tử trong mảng bằng x: ");
        for(int i = 0 ; i < n ; i++)
        {
            if (arr[i] == x)
            {
                Console.Write(i + " ");
            }
        }
    }
    static void Bai_2()
    {
        Console.Write("Nhập bậc n của đa thức: ");
        int n = int.Parse(Console.ReadLine()!);

        double[] a = new double[n + 1];

        for (int i = n; i >= 0; i--)
        {
            Console.Write($"Nhập hệ số arr[{i}] (đi với x^{i}): ");
            a[i] = double.Parse(Console.ReadLine()!);
        }

        Console.Write("Nhập giá trị x cần tính: ");
        double x = double.Parse(Console.ReadLine()!);

        double res = 0;
    
        for (int i = 0; i <= n; i++)
        {
            res += a[i] * Math.Pow(x, i);
        }

        Console.WriteLine($"Giá trị của đa thức F({x}) là: {res}");
    }

    static void Bai_3()
    {
        Console.WriteLine("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] > arr[j]) 
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        //Hoặc là Array.Sort =))))))))))))

        Console.WriteLine("Mảng tăng dần: ");
        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }
    }
    static void Bai_4()
    {
        Console.WriteLine("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        int neg = 0 , Sneg = 0, pos = 0, Spos = 0;
        foreach(int x in arr)
        {
            if (x < 0)
            {
                neg++;
                Sneg += x;
            }
            else if (x > 0)
            {
                pos++;
                Spos += x;
            }
        }
        Console.WriteLine($"Số lượng số âm là {neg} có tổng là {Sneg}");
        Console.WriteLine($"Số lượng số dươbg là {pos} có tổng là {Spos}");
    }
    static void Bai_5()
    {
        Console.Write("Nhập số lượng số Fibonacci cần in (n): ");
        int n = int.Parse(Console.ReadLine()!);

        int[] f = new int[n];

        if (n >= 1) f[0] = 0; 
        if (n >= 2) f[1] = 1; 

        for (int i = 2; i < n; i++)
        {
            f[i] = f[i - 1] + f[i - 2]; 
        }

        Console.WriteLine($"{n} số hạng đầu tiên của dãy Fibonacci: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(f[i] + " ");
        }
    }
    static void Bai_6()
    {
        int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int t;
        do
        {
            Console.Write("Nhập tháng t (1-12): ");
            string input = Console.ReadLine()!;
        
            if (int.TryParse(input, out t) && t >= 1 && t <= 12)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Tháng phải từ 1 đến 12. Vui lòng nhập lại!");
            }
        } while (true);

        Console.WriteLine($"Tháng {t} có {month[t - 1]} ngày");
    }
    static void Bai_7()
    {
        Console.WriteLine("Nhập n: ");
        int n = int.Parse(Console.ReadLine()!);

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        int left = 0;           
        int right = n - 1;      
        bool doiXung = true;

        while (left < right)
        {
            if (arr[left] != arr[right])
            {
                doiXung = false;
                break;
            }

            left++;  
            right--; 
        }

        if (doiXung)
            Console.WriteLine("Mảng đối xứng");
        else
            Console.WriteLine("Mảng không đối xứng");
    }
    static void Bai_8()
    {
        Console.WriteLine("Nhập độ lớn của mảng: ");
        int size = int.Parse(Console.ReadLine()!);

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine("Nhập N và M (N<M)");
        int n = int.Parse(Console.ReadLine()!);
        int m = int.Parse(Console.ReadLine()!);

        int count = 0; 

        Console.WriteLine("Cách ra cho dễ đọc");
        for (int i = 0; i < size; i++)
        {
            if (arr[i] >= n && arr[i] <= m)
            {
                Console.WriteLine($"{arr[i]} nằm tại vị trí: {i}");
                count++; 
            }
        }
        Console.WriteLine($"=> Tổng cộng có {count} số thoả mãn yêu cầu.");
    }
    static void Bai_9()
    {
        int[] scales = { 256, 128, 64, 32, 16, 8, 4, 2, 1};
        Console.WriteLine("Nhập độ nặng của cân M (M < 512g): ");
        int m = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Các quả cân dùng để cân {m}g là: ");
        foreach (int scale in scales)
        {
            if (m >= scale)
            {
                Console.Write(scale + "g "); 
                m -= scale;               
            }
                
            if (m == 0) break;
        }
    }

    static void Bai_10()
    {
        Console.Write("Nhập u1 của cấp số cộng: ");
        int u = int.Parse(Console.ReadLine()!);

        Console.Write("Nhập d của cấp số cộng: ");
        int d = int.Parse(Console.ReadLine()!);

        Console.Write("Nhập số phần tử cần in: ");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = 0 ; i < n ; i++)
        {
            Console.Write(u +" ");
            u += d;
        }
    }

    static void Bai_11()
    {
        Console.Write("Nhập cấp của ma trận vuông (n): ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] arr = new int[n, n]; 

        Console.WriteLine("Nhập các phần tử của ma trận:");
        for (int i = 0; i < n; i++)         
        {
            for (int j = 0; j < n; j++)     
            {
                Console.Write($"arr[{i},{j}] = ");
                arr[i, j] = int.Parse(Console.ReadLine()!);
            }
        }
        bool doiXung = true; 

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++) 
            {
                if (arr[i, j] != arr[j, i])
                {
                    doiXung = false;
                    break; 
                }
            }
            if (doiXung == false) break; 
        }

        if (doiXung)
            Console.WriteLine("ma trận đối xứng");
        else
            Console.WriteLine("ma trận không đối xứng");
    }

    static void Bai_12()
    {

        Console.Write("Nhập số dòng (m): ");
        int m = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập số cột (n): ");
        int n = int.Parse(Console.ReadLine()!);
        
        int[,] arr = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"arr[{i},{j}] = ");
                arr[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        bool doiXung = true;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n / 2; j++) 
            {
                if (arr[i, j] != arr[i, n - 1 - j])
                {
                    doiXung = false;
                    break;
                }
            }
            
            if (!doiXung) break; // cái này để đỡ tốn dung lượng thôi chứ cái core kia đúng rồi
        }

        if (doiXung)
            Console.WriteLine("Ma trận đối xứng qua trục giữa");
        else
            Console.WriteLine("Ma trận không qua trục giữa");
    }

    static void Bai_13()
    {
        Console.Write("Nhập số dòng (m): ");
        int m = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập số cột (n): ");
        int n = int.Parse(Console.ReadLine()!);
        
        int[,] arr = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"arr[{i},{j}] = ");
                arr[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        for (int j = 0; j < n; j++) 
        {
            for (int i = 0; i < m; i++) 
            {
                Console.Write(arr[i, j]); 
            }
            Console.WriteLine();
        }
    }

    static void Bai_14()
    {
        Console.Write("Nhập số dòng (m): ");
        int m = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập số cột (n): ");
        int n = int.Parse(Console.ReadLine()!);
        
        int[,] arr = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"arr[{i},{j}] = ");
                arr[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                    
                Console.Write(arr[i, n - 1 - j]);
            }
            Console.WriteLine();
        }
    }

    static void Bai_15()
    {
        Console.Write("Nhập số dòng của A (m): ");
        int m = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập số cột của A (cũng là dòng của B) (n): ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập số cột của B (p): ");
        int p = int.Parse(Console.ReadLine()!);

        int[,] A = new int[m, n];
        int[,] B = new int[n, p];
        int[,] C = new int[m, p]; // Ma trận kết quả

        // Ma trận A
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = int.Parse(Console.ReadLine()!);
            }

        // Ma trận B
        for (int i = 0; i < n; i++)
            for (int k = 0; k < p; k++) 
            {
                Console.Write($"B[{i},{k}] = ");
                B[i, k] = int.Parse(Console.ReadLine()!);
            }

        // Tổng
        for (int i = 0; i < m; i++)        
        {
            for (int k = 0; k < p; k++)     
            {
                C[i, k] = 0;
                for (int j = 0; j < n; j++) 
                {
                    C[i, k] += A[i, j] + B[j, k];
                }
            }
        }

        // Kết quả
        Console.WriteLine("Kết quả ma trận tích C = A * B: ");
        for (int i = 0; i < m; i++)
        {
            for (int k = 0; k < p; k++)
            {
                Console.Write(C[i, k]);
            }
            Console.WriteLine();
        }
    }

    static void Bai_16()
    {
        Console.Write("Nhập số dòng của A (m): ");
        int m = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập số cột của A (cũng là dòng của B) (n): ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập số cột của B (p): ");
        int p = int.Parse(Console.ReadLine()!);

        int[,] A = new int[m, n];
        int[,] B = new int[n, p];
        int[,] C = new int[m, p]; // Ma trận kết quả

        // Ma trận A
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = int.Parse(Console.ReadLine()!);
            }

        // Ma trận B
        for (int i = 0; i < n; i++)
            for (int k = 0; k < p; k++) 
            {
                Console.Write($"B[{i},{k}] = ");
                B[i, k] = int.Parse(Console.ReadLine()!);
            }

        // Tổng
        for (int i = 0; i < m; i++)        
        {
            for (int k = 0; k < p; k++)     
            {
                C[i, k] = 0;
                for (int j = 0; j < n; j++) 
                {
                    C[i, k] += A[i, j] * B[j, k];
                }
            }
        }

        // Kết quả
        Console.WriteLine("Kết quả ma trận tích C = A * B: ");
        for (int i = 0; i < m; i++)
        {
            for (int k = 0; k < p; k++)
            {
                Console.Write(C[i, k]);
            }
            Console.WriteLine();
        }
    }
}