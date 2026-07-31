using TicTacToe.Models;
using Xunit;

namespace TicTacToe.Tests.Models
{
    public class ModeloTableroTests
    {
        [Fact]
        public void ColocarMarcador_CeldaOcupada_NoSobrescribe()
        {
            // Arrange
            var tablero = new ModeloTablero();
            tablero.ColocarMarcador(0, 0, 'X');

            // Act - Intenta poner O donde ya hay X
            tablero.ColocarMarcador(0, 0, 'O');

            // Assert - Debe mantener la X original
            Assert.Equal('X', tablero.Tablero[0, 0]);
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, -1)]
        [InlineData(3, 0)]
        [InlineData(0, 3)]
        public void EsCeldaVacia_CoordenadasInvalidas_RetornaFalse(int fila, int columna)
        {
            // Arrange
            var tablero = new ModeloTablero();

            // Act
            var resultado = tablero.EsCeldaVacia(fila, columna);

            // Assert
            Assert.False(resultado);
        }
    }
}