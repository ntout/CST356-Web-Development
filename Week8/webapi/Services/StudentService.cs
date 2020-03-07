using System.Collections.Generic;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRespository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRespository = studentRepository;
    }

    public List<StudentViewModel> GetAllStudents()
    {
        var studentViewModels = new List<StudentViewModel>();

        foreach(var student in _studentRespository.GetAllStudents())
        {
            studentViewModels.Add(new StudentViewModel {
                StudentId = student.StudentId,
                EmailAddress = student.EmailAddress,
                Special = BusinessRules.isOddStudentId(student)
            });
        }

        return studentViewModels;
    }

    public Student GetStudentById(long studentId)
    {
        return _studentRespository.GetStudentById(studentId);
    }
}