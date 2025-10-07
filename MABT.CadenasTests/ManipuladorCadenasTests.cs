using MABT.Cadenas;
using Xunit;

public class ManipuladorCadenasTests
{
    // PRUEBAS PARA EL MÉTODO INVERTIRCADENA

    [Fact]
    public void InvertirCadena_HolaMundo_DebeSerOdnuMaloh()
    {
        // Arrange (Preparación)
        var manipulador = new ManipuladorCadenas();
        string entrada = "Hola Mundo";
        string esperado = "odnuM aloH";

        // Act (Acción)
        string resultado = manipulador.InvertirCadena(entrada);

        // Assert (Verificación)
        Assert.Equals(esperado, resultado);
    }

    [Fact]
    public void InvertirCadena_CadenaVacia_DebeSerCadenaVacia()
    {
        // Arrange
        var manipulador = new ManipuladorCadenas();
        string entrada = "";
        string esperado = "";

        // Act
        string resultado = manipulador.InvertirCadena(entrada);

        // Assert
        Assert.Equals(esperado, resultado);
    }

    // -----------------------------------------------------------------

    // PRUEBAS PARA EL MÉTODO CONTARVOCALES

    [Fact]
    public void ContarVocales_Prueba_DebeSerTres()
    {
        // Arrange
        var manipulador = new ManipuladorCadenas();
        string entrada = "Prueba";
        int esperado = 3; // u, e, a

        // Act
        int resultado = manipulador.ContarVocales(entrada);

        // Assert
        Assert.Equals(esperado, resultado);
    }

    [Fact]
    public void ContarVocales_MayusculasYMinusculas_DebeContarTodas()
    {
        // Arrange
        var manipulador = new ManipuladorCadenas();
        string entrada = "AEIOUaeiou";
        int esperado = 10;

        // Act
        int resultado = manipulador.ContarVocales(entrada);

        // Assert
        Assert.Equals(esperado, resultado);
    }

    [Fact]
    public void ContarVocales_SoloConsonantes_DebeSerCero()
    {
        // Arrange
        var manipulador = new ManipuladorCadenas();
        string entrada = "rhythm"; // Contiene solo consonantes en inglés
        int esperado = 0;

        // Act
        int resultado = manipulador.ContarVocales(entrada);

        // Assert
        Assert.Equals(esperado, resultado);
    }
}