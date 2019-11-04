using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceSystem.Repository.Repository;
using AttendanceSystem.Model.Model;

namespace AttendanceSystem.Manager.Manager
{
    public class SectionManager
    {
        SectionRepository _sectionRepository = new SectionRepository();

        public List<Section> GetAllSections()
        {
            return _sectionRepository.GetAllSections();
        }
    }
}
