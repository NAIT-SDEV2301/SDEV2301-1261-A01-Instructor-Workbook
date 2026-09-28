namespace L13_LinqIntro_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Asha", 91),
                new Student("Chris", 68),
                new Student("Sofia", 77),
                new Student("Jordan", 84),
                new Student("Mei", 59)
            };

            Console.WriteLine($"Number of students: {students.Count}");

            //var passing = new List<Student>();
            //foreach (var student in students)
            //{
            //    if (student.Mark >= 70)
            //    {
            //        passing.Add(student);
            //    }
            //}

            IEnumerable<Student> passing = students.Where(s => s.Mark >= 70);

            Console.WriteLine("\nStudents with a Mark >= 70:");
            foreach (var s in passing)
            {
                Console.WriteLine($"{s.Name} - {s.Mark}");
            }

            // Print students.Count and confirm that the collection has five items.
            Console.WriteLine($"Number of students passing: {passing.Count()}");

            var names = students.Select(s => s.Name);
            Console.WriteLine("\nStudent names projection:");
            foreach (var currentName in names)
            {
                Console.WriteLine($"\t{currentName}");
            }

            var marks = students.Select(s => s.Mark);
            Console.WriteLine("\nStudent marks projection:");
            foreach (var currentMarks in marks)
            {
                Console.WriteLine($"\t{currentMarks}");
            }

            var labels = students.Select(s => $"{s.Name}: {s.Mark}");
            Console.WriteLine("\nStudent name and mark projection:");
            foreach (var currentLabel in labels)
            {
                Console.WriteLine($"\t{currentLabel}");
            }

            var passingNames = students
                .Where(s => s.Mark >= 70)
                .Select(s => s.Name);
            Console.WriteLine("\nStudent passing and names projection:");
            foreach (var currentName in passingNames)
            {
                Console.WriteLine($"\t{currentName}");
            }

            // For each query below:
            // 1) what is filtered
            // 2) what is returned
            // 3) the exact type
            // 4)the expected values.
            var q1 = students.Where(s => s.Mark < 60);
            var q2 = students.Select(s => s.Mark);
            var q3 = students
                .Where(s => s.Mark >= 80)
                .Select(s => s.Name);


        }
    }
}
