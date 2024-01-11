using PrimeService;

//uses implict using
// See https://aka.ms/new-console-template for more information

var obj = new PrimeService.PrimeService();
int number;

Console.WriteLine("** Prime number checker **");
Console.WriteLine("Enter int number: ");
number = Convert.ToInt32(Console.ReadLine());

if (obj.IsPrime(number))
{
    Console.WriteLine("It is prime");
}
else
{
    Console.WriteLine("It is not prime");
}
