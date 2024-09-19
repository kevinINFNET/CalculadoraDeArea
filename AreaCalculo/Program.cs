namespace CalculadoraDeArea
{
  public delegate double CalcularArea(params double[] parametros);
    class Program
    {
  static void Main(string[] args)
 {
  CalcularArea areaCirculo = CalcularAreaCirculo;
  CalcularArea areaRetangulo = CalcularAreaRetangulo;   
  double raio = 5;
   Console.WriteLine($"Área do círculo (raio = {raio}): {areaCirculo(raio)}");
   
   double baseRetangulo = 17;
   double alturaRetangulo = 7;
Console.WriteLine($"Área do retângulo (base = {baseRetangulo}, altura = {alturaRetangulo}): {areaRetangulo(baseRetangulo, alturaRetangulo)}");
  Console.ReadLine();
   }
     static double CalcularAreaCirculo(params double[] parametros)
    {
  if (parametros.Length != 1)
   throw new ArgumentException("Um parâmetro é necessário: o raio do círculo.");
   double raio = parametros[0];
    return Math.PI * Math.Pow(raio, 2);
     }
 static double CalcularAreaRetangulo(params double[] parametros)
   {
    if (parametros.Length != 2)
     throw new ArgumentException("Dois parâmetros são necessários: a base e a altura do retângulo.");
     double baseRetangulo = parametros[0];
     double alturaRetangulo = parametros[1];
       return baseRetangulo * alturaRetangulo;
   }
  }
}
