using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Đặt encoding để hỗ trợ tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập n (n > 0): ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                // Tính (-1)^(i+1) * i
                int term = (int)Math.Pow(-1, i + 1) * i;
                sum += term;
            }

            Console.WriteLine($"Tổng S({n}) = {sum}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương lớn hơn 0.");
        }
    }
}
