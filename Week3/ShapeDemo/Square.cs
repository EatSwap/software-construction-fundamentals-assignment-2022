namespace ShapeDemo;

public class Square : Rectangle {
	public Square(double side) : base(side, side) {
	}
	
	public override int ParameterCount => 1;

	public override string Type => "Square";
}