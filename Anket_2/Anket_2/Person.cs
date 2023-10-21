namespace Anket_2;

internal class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Birth { get; set; }

    public Person()
    {
        
    }

    public Person(string name, string surname, string email, string phone, string birth)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Phone = phone;
        Birth = birth;
    }
}