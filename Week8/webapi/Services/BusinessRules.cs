public static class BusinessRules
{
    public static bool isOddStudentId(Student student) => 
        student.StudentId % 2 == 1;
}