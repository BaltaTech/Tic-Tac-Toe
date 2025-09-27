using TicTacToe.Models;

namespace TicTacToe.Interfaces
{
    // Define el contrato para la lógica del juego (quién gana o si es empate).
    public interface IServicioJuego
    {
        // El método principal de la lógica de negocio.
        EstadoJuego VerificarEstadoJuego(IModeloTablero tablero);
    }
}