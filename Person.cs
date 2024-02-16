using System.ComponentModel.DataAnnotations;
using System.Reflection;

public class Person
{
    [Required]
    public string FirstName { get; set; }
    [PersonalInformation(1)]
    public string LastName { get; set; }
    [PersonalInformation(3)][StorageType("Keychain")]
    public string SSN { get; set; }
    [PublicInformation(1)]
    public string Address { get; set; }
    [StorageType("Database")]
    public string WorkExperince { get; set; }

    [Obsolete]
    public Person(string fname, string lname)
    {
        FirstName = fname;
        LastName = lname;
    }

    public Person()
    {
        FirstName = "";
        LastName = "";
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}\nLast Name: {LastName}\nSSN: {SSN}\nAddress: {Address}\nWork Experience: {WorkExperince}";
    }

    public string ToStringRedacted() {
        PropertyInfo[] p = typeof(Person).GetProperties();  
        foreach (PropertyInfo pi in p)
        {
            if (pi.GetCustomAttribute<PersonalInformationAttribute>() != null)
            {
                if (pi.GetCustomAttribute<PersonalInformationAttribute>().level > 1)
                {
                    pi.SetValue(this, "*****");
                }
            }
        }
        return this.ToString(); // Add this line to return the modified string representation of the person.
    }

}