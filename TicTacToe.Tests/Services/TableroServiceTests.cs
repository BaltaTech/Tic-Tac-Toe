using TicTacToe.Interfaces;
using TicTacToe.Models;
using TicTacToe.Services;
using Xunit;

namespace TicTacToe.Tests.Services
{
    public class TableroServiceTests
    {
        private readonly IServicioJuego _servicio;

        public TableroServiceTests()
        {
            _servicio = new TableroService();
        }

        [Fact]
        public void VerificarEstado_CuandoFilaCompleta_RetornaGanador()
        {
            // Arrange
            var tablero = new ModeloTablero();
            tablero.ColocarMarcador(0, 0, 'X');
            tablero.ColocarMarcador(0, 1, 'X');
            tablero.ColocarMarcador(0, 2, 'X');

            // Act
            var resultado = _servicio.VerificarEstadoJuego(tablero);

            // Assert
            Assert.True(resultado.HayGanador);
            Assert.Equal('X', resultado.JugadorGanador);
            Assert.False(resultado.EsEmpate);
        }

        [Fact]
        public void VerificarEstado_CuandoDiagonalPrincipal_RetornaGanador()
        {
            // Arrange
            var tablero = new ModeloTablero();
            tablero.ColocarMarcador(0, 0, 'O');
            tablero.ColocarMarcador(1, 1, 'O');
            tablero.ColocarMarcador(2, 2, 'O');

            // Act
            var resultado = _servicio.VerificarEstadoJuego(tablero);

            // Assert
            Assert.True(resultado.HayGanador);
            Assert.Equal('O', resultado.JugadorGanador);
        }

        [Fact]
        public void VerificarEstado_CuandoDiagonalSecundaria_RetornaGanador()
        {
            // Arrange
            var tablero = new ModeloTablero();
            tablero.ColocarMarcador(0, 2, 'X');
            tablero.ColocarMarcador(1, 1, 'X');
            tablero.ColocarMarcador(2, 0, 'X');

            // Act
            var resultado = _servicio.VerificarEstadoJuego(tablero);

            // Assert
            Assert.True(resultado.HayGanador);
            Assert.Equal('X', resultado.JugadorGanador);
        }

        [Fact]
        public void VerificarEstado_CuandoEmpate_RetornaEmpateSinGanador()
        {
            // Arrange
            var tablero = new ModeloTablero();
            // Llenar tablero sin ganador
            tablero.ColocarMarcador(0, 0, 'X');
            tablero.ColocarMarcador(0, 1, 'O');
            tablero.ColocarMarcador(0, 2, 'X');
            tablero.ColocarMarcador(1, 0, 'X');
            tablero.ColocarMarcador(1, 1, 'X');
            tablero.ColocarMarcador(1, 2, 'O');
            tablero.ColocarMarcador(2, 0, 'O');
            tablero.ColocarMarcador(2, 1, 'X');
            tablero.ColocarMarcador(2, 2, 'O');

            // Act
            var resultado = _servicio.VerificarEstadoJuego(tablero);

            // Assert
            Assert.True(resultado.EsEmpate);
            Assert.False(resultado.HayGanador);
            Assert.Null(resultado.JugadorGanador);
        }

        [Fact]
        public void VerificarEstado_CuandoDosEnLinea_NoRetornaGanador()
        {
            // Arrange
            var tablero = new ModeloTablero();
            tablero.ColocarMarcador(0, 0, 'X');
            tablero.ColocarMarcador(0, 1, 'X');
            // Falta [0,2] - solo hay 2 en línea

            // Act
            var resultado = _servicio.VerificarEstadoJuego(tablero);

            // Assert
            Assert.False(resultado.HayGanador);
            Assert.False(resultado.EsEmpate);
            Assert.Null(resultado.JugadorGanador);
        }
    }
}