using QCapp.Models.Schema;
using System.ComponentModel;

namespace QCapp.Models.SchemaViewModel
{
    public class AccessLevelViewModel : AccessLevel
    {
        //  
    }

    public class AuditStatusViewModel : AuditStatus
    {
        //
    }

    public class BillingViewModel : Billing
    {
        [DisplayName("Client Name")]
        public string? ClientName { get; set; }

        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }
    }

    public class ChecklistViewModel : Checklist
    {
        //
    }

    public class CityViewModel : City
    {
        [DisplayName("Country Name")]
        public string? CountryName { get; set; }
        
        [DisplayName("State Name")] 
        public string? StateName { get; set; }
    }

    public class ClientViewModel : Client
    {
        [DisplayName("Company Name")]
        public string? CompanyName { get; set; }
        
        [DisplayName("Client Address City Name")] 
        public string? ClientAddressCityName { get; set; }
        
        [DisplayName("Client Address State Name")]
        public string? ClientAddressStateName { get; set; }
        
        [DisplayName("Client Address Country Name")]
        public string? ClientAddressCountryName { get; set; }

        [DisplayName("Work Flow Name")]
        public string? WorkFlowName { get; set; }
    }
    
    public class CompanyViewModel : Company
    {
        [DisplayName("Company Address City Name")] 
        public string? CompanyAddressCityName { get; set; }

        [DisplayName("Company Address State Name")] 
        public string? CompanyAddressStateName { get; set; }

        [DisplayName("Company Address Country Name")] 
        public string? CompanyAddressCountryName { get; set; }

        [DisplayName("Billing Address City Name")] 
        public string? BillingAddressCityName { get; set; }

        [DisplayName("Billing Address State Name")] 
        public string? BillingAddressStateName { get; set; }
        
        [DisplayName("Billing Address Country Name")] 
        public string? BillingAddressCountryName { get; set; }
    }
    
    public class CountryViewModel : Country
    {
        //
    }
    
    public class DocumentConfigurationViewModel : DocumentConfiguration
    {
        //
    }
    
    public class FieldConfigurationViewModel : FieldConfiguration
    {
        [DisplayName("Document Name")] 
        public string? DocumentName { get; set; }
    }
    
    public class LoanStatusViewModel : LoanStatus
    {
        //
    }
    
    public class ProcessViewModel : Process
    {
        //
    }
    
    public class StateViewModel : State
    {
        [DisplayName("Country Name")] 
        public string? CountryName { get; set; }
    }
    
    public class UserViewModel : User
    {
        [DisplayName("Company Name")] 
        public string? CompanyName { get; set; }

        [DisplayName("Access Level Name")] 
        public string? AccessLevelName { get; set; }

        [DisplayName("Country Name")] 
        public string? CountryName { get; set; }

        [DisplayName("Client Name")] 
        public string? ClientName { get; set; }
        
        [DisplayName("Process Name")] 
        public string? ProcessName { get; set; }
    }

    public class WorkFlowConfigurationViewModel : WorkFlowConfiguration
    {
        //
    }
    
    public class QuestionnaireViewModel : Questionnaire
    {
        [DisplayName("Uploaded By")]
        public string? UploadedByName { get; set; }
    }
    
    public class BillingSummaryViewModel
    {
        [DisplayName("Client Name")]
        public string? ClientName { get; set; }

        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }

        [DisplayName("Billing Month")]
        public string? BillingMonth { get; set; }

        [DisplayName("Total Orders")]
        public string? TotalOrders { get; set; }

        [DisplayName("Billed Amount")]
        public string? BilledAmount { get; set; }
    }

    public class AuditViewModel : Audit
    {
        [DisplayName("Audit Type Name")]
        public string? AuditTypeName { get; set; }

        [DisplayName("Question Batch")]
        public string? QuestionBatch { get; set; }
    }
    
    public class LoansFileViewModel : LoansFile
    {
        [DisplayName("Status")]
        public string? LoanUploadStatusName { get; set; }

        [DisplayName("Work Flow Name")]
        public string? WorkFlowName { get; set; }

        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }

        [DisplayName("Audit Name")]
        public string? AuditName { get; set; }
    }
    
    public class LoanViewModel : Loan
    {
        [DisplayName("Last Finished Milestone")]
        public string? LastFinishedMilestone { get; set; }

        [DisplayName("Current Milestone")]
        public string? CurrentMilestone { get; set; }

        [DisplayName("Loan Status")]
        public string? LoanStatus { get; set; }

        [DisplayName("Loan Type")]
        public string? LoanType { get; set; }

        [DisplayName("Occupancy")]
        public string? Occupancy { get; set; }

        [DisplayName("Subject Property City")]
        public string? SubjectPropertyCity { get; set; }

        [DisplayName("Subject Property State")]
        public string? SubjectPropertyState { get; set; }

        [DisplayName("Audit Name")]
        public string? AuditName { get; set; }
        
        [DisplayName("Process Name")]
        public string? ProcessName { get; set; }
        
        [DisplayName("WorkFlow Name")]
        public string? WorkFlowName { get; set; }
    }
}