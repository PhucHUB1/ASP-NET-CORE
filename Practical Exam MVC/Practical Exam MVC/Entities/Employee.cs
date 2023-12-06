using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practical_Exam_MVC.Entities;

[Table("Employee")]
public class Employee
{
    
    [Key]
    public int EmployeeId { get; set; }
    
    public string EmployeeName { get; set; } = null!;
    
    public string Rank { get; set; }
    
    [ForeignKey("DepartmanentId")]
    public string DepartmanentId { get; set; }
}