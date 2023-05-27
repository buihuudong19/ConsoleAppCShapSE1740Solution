using PRN211_SE1740_OOP.Entities;

namespace PRN211_SE1740_OOP.Repository;

public class Repository : IRepository
{
    //connect to database: ADO.net/EntityFramework
    private Student[] _students;
    private int _size;

    public Repository()
    {
        _students = new Student[2];
        _size = 0;
    }

    public void Add(Student entity)
    {
        //thuc hien resize
        if (_size >= _students.Length)
        {
            Student[] temp = new Student[_size * 2];
            Array.Copy(_students, 0, temp, 0, _size);
            _students = temp;
        }

        _students[_size++] = entity;
    }

    public void Delete(Student entity)
    {
        Delete(entity.Id);
    }

    public void Delete(int id)
    {
        int pos = _findPos(id);//vi tri cua sv can xoa
        if(pos >= 0)
        {
            for(int i=pos; i<_size-1;i++)
                _students[i]= _students[i+1];
        }
        _students[_size] = null;
        _size--;    

    }

    public void Display()
    {
        foreach(Student entity in _students)
        {
            Console.WriteLine(entity);
        }
    }

    public Student[] GetAll() => _students;


    public Student? GetById(int id)
    {
        for(int i = 0; i <_size; i++)
        {
            if(_students[i].Id.Equals(id)) return _students[i];
        }
        return null;
    }

    public void Update(Student entity)
    {
        throw new NotImplementedException();
    }
    //truyen vao 1 id => index cua id do
    private int _findPos(int id)
    {
        for(int i =0; i<_size; i++)
        {
            if (_students[i].Id.Equals(id))
                return i;
        }
        return -1;
    }
}
