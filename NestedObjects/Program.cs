using NestedObjects;
Advisor compSciAdvisor = new Advisor()
{
    Email = "AnneMarie@cptc.edu",
    FullName = "AnneMarie Smith",
    OfficeLocation = "B17 Rm150"

};
Student stu1 = new Student()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "2539999999",
    SchoolEmail = "Homer.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName} for their advisor");