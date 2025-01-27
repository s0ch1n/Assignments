using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment_7thD
{
    // Course Class (No inheritance, as it's not a person)
    public class Course
    {
        public string Title { get; set; }
        public int Duration { get; set; } // Duration in weeks

        public Course(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Course Details:\nTitle: {Title}\nDuration: {Duration} weeks");
        }
    }
}
