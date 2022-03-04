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

	public double Side1 {
		get => _side1;
		set {
			if (value <= 0) throw new ArgumentException("Side1 must be greater than 0");
			if (!IsTriangle(value, _side2, _side3)) throw new ArgumentException("Sides must form a triangle");

			_side1 = value;
		}
	}

	public double Side2 {
		get => _side2;
		set {
			if (value <= 0) throw new ArgumentException("Side2 must be greater than 0");
			if (!IsTriangle(_side1, value, _side3)) throw new ArgumentException("Sides must form a triangle");

			_side2 = value;
		}
	}

	public double Side3 {
		get => _side3;
		set {
			if (value <= 0) throw new ArgumentException("Side3 must be greater than 0");
			if (!IsTriangle(_side1, _side2, value)) throw new ArgumentException("Sides must form a triangle");

			_side3 = value;
		}
	}

	public static bool IsTriangle(double side1, double side2, double side3) {
		return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
	}

	public override double Area() {
		if (_side1 == 0 || _side2 == 0 || _side3 == 0) return 0;
		var s = (_side1 + _side2 + _side3) / 2;
		return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
	}

	public override string Type() {
		return "Triangle";
	}
	
	public override string ToString() {
		return $"I am a {Type()} and I have area {Area()}";
	}
}