using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs
{
    public class ShiftAssignmentDTO
    {
        [Required(ErrorMessage = "Vardiya ID zorunludur.")]
        public int ShiftId { get; set; }

        [Required(ErrorMessage = "Çalışma tarihi zorunludur.")]
        public DateTime WorkDate { get; set; }

        [Required(ErrorMessage = "En az bir çalışan seçilmelidir.")]
        public List<int> EmployeeIds { get; set; }

        [MaxLength(300)]
        public string Notes { get; set; }
    }
}
