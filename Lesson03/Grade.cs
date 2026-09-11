int score = 82; 
string grade;
if (score >= 90) 
    grade = "A";
else if (score >= 80) 
    grade = "B";
else if (score >= 70) 
    grade = "C";
else 
    grade = "F";

Console.WriteLine($"{score} is a {grade}");
