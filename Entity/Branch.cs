namespace AFS_Visa_Application_REST_API.Entity
{
    public class Branch : EntityBase
    {
        public Guid BranchId { get; set; }
        public Guid CountryId { get; set; }
        public int BranchCode { get; set; }
        public string BranchName { get; set; }

        public Country Country { get; set; }
        public List<VisaApplication> VisaApplications { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
