// See https://aka.ms/new-console-template for more information
using Test_1;


Human [] humans =

{
    new Facilitator() { Name = "Murphy",    Programme = Programme.Backend},
    new Facilitator() { Name = "Ifeanyi",   Programme = Programme.Backend},
    new Facilitator() { Name = "Nwachukwu", Programme = Programme.Frontend},
    new Facilitator() { Name = "Ochuba",    Programme = Programme.Frontend},

    new Student() { Name = "Harrison",  Programme = Programme.Backend},
    new Student() { Name = "Victory",   Programme = Programme.Backend},
    new Student() { Name = "Dozie",     Programme = Programme.Backend},

    new Student() { Name = "Jaja",  Programme = Programme.Frontend},
    new Student() { Name = "Frank", Programme = Programme.Frontend},
    new Student() { Name = "Lina",  Programme = Programme.Frontend}
};


foreach (var human in humans)
{
    human.AttendClasses(DaysOfWeek.Monday);
    human.AttendClasses(DaysOfWeek.Tuesday);
    human.AttendClasses(DaysOfWeek.Thursday);
    
}