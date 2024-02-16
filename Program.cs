using System.Reflection;
using System.Reflection.Emit;

Console.WriteLine("Hello, World!");
Person p1 = new Person() {
    FirstName = "John",
    LastName = "Doe",
    SSN = "123-45-6789",
    Address = "123 Public St",
    WorkExperince = "Software Developer"
};
Person p2 = new Person() {
    FirstName = "Jane",
    LastName = "Doe",
    SSN = "987-65-4321",
    Address = "123 Private St",
    WorkExperince = "Baker"
};
Person p3 = new Person() {
    FirstName = "John",
    LastName = "Smith",
    SSN = "123-45-6789",
    Address = "123 Private St",
    WorkExperince = "Brick Layer"
};
Person p4 = new Person() {
    FirstName = "Jane",
    LastName = "Smith",
    SSN = "987-65-4321",
    Address = "123 Public St",
    WorkExperince = "Salesman"
};
Person p5 = new Person() {
    FirstName = "John",
    LastName = "Resese",
    SSN = "111-22-2222",
    Address = "123 Callord St",
    WorkExperince = "Monster Truck Driver"
}; 

// Console.WriteLine(p1);
// Type t1 = p1.GetType();
// Console.WriteLine(t1);

/*
ConstructorInfo[] c = t1.GetConstructors();
foreach (ConstructorInfo ci in c)
{
    Console.WriteLine(ci);
}
 
*/
// PropertyInfo[] p = t1.GetProperties();  
// foreach (PropertyInfo pi in p)
// {
//     Console.WriteLine(pi);
// }


// MemberInfo[] m = t1.GetMembers();
// foreach (MemberInfo mi in m)
// {
//     Console.WriteLine(mi);
//     Object[] attributes = mi.GetCustomAttributes(true);
//     foreach (Object o in attributes)
//     {
//         Console.WriteLine(o);
//         if (o is PersonalInformationAttribute)
//         {
//             PersonalInformationAttribute pia = (PersonalInformationAttribute)o;
//             Console.WriteLine("Personal Information - Don't print this!");
//             if (pia.level == 3)
//             {
//                 Console.WriteLine("Super Private");
//             }
//             else
//             {
//                 Console.WriteLine("Sorta Private");
//             }
//             PublicInformationAttribute pua = (PublicInformationAttribute)o;
//             if (pua.level == 3)
//             {
//                 Console.WriteLine("Super Public");
//             }
//             else
//             {
//                 Console.WriteLine("Sorta Public");
//             }
//             StorageTypeAttribute sta = (StorageTypeAttribute)o;
//             Console.WriteLine(sta.storageType);
//         }
//     }
//     Console.WriteLine("------");
// }

Console.WriteLine("-----New Tutorial Section-----");

List<Person> PersonList = new List<Person>();
PersonList.Add(p1);
PersonList.Add(p2);
PersonList.Add(p3);
PersonList.Add(p4);
PersonList.Add(p5);

foreach (Person pr in PersonList)
{
    Console.WriteLine(pr.ToStringRedacted());
}


//int x = 10;
//bool b = true;
//Console.WriteLine(x.GetType());
//Console.WriteLine(b.GetType());