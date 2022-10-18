using System.Text;

namespace ConsoleApp3
{
    internal class Completion
    {
        private readonly Random Random = new(DateTime.Now.Millisecond);

        private readonly string Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public DateTime DateTime { get; set; }
        public string? Info { get; set; }

        public Completion()
        {
            int num = Random.Next(10, 20);
            StringBuilder stringBuilder = new();

            DateTime = new(Random.Next(2000, 2005), Random.Next(1, 12), Random.Next(1, 28));
            


            for (int i = 0; i < num; i++)
            {
                stringBuilder.Append(Text[Random.Next(0, Text.Length)]);
            }

            Info = stringBuilder.ToString();
        }

        public override string ToString()
        {
            return $"{Info}";
        }



        
        
        
           
         

        
        
    }
}
