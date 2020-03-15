using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;

public class StudentServiceTest
{
    private StudentService _studentService; // System Under Test
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void ShouldNotReturnOddStudentId()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 2,
                    EmailAddress = "student1@test.edu"
                },
                new Student {
                    StudentId = 4,
                    EmailAddress = "student2@test.edu"
                }
            }
        );

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(s => s.Special).Should().BeFalse();
    }


    [Test]
    public void ShouldReturnTwoOddStudentId()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 1,
                    EmailAddress = "student1@test.edu"
                },
                new Student {
                    StudentId = 2,
                    EmailAddress = "student2@test.edu"
                },
                new Student {
                    StudentId = 3,
                    EmailAddress = "student3@test.edu"
                }
            }
        );

        // Act (When)
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (FluentAssertions) (Then)
        studentViewModels.Count(s => s.Special).Should().Be(2);
    }
    
}