var eventTester = new EventTestPublisher();

eventTester.OnKeyPressed += (_, c) =>
	Console.WriteLine($"\nВведенный символ: {c}");

eventTester.Run();
