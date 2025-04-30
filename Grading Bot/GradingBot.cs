using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Bot
{
    internal class GradingBot
    {
        public string GradeStudent(string name, int score)

        {

            string grade;

            if (score >= 90)
                grade = "A";

            else if (score >= 80)
                grade = "B";

            else if (score >= 70)
                grade = "C";

            else if (score >= 60)
                grade = "D";

            else
                grade = "F";
            return grade;


        }
    }
}

