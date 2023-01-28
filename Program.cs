using LinqHW_AlonShani;


List<string> languageList = new();
languageList.Add("Python");
languageList.Add("Python");
languageList.Add("cpp");
languageList.Add("Java");

string catchphrase = "It is what it is";

List<string> colorList = new();
colorList.Add("blue");
colorList.Add("purple");
colorList.Add("green");
colorList.Add("orange");

List<Student> students = new List<Student>
{
    new Student {Name = "Alon", Id = 0},
    new Student {Name = "Pablo", Id = 1},
    new Student {Name = "Jaime", Id = 2}
};

List<Grade> grades = new List<Grade>
{
    new Grade {FinalGrade = 69, Id = 0},
    new Grade {FinalGrade = 81, Id = 1},
    new Grade {FinalGrade = 90, Id = 2}
};

languageList.DistinctOrderBy();
catchphrase.AverageWordLength();
colorList.StringsContainingLetters('g', 'b');
students.StudentGradeJoin(grades);
colorList.PrintCollection();

