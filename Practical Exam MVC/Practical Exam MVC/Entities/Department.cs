using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practical_Exam_MVC.Entities;

[Table("Department")]
public class Department
{
    [Key]
    public int DepartmentId { get; set; }
    
    public string DepartmentName { get; set; } = null!;

    public string location { get; set; } = null!;
    
    public string numberOfpersonals { get; set; }
}