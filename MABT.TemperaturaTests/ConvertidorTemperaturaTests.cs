using MABT.Temperatura; // 👈 Importante: referencia a la clase a probar
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ConvertidorTemperaturaTests
{
    [TestMethod]
    public void CelsiusAFahrenheit_CeroCelsius_DebeSerTreintaDos()
    {
        // Arrange
        var conversor = new ConvertidorTemperatura();
        double celsius = 0;
        double esperado = 32;

        // Act
        double resultado = conversor.CelsiusAFahrenheit(celsius);

        // Assert
        Assert.AreEqual(esperado, resultado);
    }

    [TestMethod]
    public void FahrenheitACelsius_TreintaDosFahrenheit_DebeSerCero()
    {
        // Arrange
        var conversor = new ConvertidorTemperatura();
        double fahrenheit = 32;
        double esperado = 0;

        // Act
        double resultado = conversor.FahrenheitACelsius(fahrenheit);

        // Assert
        Assert.AreEqual(esperado, resultado);
    }
}