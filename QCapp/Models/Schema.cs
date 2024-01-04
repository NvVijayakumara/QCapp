using System.ComponentModel;

namespace QCapp.Models.Schema
{
    public class AccessLevel
    {
        [DisplayName("Access Level Id")]
        public int AccessLevelId { get; set; }

        [DisplayName("Access Level Name")]
        public string? AccessLevelName { get; set; }
    }

    public class AuditStatus
    {
        [DisplayName("Audit Status Id")]
        public int AuditStatusId { get; set; }

        [DisplayName("Audit Status Name")]
        public string? AuditStatusName { get; set; }
    }

    public class Billing
    {
        [DisplayName("Billing Id")]
        public int BillingId { get; set; }

        [DisplayName("Client Id")]
        public int? ClientId { get; set; }

        [DisplayName("Process Id")]
        public int? ProcessId { get; set; }

        [DisplayName("Pricing")]
        public double? Pricing { get; set; }

        [DisplayName("Date")]
        public DateTime? Date { get; set; }

        [DisplayName("Access")]
        public string? OrderNumber { get; set; }

        [DisplayName("Invoice Number")]
        public string? InvoiceNumber { get; set; }


        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }

    public class Checklist
    {
        [DisplayName("Checklist Id")]
        public int ChecklistId { get; set; }

        [DisplayName("Question Code")]
        public string? QuestionCode { get; set; }

        [DisplayName("Question")] 
        public string? Question { get; set; }

        [DisplayName("Exception Category Name")] 
        public string? ExceptionCategoryName { get; set; }

        [DisplayName("FNMA Category Name")] 
        public string? FNMACategoryName { get; set; }

        [DisplayName("FNMA Sub Category Name")] 
        public string? FNMASubCategoryName { get; set; }

        [DisplayName("Exception Name")] 
        public string? ExceptionName { get; set; }

        [DisplayName("Question Category 1")] 
        public int? QuestionCategory1 { get; set; }

        [DisplayName("Question Category 2")] 
        public int? QuestionCategory2 { get; set; }

        [DisplayName("Question Category 3")] 
        public int? QuestionCategory3 { get; set; }

        [DisplayName("Question Category 4")] 
        public int? QuestionCategory4 { get; set; }

        [DisplayName("Question Category 5")] 
        public int? QuestionCategory5 { get; set; }

        [DisplayName("Question Category 6")] 
        public int? QuestionCategory6 { get; set; }

        [DisplayName("Question Category 7")] 
        public int? QuestionCategory7 { get; set; }

        [DisplayName("Question Category 8")] 
        public int? QuestionCategory8 { get; set; }

        [DisplayName("AQuestion Category 9ccess")] 
        public int? QuestionCategory9 { get; set; }

        [DisplayName("Responsible Unit")] 
        public int? ResponsibleUnit { get; set; }

        [DisplayName("Significance")] 
        public int? Significance { get; set; }

        [DisplayName("Access")] 
        public string? Template { get; set; }


        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }

    public class City
    {
        [DisplayName("City Id")]
        public int Id { get; set; }

        [DisplayName("Country Id")] 
        public int? CountryId { get; set; }

        [DisplayName("State Id")] 
        public int? StateId { get; set; }

        [DisplayName("City Name")] 
        public string? CityName { get; set; }

        [DisplayName("CityCode")] 
        public string? CityCode { get; set; }
        
        [DisplayName("Zip")] 
        public string? Zip { get; set; }
    }

    public class Client
    {
        [DisplayName("Client Id")] 
        public int? ClientId { get; set; }

        [DisplayName("Client Name")] 
        public string? ClientName { get; set; }

        [DisplayName("Client Code")] 
        public string? ClientCode { get; set; }

        [DisplayName("Company Id")] 
        public int? CompanyId { get; set; }

        [DisplayName("Client Address Line 1")] 
        public string? ClientAddressLine1 { get; set; }

        [DisplayName("Client Address Line 2")] 
        public string? ClientAddressLine2 { get; set; }

        [DisplayName("Client Address City")] 
        public int? ClientAddressCity { get; set; }

        [DisplayName("Client Address State")] 
        public int? ClientAddressState { get; set; }

        [DisplayName("Client Address Country")] 
        public int? ClientAddressCountry { get; set; }

        [DisplayName("Client Address Zip")] 
        public string? ClientAddressZip { get; set; }

        [DisplayName("Client Email Address")] 
        public string? ClientEmailAddress { get; set; }

        [DisplayName("Active Status")] 
        public bool? ActiveStatus { get; set; }
        
        [DisplayName("Work Flow Id")] 
        public int? WorkFlowId { get; set; }


        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }

    public class Company
    {
        [DisplayName("Company Id")]
        public int? CompanyId { get; set; }

        [DisplayName("Company Name")] 
        public string? CompanyName { get; set; }
        
        [DisplayName("Company Code")] 
        public string? CompanyCode { get; set; }

        [DisplayName("Company Address Line 1")] 
        public string? CompanyAddressLine1 { get; set; }

        [DisplayName("Company Address Line 2")] 
        public string? CompanyAddressLine2 { get; set; }

        [DisplayName("Company Address City")] 
        public int? CompanyAddressCity { get; set; }

        [DisplayName("Company Address State")] 
        public int? CompanyAddressState { get; set; }

        [DisplayName("Company Address Country")] 
        public int? CompanyAddressCountry { get; set; }

        [DisplayName("Company Address Zip")] 
        public string? CompanyAddressZip { get; set; }

        [DisplayName("Company Email Address")] 
        public string? CompanyEmailAddress { get; set; }

        [DisplayName("Billing Adress Same As Company")] 
        public bool? BillingAdressSameAsCompany { get; set; }

        [DisplayName("Billing Address Line 1")] 
        public string? BillingAddressLine1 { get; set; }

