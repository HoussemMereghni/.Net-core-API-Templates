using System;


namespace APIoracle.Models
{
    public partial class AttEmployees
    {

        public string EmployeeCode { get; set; }
        public string EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public string BranchCode { get; set; }
        public string DepartmentCode { get; set; }
        public string SectionCode { get; set; }
        public string UnitCode { get; set; }
        public string PositionCode { get; set; }
        public string NationaltiyCode { get; set; }
        public string NationaltiyName { get; set; }
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
        public string EmployeeType { get; set; }
        public string WorkStatus { get; set; }
        public DateTime? JionDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string SupervisorCode { get; set; }
    }
}
