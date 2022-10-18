using System.Globalization;

namespace ConsoleApp3
{
	internal class Program
	{
        private static Student[] Students;

		private static void Main()
		{
			ZodiacSign[] zodiacSigns = new ZodiacSign[12];
			Zodiac(zodiacSigns);
			foreach (ZodiacSign zodiacSign in zodiacSigns)
			{
				Console.WriteLine(zodiacSign);
			}


            int num = new Random(DateTime.Now.Millisecond).Next(60 * 20, 60 * 35);
            Students = new Student[num];
            for(int i=0;i < Students.Length; i++)
            {
                Completion completion = new();
                Students[i] = new Student();
                Students[i].DateTime = completion.DateTime;
            }
            Group[] BIST = new Group[20];
            CompletionForGroup(BIST);

            Group[] BIVT = new Group[20];
            CompletionForGroup(BIVT);

            Group[] BPI = new Group[20];
            CompletionForGroup(BPI);
            for(int i=0; i<BIST.Length;i++)
            {
                for(int j=0; j < BIST[i].Students.Count; j++)
                {
                    var n = from f in BIST where f.Students[j].ZodiacSign.Name == "Близнецы" || f.Students[j].ZodiacSign.Name == "Весы" || f.Students[j].ZodiacSign.Name == "Водолей" select f;
                }
            }
        }

        private static void CompletionForGroup(Group[] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new Group
                {
                    Name = i.ToString(),
                    Students = new List<Student>()
                };

                for (int j = 0; j < Students?.Length / groups.Length; j++)
                {
                    groups[i]?.Students?.Add(Students![j]);
                }
            }
        }

        private static void Zodiac(ZodiacSign[] zodiacSigns)
		{
            string n = "";

            using (StreamReader streamReader = new(@"C:\Users\danii\source\repos\ConsoleApp3\ConsoleApp3\hhhghg.txt"))
            {
                n = streamReader.ReadToEnd();
            }

            string[] a = new string[12];

            for (int i = 0; i < zodiacSigns.Length; i++)
            {
				zodiacSigns[i] = new();
                a = n.Split("\r\n");
                string[] b = a[i].Split(" ");
                zodiacSigns[i].Name = b[0];
                zodiacSigns[i].Start = DateTime.Parse(b[1]);
                zodiacSigns[i].End = DateTime.Parse(b[2]);

            }

		}
	}
}