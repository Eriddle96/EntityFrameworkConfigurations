using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

public class StudentService : IStudentService
{
    private readonly IRepository<Student> _studentRepository;

    public StudentService(IRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public Student GetStudentById(int id)
    {
        var students = (IDbSet<Student>)_studentRepository.Table;

        var query = from s in students.Include(s => s.Courses)
                    where s.Id == id
            select s;

        return query.FirstOrDefault();
    }
}

