public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        //arrary to hold counts of both prefrences
        //students can loop endlessly so it only 
        //matters if all the sandwich prfrences are stuck 
        //with no more students for them 
        int remainingStudents = students.Length;
        int[] countStudentPrefrence = new int[2];

        foreach (int student in students) {
            //set counts of both students prefrences
            countStudentPrefrence[student]++;
        }

        foreach (int sandwich in sandwiches)
        {
            if (countStudentPrefrence(sandwich) > 0)
            {
                //feed a student
                countStudentPrefrence(sandwich)--;
                remainingStudents--;
            } else
            {
                //all reamining students starve
                break;
            }

        }
        return remainingStudents;
    }
}