using TicTacToe.Models;

namespace TicTacToe.Interfaces
{
    // IModeloTablero define el contrato para el modelo de datos del tablero.
    public interface IModeloTablero
    {
        char[,] Tablero { get; }
        void Reiniciar();
        bool EsCeldaVacia(int fila, int columna);
        void ColocarMarcador(int fila, int columna, char jugador);
    }
}