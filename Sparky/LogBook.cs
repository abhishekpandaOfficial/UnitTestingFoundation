using System;
namespace Sparky
{
	public interface ILogBook
	{
		void Message(string message);
	}

	public class LogBook:ILogBook
	{
		public LogBook()
		{
		}


		public void Message(string _message)
		{
			Console.WriteLine(_message);
		}
	}
}

