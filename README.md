# ❌⭕ Tic-Tac-Toe (Gato) - WPF MVVM

> **Mi primer proyecto aplicando MVVM, Dependency Injection y Command Pattern**

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![WPF](https://img.shields.io/badge/WPF-UI-5C2D91?logo=windows)](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/)
[![MVVM](https://img.shields.io/badge/MVVM-Pattern-4CAF50)](https://docs.microsoft.com/en-us/dotnet/architecture/maui/mvvm)
[![License](https://img.shields.io/badge/license-MIT-red)](LICENSE)

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Why This Project?](#-why-this-project)
- [Features](#-features)
- [Architecture](#-architecture)
- [Technologies](#-technologies)
- [Installation](#-installation)
- [Lessons Learned](#-lessons-learned)
- [License](#-license)
- [Author](#-author)

---

## 🎯 Overview

**Tic-Tac-Toe** es un juego clásico de 3x3 implementado en **WPF** utilizando el **patrón MVVM**. Fue mi primer proyecto aplicando:

- ✅ MVVM (Model-View-ViewModel)
- ✅ Dependency Injection
- ✅ Command Pattern (RelayCommand)
- ✅ INotifyPropertyChanged
- ✅ Separación de responsabilidades

---

## 🤔 Why This Project?

Este proyecto fue mi **laboratorio de aprendizaje** para entender:

| Concepto | Cómo lo apliqué |
|----------|-----------------|
| **MVVM** | Separación clara entre Model, View y ViewModel |
| **Dependency Injection** | Inyección de servicios en el ViewModel |
| **Command Pattern** | `RelayCommand` para manejar acciones |
| **Interfaces** | `IModeloTablero`, `IServicioJuego` |

### ⚠️ Nota Importante

> **Este proyecto está intencionalmente sobreingenierizado.** Para un juego tan simple, no necesitaba interfaces ni DI. Sin embargo, fue mi **entrenamiento** para entender estos conceptos. Ahora sé que la arquitectura debe ser proporcional al problema.

---

## ✨ Features

- ✅ Juego de Tic-Tac-Toe para 2 jugadores
- ✅ Interfaz limpia y moderna con WPF
- ✅ Indicador de turno visual
- ✅ Detección de ganador y empate
- ✅ Botón de reinicio
- ✅ Código desacoplado con MVVM

---
## 🏗️ Architecture

### Diagrama de Clases
![Diagrama de Clases](docs/Documentación%20UML/TictTacToe-ClassDiagram.png)

### Diagrama de Secuencia - Flujo Normal
![Flujo Normal](docs/Documentación%20UML/TictTacToe-Secuence%20Diagram.png)

### Diagrama de Secuencia - Victoria
![Flujo Victoria](docs/Documentación%20UML/TictTacToe-SecuenceDiagram-Victory.png)

### Diagrama UML General
![UML General](docs/Documentación%20UML/_UML.png)

### Estructura del Proyecto

TicTacToe/
├── Models/
│ ├── ModeloTablero.cs # Lógica del tablero
│ └── EstadoJuego.cs # Estado del juego
├── Interfaces/
│ ├── IModeloTablero.cs # Contrato del tablero
│ └── IServicioJuego.cs # Contrato del servicio
├── Services/
│ └── TableroService.cs # Lógica de verificación
├── ViewModels/
│ └── ControladorJuegoViewModel.cs # MVVM ViewModel
├── Views/
│ └── MainWindow.xaml # Interfaz de usuario
└── App.xaml # Configuración



### Patrones Utilizados

| Patrón | Implementación |
|--------|----------------|
| **MVVM** | ViewModel separado de la View |
| **Dependency Injection** | Constructor injection en ViewModel |
| **Command Pattern** | `RelayCommand` para acciones |
| **Observer** | `INotifyPropertyChanged` para binding |
| **Strategy** | `IServicioJuego` para lógica intercambiable |

---

## 🛠️ Technologies

| Tecnología | Versión | Propósito |
|------------|---------|-----------|
| **.NET** | 8.0 | Framework |
| **WPF** | - | Interfaz de usuario |
| **C#** | 12.0 | Lenguaje |
| **XAML** | - | UI declarativa |

---

## 🚀 Installation

### Prerrequisitos

- ✅ .NET 8 SDK
- ✅ Visual Studio 2022 (o superior)

### Setup

```bash
# 1. Clonar repositorio
git clone https://github.com/tu-usuario/TicTacToe.git

# 2. Navegar al proyecto
cd TicTacToe

# 3. Ejecutar
dotnet run


Ejecutar desde Visual Studio
Abrir TicTacToe.sln

Presionar F5

🎮 Gameplay
Cómo Jugar
El jugador X comienza

Haz clic en una celda vacía para colocar tu marca

Alternan turnos entre X y O

El juego detecta automáticamente:

✅ 3 en línea (victoria)

✅ Tablero lleno (empate)

Controles
Acción	Método
Colocar marca	Click en celda
Reiniciar juego	Botón "REINICIAR JUEGO"
🧠 Lessons Learned
Este proyecto me enseñó lecciones valiosas:

Lección	Explicación
Sobreingeniería	No todo necesita interfaces y DI. Para proyectos pequeños, simple es mejor.
YAGNI	"You Aren't Gonna Need It" - No añadas complejidad innecesaria.
KISS	"Keep It Simple, Stupid" - La simplicidad es clave.
Arquitectura Proporcional	La complejidad arquitectónica debe ser proporcional al problema.
Contexto	Una interfaz para un solo servicio es innecesaria.
Cómo Lo Aplico Ahora
Entonces	Ahora
Interfaces para todo	Interfaces solo cuando hay múltiples implementaciones
DI para todo	DI solo cuando es necesario
Separación excesiva	Separación proporcional al problema


🔜 Próximos Pasos (Si continuara el proyecto)
Mejora	Descripción
IA Básica	Agregar un oponente CPU con algoritmo minimax
Modo Oscuro	Tema oscuro para la interfaz
Historial	Guardar partidas jugadas
Animaciones	Transiciones suaves al colocar marcas
🤝 Contributing
🍴 Fork el repositorio

🌿 Crea una rama (git checkout -b feature/AmazingFeature)

💾 Commit tus cambios (git commit -m 'Add some AmazingFeature')

📤 Push a la rama (git push origin feature/AmazingFeature)

📝 Abre un Pull Request

📄 License
Este proyecto está bajo la Licencia MIT - ver el archivo LICENSE para más detalles.

👤 Author
Tu Nombre

💼 LinkedIn

🐙 GitHub

📧 Email

🙏 Acknowledgments
Microsoft por WPF y .NET

Comunidad por los recursos de MVVM

❌⭕ Proyecto de aprendizaje para practicar MVVM y patrones de diseño

"La sobreingeniería es el precio del aprendizaje. Lo importante es reconocerla y evolucionar."

text

---

## 📝 INSTRUCCIONES PARA GUARDAR

1. **Copia TODO el texto de arriba** (desde `# ❌⭕ Tic-Tac-Toe (Gato) - WPF MVVM` hasta el final)

2. **Abre tu proyecto en VS Code**

3. **Crea/abre `README.md`** en la raíz del proyecto

4. **Reemplaza TODO el contenido** (Ctrl+A, Ctrl+V)

5. **Guarda** (Ctrl+S)

6. **Sube a GitHub:**

```bash
git add README.md
git commit -m "docs: agregar README profesional para Tic-Tac-Toe"
git push origin main
