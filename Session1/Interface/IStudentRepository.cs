using Session1.Models;

namespace Session1.Interface
{
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
    }
}
