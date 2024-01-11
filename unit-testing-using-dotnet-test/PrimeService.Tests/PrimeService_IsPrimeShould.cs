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
    [InlineData(15)]
    public void IsPrime_Value_minus1_0_1_15_ReturnFalse(int value)
    {
        var result = _primeService.IsPrime(value);

        Assert.False(result, $"{value} should not be prime");
    }
}
