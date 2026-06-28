using System;

// Интерфейс цвета
interface IColor {
  void Paint();
}

// Красный цвет
class Red : IColor {
  public void Paint() {
    Console.WriteLine("Красный");
  }
}

// Синий цвет
class Blue : IColor {
  public void Paint() {
    Console.WriteLine("Синий");
  }
}

// Базовый класс фигуры
class Shape {
  protected IColor color;

  // Конструктор получает цвет
  public Shape(IColor color) {
    this.color = color;
  }
}

// Круг
class Circle : Shape {
  public Circle(IColor color) : base(color) {
  }

  public void Draw() {
    Console.Write("Круг: ");
    color.Paint();
  }
}

class Program {
  static void Main(string[] args) {
    // Создаем красный круг
    Circle circle1 = new Circle(new Red());
    circle1.Draw();

    // Создаем синий круг
    Circle circle2 = new Circle(new Blue());
    circle2.Draw();
  }
}