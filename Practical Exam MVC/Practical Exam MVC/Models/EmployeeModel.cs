using System.ComponentModel.DataAnnotations;

namespace Practical_Exam_MVC.Models;

public class EmployeeModel
{
    public int EmployeeId { get; set; }//abstract property

    [Required(ErrorMessage = "Vui lòng nhập tên")]
    [MinLength(4, ErrorMessage = "Tên danh mục tối thiểu 4 ký tự")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Vui lòng nhập cấp độ")]
    public string Rank { get; set; }

  

    [Required(ErrorMessage = "Vui lòng nhập mã phòng ban")]
    public string DepartmentId { get; set; }
}
