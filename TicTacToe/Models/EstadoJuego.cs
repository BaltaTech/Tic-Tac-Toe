namespace TicTacToe.Models
{
    // Esta clase representa el estado actual del juego.
    public class EstadoJuego
    {
        // Propiedades de solo lectura para el estado.
        public bool HayGanador { get; }
        public bool EsEmpate { get; }
        public char? JugadorGanador { get; }

        public EstadoJuego(bool hayGanador, bool esEmpate, char? jugadorGanador)
        {
            HayGanador = hayGanador;
            EsEmpate = esEmpate;
            JugadorGanador = jugadorGanador;
        }
    }
}