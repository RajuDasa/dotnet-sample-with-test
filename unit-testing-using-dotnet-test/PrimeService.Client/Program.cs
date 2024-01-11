using PrimeService;

//uses implict using
// See https://aka.ms/new-console-template for more information

public static void main(string[] args)
{
    if(args == null || args.Length ==0)
        throw new InvalidArgumentError();

    var obj = new PrimeService.PrimeService();
    int number;

    Console.WriteLine("** Prime number checker **");
    Console.WriteLine("passed int number: ${args[0]} ");
    number = Convert.ToInt32(args[0]);

    if (obj.IsPrime(number))
    {
        Console.WriteLine("It is prime");
    }
    else
    {
        Console.WriteLine("It is not prime");
    }
}
