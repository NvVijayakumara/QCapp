using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QCapp.Models;

public partial class QcprojV1Context : DbContext
{
    public IConfiguration Configuration { get; }
    public QcprojV1Context(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(Configuration.GetConnectionString("SqlConnection"));
        }
    }

    //public QcprojV1Context(DbContextOptions<QcprojV1Context> options)
    //    : base(options)
    //{
    //    //ChangeTracker.LazyLoadingEnabled = false;
    //}

    public virtual DbSet<AccessLevel> AccessLevels { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<AuditStatus> AuditStatuses { get; set; }

    public virtual DbSet<AuditType> AuditTypes { get; set; }

    public virtual DbSet<Billing> Billings { get; set; }

    public virtual DbSet<Checklist> Checklists { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<DocumentConfiguration> DocumentConfigurations { get; set; }

    public virtual DbSet<FieldConfiguration> FieldConfigurations { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<LoanOccupancy> LoanOccupancies { get; set; }

    public virtual DbSet<LoanStatus> LoanStatuses { get; set; }

    public virtual DbSet<LoanType> LoanTypes { get; set; }

    public virtual DbSet<LoansFile> LoansFiles { get; set; }

    public virtual DbSet<LoansFileUploadStatus> LoansFileUploadStatuses { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuLink> MenuLinks { get; set; }

    public virtual DbSet<Milestone> Milestones { get; set; }

    public virtual DbSet<Process> Processes { get; set; }

    public virtual DbSet<Questionnaire> Questionnaires { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAccessMenuMaping> UserAccessMenuMapings { get; set; }

    public virtual DbSet<WorkFlowConfiguration> WorkFlowConfigurations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessLevel>(entity =>
        {
            entity.ToTable("AccessLevel");

            entity.Property(e => e.AccessLevelId).ValueGeneratedNever();
            entity.Property(e => e.AccessLevelName).HasMaxLength(50);
        });

        modelBuilder.Entity<Audit>(entity =>
        {
            entity.ToTable("Audit");

            entity.Property(e => e.AuditId).ValueGeneratedNever();
            entity.Property(e => e.AuditDueDate).HasColumnType("datetime");
            entity.Property(e => e.AuditEndDate).HasColumnType("datetime");
            entity.Property(e => e.AuditName).HasMaxLength(50);
            entity.Property(e => e.AuditStartDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AuditType).WithMany(p => p.Audits)
                .HasForeignKey(d => d.AuditTypeId)
                .HasConstraintName("FK_Audit_AuditType");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AuditCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Audit_User");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.AuditModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_Audit_User1");

            entity.HasOne(d => d.Questionnaire).WithMany(p => p.Audits)
                .HasForeignKey(d => d.QuestionnaireId)
                .HasConstraintName("FK_Audit_Questionnaire");
        });

        modelBuilder.Entity<AuditStatus>(entity =>
        {
            entity.ToTable("AuditStatus");

            entity.Property(e => e.AuditStatusId).ValueGeneratedNever();
            entity.Property(e => e.AuditStatusName).HasMaxLength(50);
        });

        modelBuilder.Entity<AuditType>(entity =>
        {
            entity.ToTable("AuditType");

            entity.Property(e => e.AuditTypeId).ValueGeneratedNever();
            entity.Property(e => e.AuditTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Billing>(entity =>
        {
            entity.ToTable("Billing");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderNumber).HasMaxLength(50);
            entity.Property(e => e.Pricing).HasColumnType("money");

            entity.HasOne(d => d.Client).WithMany(p => p.Billings)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Billing_Client");

            entity.HasOne(d => d.Process).WithMany(p => p.Billings)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("FK_Billing_Process");
        });

        modelBuilder.Entity<Checklist>(entity =>
        {
            entity.HasKey(e => e.ChecklistId).HasName("PK_Checklist_1");

            entity.ToTable("Checklist");

            entity.Property(e => e.ChecklistId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExceptionCategoryName).HasMaxLength(50);
            entity.Property(e => e.ExceptionName).HasMaxLength(50);
            entity.Property(e => e.FnmacategoryName)
                .HasMaxLength(50)
                .HasColumnName("FNMACategoryName");
            entity.Property(e => e.FnmasubCategoryName)
                .HasMaxLength(50)
                .HasColumnName("FNMASubCategoryName");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Question).HasMaxLength(1000);
            entity.Property(e => e.QuestionCode).HasMaxLength(50);
            entity.Property(e => e.Template).HasMaxLength(250);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CityCode).HasMaxLength(10);
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.Zip).HasMaxLength(15);

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_City_State");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.ClientId).ValueGeneratedNever();
            entity.Property(e => e.ClientAddressLine1).HasMaxLength(250);
            entity.Property(e => e.ClientAddressLine2).HasMaxLength(250);
            entity.Property(e => e.ClientAddressZip).HasMaxLength(25);
            entity.Property(e => e.ClientCode).HasMaxLength(25);
            entity.Property(e => e.ClientEmailAddress).HasMaxLength(50);
            entity.Property(e => e.ClientName).HasMaxLength(25);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.ClientAddressCityNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.ClientAddressCity)
                .HasConstraintName("FK_Client_City");

            entity.HasOne(d => d.ClientAddressCountryNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.ClientAddressCountry)
                .HasConstraintName("FK_Client_Country");

            entity.HasOne(d => d.ClientAddressStateNavigation).WithMany(p => p.Clients)
                .HasForeignKey(d => d.ClientAddressState)
                .HasConstraintName("FK_Client_State");

            entity.HasOne(d => d.Company).WithMany(p => p.Clients)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Company_Client");

            entity.HasOne(d => d.WorkFlow).WithMany(p => p.Clients)
                .HasForeignKey(d => d.WorkFlowId)
                .HasConstraintName("FK_Client_WorkFlowConfiguration");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.HasIndex(e => e.CompanyId, "IX_Company").IsUnique();

            entity.Property(e => e.CompanyId).ValueGeneratedNever();
            entity.Property(e => e.BillingAddressLine1).HasMaxLength(250);
            entity.Property(e => e.BillingAddressLine2).HasMaxLength(250);
            entity.Property(e => e.BillingAddressZip).HasMaxLength(25);
            entity.Property(e => e.BillingEmailAddress).HasMaxLength(50);
            entity.Property(e => e.CompanyAddressLine1).HasMaxLength(250);
            entity.Property(e => e.CompanyAddressLine2).HasMaxLength(250);
            entity.Property(e => e.CompanyAddressZip).HasMaxLength(25);
            entity.Property(e => e.CompanyCode).HasMaxLength(25);
            entity.Property(e => e.CompanyEmailAddress).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.ContactName).HasMaxLength(50);
            entity.Property(e => e.ContactPhone).HasMaxLength(15);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BillingAddressCountryNavigation).WithMany(p => p.CompanyBillingAddressCountryNavigations)
                .HasForeignKey(d => d.BillingAddressCountry)
                .HasConstraintName("FK_Company_Country1");

            entity.HasOne(d => d.CompanyAddressCityNavigation).WithMany(p => p.Companies)
                .HasForeignKey(d => d.CompanyAddressCity)
                .HasConstraintName("FK_Company_City");

            entity.HasOne(d => d.CompanyAddressCountryNavigation).WithMany(p => p.CompanyCompanyAddressCountryNavigations)
                .HasForeignKey(d => d.CompanyAddressCountry)
                .HasConstraintName("FK_Company_Country");

            entity.HasOne(d => d.CompanyAddressStateNavigation).WithMany(p => p.Companies)
                .HasForeignKey(d => d.CompanyAddressState)
                .HasConstraintName("FK_Company_State");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CountryName).HasMaxLength(50);
        });

        modelBuilder.Entity<DocumentConfiguration>(entity =>
        {
            entity.HasKey(e => e.DocumentId);

            entity.ToTable("DocumentConfiguration");

            entity.Property(e => e.DocumentId).ValueGeneratedNever();
            entity.Property(e => e.ClientDocumentName).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentName).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Template).HasMaxLength(50);
        });

        modelBuilder.Entity<FieldConfiguration>(entity =>
        {
            entity.HasKey(e => e.FieldId);

            entity.ToTable("FieldConfiguration");

            entity.Property(e => e.FieldId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FieldName).HasMaxLength(50);
            entity.Property(e => e.FieldType).HasMaxLength(25);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Template).HasMaxLength(50);

            entity.HasOne(d => d.Document).WithMany(p => p.FieldConfigurations)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("FK_FieldConfiguration_DocumentConfiguration");
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.ToTable("Loan");

            entity.Property(e => e.LoanId).ValueGeneratedNever();
            entity.Property(e => e.AgencyCaseNo).HasMaxLength(50);
            entity.Property(e => e.AmortizationType).HasMaxLength(50);
            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");
            entity.Property(e => e.AppraisalAcceptedDate).HasColumnType("datetime");
            entity.Property(e => e.AppraisedValue).HasColumnType("money");
            entity.Property(e => e.ApprovalDate).HasColumnType("datetime");
            entity.Property(e => e.BorrowerLastName).HasMaxLength(50);
            entity.Property(e => e.ClosingDate).HasColumnType("datetime");
            entity.Property(e => e.Cltv).HasColumnName("CLTV");
            entity.Property(e => e.CostCenter).HasMaxLength(50);
            entity.Property(e => e.DateSelectedPfqc)
                .HasColumnType("datetime")
                .HasColumnName("DateSelectedPFQC");
            entity.Property(e => e.DisbursementDate).HasColumnType("datetime");
            entity.Property(e => e.Fico).HasColumnName("FICO");
            entity.Property(e => e.FundsSent).HasColumnType("datetime");
            entity.Property(e => e.IncomeTotalNetRentalIncome).HasColumnType("money");
            entity.Property(e => e.LastFinishedMilestoneDate).HasColumnType("datetime");
            entity.Property(e => e.LenderChannel).HasMaxLength(50);
            entity.Property(e => e.LienPosition).HasMaxLength(50);
            entity.Property(e => e.LoanAmount).HasColumnType("money");
            entity.Property(e => e.LoanCloser).HasMaxLength(50);
            entity.Property(e => e.LoanFolder).HasMaxLength(50);
            entity.Property(e => e.LoanNumber).HasMaxLength(50);
            entity.Property(e => e.LoanOfficer).HasMaxLength(50);
            entity.Property(e => e.LoanProcessor).HasMaxLength(50);
            entity.Property(e => e.LoanProgram).HasMaxLength(50);
            entity.Property(e => e.LoanPurpose).HasMaxLength(50);
            entity.Property(e => e.MilestoneDateDecision).HasColumnType("datetime");
            entity.Property(e => e.MilestoneDateResubmittal).HasColumnType("datetime");
            entity.Property(e => e.PfqcclearedDate)
                .HasColumnType("datetime")
                .HasColumnName("PFQCClearedDate");
            entity.Property(e => e.Piw).HasColumnName("PIW");
            entity.Property(e => e.StatusDate).HasColumnType("datetime");
            entity.Property(e => e.SubjectPropertyType).HasMaxLength(50);
            entity.Property(e => e.SubjectPropertyZip).HasMaxLength(50);
            entity.Property(e => e.TotalGiftFundsAmt).HasColumnType("money");
            entity.Property(e => e.Underwriter).HasMaxLength(50);

            entity.HasOne(d => d.CurrentMilestoneNavigation).WithMany(p => p.LoanCurrentMilestoneNavigations)
                .HasForeignKey(d => d.CurrentMilestone)
                .HasConstraintName("FK_Loan_Milestone1");

            entity.HasOne(d => d.LastFinishedMilestoneNavigation).WithMany(p => p.LoanLastFinishedMilestoneNavigations)
                .HasForeignKey(d => d.LastFinishedMilestone)
                .HasConstraintName("FK_Loan_Milestone");

            entity.HasOne(d => d.LoanFile).WithMany(p => p.Loans)
                .HasForeignKey(d => d.LoanFileId)
                .HasConstraintName("FK_Loan_LoansFile");

            entity.HasOne(d => d.LoanStatusNavigation).WithMany(p => p.Loans)
                .HasForeignKey(d => d.LoanStatus)
                .HasConstraintName("FK_Loan_LoanStatus");

            entity.HasOne(d => d.LoanTypeNavigation).WithMany(p => p.Loans)
                .HasForeignKey(d => d.LoanType)
                .HasConstraintName("FK_Loan_LoanType");

            entity.HasOne(d => d.OccupancyNavigation).WithMany(p => p.Loans)
                .HasForeignKey(d => d.Occupancy)
                .HasConstraintName("FK_Loan_LoanOccupancy");

            entity.HasOne(d => d.SubjectPropertyCityNavigation).WithMany(p => p.Loans)
                .HasForeignKey(d => d.SubjectPropertyCity)
                .HasConstraintName("FK_Loan_City");

            entity.HasOne(d => d.SubjectPropertyStateNavigation).WithMany(p => p.Loans)
                .HasForeignKey(d => d.SubjectPropertyState)
                .HasConstraintName("FK_Loan_State");
        });

        modelBuilder.Entity<LoanOccupancy>(entity =>
        {
            entity.ToTable("LoanOccupancy");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanStatus>(entity =>
        {
            entity.ToTable("LoanStatus");

            entity.Property(e => e.LoanStatusId).ValueGeneratedNever();
            entity.Property(e => e.LoanStatusName).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanType>(entity =>
        {
            entity.ToTable("LoanType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(50);
        });

        modelBuilder.Entity<LoansFile>(entity =>
        {
            entity.ToTable("LoansFile");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FileName).HasMaxLength(50);
            entity.Property(e => e.UploadedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Audit).WithMany(p => p.LoansFiles)
                .HasForeignKey(d => d.AuditId)
                .HasConstraintName("FK_LoansFile_Audit");

            entity.HasOne(d => d.Process).WithMany(p => p.LoansFiles)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("FK_LoansFile_Process");

            entity.HasOne(d => d.Status).WithMany(p => p.LoansFiles)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_LoansFile_LoansFileUploadStatus");

            entity.HasOne(d => d.UpoadedByNavigation).WithMany(p => p.LoansFiles)
                .HasForeignKey(d => d.UpoadedBy)
                .HasConstraintName("FK_LoansFile_User");

            entity.HasOne(d => d.WorkFlow).WithMany(p => p.LoansFiles)
                .HasForeignKey(d => d.WorkFlowId)
                .HasConstraintName("FK_LoansFile_WorkFlowConfiguration");
        });

        modelBuilder.Entity<LoansFileUploadStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LoanUploadStatus");

            entity.ToTable("LoansFileUploadStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.Property(e => e.MenuId).ValueGeneratedNever();
            entity.Property(e => e.CssClass).HasMaxLength(50);
            entity.Property(e => e.MenuName).HasMaxLength(50);

            entity.HasOne(d => d.ParentMeenu).WithMany(p => p.InverseParentMeenu)
                .HasForeignKey(d => d.ParentMeenuId)
                .HasConstraintName("FK_Menus_Menus");
        });

        modelBuilder.Entity<MenuLink>(entity =>
        {
            entity.HasKey(e => e.MenuLinkId).HasName("PK_MenuLink");

            entity.Property(e => e.MenuLinkId).ValueGeneratedNever();
            entity.Property(e => e.Href).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Milestone>(entity =>
        {
            entity.ToTable("Milestone");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Value).HasMaxLength(50);
        });

        modelBuilder.Entity<Process>(entity =>
        {
            entity.ToTable("Process");

            entity.Property(e => e.ProcessId).ValueGeneratedNever();
            entity.Property(e => e.ProcessCode).HasMaxLength(25);
            entity.Property(e => e.ProcessName).HasMaxLength(50);
        });

        modelBuilder.Entity<Questionnaire>(entity =>
        {
            entity.ToTable("Questionnaire");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FileName).HasMaxLength(50);
            entity.Property(e => e.QuestionnaireName).HasMaxLength(50);
            entity.Property(e => e.UploadedDate).HasColumnType("datetime");

            entity.HasOne(d => d.UploadedByNavigation).WithMany(p => p.Questionnaires)
                .HasForeignKey(d => d.UploadedBy)
                .HasConstraintName("FK_Questionnaire_User");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.ToTable("State");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.StateCode).HasMaxLength(10);
            entity.Property(e => e.StateName).HasMaxLength(50);

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_State_Country");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.ContactNumber).HasMaxLength(15);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.AccessLevel).WithMany(p => p.Users)
                .HasForeignKey(d => d.AccessLevelId)
                .HasConstraintName("FK_User_AccessLevel");

            entity.HasOne(d => d.ClientAssignedNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.ClientAssigned)
                .HasConstraintName("FK_User_Client");

            entity.HasOne(d => d.Company).WithMany(p => p.Users)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_User_Company");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK_User_Country");

            entity.HasOne(d => d.ProcessAssignedNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.ProcessAssigned)
                .HasConstraintName("FK_User_Process");
        });

        modelBuilder.Entity<UserAccessMenuMaping>(entity =>
        {
            entity.HasKey(e => e.MappingId);

            entity.ToTable("UserAccessMenuMaping");

            entity.HasOne(d => d.AccessLevel).WithMany(p => p.UserAccessMenuMapings)
                .HasForeignKey(d => d.AccessLevelId)
                .HasConstraintName("FK_UserAccessMenuMaping_AccessLevel");

            entity.HasOne(d => d.MenuLink).WithMany(p => p.UserAccessMenuMapings)
                .HasForeignKey(d => d.MenuLinkId)
                .HasConstraintName("FK_UserAccessMenuMaping_MenuLinks");
        });

        modelBuilder.Entity<WorkFlowConfiguration>(entity =>
        {
            entity.HasKey(e => e.WorkFlowId);

            entity.ToTable("WorkFlowConfiguration");

            entity.Property(e => e.WorkFlowId).ValueGeneratedNever();
            entity.Property(e => e.ChecklistQc).HasColumnName("ChecklistQC");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DataExtractionQc).HasColumnName("DataExtractionQC");
            entity.Property(e => e.ExceptionsQc).HasColumnName("ExceptionsQC");
            entity.Property(e => e.IndexingQc).HasColumnName("IndexingQC");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReverificationQc).HasColumnName("ReverificationQC");
            entity.Property(e => e.WorkflowName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
