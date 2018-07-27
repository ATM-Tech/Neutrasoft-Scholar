using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neutrasoft_Scholar
{
    public class Assignment
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




        public static string GetLetterGrade(int grade)
        {
            if (grade >= 95)
            {
                return "A+";
            }
            else if (grade >= 90 && grade < 95)
            {
                return "A-";
            }
            else if (grade >= 85 && grade < 90)
            {
                return "B+";
            }
            else if (grade >= 80 && grade < 85)
            {
                return "B-";
            }
            else if (grade >= 75 && grade < 80)
            {
                return "C+";
            }
            else if (grade >= 70 && grade < 75)
            {
                return "C-";
            }
            else if (grade >= 65 && grade < 70)
            {
                return "D+";
            }
            else if (grade >= 60 && grade < 65)
            {
                return "D-";
            }
            else if (grade <= 59 && grade >= 0)
            {
                return "F";
            }
            else if (grade == -1)
            {
                return "No Grade";
            }
            else
            {
                throw new Exception("Number is negative");
            }

        }

        //Returns sorted list of assignments and grades
        public static List<Assignment> GetStudentAssignments(Teacher teacher, Student student)
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

            List<Assignment> assignments = new List<Assignment>();
            //Sorts all Names, Types, and Grades into their respective lists in the dictionary.
            for (int i = 0; i < assignmentNames.Count; i++)
            {
                assignments.Add(new Assignment(assignmentNames[i], assignmentTypes[i], assignmentGrades[i]));
            }

            return assignments;
        }
        public static Dictionary<string, List<Assignment>> GetTeacherAssignments(Teacher teacher)
        {
            //Grabs a teacher's assignments and types
            string teacherAssignmentsQuery = String.Format("SELECT Assignments,AssignmentTypes FROM Teachers WHERE TeacherID={0}", teacher.TeacherID);
            Dictionary<string, List<string>> output = SQLDatabase.ReadFromSQLServer(teacherAssignmentsQuery, new List<string> { "Assignments", "AssignmentTypes" });

            //Splits comma'ed list into a real list
            List<string> assignmentNames = output["Assignments"][0].Split(',').ToList();
            List<string> assignmentTypes = output["AssignmentTypes"][0].Split(',').ToList();

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
                    assignments["Daily"].Add(new Assignment(assignmentNames[i], assignmentTypes[i], -1));
                }
                else if (assignmentTypes[i] == "Quiz")
                {
                    assignments["Quiz"].Add(new Assignment(assignmentNames[i], assignmentTypes[i], -1));
                }
                else if (assignmentTypes[i] == "Test")
                {
                    assignments["Test"].Add(new Assignment(assignmentNames[i], assignmentTypes[i], -1));
                }
            }

            return assignments;
        }
        public static decimal CalculateAverage(List<Assignment> assignments)
        {
            List<Assignment> dailyAssignments = new List<Assignment>();
            List<Assignment> quizAssignments = new List<Assignment>();
            List<Assignment> testAssignments = new List<Assignment>();

            //Seperates assignments by type
            foreach (Assignment assignment in assignments)
            {
                if (assignment.Type == "Daily")
                {
                    dailyAssignments.Add(assignment);
                }
                else if (assignment.Type == "Quiz")
                {
                    quizAssignments.Add(assignment);
                }
                else if (assignment.Type == "Test")
                {
                    testAssignments.Add(assignment);
                }
            }
            //Creates associated variable
            int dailyTotal = 0;
            int quizTotal = 0;
            int testTotal = 0;
            int dailyAssignmentCount = dailyAssignments.Count;
            int quizAssignmentCount = quizAssignments.Count;
            int testAssignmentCount = testAssignments.Count;
            //Adds grades to each total
            foreach (Assignment assignment in dailyAssignments)
            {
                if (assignment.Grade != -1)
                {
                    dailyTotal += assignment.Grade;

                }
                else
                {
                    dailyAssignmentCount--;
                }
            }
            foreach (Assignment assignment in quizAssignments)
            {
                if (assignment.Grade != -1)
                {
                    quizTotal += assignment.Grade;

                }
                else
                {
                    quizAssignmentCount--;
                }
            }
            foreach (Assignment assignment in testAssignments)
            {
                if (assignment.Grade != -1)
                {
                    testTotal += assignment.Grade;
                }
                else
                {
                    testAssignmentCount--;
                }                
            }
            //Calculates all weighted averages
            decimal dailyAverage = dailyTotal / dailyAssignmentCount;
            decimal quizAverage = quizTotal / quizAssignmentCount;
            decimal testAverage = testTotal / testAssignmentCount;

            decimal dailyRounded = Math.Round(dailyAverage);
            decimal quizRounded = Math.Round(quizAverage);
            decimal testRounded = Math.Round(testAverage);

            decimal dailyWeighted = 20 * (dailyAverage / 100);
            decimal quizWeighted = 30 * (quizAverage / 100);
            decimal testWeighted = 50 * (testAverage / 100);

            decimal average = dailyWeighted + quizWeighted + testWeighted;
            return average;
        }
    }
}
