namespace ShapeDemo;

public class Rectangle : Shape {
	private double _length;
	private double _width;

	public Rectangle(double length, double width) {
		Length = length;
		Width = width;
	}

	public double Length {
		get => _length;
		set {
			if (value <= 0) throw new ArgumentException("Length must be greater than 0");
			_length = value;
		}
	}

	public double Width {
		get => _width;
		set {
			if (value <= 0) throw new ArgumentException("Width must be greater than 0");
			_width = value;
		}
	}

	public override double Area => _length * _width;

	public override string Type => "Rectangle";

	public override int ParameterCount => 2;

	public override string ToString() {
		return $"I am a {Type} and I have area {Area}";
	}
}