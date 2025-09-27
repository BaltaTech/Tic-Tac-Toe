using TicTacToe.Models;
using TicTacToe.Interfaces;

namespace TicTacToe.Services
{
    public class TableroService : IServicioJuego
    {
        private const int Tamano = 3;

        public EstadoJuego VerificarEstadoJuego(IModeloTablero tablero)
        {
            var _tablero = tablero.Tablero;

            // Verificar filas
            for (int i = 0; i < Tamano; i++)
            {
                if (_tablero[i, 0] != '\0' && _tablero[i, 0] == _tablero[i, 1] && _tablero[i, 1] == _tablero[i, 2])
                    return new EstadoJuego(true, false, _tablero[i, 0]);

                // Verificar columnas
                if (_tablero[0, i] != '\0' && _tablero[0, i] == _tablero[1, i] && _tablero[1, i] == _tablero[2, i])
                    return new EstadoJuego(true, false, _tablero[0, i]);
            }

            // Verificar diagonales
            if (_tablero[0, 0] != '\0' && _tablero[0, 0] == _tablero[1, 1] && _tablero[1, 1] == _tablero[2, 2])
                return new EstadoJuego(true, false, _tablero[0, 0]);

            if (_tablero[0, 2] != '\0' && _tablero[0, 2] == _tablero[1, 1] && _tablero[1, 1] == _tablero[2, 0])
                return new EstadoJuego(true, false, _tablero[0, 2]);

            // Verificar empate
            bool esEmpate = true;
            for (int i = 0; i < Tamano; i++)
            {
                for (int j = 0; j < Tamano; j++)
                {
                    if (_tablero[i, j] == '\0')
                    {
                        esEmpate = false;
                        break;
                    }
                }
                if (!esEmpate) break;
            }

            if (esEmpate)
                return new EstadoJuego(false, true, null);

            return new EstadoJuego(false, false, null);
        }
    }
}