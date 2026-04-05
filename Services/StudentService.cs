using StudentManagement.DTOs;
using StudentManagement.Models;
using StudentManagement.Repositories;

namespace StudentManagement.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repo;

    public StudentService(IStudentRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<StudentDto>> GetAllAsync()
    {
        var students = await _repo.GetAllAsync();
        return students.Select(Map);
    }

    public async Task<StudentDto?> GetByIdAsync(int id)
    {
        var student = await _repo.GetByIdAsync(id);
        return student == null ? null : Map(student);
    }

    public async Task<StudentDto> AddAsync(CreateStudentDto dto)
    {
        var student = new Student
        {
            Name = dto.Name,
            Email = dto.Email,
            Age = dto.Age,
            Course = dto.Course
        };
        var created = await _repo.AddAsync(student);
        return Map(created);
    }

    public async Task<StudentDto?> UpdateAsync(int id, UpdateStudentDto dto)
    {
        var student = new Student
        {
            Name = dto.Name,
            Email = dto.Email,
            Age = dto.Age,
            Course = dto.Course
        };
        var updated = await _repo.UpdateAsync(id, student);
        return updated == null ? null : Map(updated);
    }

    public async Task<bool> DeleteAsync(int id) =>
        await _repo.DeleteAsync(id);

    private static StudentDto Map(Student s) => new()
    {
        Id = s.Id,
        Name = s.Name,
        Email = s.Email,
        Age = s.Age,
        Course = s.Course,
        CreatedDate = s.CreatedDate
    };
}
