namespace retangulo;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler as medidas da base e altura de um fretangulo. Em seguida mostrar o valor da area,
        //perimetro e diagonal deste retangulo, com quatro casas descimais, conforme exemplos.
        
        double area, perimetro, diagonal, Base, altura, Diagonal;

        Console.Write("Entre com a base do retangulo por favor: ");
        Base = double.Parse(Console.ReadLine());

        Console.Write("Entre com a altura do retangulo por favor: ");
        altura = double.Parse(Console.ReadLine());

        area = Base * altura;

        perimetro = (Base * 2) + (altura * 2);

        diagonal = Math.Sqrt(Base * Base + altura * altura);

        Console.WriteLine("A area do retangunlo é = " + area.ToString("C"));
        
        Console.WriteLine("A area do perimetro é = " + perimetro.ToString("C"));
        
        Console.WriteLine("A area do diagonal é = " + diagonal.ToString("C"));
    }
}