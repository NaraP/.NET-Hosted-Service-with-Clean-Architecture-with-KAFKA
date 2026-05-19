using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafka.Domain.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() 
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BcpPartOrder> BcpPartOrders { get; set; }

        public virtual DbSet<BcpWorkOrder> BcpWorkOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BcpPartOrder>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("XPKPartOrder")
                    .HasFillFactor(90);

                entity.ToTable("BCP_PartOrder");

                entity.HasIndex(e => e.BcppartOrderId, "Unique_BCPPartOrderID").IsUnique();

                entity.Property(e => e.AddressTypeCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Address_Type_Code__c");
                entity.Property(e => e.AdvisoryNoteIdentifierC)
                    .HasMaxLength(40)
                    .HasColumnName("Advisory_Note_Identifier__c");
                entity.Property(e => e.AnyPartLineInJeopardyStatusC).HasColumnName("Any_Part_Line_In_Jeopardy_Status__c");
                entity.Property(e => e.AvailabilityCheckCompleteC).HasColumnName("Availability_Check_Complete__c");
                entity.Property(e => e.BadgeC)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Badge__c");
                entity.Property(e => e.BcpcaseNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BCPCaseNumber");
                entity.Property(e => e.BcppartOrderId)
                    .HasMaxLength(80)
                    .HasColumnName("BCPPartOrderID");
                entity.Property(e => e.BcptaskId)
                    .HasMaxLength(80)
                    .HasColumnName("BCPTaskId");
                entity.Property(e => e.CalculatedArrivalTimeStampC)
                    .HasColumnType("datetime")
                    .HasColumnName("Calculated_Arrival_TimeStamp__c");
                entity.Property(e => e.CaseNumberC)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Case_Number__c");
                entity.Property(e => e.Ceemail)
                    .HasMaxLength(250)
                    .HasColumnName("CEEmail");
                entity.Property(e => e.Cename)
                    .HasMaxLength(250)
                    .HasColumnName("CEName");
                entity.Property(e => e.CephoneNumber)
                    .HasMaxLength(60)
                    .HasColumnName("CEPhoneNumber");
                entity.Property(e => e.CityC)
                    .HasMaxLength(100)
                    .HasColumnName("City__c");
                entity.Property(e => e.CompanyNameC)
                    .HasMaxLength(300)
                    .HasColumnName("Company_Name__c");
                entity.Property(e => e.ContactEmailC)
                    .HasMaxLength(80)
                    .HasColumnName("Contact_Email__c");
                entity.Property(e => e.ContactFirstNameC)
                    .HasMaxLength(300)
                    .HasColumnName("Contact_First_Name__c");
                entity.Property(e => e.ContactLastNameC)
                    .HasMaxLength(300)
                    .HasColumnName("Contact_Last_Name__c");
                entity.Property(e => e.ContactNameC)
                    .HasMaxLength(120)
                    .HasColumnName("Contact_Name__c");
                entity.Property(e => e.ContactPhoneC)
                    .HasMaxLength(50)
                    .HasColumnName("Contact_Phone__c");
                entity.Property(e => e.CountOfJeapodyPartLinesC).HasColumnName("Count_Of_Jeapody_Part_Lines__c");
                entity.Property(e => e.CountOfNonPodPartLinesC).HasColumnName("Count_of_Non_POD_Part_Lines__c");
                entity.Property(e => e.CountOfOpenPartLinesC).HasColumnName("Count_of_Open_Part_Lines__c");
                entity.Property(e => e.CountryC)
                    .HasMaxLength(100)
                    .HasColumnName("Country__c");
                entity.Property(e => e.CoverageResponseC)
                    .HasMaxLength(255)
                    .HasColumnName("Coverage_Response__c");
                entity.Property(e => e.CreatedById)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
                entity.Property(e => e.Createdby).HasMaxLength(80);
                entity.Property(e => e.CrsIdC)
                    .HasMaxLength(10)
                    .HasColumnName("CRS_ID__c");
                entity.Property(e => e.CurrencyIsoCode).HasMaxLength(3);
                entity.Property(e => e.DeliveryPriorityCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Delivery_Priority_Code__c");
                entity.Property(e => e.DualDispatchC).HasColumnName("Dual_dispatch__c");
                entity.Property(e => e.EntitlementSlaResponseC)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Entitlement_SLA_Response__c");
                entity.Property(e => e.ExpoPartOrderNumber).HasMaxLength(40);
                entity.Property(e => e.InsertGmtTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("Insert_GMT_Timestamp");
                entity.Property(e => e.IsRevisitOrderC).HasColumnName("Is_Revisit_Order__c");
                entity.Property(e => e.Iso2CharacterCountryCodeC)
                    .HasMaxLength(2)
                    .HasColumnName("ISO2_Character_Country_Code__c");
                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
                entity.Property(e => e.LastModifiedById)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
                entity.Property(e => e.LastReferencedDate).HasColumnType("datetime");
                entity.Property(e => e.LastViewedDate).HasColumnType("datetime");
                entity.Property(e => e.LatitudeC).HasColumnName("Latitude__c");
                entity.Property(e => e.LegacyPartOrderNumberC)
                    .HasMaxLength(100)
                    .HasColumnName("Legacy_Part_Order_number__c");
                entity.Property(e => e.LocationLatitudeS).HasColumnName("Location__Latitude__s");
                entity.Property(e => e.LocationLongitudeS).HasColumnName("Location__Longitude__s");
                entity.Property(e => e.LogisticOrderIdentifierC)
                    .HasMaxLength(40)
                    .HasColumnName("Logistic_Order_Identifier__c");
                entity.Property(e => e.LongitudeC).HasColumnName("Longitude__c");
                entity.Property(e => e.MediaRetentionEligibilityC)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Media_Retention_Eligibility__c");
                entity.Property(e => e.MessageC)
                    .HasMaxLength(255)
                    .HasColumnName("Message__c");
                entity.Property(e => e.MessageTypeC)
                    .HasMaxLength(255)
                    .HasColumnName("Message_Type__c");
                entity.Property(e => e.MissionCriticalC).HasColumnName("Mission_Critical__c");
                entity.Property(e => e.ModifierName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.ModifierValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Name).HasMaxLength(80);
                entity.Property(e => e.OrderEstimatedArrivalTimeStampC)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_Estimated_Arrival_TimeStamp__c");
                entity.Property(e => e.OrderPlacedInBcpC).HasColumnName("Order_Placed_in_BCP__c");
                entity.Property(e => e.OrderReasonCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Order_Reason_Code__c");
                entity.Property(e => e.OrderStatusCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Order_Status_Code__c");
                entity.Property(e => e.OrderTypeCodeIdentifierC)
                    .HasMaxLength(20)
                    .HasColumnName("Order_Type_Code_Identifier__c");
                entity.Property(e => e.OutageId).HasColumnName("OutageID");
                entity.Property(e => e.OwnerId)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.PartDeliveryRequestedTimeStampC)
                    .HasColumnType("datetime")
                    .HasColumnName("Part_Delivery_Requested_TimeStamp__c");
                entity.Property(e => e.PartLineCountC).HasColumnName("Part_Line_Count__c");
                entity.Property(e => e.PartOrderIdentifierC)
                    .HasMaxLength(40)
                    .HasColumnName("Part_Order_Identifier__c");
                entity.Property(e => e.PartOrderTypeCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Part_Order_Type_Code__c");
                entity.Property(e => e.PartPickupLocationC)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Part_Pickup_Location__c");
                entity.Property(e => e.PartTransferDestinationTaskC)
                    .HasMaxLength(18)
                    .HasColumnName("Part_Transfer_Destination_Task__c");
                entity.Property(e => e.PartsUsageLoggingCompleteC).HasColumnName("Parts_Usage_Logging_Complete__c");
                entity.Property(e => e.PendingTransactionTypeC)
                    .HasMaxLength(16)
                    .HasColumnName("Pending_Transaction_Type__c");
                entity.Property(e => e.PickPackInstructionsC)
                    .HasMaxLength(255)
                    .HasColumnName("Pick_Pack_Instructions__c");
                entity.Property(e => e.PickupTaskC)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Pickup_Task__c");
                entity.Property(e => e.PreferredLangugeCodeC)
                    .HasMaxLength(20)
                    .HasColumnName("Preferred_Languge_Code__c");
                entity.Property(e => e.PrivateC).HasColumnName("Private__c");
                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);
                entity.Property(e => e.ReceivedInstructionsC)
                    .HasMaxLength(255)
                    .HasColumnName("Received_Instructions__c");
                entity.Property(e => e.RecordTypeId)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.Region).HasMaxLength(50);
                entity.Property(e => e.RepairTaskC)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("Repair_Task__c");
                entity.Property(e => e.RequestorTimeZoneC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Requestor_TimeZone__c");
                entity.Property(e => e.ResponsiblePartyIdC)
                    .HasMaxLength(20)
                    .HasColumnName("Responsible_Party_Id__c");
                entity.Property(e => e.RohsOverrideC).HasColumnName("ROHS_Override__c");
                entity.Property(e => e.RohsProductNumberC)
                    .HasMaxLength(20)
                    .HasColumnName("ROHS_Product_Number__c");
                entity.Property(e => e.SbdDeferredC).HasColumnName("SBD_Deferred__c");
                entity.Property(e => e.SecurityStatusCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Security_Status_Code__c");
                entity.Property(e => e.SentInstructionsC)
                    .HasMaxLength(255)
                    .HasColumnName("Sent_Instructions__c");
                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);
                entity.Property(e => e.ServiceDeliveryTypeC)
                    .HasMaxLength(255)
                    .HasColumnName("Service_Delivery_Type__c");
                entity.Property(e => e.ServiceNotificationIdentifierC)
                    .HasMaxLength(12)
                    .HasColumnName("Service_Notification_Identifier__c");
                entity.Property(e => e.SfdccaseNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SFDCCaseNumber");
                entity.Property(e => e.SfdcpartOrderId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SFDCPartOrderID");
                entity.Property(e => e.SfdctaskNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SFDCTaskNumber");
                entity.Property(e => e.ShippingCarrierCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Shipping_Carrier_Code__c");
                entity.Property(e => e.ShippingConditionCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Shipping_Condition_Code__c");
                entity.Property(e => e.ShippingConditionUpgradeReasonCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Shipping_Condition_Upgrade_Reason_Code__c");
                entity.Property(e => e.SkuC)
                    .HasMaxLength(30)
                    .HasColumnName("SKU__c");
                entity.Property(e => e.SpecialDeliveryProcessCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Special_Delivery_Process_Code__c");
                entity.Property(e => e.StateC)
                    .HasMaxLength(30)
                    .HasColumnName("State__c");
                entity.Property(e => e.Street2C)
                    .HasMaxLength(150)
                    .HasColumnName("Street2__c");
                entity.Property(e => e.StreetC)
                    .HasMaxLength(150)
                    .HasColumnName("Street__c");
                entity.Property(e => e.SystemModstamp).HasColumnType("datetime");
                entity.Property(e => e.TriggerAutomaticPartsOrderingC).HasColumnName("Trigger_Automatic_Parts_Ordering__c");
                entity.Property(e => e.TriggerCsrPartsUsageC).HasColumnName("Trigger_CSR_Parts_Usage__c");
                entity.Property(e => e.TriggerImmediatePartsOrderingC).HasColumnName("Trigger_Immediate_Parts_Ordering__c");
                entity.Property(e => e.TrunkStockIndicatorC).HasColumnName("Trunk_Stock_Indicator__c");
                entity.Property(e => e.UpdateBadgeDestinationEngineerC)
                    .HasMaxLength(18)
                    .HasColumnName("Update_Badge_Destination_Engineer__c");
                entity.Property(e => e.UpdatedGmtTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_GMT_Timestamp");
                entity.Property(e => e.Updatedby).HasMaxLength(80);
                entity.Property(e => e.ZipPostalCodeC)
                    .HasMaxLength(50)
                    .HasColumnName("Zip_Postal_Code__c");
            });

            modelBuilder.Entity<BcpWorkOrder>(entity =>
            {
                entity.HasKey(e => e.BcpTaskIdC).HasName("PK__BCP_Work__AC0A10FA7D84AF52");

                entity.ToTable("BCP_WorkOrder");

                entity.Property(e => e.BcpTaskIdC)
                    .HasMaxLength(20)
                    .HasColumnName("BCP_Task_ID__c");
                entity.Property(e => e.AccessOnlyForHpEngineersFlagC).HasColumnName("Access_only_for_HP_engineers_flag__c");
                entity.Property(e => e.AccountId)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.AccountNameC)
                    .HasMaxLength(128)
                    .HasColumnName("Account_Name__c");
                entity.Property(e => e.ActionTypeC)
                    .HasColumnType("ntext")
                    .HasColumnName("Action_Type__c");
                entity.Property(e => e.AdditionalSiteAccessTimeSecC).HasColumnName("Additional_Site_Access_Time_Sec__c");
                entity.Property(e => e.AllSdiShortC)
                    .HasColumnType("ntext")
                    .HasColumnName("All_SDI_Short__c");
                entity.Property(e => e.AlternateContactEmailC)
                    .HasMaxLength(128)
                    .HasColumnName("Alternate_Contact_Email__c");
                entity.Property(e => e.AlternateContactFirstNameC)
                    .HasMaxLength(128)
                    .HasColumnName("Alternate_Contact_First_Name__c");
                entity.Property(e => e.AlternateContactLastNameC)
                    .HasMaxLength(128)
                    .HasColumnName("Alternate_Contact_Last_Name__c");
                entity.Property(e => e.AlternateContactMobileC)
                    .HasMaxLength(64)
                    .HasColumnName("Alternate_Contact_Mobile__c");
                entity.Property(e => e.AlternateContactNameC)
                    .HasMaxLength(128)
                    .HasColumnName("Alternate_Contact_Name__c");
                entity.Property(e => e.AlternateContactPhoneNumberC)
                    .HasMaxLength(64)
                    .HasColumnName("Alternate_Contact_Phone_Number__c");
                entity.Property(e => e.AlternativeContactC)
                    .HasMaxLength(255)
                    .HasColumnName("Alternative_Contact__c");
                entity.Property(e => e.AssetLocationDetailC)
                    .HasMaxLength(255)
                    .HasColumnName("Asset_Location_Detail__c");
                entity.Property(e => e.AssignedCe)
                    .HasMaxLength(255)
                    .HasColumnName("AssignedCE");
                entity.Property(e => e.AssignedCeemail)
                    .HasMaxLength(128)
                    .HasColumnName("AssignedCEEmail");
                entity.Property(e => e.AssignedPartnerC)
                    .HasMaxLength(255)
                    .HasColumnName("Assigned_Partner__c");
                entity.Property(e => e.AssignedPartnerName).HasMaxLength(200);
                entity.Property(e => e.AssignerCename)
                    .HasMaxLength(200)
                    .HasColumnName("AssignerCEName");
                entity.Property(e => e.BcpcaseId)
                    .HasMaxLength(80)
                    .HasColumnName("BCPCaseId");
                entity.Property(e => e.BcpoutageId).HasColumnName("BCPOutageID");
                entity.Property(e => e.BcpsyncDate)
                    .HasMaxLength(80)
                    .HasColumnName("BCPSyncDate");
                entity.Property(e => e.BcpsyncStatus)
                    .HasMaxLength(80)
                    .HasColumnName("BCPSyncStatus");
                entity.Property(e => e.BlackOutSitesFlagC).HasColumnName("Black_out_sites_flag__c");
                entity.Property(e => e.BusinessCenterC)
                    .HasMaxLength(255)
                    .HasColumnName("Business_Center__c");
                entity.Property(e => e.BusinessCenterName).HasMaxLength(200);
                entity.Property(e => e.CaseCountryTimezoneC)
                    .HasMaxLength(255)
                    .HasColumnName("Case_Country_Timezone__c");
                entity.Property(e => e.CaseCreatedUserFirstNameC)
                    .HasMaxLength(40)
                    .HasColumnName("Case_Created_User_First_Name__c");
                entity.Property(e => e.CaseCreatedUserLastNameC)
                    .HasMaxLength(60)
                    .HasColumnName("Case_Created_User_Last_Name__c");
                entity.Property(e => e.CaseCreationDateC)
                    .HasColumnType("datetime")
                    .HasColumnName("Case_Creation_Date__c");
                entity.Property(e => e.CaseExchangeIdentifierC)
                    .HasMaxLength(255)
                    .HasColumnName("Case_Exchange_Identifier__c");
                entity.Property(e => e.CaseExchangeProviderTaskAliasC)
                    .HasMaxLength(30)
                    .HasColumnName("Case_Exchange_Provider_Task_Alias__c");
                entity.Property(e => e.CaseExchangeStatusC)
                    .HasMaxLength(255)
                    .HasColumnName("Case_Exchange_Status__c");
                entity.Property(e => e.CaseId)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.CaseOwnerC)
                    .HasMaxLength(64)
                    .HasColumnName("Case_Owner__c");
                entity.Property(e => e.CaseQuoteC)
                    .HasMaxLength(255)
                    .HasColumnName("Case_Quote__c");
                entity.Property(e => e.CaseSeverityC)
                    .HasMaxLength(255)
                    .HasColumnName("Case_Severity__c");
                entity.Property(e => e.CaseSubscribedWesUsersC)
                    .HasMaxLength(255)
                    .HasColumnName("Case_Subscribed_WES_Users__c");
                entity.Property(e => e.CeCarLicensePlateC).HasColumnName("CE_Car_License_Plate__c");
                entity.Property(e => e.CeEmailAddressC).HasColumnName("CE_Email_Address__c");
                entity.Property(e => e.CeNameC).HasColumnName("CE_Name__c");
                entity.Property(e => e.CePhoneNumberC).HasColumnName("CE_Phone_Number__c");
                entity.Property(e => e.CephoneNumber)
                    .HasMaxLength(60)
                    .HasColumnName("CEPhoneNumber");
                entity.Property(e => e.City).HasMaxLength(128);
                entity.Property(e => e.CkswAssignedResourceC)
                    .HasMaxLength(255)
                    .HasColumnName("CKSW__Assigned_Resource__c");
                entity.Property(e => e.CkswAssignmentFinishC)
                    .HasColumnType("datetime")
                    .HasColumnName("CKSW__Assignment_Finish__c");
                entity.Property(e => e.CkswAssignmentStartC)
                    .HasColumnType("datetime")
                    .HasColumnName("CKSW__Assignment_Start__c");
                entity.Property(e => e.CkswCriticalC).HasColumnName("CKSW__Critical__c");
                entity.Property(e => e.CkswGeolocationLatitudeS).HasColumnName("CKSW__Geolocation__Latitude__s");
                entity.Property(e => e.CkswGeolocationLongitudeS).HasColumnName("CKSW__Geolocation__Longitude__s");
                entity.Property(e => e.CkswStatusC)
                    .HasMaxLength(255)
                    .HasColumnName("CKSW__Status__c");
                entity.Property(e => e.CleanTaskManualCheckedC).HasColumnName("CleanTaskManualChecked__c");
                entity.Property(e => e.CloseDateC)
                    .HasColumnType("datetime")
                    .HasColumnName("Close_Date__c");
                entity.Property(e => e.ClosingSummaryC)
                    .HasColumnType("ntext")
                    .HasColumnName("Closing_Summary__c");
                entity.Property(e => e.CommentsC)
                    .HasColumnType("ntext")
                    .HasColumnName("Comments__c");
                entity.Property(e => e.CompanyDepartmentC)
                    .HasMaxLength(128)
                    .HasColumnName("Company_Department__c");
                entity.Property(e => e.CompletionDateC)
                    .HasColumnType("datetime")
                    .HasColumnName("Completion_Date__c");
                entity.Property(e => e.Contact).HasMaxLength(255);
                entity.Property(e => e.ContactDateC)
                    .HasColumnType("datetime")
                    .HasColumnName("Contact_Date__c");
                entity.Property(e => e.ContactEmailC)
                    .HasMaxLength(255)
                    .HasColumnName("Contact_Email__c");
                entity.Property(e => e.ContactFirstNameC)
                    .HasMaxLength(128)
                    .HasColumnName("Contact_First_Name__c");
                entity.Property(e => e.ContactLastNameC)
                    .HasMaxLength(128)
                    .HasColumnName("Contact_Last_Name__c");
                entity.Property(e => e.ContactMobileC)
                    .HasMaxLength(64)
                    .HasColumnName("Contact_Mobile__c");
                entity.Property(e => e.ContactNameC)
                    .HasMaxLength(255)
                    .HasColumnName("Contact_Name__c");
                entity.Property(e => e.ContactPhoneNumberC)
                    .HasMaxLength(255)
                    .HasColumnName("ContactPhoneNumber__c");
                entity.Property(e => e.ContactPhoneNumberC1)
                    .HasMaxLength(64)
                    .HasColumnName("Contact_Phone_Number__c");
                entity.Property(e => e.ContractId).HasMaxLength(100);
                entity.Property(e => e.Country)
                    .HasMaxLength(80)
                    .HasColumnName("country");
                entity.Property(e => e.CourierAssistC).HasColumnName("Courier_Assist__c");
                entity.Property(e => e.CreatedById)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");
                entity.Property(e => e.CurrencyIsoCode).HasMaxLength(3);
                entity.Property(e => e.CustomerCaseIdC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Case_ID__c");
                entity.Property(e => e.CustomerDedicatedPartnerSelectCountC)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Customer_Dedicated_Partner_Select_Count__c");
                entity.Property(e => e.CustomerReferenceIdC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Reference_Id__c");
                entity.Property(e => e.CustomerRequestedEndDayC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Requested_End_Day__c");
                entity.Property(e => e.CustomerRequestedEndMonthC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Requested_End_Month__c");
                entity.Property(e => e.CustomerRequestedEndTimeC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Requested_End_Time__c");
                entity.Property(e => e.CustomerRequestedEndYearC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Requested_End_Year__c");
                entity.Property(e => e.CustomerRequestedStartDayC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Requested_Start_Day__c");
                entity.Property(e => e.CustomerRequestedStartMonthC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Requested_Start_Month__c");
                entity.Property(e => e.CustomerRequestedStartTimeC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Requested_Start_Time__c");
                entity.Property(e => e.CustomerRequestedStartYearC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Requested_Start_Year__c");
                entity.Property(e => e.CustomerServiceWindowEndDateTimeC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Service_Window_End_DateTime__c");
                entity.Property(e => e.CustomerServiceWindowStartDateTimeC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Service_Window_Start_DateTime__c");
                entity.Property(e => e.CustomerTimezoneC)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Timezone__c");
                entity.Property(e => e.CustomerTrackingNumberC)
                    .HasColumnType("ntext")
                    .HasColumnName("Customer_Tracking_Number__c");
                entity.Property(e => e.DelayCodeC)
                    .HasMaxLength(255)
                    .HasColumnName("Delay_Code__c");
                entity.Property(e => e.DelayRequestReasonC)
                    .HasMaxLength(255)
                    .HasColumnName("Delay_Request_Reason__c");
                entity.Property(e => e.DeliverableNameC)
                    .HasMaxLength(128)
                    .HasColumnName("Deliverable_Name__c");
                entity.Property(e => e.Description).HasColumnType("ntext");
                entity.Property(e => e.DiagnosisOwnByPspC).HasColumnName("Diagnosis_Own_by_PSP__c");
                entity.Property(e => e.DispatchContactC)
                    .HasMaxLength(100)
                    .HasColumnName("Dispatch_Contact__c");
                entity.Property(e => e.DispatchDateC)
                    .HasColumnType("datetime")
                    .HasColumnName("Dispatch_Date__c");
                entity.Property(e => e.DispatchEmailSentC).HasColumnName("Dispatch_Email_Sent__c");
                entity.Property(e => e.DispatchSdiShortC)
                    .HasColumnType("ntext")
                    .HasColumnName("Dispatch_SDI_Short__c");
                entity.Property(e => e.DispatchServiceDeliveryInstructionsC)
                    .HasColumnType("ntext")
                    .HasColumnName("Dispatch_Service_Delivery_Instructions__c");
                entity.Property(e => e.DistrictName).HasMaxLength(200);
                entity.Property(e => e.DistrictTimeZone).HasMaxLength(200);
                entity.Property(e => e.DriverLicenseNumberC).HasColumnName("Driver_License_Number__c");
                entity.Property(e => e.Duedate)
                    .HasColumnType("datetime")
                    .HasColumnName("duedate");
                entity.Property(e => e.EarliestStartTime).HasColumnType("datetime");
                entity.Property(e => e.EntitledServiceWindowEndDateTimeC)
                    .HasColumnType("datetime")
                    .HasColumnName("Entitled_ServiceWindowEndDateTime__c");
                entity.Property(e => e.EntitledServiceWindowEndDateTimeC1)
                    .HasMaxLength(255)
                    .HasColumnName("Entitled_Service_Window_End_DateTime__c");
                entity.Property(e => e.EntitledServiceWindowStartDateTimeC)
                    .HasColumnType("datetime")
                    .HasColumnName("Entitled_ServiceWindowStartDateTime__c");
                entity.Property(e => e.EntitledServiceWindowStartDateTimeC1)
                    .HasMaxLength(255)
                    .HasColumnName("Entitled_Service_Window_Start_DateTime__c");
                entity.Property(e => e.EntitlementMobileTextC)
                    .HasColumnType("ntext")
                    .HasColumnName("Entitlement_Mobile_Text__c");
                entity.Property(e => e.ExternalCaseIdC)
                    .HasMaxLength(128)
                    .HasColumnName("External_Case_ID__c");
                entity.Property(e => e.FinishDelayReasonC)
                    .HasMaxLength(64)
                    .HasColumnName("Finish_Delay_Reason__c");
                entity.Property(e => e.FirstTimeScheduleEmailSentC).HasColumnName("First_Time_Schedule_Email_Sent__c");
                entity.Property(e => e.GsdProjectTaskC)
                    .HasMaxLength(255)
                    .HasColumnName("GSD_Project_Task__c");
                entity.Property(e => e.GsemCaseAgentKeyC)
                    .HasMaxLength(255)
                    .HasColumnName("GSEM_Case_Agent_Key__c");
                entity.Property(e => e.GsemCaseAgentNameC)
                    .HasMaxLength(255)
                    .HasColumnName("GSEM_Case_Agent_Name__c");
                entity.Property(e => e.GsemSubKAgentKeyC)
                    .HasMaxLength(255)
                    .HasColumnName("GSEM_SubK_Agent_Key__c");
                entity.Property(e => e.GuaranteedFixTimeTextC)
                    .HasMaxLength(255)
                    .HasColumnName("Guaranteed_Fix_Time_Text__c");
                entity.Property(e => e.IgnorePartnerReasonC)
                    .HasMaxLength(255)
                    .HasColumnName("Ignore_Partner_Reason__c");
                entity.Property(e => e.IgnorePspC).HasColumnName("Ignore_PSP__c");
                entity.Property(e => e.InsertGmtTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("Insert_GMT_Timestamp");
                entity.Property(e => e.IsTaskAssignedInBcp)
                    .HasDefaultValue(false)
                    .HasColumnName("IsTaskAssignedInBCP");
                entity.Property(e => e.IsTaskAssignedInBcpC).HasColumnName("Is_Task_Assigned_In_BCP__c");
                entity.Property(e => e.IsWessrcC).HasColumnName("IsWESSrc__c");
                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
                entity.Property(e => e.LastModifiedById).HasMaxLength(18);
                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
                entity.Property(e => e.LastReferencedDate).HasColumnType("datetime");
                entity.Property(e => e.LastViewedDate).HasColumnType("datetime");
                entity.Property(e => e.LatestServiceDeliveryTimeTextC)
                    .HasMaxLength(255)
                    .HasColumnName("Latest_Service_Delivery_Time_Text__c");
                entity.Property(e => e.LeadDateToContactCustomerC).HasColumnName("Lead_Date_to_Contact_Customer__c");
                entity.Property(e => e.LeadNotesC)
                    .HasColumnType("ntext")
                    .HasColumnName("Lead_Notes__c");
                entity.Property(e => e.LogLeadC).HasColumnName("Log_Lead__c");
                entity.Property(e => e.MaintenanceWindowFlagC).HasColumnName("Maintenance_Window_Flag__c");
                entity.Property(e => e.ManualDispatchFlagC).HasColumnName("Manual_Dispatch_Flag__c");
                entity.Property(e => e.ManualDispatchReasonC)
                    .HasMaxLength(255)
                    .HasColumnName("Manual_Dispatch_Reason__c");
                entity.Property(e => e.ManualDispatchReasonNewC)
                    .HasMaxLength(255)
                    .HasColumnName("Manual_Dispatch_Reason_New__c");
                entity.Property(e => e.ManualTaskClosureC).HasColumnName("Manual_Task_Closure__c");
                entity.Property(e => e.MediaRetentionEligibilityC)
                    .HasMaxLength(255)
                    .HasColumnName("Media_Retention_Eligibility__c");
                entity.Property(e => e.ModifierNameC)
                    .HasMaxLength(128)
                    .HasColumnName("Modifier_Name__c");
                entity.Property(e => e.ModifierValueC)
                    .HasMaxLength(128)
                    .HasColumnName("Modifier_Value__c");
                entity.Property(e => e.Name).HasMaxLength(80);
                entity.Property(e => e.NotificationTimestampC)
                    .HasColumnType("datetime")
                    .HasColumnName("Notification_Timestamp__c");
                entity.Property(e => e.OnsiteActionC)
                    .HasColumnType("ntext")
                    .HasColumnName("Onsite_Action__c");
                entity.Property(e => e.OnsiteContactName).HasMaxLength(200);
                entity.Property(e => e.OnsiteDateC)
                    .HasColumnType("datetime")
                    .HasColumnName("Onsite_Date__c");
                entity.Property(e => e.OnsiteSdiShortC)
                    .HasColumnType("ntext")
                    .HasColumnName("Onsite_SDI_Short__c");
                entity.Property(e => e.OnsiteSupplierEngineerC)
                    .HasMaxLength(100)
                    .HasColumnName("Onsite_Supplier_Engineer__c");
                entity.Property(e => e.OpenDateC)
                    .HasColumnType("datetime")
                    .HasColumnName("OpenDate__c");
                entity.Property(e => e.OpenDateDateTimeC)
                    .HasMaxLength(255)
                    .HasColumnName("Open_Date_Date_Time__c");
                entity.Property(e => e.OpenDateJeopardyC)
                    .HasColumnType("datetime")
                    .HasColumnName("Open_date_Jeopardy__c");
                entity.Property(e => e.OpenDateTime24C)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Open_Date_Time_24__c");
                entity.Property(e => e.OpenDateTimeAmpmC)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Open_Date_Time_AMPM__c");
                entity.Property(e => e.OrderTypeCodeC)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Order_Type_Code__c");
                entity.Property(e => e.OrderTypeCodePrefixC)
                    .HasMaxLength(255)
                    .HasColumnName("Order_Type_Code_Prefix__c");
                entity.Property(e => e.OrganizationNameC)
                    .HasMaxLength(255)
                    .HasColumnName("Organization_Name__c");
                entity.Property(e => e.PartnerAssignmentReasonC)
                    .HasMaxLength(255)
                    .HasColumnName("Partner_Assignment_Reason__c");
                entity.Property(e => e.PartnerEmailC)
                    .HasMaxLength(80)
                    .HasColumnName("Partner_Email__c");
                entity.Property(e => e.PartnerRejectReasonC)
                    .HasMaxLength(255)
                    .HasColumnName("Partner_Reject_Reason__c");
                entity.Property(e => e.PartnerRejectedC).HasColumnName("Partner_Rejected__c");
                entity.Property(e => e.PartnerRescheduledReasonC)
                    .HasMaxLength(255)
                    .HasColumnName("Partner_Rescheduled_Reason__c");
                entity.Property(e => e.PartnerSelectedC).HasColumnName("Partner_Selected__c");
                entity.Property(e => e.PartnerSelectionCountC).HasColumnName("Partner_Selection_Count__c");
                entity.Property(e => e.PartsRequestPendingC).HasColumnName("Parts_Request_Pending__c");
                entity.Property(e => e.PostalcodeC)
                    .HasMaxLength(255)
                    .HasColumnName("postalcode__c");
                entity.Property(e => e.Priority).HasMaxLength(255);
                entity.Property(e => e.ProblemDescriptionC)
                    .HasColumnType("ntext")
                    .HasColumnName("Problem_Description__c");
                entity.Property(e => e.ProductDescriptionC)
                    .HasColumnType("ntext")
                    .HasColumnName("Product_Description__c");
                entity.Property(e => e.ProductNumberC)
                    .HasColumnType("ntext")
                    .HasColumnName("Product_Number__c");
                entity.Property(e => e.ProductSeriesC)
                    .HasMaxLength(20)
                    .HasColumnName("Product_Series__c");
                entity.Property(e => e.ProjectIdC)
                    .HasMaxLength(255)
                    .HasColumnName("Project_ID__c");
                entity.Property(e => e.PspId).HasMaxLength(50);
                entity.Property(e => e.RecordTypeId)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.RegionC)
                    .HasMaxLength(255)
                    .HasColumnName("Region__c");
                entity.Property(e => e.RegionName).HasMaxLength(200);
                entity.Property(e => e.RepairClassC)
                    .HasMaxLength(255)
                    .HasColumnName("Repair_Class__c");
                entity.Property(e => e.RepairComplexityC)
                    .HasMaxLength(255)
                    .HasColumnName("Repair_Complexity__c");
                entity.Property(e => e.RequestedServiceWindowEndDateTimeC)
                    .HasColumnType("datetime")
                    .HasColumnName("Requested_Service_Window_End_DateTime__c");
                entity.Property(e => e.RequestedServiceWindowStartDateTimeC)
                    .HasColumnType("datetime")
                    .HasColumnName("Requested_Service_Window_Start_DateTime__c");
                entity.Property(e => e.RescheduleManualDispatchC).HasColumnName("Reschedule_Manual_Dispatch__c");
                entity.Property(e => e.RescheduleNotesC)
                    .HasColumnType("ntext")
                    .HasColumnName("Reschedule_Notes__c");
                entity.Property(e => e.Resident24x7C).HasColumnName("Resident_24x7__c");
                entity.Property(e => e.ResidentLocationC).HasColumnName("Resident_Location__c");
                entity.Property(e => e.ResolutionCodeC)
                    .HasMaxLength(20)
                    .HasColumnName("Resolution_Code__c");
                entity.Property(e => e.RevisitManualDispatchC).HasColumnName("Revisit_Manual_Dispatch__c");
                entity.Property(e => e.RevisitOnlyMeC).HasColumnName("Revisit_Only_Me__c");
                entity.Property(e => e.SendNotifToC)
                    .HasMaxLength(255)
                    .HasColumnName("SendNotifTo__c");
                entity.Property(e => e.SerialNumberC)
                    .HasColumnType("ntext")
                    .HasColumnName("Serial_Number__c");
                entity.Property(e => e.ServiceDeliveryInstructionsC)
                    .HasColumnType("ntext")
                    .HasColumnName("Service_Delivery_Instructions__c");
                entity.Property(e => e.ServiceDeliveryLocationC)
                    .HasMaxLength(255)
                    .HasColumnName("Service_Delivery_Location__c");
                entity.Property(e => e.ServiceDeliveryLocationName).HasMaxLength(200);
                entity.Property(e => e.ServiceLocationIdC)
                    .HasMaxLength(255)
                    .HasColumnName("Service_Location_ID__c");
                entity.Property(e => e.ServiceNoteC)
                    .HasColumnType("ntext")
                    .HasColumnName("Service_Note__c");
                entity.Property(e => e.ServiceTerritory)
                    .HasMaxLength(18)
                    .IsUnicode(false);
                entity.Property(e => e.ServiceWindowEndC)
                    .HasColumnType("datetime")
                    .HasColumnName("Service_Window_End__c");
                entity.Property(e => e.ServiceWindowStartC)
                    .HasColumnType("datetime")
                    .HasColumnName("Service_Window_Start__c");
                entity.Property(e => e.SiteAccessCodeC).HasColumnName("Site_Access_Code__c");
                entity.Property(e => e.SiteAccessContactC)
                    .HasMaxLength(255)
                    .HasColumnName("Site_Access_Contact__c");
                entity.Property(e => e.SiteAccessDetailsOthersC)
                    .HasColumnType("ntext")
                    .HasColumnName("Site_Access_Details_Others__c");
                entity.Property(e => e.SiteAccessInstructionsC)
                    .HasMaxLength(255)
                    .HasColumnName("Site_Access_Instructions__c");
                entity.Property(e => e.SiteAccessPermanentChangeC).HasColumnName("Site_Access_Permanent_Change__c");
                entity.Property(e => e.SiteAccessRequiredC)
                    .HasMaxLength(255)
                    .HasColumnName("Site_Access_Required__c");
                entity.Property(e => e.SiteIdC)
                    .HasColumnType("ntext")
                    .HasColumnName("SiteID__c");
                entity.Property(e => e.SpecialAccessOnsiteResourcesC).HasColumnName("Special_Access_Onsite_Resources__c");
                entity.Property(e => e.SpecialAccessTimeMinC)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("Special_Access_Time_min__c");
                entity.Property(e => e.SpecialLaborChargeC)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("Special_Labor_Charge__c");
                entity.Property(e => e.StartDelayReasonC)
                    .HasMaxLength(64)
                    .HasColumnName("Start_Delay_Reason__c");
                entity.Property(e => e.State).HasMaxLength(40);
                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");
                entity.Property(e => e.StatusIconC)
                    .HasMaxLength(255)
                    .HasColumnName("status_Icon__c");
                entity.Property(e => e.Statuscategory)
                    .HasMaxLength(255)
                    .HasColumnName("statuscategory");
                entity.Property(e => e.Street).HasMaxLength(255);
                entity.Property(e => e.StreetC)
                    .HasMaxLength(255)
                    .HasColumnName("Street__c");
                entity.Property(e => e.StreetLine2)
                    .HasMaxLength(255)
                    .HasColumnName("Street_Line2");
                entity.Property(e => e.StreetLine3)
                    .HasMaxLength(510)
                    .HasColumnName("Street_Line3");
                entity.Property(e => e.SupplierResidentEngineerC).HasColumnName("Supplier_Resident_Engineer__c");
                entity.Property(e => e.SystemDownDurationC)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("System_Down_Duration__c");
                entity.Property(e => e.SystemFixTimeC)
                    .HasColumnType("datetime")
                    .HasColumnName("System_Fix_Time__c");
                entity.Property(e => e.SystemModstamp).HasColumnType("datetime");
                entity.Property(e => e.SystemSerialNumberC).HasColumnName("System_Serial_Number__c");
                entity.Property(e => e.TaskIdC)
                    .HasMaxLength(255)
                    .HasColumnName("Task_ID__c");
                entity.Property(e => e.TravelZoneC)
                    .HasMaxLength(255)
                    .HasColumnName("Travel_Zone__c");
                entity.Property(e => e.TriggerPartsUsageForOnsiteOrdersC).HasColumnName("Trigger_Parts_Usage_For_Onsite_Orders__c");
                entity.Property(e => e.TypeC)
                    .HasMaxLength(255)
                    .HasColumnName("Type__c");
                entity.Property(e => e.UpdatedGmtTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_GMT_Timestamp");
                entity.Property(e => e.WorkOrderId)
                    .HasMaxLength(255)
                    .HasColumnName("WorkOrder_ID");
                entity.Property(e => e.WorkTypeId)
                    .HasMaxLength(255)
                    .HasColumnName("WorkType_ID");
            });

        }
    }
}
