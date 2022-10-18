namespace ConsoleApp3
{
    internal class ZodiacSign
    {
        public string Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Start}, {End}";
        }
    }
}