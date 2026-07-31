using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TicTacToe.Models;
using TicTacToe.Interfaces;

namespace TicTacToe.ViewModels
{
    public class ControladorJuegoViewModel : INotifyPropertyChanged
    {
        private readonly IModeloTablero _modeloTablero;
        private readonly IServicioJuego _servicioJuego;
        private char _jugadorActual;

        private string _textoEstado = string.Empty;
        private bool _juegoActivo = false;

        public string TextoEstado
        {
            get => _textoEstado;
            private set
            {
                _textoEstado = value;
                OnPropertyChanged();
            }
        }

        public bool JuegoActivo
        {
            get => _juegoActivo;
            private set
            {
                _juegoActivo = value;
                OnPropertyChanged();
            }
        }

        // Ahora el tablero se expone como lista 1D de strings
        public ObservableCollection<string> Celdas { get; } = new ObservableCollection<string>(new string[9]);

        public ICommand HacerMovimientoCommand { get; }
        public ICommand ReiniciarJuegoCommand { get; }

        public ControladorJuegoViewModel(IModeloTablero modeloTablero, IServicioJuego servicioJuego)
        {
            _modeloTablero = modeloTablero;
            _servicioJuego = servicioJuego;

            HacerMovimientoCommand = new RelayCommand(param => HacerMovimiento(param?.ToString() ?? ""));
            ReiniciarJuegoCommand = new RelayCommand(_ => ReiniciarJuego());

            ReiniciarJuego();
        }

        private void HacerMovimiento(string parametro)
        {
            if (!JuegoActivo || string.IsNullOrEmpty(parametro)) return;

            try
            {
                var partes = parametro.Split(',');
                if (partes.Length != 2) return;

                int fila = int.Parse(partes[0]);
                int columna = int.Parse(partes[1]);

                if (fila < 0 || fila >= 3 || columna < 0 || columna >= 3) return;

                if (_modeloTablero.EsCeldaVacia(fila, columna))
                {
                    _modeloTablero.ColocarMarcador(fila, columna, _jugadorActual);

                    // Actualizamos la celda en la colección 1D
                    int index = fila * 3 + columna;
                    Celdas[index] = _jugadorActual.ToString();

                    var estadoJuego = _servicioJuego.VerificarEstadoJuego(_modeloTablero);

                    if (estadoJuego.HayGanador)
                    {
                        TextoEstado = $"¡El jugador {_jugadorActual} ha ganado!";
                        JuegoActivo = false;
                    }
                    else if (estadoJuego.EsEmpate)
                    {
                        TextoEstado = "¡Es un empate!";
                        JuegoActivo = false;
                    }
                    else
                    {
                        _jugadorActual = _jugadorActual == 'X' ? 'O' : 'X';
                        TextoEstado = $"Turno del jugador: {_jugadorActual}";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar movimiento: {ex.Message}");
            }
        }

        private void ReiniciarJuego()
        {
            _modeloTablero.Reiniciar();
            for (int i = 0; i < 9; i++)
            {
                Celdas[i] = string.Empty; // limpiar tablero
            }

            _jugadorActual = 'X';
            TextoEstado = $"Turno del jugador: {_jugadorActual}";
            JuegoActivo = true;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Func<object?, bool>? _canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;
        public void Execute(object? parameter) => _execute(parameter);
    }
}
