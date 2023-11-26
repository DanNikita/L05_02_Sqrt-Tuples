    internal class Sqrt_Tuples
    {
    public static (double, double, bool) Discr(int a, int b, int c)
    {
        double temp = b * b - 4 * a * c;
        double x1 =0, x2=0;
        bool flag = false;
        switch (temp)
        {
            case (> 0):
                {
                    x1 = (-b + Math.Sqrt(temp)) / 2 * a;
                    x2 = (-b - Math.Sqrt(temp)) / 2 * a;
                    flag = true;
                    break;
                }
            case (0):
                {
                    x1 = (-b / 2 * a);
                    flag = true;
                    x2 = 0;
                    break;
                }
            case (< 0):
                {
                    x1 = 0; 
                    x2 = 0;
                    flag = false;
                    break;
                }
        }
        return (x1, x2, flag);
    }
    public static void Main(string[] args)
        {
            Console.WriteLine("Enter a,b,c coefficients:");
            Console.Write("a (not a zero!) = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            (double x1, double x2, bool flag) result = Discr(a, b, c);
            if (result.flag == false ) 
                Console.WriteLine("No roots");
                else
                {
                    if (result.x2 == 0)
                        Console.WriteLine("One root x1 = {0}",result.x1);
                    else
                        Console.WriteLine("Two roots x1 = {0:F2}, x2 = {1:F2}", result.x1, result.x2);
                }
            Console.ReadLine();
        }
    }