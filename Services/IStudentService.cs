using StudentManagementSystm.DTOs;

namespace StudentManagementSystm.Services;

public interface IStudentService
{
    Task<IEnumerable<StudentDto>> GetAllAsync();
    Task<StudentDto?> GetByIdAsync(int id);
    Task<StudentDto> AddAsync(CreateStudentDto dto);
    Task<StudentDto?> UpdateAsync(int id, UpdateStudentDto dto);
    Task<bool> DeleteAsync(int id);
}
