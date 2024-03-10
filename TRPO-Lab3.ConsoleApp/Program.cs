using TRPO_Lab3.Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите периметр основания правильной пирамиды: ");
        double p = float.Parse(Console.ReadLine());
        Console.WriteLine("Введите апофему правильной пирамиды: ");
        double a = float.Parse(Console.ReadLine());
        Console.WriteLine("Полученная боковая поверхность правильной пирамиды: ");
        double s = Lateral_Surface_Regular_Piramid.Lateral_Surface_Regular_Piramid_formula(p, a);
        Console.WriteLine(s);
    }
}