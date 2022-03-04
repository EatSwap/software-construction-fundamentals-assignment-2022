namespace ShapeDemo;

public class Triangle : Shape {
	private double _side1;
	private double _side2;
	private double _side3;

	public Triangle(double side1, double side2, double side3) {
		// 3 sides should be greater than 0
		if (side1 < 0 || side2 < 0 || side3 < 0) throw new ArgumentException("Sides should be greater than 0");
		if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
			throw new ArgumentException("Sides should be greater than the sum of other two");

		_side1 = side1;
		_side2 = side2;
		_side3 = side3;
	}

	private void ParameterSetter(double val, ref double target) {
		if (val <= 0) throw new ArgumentException("Side of triangle must be greater than 0");

		var tmp = target;
		target = val;

		if (!IsTriangle(_side1, _side2, _side3)) {
			target = tmp;
			throw new ArgumentException("Sides must form a triangle");
		}
	}

	public double Side1 {
		get => _side1;
		set => ParameterSetter(value, ref _side1);
	}

	public double Side2 {
		get => _side2;
		set => ParameterSetter(value, ref _side2);
	}

	public double Side3 {
		get => _side3;
		set => ParameterSetter(value, ref _side3);
	}

	public static bool IsTriangle(double side1, double side2, double side3) {
		return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
	}

	public override double Area {
		get {
			var s = (_side1 + _side2 + _side3) / 2;
			return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
		}
	}

	public override string Type => "Triangle";

	public override int ParameterCount => 3;

	public override string ToString() {
		return $"I am a {Type} and I have area {Area}";
	}
}