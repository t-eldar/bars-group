public class EventTestPublisher
{
	public event EventHandler<char> OnKeyPressed;

	public void Run()
	{
		var key = ' ';
		do
		{
			key = Console.ReadKey().KeyChar;
			OnKeyPressed?.Invoke(this, key);
		} while (key != 'c');
	}
}