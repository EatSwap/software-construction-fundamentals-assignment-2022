namespace ShapeDemo;

public class ShapeFactory {
	public Shape GetShape(string? shapeType, params double[] parameters) {
		if (shapeType == null) throw new ArgumentNullException(nameof(shapeType));

		// Make shapeType lowercase to make it case-insensitive
		shapeType = shapeType.ToLower();

		switch (shapeType) {
			case "circle":
				if (parameters.Length != 1) throw new ArgumentException("Invalid number of parameters for circle");
				return new Circle(parameters[0]);
			case "rectangle":
				if (parameters.Length != 2) throw new ArgumentException("Invalid number of parameters for rectangle");
				return new Rectangle(parameters[0], parameters[1]);
			case "square":
				if (parameters.Length != 1) throw new ArgumentException("Invalid number of parameters for square");
				return new Square(parameters[0]);
			case "triangle":
				if (parameters.Length != 3) throw new ArgumentException("Invalid number of parameters for triangle");
				return new Triangle(parameters[0], parameters[1], parameters[2]);
			default:
				throw new ArgumentException("Invalid shape type", nameof(shapeType));
		}
	}
}