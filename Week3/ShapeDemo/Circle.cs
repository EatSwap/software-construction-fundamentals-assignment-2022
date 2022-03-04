namespace ShapeDemo;

public class Circle : Shape {
	private double _radius;

	public Circle(double radius) {
		Radius = radius;
	}

	public double Radius {
		get => _radius;
		set {
			if (value <= 0) throw new ArgumentException("Radius must be greater than 0");
			_radius = value;
		}
	}

	public override double Area => Math.PI * _radius * _radius;

	public override string Type => "Circle";

	public override int ParameterCount => 3;

	public override string ToString() {
		return $"I am a {Type} and I have area {Area}";
	}
}