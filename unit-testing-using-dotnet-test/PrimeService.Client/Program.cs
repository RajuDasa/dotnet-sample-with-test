using PrimeService;

//uses implict using
// See https://aka.ms/new-console-template for more information
var obj = new PrimeService.PrimeService();
Console.WriteLine("is 1 prime: " + obj.IsPrime(1));