using Csharp_Lessons.Services;

Console.WriteLine("=== C# Variables and Data Types ===");
var dataTypeService = new DataTypeService();
dataTypeService.PrintPrimitiveTypes();
dataTypeService.PrintComplexTypes();

Console.WriteLine("\n\n\n\n\n=== C# Operators ===");
var operatorsService = new OperatorsService();
operatorsService.DemonstrateAllOperators();

Console.WriteLine("\n\n\n\n\n=== Math Operations ===");
var mathOperationsService = new MathOperationsService();
mathOperationsService.DemonstrateMathLibrary();

Console.WriteLine("\n\n\n\n\n=== Memory Difference ===");
var memoryManagementService = new MemoryManagementService();
memoryManagementService.DemonstrateValueType();
memoryManagementService.DemonstrateReferenceType();

Console.WriteLine("\n\n\n\n\n=== Parameter Passing through Methods ===");
var parameterPassingService = new ParameterPassingService();
parameterPassingService.CallAllMethods();

Console.WriteLine("\n\n\n\n\n=== Conditions(switch, if,else,else if)===");
var conditionsService = new ConditionsService();
conditionsService.PrintDayOfWeek(2);
conditionsService.EvaluateTemperature(25);
conditionsService.CheckEvenOdd(7);

Console.WriteLine("\n\n\n\n\n=== Loops (for, foreach, while, do-while) ===");
var loopsService = new LoopsService();
loopsService.DemonstrateLoops();


