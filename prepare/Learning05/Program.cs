using System;

class Program
{
  static void Main(string[] args)
  {
    List<Shape> shapes = new List<Shape>();

    Square sq = new Square("yellow", 4);
    shapes.Add(sq);
    Rectangle rec = new Rectangle("blue", 10, 5);
    shapes.Add(rec);
    Circle circ = new Circle("red", 7);
    shapes.Add(circ);

    // DisplayShapeInfo(sq);
    // DisplayShapeInfo(rec);
    // DisplayShapeInfo(circ);

    foreach (Shape shape in shapes)
    {
      string shapeName = "";
      string color = shape.GetColor();
      double area = shape.GetArea();

      switch (color)
      {
        case "yellow":
          shapeName = "Square";
          break;
        case "blue":
          shapeName = "Rectangle";
          break;
        case "red":
          shapeName = "Circle";
          break;
      }
      Console.WriteLine($"The {color} {shapeName} area is {area:f2} cm2");
    }

  }
  //   public static void DisplayShapeInfo(Shape shape)
  //   {
  //     string shapeName = "";
  //     string color = shape.GetColor();
  //     double area = shape.GetArea();
  //     switch (color)
  //     {
  //       case "yellow":
  //         shapeName = "Square";
  //         break;
  //       case "blue":
  //         shapeName = "Rectangle";
  //         break;
  //       case "red":
  //         shapeName = "Circle";
  //         break;
  //     }
  //     Console.WriteLine($"The {color} {shapeName} area is {area:f2} cm2");
  //   }

}