using NetTemplate.DAL.Data.Entities;

namespace NetTemplate.API.Constants
{
    public static class RoleConstants
    {
        public static readonly string[] AllRoles = Enum.GetValues(typeof(SystemRole))
                                                      .Cast<SystemRole>()
                                                      .Select(r => r.ToString())
                                                      .ToArray();
    }
}