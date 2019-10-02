using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VOD.Common.DTOModels.UI;

namespace VOD.UI.Models.MembershipViewModel
{
    public class DashboardViewModel
    {
        public List<List<CourseDTO>> Courses { get; set; }
    }
}
