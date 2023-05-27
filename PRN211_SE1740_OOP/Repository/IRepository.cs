using PRN211_SE1740_OOP.Entities;

namespace PRN211_SE1740_OOP.Repository;

public interface IRepository
{
    void Add(Student entity);
    void Delete(Student entity);
    void Delete(int id);
    void Update(Student entity);
    Student[] GetAll();
    Student? GetById(int id);

    void Display();


}