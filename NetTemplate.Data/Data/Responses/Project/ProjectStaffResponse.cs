﻿using NetTemplate.DAL.Data.Entities;

namespace NetTemplate.DAL.Data.Responses.Project
{
    public class ProjectStaffResponse
    {
        public Guid StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffEmail { get; set; }
        public Department Department { get; set; }
        public ProjectRole Role { get; set; }
    }
}