
using EmployeeRoleEf.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace EmployeeRoleEf.Models;

public class Employee
{
    [Key]
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? Dob { get; set; }
    [CustomEmail(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; }
    [CustomPhone(ErrorMessage = "Please enter a valid phone number")]
    public string? MobileNumber { get; set; }
    public DateTime JoiningDate { get; set; }
    public string Location { get; set; }
    public string JobTitle { get; set; }
    public string Department { get; set; }
    public string? Manager { get; set; }
    public string? Project { get; set; }

    public Employee(string empId, string fname, string lname, string email, DateTime joinDate, string location, string jobtitle, string department)
    {
        Id = empId;
        FirstName = fname;
        LastName = lname;
        Email = email;
        JoiningDate = joinDate;
        Location = location;
        JobTitle = jobtitle;
        Department = department;
    }
    public Employee()
    {
        Id = "";
        FirstName = "";
        LastName = "";
        Dob = null;
        Email = "";
        MobileNumber = null;
        JoiningDate = DateTime.MinValue;
        Location = "";
        JobTitle = "";
        Department = "";
        Manager = null;
        Project = null;
    }
}