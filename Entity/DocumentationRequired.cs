namespace AFS_Visa_Application_REST_API.Entity
{
    public class DocumentationRequired
    {
        public Guid DocumentationRequiredId {  get; set; }
        public string DocumentationTitle { get; set; }
        public string FileType { get; set; }

        public List<Visa> Visa { get; } = new();
    }
}
