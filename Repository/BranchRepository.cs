using AFS_Visa_Application_REST_API.Entity;
using AFS_Visa_Application_REST_API.Interfaces.Repository;

namespace AFS_Visa_Application_REST_API.Repository
{
    public class BranchRepository : BaseRepository<Branch>, IBranchRepository
    {
        public List<List<DateTime>> GetAppointmentDates(Guid branchId, DateTime departureDate)
        {
            var baseDates = new List<List<DateTime>>();
            var branch = GetById(branchId);

            var startDate = DateTime.Now.Date + new TimeSpan(9, 0, 0);

            for (var i = startDate; i < departureDate; i = i.AddDays(1))
            {
                var baseTimes = new List<DateTime>();
                for (var x = i; x.TimeOfDay <= new TimeSpan(16, 0, 0); x= x.AddHours(1))
                {
                    if(!branch.Appointments.Any(a => a.AppointmentDate == x) && x.TimeOfDay.Hours != 12) 
                    {
                        baseTimes.Add(x);
                    }
                }
                baseDates.Add(baseTimes);
            }

            return baseDates;
        }
    }
}
