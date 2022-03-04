namespace ShapeDemo;

public class Square : Rectangle {
	public Square(double side) : base(side, side) {
	}

	public override string Type() {
		return "Square";
	}
}