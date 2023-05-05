using System;
using System.Collections.Generic;

namespace Final_Practice
{
	public class Sequence
	{


        private List<string> colors = new List<string>()
		{
			"Red",
			"Yellow",
			"Green",
			"Blue",
		};

		private List<string> colorSequence;


        public Sequence(int count)
		{

			colorSequence = new List<string>();

            
            for (int i = 0; i<count; i++)
			{
                var random = new Random();
                int index = random.Next(colors.Count);
				this.colorSequence.Add(colors[index]);
			}
		}

		public List<String> GetSequence()
		{
			return this.colorSequence;
		}

		public void DisplaySequence()
		{
			foreach(string color in this.colorSequence)
			{

			}
		}

		public void NextSequence()
		{
            var random = new Random();
            int index = random.Next(colors.Count);
            this.colorSequence.Add(colors[index]);
        }
	}
}