        [DisplayName("Billing Address Line 2")] 
        public string? BillingAddressLine2 { get; set; }

        [DisplayName("Billing Address City")] 
        public int? BillingAddressCity { get; set; }

        [DisplayName("Billing Address State")] 
        public int? BillingAddressState { get; set; }

        [DisplayName("Billing Address Country")] 
        public int? BillingAddressCountry { get; set; }

        [DisplayName("Billing Address Zip")] 
        public string? BillingAddressZip { get; set; }

        [DisplayName("Billing Email Address")] 
        public string? BillingEmailAddress { get; set; }

        [DisplayName("Contact Name")] 
        public string? ContactName { get; set; }

        [DisplayName("Contact Phone")] 
        public string? ContactPhone { get; set; }


        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }

    public class Country
    {
        [DisplayName("Country Id")]
        public int Id { get; set; }
        
        [DisplayName("Country Name")] 
        public string? CountryName { get; set; }
    }
    
    public class DocumentConfiguration
    {
        [DisplayName("Document Id")] 
        public int? DocumentId { get; set; }

        [DisplayName("Document Sub Id")] 
        public int? DocumentSubId { get; set; }

        [DisplayName("Document Name")] 
        public string? DocumentName { get; set; }

        [DisplayName("Client Document Name")] 
        public string? ClientDocumentName { get; set; }

        [DisplayName("Critical")] 
        public bool? Critical { get; set; }

        [DisplayName("Enable")] 
        public bool? Enable { get; set; }
        
        [DisplayName("Template")] 
        public string? Template { get; set; }


        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }

    public class FieldConfiguration
    {
        [DisplayName("Field Id")]
        public int FieldId { get; set; }

        [DisplayName("Field Sub Id")] 
        public int? FieldSubId { get; set; }

        [DisplayName("Field Name")] 
        public string? FieldName { get; set; }

        [DisplayName("Field Type")] 
        public string? FieldType { get; set; }

        [DisplayName("Document Id")] 
        public int? DocumentId { get; set; }

        [DisplayName("Critical")] 
        public bool? Critical { get; set; }

        [DisplayName("Enable")] 
        public bool? Enable { get; set; }

        [DisplayName("Template")]
        public string? Template { get; set; }


        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }

    public class LoanStatus
    {
        [DisplayName("Loan Status Id")]
        public int LoanStatusId { get; set; }

        [DisplayName("Loan Status Name")] 
        public string? LoanStatusName { get; set; }
    }
    
    public class Process
    {
        [DisplayName("Process Id")]
        public int ProcessId { get; set; }

        [DisplayName("Process Code")] 
        public string? ProcessCode { get; set; }
        
        [DisplayName("Process Name")] 
        public string? ProcessName { get; set; }
    }
    
    public class State
    {
        [DisplayName("State Id")]
        public int Id { get; set; }

        [DisplayName("Country Id")] 
        public int? CountryId { get; set; }

        [DisplayName("State Name")] 
        public string? StateName { get; set; }

        [DisplayName("State Code")] 
        public string? StateCode { get; set; }
    }
    
    public class User
    {
        [DisplayName("User Id")] 
        public int? UserId { get; set; }
        
        [DisplayName("First Name")] 
        public string? FirstName { get; set; }
        
        [DisplayName("Middle Name")] 
        public string? MiddleName { get; set; }
        
        [DisplayName("Last Name")] 
        public string? LastName { get; set; }
        
        [DisplayName("Email Address")] 
        public string? EmailAddress { get; set; }
        
        [DisplayName("Company Id")] 
        public int? CompanyId { get; set; }
        
        [DisplayName("Contact Number")] 
        public string? ContactNumber { get; set; }
        
        [DisplayName("Access Level Id")] 
        public int? AccessLevelId { get; set; }
        
        [DisplayName("Country")] 
        public int? Country { get; set; }

        [DisplayName("Client Assigned")] 
        public int? ClientAssigned { get; set; }

        [DisplayName("Process Assigned")] 
        public int? ProcessAssigned { get; set; }
        
        [DisplayName("Active Status")] 
        public bool? ActiveStatus { get; set; }


        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }

    public class WorkFlowConfiguration
    {
        [DisplayName("WorkFlow Id")] 
        public int WorkFlowId { get; set; }
        
        [DisplayName("WorkFlow Name")] 
        public string? WorkflowName { get; set; }
        
        [DisplayName("Indexing")] 
        public bool? Indexing { get; set; }
        
        [DisplayName("Indexing QC")] 
        public bool? IndexingQC { get; set; }

        [DisplayName("Data Extraction")] 
        public bool? DataExtraction { get; set; }

        [DisplayName("Data Extraction QC")] 
        public bool? DataExtractionQC { get; set; }

        [DisplayName("Checklist")] 
        public bool? Checklist { get; set; }
        
        [DisplayName("Checklist QC")] 
        public bool? ChecklistQC { get; set; }

        [DisplayName("Reverification")] 
        public bool? Reverification { get; set; }

        [DisplayName("Reverification QC")] 
        public bool? ReverificationQC { get; set; }
        
        [DisplayName("Exceptions")] 
        public bool? Exceptions { get; set; }

        [DisplayName("Exceptions QC")]
        public bool? ExceptionsQC { get; set; }


        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }


    public class Questionnaire
    {
        [DisplayName("Questionnaire Id")]
        public int Id { get; set; }

        [DisplayName("Questionnaire Name")]
        public string? QuestionnaireName { get; set; }
        
        [DisplayName("File Name")]
        public string? FileName { get; set; }

        [DisplayName("Uploaded By")]
        public int? UploadedBy { get; set; }

        [DisplayName("Uploaded Date")]
        public DateTime? UploadedDate { get; set; }
    }
}