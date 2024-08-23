using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly TechtrendsContext _context;

        public ProjectRepository(TechtrendsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project?> GetProjectByIdAsync(Guid projectId) // Nullable return type
        {
            return await _context.Projects.FindAsync(projectId);
        }

        public async Task AddProjectAsync(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProjectAsync(Project project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProjectAsync(Guid projectId)
        {
            var project = await _context.Projects.FindAsync(projectId);
            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> ProjectExistsAsync(Guid projectId)
        {
            return await _context.Projects.AnyAsync(e => e.ProjectId == projectId);
        }
    }
}
