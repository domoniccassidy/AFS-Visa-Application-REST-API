using AFS_Visa_Application_REST_API.Data_Contracts.Base;

namespace AFS_Visa_Application_REST_API.Data_Contracts.DocumentationRequired
{
    public class DocumentationRequiredDto : IDataContract
    {
        public string DocumentationTitle { get; set; }
        public string FileType { get; set; }
    }
}
