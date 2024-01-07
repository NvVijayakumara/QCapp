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
        public int? WorkFlowId { get; set; }
        
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
    
    public class Audit
    {
        [DisplayName("Audit Id")]
        public int? AuditId { get; set; }
        
        [DisplayName("Audit Name")]
        public string? AuditName { get; set; }

        [DisplayName("Audit Start Date")]
        public DateTime? AuditStartDate { get; set; }

        [DisplayName("Audit End Date")]
        public DateTime? AuditEndDate { get; set; }

        [DisplayName("Audit Type Id")]
        public int? AuditTypeId { get; set; }

        [DisplayName("Questionnaire Id")]
        public int? QuestionnaireId { get; set; }

        [DisplayName("Audit Due Date")]
        public DateTime? AuditDueDate { get; set; }

        //[DisplayName("Created By")]
        //public int? CreatedBy { get; set; }

        //[DisplayName("Created Date")]
        //public DateTime? CreatedDate { get; set; }

        //[DisplayName("Modified By")]
        //public int? ModifiedBy { get; set; }

        //[DisplayName("Modified Date")]
        //public DateTime? ModifiedDate { get; set; }
    }

    public class LoansFile
    {
        [DisplayName("Id")]
        public int? Id { get; set; }

        [DisplayName("File Name")]
        public string? FileName { get; set; }
        
        [DisplayName("Status Id")]
        public int? LoanUploadStatusId { get; set; }
        
        [DisplayName("Total Loans")]
        public int? TotalLoans { get; set; }

        [DisplayName("Loans Success")]
        public int? LoansSuccessCount { get; set; }

        [DisplayName("Loans Failed")]
        public int? LoansFailedCount { get; set; }

        [DisplayName("Work Flow Id")]
        public int? WorkFlowId { get; set; }

        [DisplayName("Process Id")]
        public int? ProcessId { get; set; }
        
        [DisplayName("Audit Id")]
        public int? AuditId { get; set; }

        [DisplayName("Uploaded By")]
        public int? UploadedBy { get; set; }

        [DisplayName("Uploaded Date")]
        public DateTime? UploadedDate { get; set; }
    }

    public class Loan
    {
        [DisplayName("Loan Id")]
        public int? LoanId { get; set; }

        [DisplayName("Loan Number")]
        public string? LoanNumber { get; set; }

        [DisplayName("Borrower Last Name")]
        public string? BorrowerLastName { get; set; }

        [DisplayName("Cost Center")]
        public double? CostCenter { get; set; }

        [DisplayName("Date Selected PFQC")]
        public DateTime? DateSelectedPFQC { get; set; }

        [DisplayName("PFQC Cleared Date")]
        public DateTime? PFQCClearedDate { get; set; }

        [DisplayName("Appraisal Accepted Date")]
        public DateTime? AppraisalAcceptedDate { get; set; }

        [DisplayName("PIW")]
        public bool? PIW { get; set; }

        [DisplayName("Underwriting Delegated")]
        public bool? UnderwritingDelegated { get; set; }

        [DisplayName("Last Finished Milestone Date")]
        public DateTime? LastFinishedMilestoneDate { get; set; }

        [DisplayName("Last Finished Milestone")]
        public int? LastFinishedMilestoneId { get; set; }

        [DisplayName("Current Milestone")]
        public int? CurrentMilestoneId { get; set; }

        [DisplayName("Lender Channel")]
        public string? LenderChannel { get; set; }

        [DisplayName("Loan Folder")]
        public string? LoanFolder { get; set; }

        [DisplayName("Loan Status")]
        public int? LoanStatusId { get; set; }

        [DisplayName("Status Date")]
        public DateTime? StatusDate { get; set; }

        [DisplayName("Application Date")]
        public DateTime? ApplicationDate { get; set; }

        [DisplayName("Approval Date")]
        public DateTime? ApprovalDate { get; set; }

        [DisplayName("Milestone Date Decision")]
        public DateTime? MilestoneDateDecision { get; set; }

        [DisplayName("Milestone Date Resubmittal")]
        public DateTime? MilestoneDateResubmittal { get; set; }

        [DisplayName("Closing Date")]
        public DateTime? ClosingDate { get; set; }

        [DisplayName("Disbursement Date")]
        public DateTime? DisbursementDate { get; set; }

        [DisplayName("Funds Sent")]
        public DateTime? FundsSent { get; set; }

        [DisplayName("Loan Type")]
        public int? LoanTypeId { get; set; }

        [DisplayName("Loan Purpose")]
        public string? LoanPurpose { get; set; }

        [DisplayName("Loan Program")]
        public string? LoanProgram { get; set; }

        [DisplayName("Occupancy")]
        public int? OccupancyId { get; set; }

        [DisplayName("Loan Term")]
        public int? LoanTerm { get; set; }

        [DisplayName("Amortization Type")]
        public string? AmortizationType { get; set; }

        [DisplayName("Lien Position")]
        public string? LienPosition { get; set; }

        [DisplayName("Loan Amount")]
        public double? LoanAmount { get; set; }

        [DisplayName("Note Rate")]
        public float? NoteRate { get; set; }

        [DisplayName("Appraised Value")]
        public double? AppraisedValue { get; set; }

        [DisplayName("Subject Property Type")]
        public string? SubjectPropertyType { get; set; }

        [DisplayName("Subject Property City")]
        public int? SubjectPropertyCityId { get; set; }

        [DisplayName("Subject Property State")]
        public int? SubjectPropertyStateId { get; set; }

        [DisplayName("Subject Property Zip")]
        public string? SubjectPropertyZip { get; set; }

        [DisplayName("CLTV")]
        public float? CLTV { get; set; }

        [DisplayName("FICO")]
        public int? FICO { get; set; }

        [DisplayName("Total Gift Funds Amt")]
        public double? TotalGiftFundsAmt { get; set; }

        [DisplayName("Bottom Ratio")]
        public float? BottomRatio { get; set; }

        [DisplayName("Loan Closer")]
        public string? LoanCloser { get; set; }

        [DisplayName("Loan Officer")]
        public string? LoanOfficer { get; set; }

        [DisplayName("Loan Processor")]
        public string? LoanProcessor { get; set; }

        [DisplayName("Underwriter")]
        public string? Underwriter { get; set; }

        [DisplayName("Borr Self Employed")]
        public bool? BorrSelfEmployed { get; set; }

        [DisplayName("CoBorr Self Employed")]
        public bool? CoBorrSelfEmployed { get; set; }

        [DisplayName("Agency Case No")]
        public string? AgencyCaseNo { get; set; }

        [DisplayName("Income Total Net Rental Income")]
        public double? IncomeTotalNetRentalIncome { get; set; }
        
        [DisplayName("Loan File Id")]
        public double? LoanFileId { get; set; }
    }
}