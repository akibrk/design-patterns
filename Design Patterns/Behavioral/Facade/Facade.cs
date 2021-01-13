using System;
using System.Collections.Generic;
using System.Text;
namespace Design_Patterns.Behavioral.Facade
{
    /*
     *  Facade VS Repository
        A facade is more general than a repository.
        A facade can apply to anything that is not persistence based, whereas a repository is supposed
        to encapsulate access to an underlying source and make it look like an in memory data source.

        Facades are for creating a simple interface for some other, complicated interface.
     */

    class Facade
    {
        public Facade()
        {
            
        }

    }

    /// <summary>
    /// Simple student admission system using facade
    /// </summary>
    public class AdmissionManager
    {
        private readonly StudentManager _studentManager;
        private readonly PaymentSystem _paymentSystem;
        public AdmissionManager()
        {
            _studentManager = new StudentManager();
            _paymentSystem = new PaymentSystem();
        }

        public void AdmitStudent(string studentName, int grade, decimal tution)
        {
            // You could use a factory instead
            if (grade > 10 || grade < 5) throw new ArgumentException("Grade must be between 5 and 10");
            var student = new Student(studentName, grade, tution);

            _studentManager.AddNewStudent(student);
            _paymentSystem.AddNewTution(student);

        }

    }


    class Student
    {
        private static int IdGenerator = 0;
        public readonly int Id;
        public string Name { get; set; }
        public int Grade { get; set; }
        public decimal Tution { get; }

        public Student(string name, int grade, decimal tution)
        {
            IdGenerator++;

            Id = IdGenerator;
            Name = name;
            Grade = grade;
            Tution = tution;
        }
        
    }

    /// <summary>
    /// Student Manager Sub-System
    /// </summary>
    class StudentManager
    {
        public List<Student> Students { get; set; }
        public List<Student> SuspendedStudents { get; set; }
        public StudentManager()
        {
            Students = new List<Student>();
        }
        public void AddNewStudent(Student student)
        {
            Students.Add(student);
        }

        public Student RemoveStudent(Student student)
        {
            var entity = Students.Find(s => s.Id == student.Id);
            
            if (entity != null)
            {
                Students.Remove(entity);
            }

            return entity;
        }
    }

    class Payment
    {
        public decimal Amount { get; }
        public DateTime Created;
        public Payment(decimal amount)
        {
            Created = DateTime.Now;
            Amount = amount;
        }
    }

    class StudentPayment
    {
        public int Id;
        private List<Payment> TutionPayments { get; set; }

        public StudentPayment(Student student)
        {
            Id = student.Id;
            TutionPayments = new List<Payment>();
        }

        public void AddPayment(decimal amount)
        {
            TutionPayments.Add(new Payment(amount));
        }

        public decimal TotalTutionPaid
        {
            get
            {
                decimal total = 0;
                TutionPayments.ForEach(pay =>
                {
                    total += pay.Amount;
                });
                return total;
            }
        }
    }

    class PaymentSystem
    {
        public List<StudentPayment> StudentPayments { get; set; }

        public void AddNewTution (Student student)
        {
            StudentPayments.Add(new StudentPayment(student));
        }

        public void PayTution(Student student, decimal amount)
        {
            var payment = StudentPayments.Find(s => s.Id == student.Id);
            payment.AddPayment(amount);
        }

        // Month should be automatically calculated, this is just example
        public decimal Due(Student student, int months)
        {
            var payment = StudentPayments.Find(s => s.Id == student.Id);
            // paid = 800, tution = 60
            // month = 16
            // 16 * tution
            // 800 - (16*tution)
            // 
            return (payment.TotalTutionPaid - (student.Tution * months));
        }
    }
}
