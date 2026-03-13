 **Tic-Tac-Toe**
Este repositorio contiene una implementación del juego "El Gato" desarrollada en .NET, cuyo objetivo principal es demostrar la aplicación práctica de patrones de diseño estructurales y de comportamiento para resolver problemas comunes de acoplamiento y escalabilidad.

**Patrones de Diseño Implementados**

**Strategy Pattern**: Se utiliza para encapsular los algoritmos de decisión de la IA. Esto permite intercambiar dinámicamente la dificultad (Random vs. Minimax) sin alterar el motor del juego.
**Observer Pattern:** Implementado para establecer un flujo de comunicación reactivo entre el núcleo del juego (Domain) y la interfaz de usuario, garantizando que la lógica de negocio sea totalmente agnóstica a la capa de presentación.

**Arquitectura y Principios**
A diferencia de implementaciones convencionales, este proyecto sigue principios de Clean Architecture:

Separación de Responsabilidades: Lógica de validación, gestión de turnos y renderizado residen en capas independientes.
Inversión de Dependencias (DIP): El núcleo del juego depende de abstracciones, permitiendo que la interfaz (Consola hoy, Blazor mañana) sea un detalle de implementación.
SOLID: Énfasis en el principio de Responsabilidad Única para facilitar el mantenimiento y la extensión del código.

 Stack Tecnológico
Runtime: .NET 8.0 

Lenguaje: C#

IDE:Visual Studio 2022

Modelado: UML (Class & Sequence Diagrams)
