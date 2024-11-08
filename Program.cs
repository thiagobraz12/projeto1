int valor1 = 0;
int valor2 = 0;
int resultado = 0;

Console.WriteLine("Digite um valor");
valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor");
valor2 = int.Parse(Console.ReadLine());

resultado = valor1 + valor2;

// como fazer if e else
if (resultado > 2)
{
    
    Console.WriteLine("Seu resultado e positivo");

}
else 
{
    Console.WriteLine("Seu resultado e negativo");
}
