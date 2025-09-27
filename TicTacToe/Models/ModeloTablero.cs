using System;
using TicTacToe.Interfaces;

namespace TicTacToe.Models
{
    // La clase ModeloTablero implementa la interfaz IModeloTablero
    public class ModeloTablero : IModeloTablero
    {
        private const int Tamano = 3;
        private readonly char[,] _tablero;

        public ModeloTablero()
        {
            _tablero = new char[Tamano, Tamano];
            Reiniciar();
        }

        public char[,] Tablero => _tablero;

        public void Reiniciar()
        {
            for (int i = 0; i < Tamano; i++)
            {
                for (int j = 0; j < Tamano; j++)
                {
                    _tablero[i, j] = '\0';
                }
            }
        }

        public bool EsCeldaVacia(int fila, int columna)
        {
            if (fila < 0 || fila >= Tamano || columna < 0 || columna >= Tamano)
            {
                return false;
            }
            return _tablero[fila, columna] == '\0';
        }

        public void ColocarMarcador(int fila, int columna, char jugador)
        {
            if (EsCeldaVacia(fila, columna))
            {
                _tablero[fila, columna] = jugador;
            }
            else
            {
                Console.WriteLine("La celda ya está ocupada.");
            }
        }
    }
}