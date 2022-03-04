namespace ShapeDemo; 

public class Demo {
	public static void Main() {
		var shapeTypes = new [] {
			"SQUARE",
			"RECTANGLE",
			"CIRCLE",
			"TRIANGLE",
		};
		
		var parameterCount = new [] {
			1,
			2,
			1,
			3,
		};
		
		var shapeFactory = new ShapeFactory();
		var rndEngine = new Random();

		for (int i = 0; i < 10; ++i) {
			int type = rndEngine.Next(shapeTypes.Length);
			
			int paramCount = parameterCount[type];
			var parameters = new double[paramCount];
			if ("TRIANGLE" == shapeTypes[type]) {
				do {
					for (int j = 0; j < paramCount; ++j) {
						parameters[j] = rndEngine.NextDouble() * 100;
					}
				} while(!Triangle.IsTriangle(parameters[0], parameters[1], parameters[2]));
			}
			else {
				for (int j = 0; j < paramCount; ++j) {
					parameters[j] = rndEngine.NextDouble() * 100;
				}
			}
			
			var s = shapeFactory.GetShape(shapeTypes[type], parameters);
			Console.WriteLine(s.ToString());
		}
		
		Console.WriteLine();
		Console.WriteLine(shapeFactory.GetShape("tRiAnGlE", 2, 3, 4).ToString());
	}
}