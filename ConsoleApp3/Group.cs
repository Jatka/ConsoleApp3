﻿ namespace ConsoleApp3
{
    internal class Group
    {
        public string? Name { get; set; }

        public List<Student>? Students { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
