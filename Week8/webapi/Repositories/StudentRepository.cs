using System.Collections.Generic;
using System.Linq;
using database;
using System;

public class StudentRepository : IStudentRepository
{
    private readonly SchoolContext _dbContext;

    public StudentRepository(SchoolContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Student> GetAllStudents()
    {
        try
        {
            return _dbContext.Student.ToList();
        } 
        catch(Exception ex)
        {
            return new List<Student>();
        }
    }

    public Student GetStudentById(long studentId)
    {
        return _dbContext.Student.SingleOrDefault(s => s.StudentId == studentId);
    }
}