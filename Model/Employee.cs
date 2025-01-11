using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIC_.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int Employee_id { get; private set; } //Get: Obtem os dados e Set: Defini ou modifica os dados
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime Date { get; private set; }
        public string Photo { get; private set; }

        //Construtor
        public Employee(string Name, string Email, DateTime Date, string Photo)
        {
            this.Name = Name ?? throw new ArgumentNullException(nameof(Name));
            this.Email = Email ?? throw new ArgumentNullException(nameof(Email));
            if (Date == default(DateTime)) 
                throw new ArgumentNullException(nameof(Date));
            this.Date = Date;
            this.Photo = Photo;
        }
    }
}
