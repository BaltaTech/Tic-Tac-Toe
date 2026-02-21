using System.Windows;
using TicTacToe.Models;
using TicTacToe.Services;
using TicTacToe.ViewModels;

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var modeloTablero = new ModeloTablero();
            var servicioJuego = new TableroService();
            this.DataContext = new ControladorJuegoViewModel(modeloTablero, servicioJuego);
        }
    }
}