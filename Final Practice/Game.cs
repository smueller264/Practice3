using System;
namespace Final_Practice
{
	public class Game
	{

		User user;
		public Game(User user)
		{
			this.user = user;
			GameLoop();
		}

		public void GameLoop()
		{
			Console.Clear();
			int count = 1;
			Sequence sequence = new Sequence(count);

			while(true)
			{
				Console.Clear();


				sequence.GetSequence().ForEach(Console.WriteLine);
				Console.ReadKey();
				count++;
				sequence.NextSequence();





			}
		}

		




	}
}

