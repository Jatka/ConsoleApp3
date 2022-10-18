namespace ConsoleApp3
{
    internal class Student
    {
        public string? LastName { get; set; }

        public string? FirstName { get; set; }

        public string? Patronymic { get; set; }

        public string? Gender { get; set; }

        public string? Birthday { get; set; }

        public Group? Group { get; set; }

        public string? Course { get; set; }

        public int Summ { get; private set; }

        public ZodiacSign ZodiacSign { get; set; }

        public DateTime DateTime { get; set; }

        public Student()
        {
            Completion completion = new();
            DateTime = completion.DateTime;

        }
    }
}