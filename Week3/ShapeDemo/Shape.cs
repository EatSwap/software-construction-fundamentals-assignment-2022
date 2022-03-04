namespace ShapeDemo;

public abstract class Shape {
	public abstract double Area { get; }

	public abstract string Type { get; }
	
	public abstract int ParameterCount { get; }
	
	public abstract string ToString();
}