using PRN211_SE1740_OOP.Entities;
using PRN211_SE1740_OOP.Repository;

namespace ConsoleAppOopDemo;

public class Program
{
    static void Main(string[] args)
    {

        /*
            Viet chuong trinh:
            - cho phep nhap nhieu n sinh vien (id, name, address,mark)
            - in ra man hinh n sinh vien do
            - sap xep sinh vien theo diem tang dan
            - xoa/sua sinh vien bat ky theo Id
         
         */
        IRepository repository = new Repository();

        Student s1 = new Student(1, "Ma Van Meo", "Quan 1, HCM", 3.5);
        Student s2 = new Student(2, "Nguyen Cong Phuong", "Quan 10, HCM", 7.5);
        Student s3 = new Student(3, "Nguyen Van Ha", "Quan 1, HCM", 1.5);
        Student s4 = new Student(4, "Tran Dinh Xu", "Quan 3, HCM", 4.5);


        repository.Add(s1);
        repository.Add(s2);
        repository.Add(s3);
        repository.Add(s4);


        repository.Display();





        Console.ReadLine();
    }
}