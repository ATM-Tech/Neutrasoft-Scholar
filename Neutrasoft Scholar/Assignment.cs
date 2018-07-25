using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neutrasoft_Scholar
{
    class Assignment
    {
        public string Name { get; }
        public string Type { get; }
        public int Grade { get; }
        public Assignment(string name, string type, int grade)
        {
            Name = name;
            Type = type;
            Grade = grade;
        }


        //Returns sorted list of assignments and grades
        public static Dictionary<string, List<Assignment>> GetStudentAssignments(Teacher teacher, Student student)
        {
            //Grabs a teacher's assignments and types
            string teacherAssignmentsQuery = String.Format("SELECT Assignments,AssignmentTypes FROM Teachers WHERE TeacherID={0}", teacher.TeacherID);
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(teacherAssignmentsQuery, new List<string> { "Assignments", "AssignmentTypes" });

            //Splits comma'ed list into a real list
            List<string> assignmentNames = output["Assignments"][0].Split(',').ToList();
            List<string> assignmentTypes = output["AssignmentTypes"][0].Split(',').ToList();

            //Grabs a student's grades for assignments and splits the list into a real list
            string studentAssignmentGradesQuery = String.Format("SELECT AssignmentGrades from Grades WHERE StudentID={0} AND TeacherID={1}", student.StudentID, teacher.TeacherID);
            List<string> assignmentGradesStrings = SQLDatabase.ReadFromSQLServer(studentAssignmentGradesQuery, new List<string> { "AssignmentGrades" })["AssignmentGrades"][0].Split(',').ToList();

            //Converts grade strings to ints
            List<int> assignmentGrades = new List<int>();
            foreach (string gradeString in assignmentGradesStrings)
            {
                assignmentGrades.Add(int.Parse(gradeString));
            }

            //Creates output dictionary
            Dictionary<string, List<Assignment>> assignments = new Dictionary<string, List<Assignment>>
            {
                { "Daily", new List<Assignment>() },
                { "Quiz", new List<Assignment>() },
                { "Test", new List<Assignment>() }
            };
            //Sorts all Names, Types, and Grades into their respective lists in the dictionary.
            for (int i = 0; i < assignmentNames.Count; i++)
            {
                if (assignmentTypes[i] == "Daily")
                {
                    assignments["Daily"].Add(new Assignment(assignmentNames[i], assignmentTypes[i], assignmentGrades[i]));
                }
                else if (assignmentTypes[i] == "Quiz")
                {
                    assignments["Quiz"].Add(new Assignment(assignmentNames[i], assignmentTypes[i], assignmentGrades[i]));
                }
                else if (assignmentTypes[i] == "Test")
                {
                    assignments["Test"].Add(new Assignment(assignmentNames[i], assignmentTypes[i], assignmentGrades[i]));
                }
            }

            return assignments;
        }
    }
}
