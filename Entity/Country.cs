namespace AFS_Visa_Application_REST_API.Entity
{
    public class Country : EntityBase
    {
        public Guid CountryId { get; set; }
        public string Name { get; set; }

        public List<Visa> VisasOffered { get; set; }
        public List<Visa> VisasExempt { get; set; } 
        public List<Branch> Branch { get; set; }
    }
}
