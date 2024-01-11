namespace PrimeService.Tests;

public class PrimeService_IsPrimeShould
{

    private readonly PrimeService _primeService;

    public PrimeService_IsPrimeShould()
    {
        _primeService = new PrimeService();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(19)]
    public void IsPrime_Value_minus1_0_1_19_ReturnFalse(int value)
    {
        var result = _primeService.IsPrime(value);

        Assert.False(result, $"{value} should not be prime");
    }
}