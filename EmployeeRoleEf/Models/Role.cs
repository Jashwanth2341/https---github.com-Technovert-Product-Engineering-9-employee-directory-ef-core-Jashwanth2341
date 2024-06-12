
using System.ComponentModel.DataAnnotations;


namespace EmployeeRoleEf.Models;

public class Role
{
    [Key]
    public string Id { get; set; }
    public string RoleName { get; set; }
    public string Department { get; set; }
    public string Location { get; set; }
    public string? Description { get; set; }


    public Role(string id, string rolename, string department, string location)
    {
        Id = id;
        RoleName = rolename;
        Department = department;
        Location = location;
    }
    public Role()
    {
        Id = "";
        RoleName = "";
        Department = "";
        Location = "";
        Description = null;

    }
}