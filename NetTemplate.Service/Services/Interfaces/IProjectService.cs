﻿using NetTemplate.DAL.Data.Entities;
using NetTemplate.DAL.Data.MetaDatas;
using NetTemplate.DAL.Data.Requests.Project;
using NetTemplate.DAL.Data.Responses.Project;

namespace NetTemplate.BLL.Services.Interfaces
{
   public interface IProjectService
{
    Task<CreateProjectResponse> CreateProject(CreateProjectRequest createProjectRequest);
    Task<CreateProjectResponse> GetProjectById(Guid id);
        Task<PagingResponse<CreateProjectResponse>> GetProjects(
           int page,
           int pageSize,
           string sortBy = "Name",
           bool isDescending = false,
           string? name = null,
           string? description = null,
           string? projectManagerName = null,
           ProjectStatus? status = null,
           Guid? projectManagerId = null,
           Guid? financeStaffId = null,              
           string? financeStaffName = null,           
           ProjectRole? role = null,
           decimal? minBudget = null,
           decimal? maxBudget = null,
           DateOnly? startDateFrom = null,
           DateOnly? endDateTo = null,
           bool? isActive = true,
           Guid? staffId = null
       );
        Task<CreateProjectResponse> UpdateProject(Guid id, UpdateProjectRequest updateProjectRequest);
    Task<bool> DeleteProject(Guid id);
}
}