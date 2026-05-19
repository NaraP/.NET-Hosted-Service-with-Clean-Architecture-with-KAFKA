using System;
using System.Collections.Generic;

namespace Kafka.Domain.Entities;

public partial class BcpWorkOrder
{
    public bool? IsDeleted { get; set; }

    public string? Name { get; set; }

    public string? CurrencyIsoCode { get; set; }

    public string? LastModifiedById { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public DateTime? LastActivityDate { get; set; }

    public DateTime? SystemModstamp { get; set; }

    public string? BcpsyncStatus { get; set; }

    public string? BcpsyncDate { get; set; }

    public string? RegionName { get; set; }

    public string? DistrictName { get; set; }

    public string? DistrictTimeZone { get; set; }

    public string? AssignerCename { get; set; }

    public string? AssignedPartnerName { get; set; }

    public string? ServiceDeliveryLocationName { get; set; }

    public string? BusinessCenterName { get; set; }

    public string? OnsiteContactName { get; set; }

    public int? BcpoutageId { get; set; }

    public string? BcpcaseId { get; set; }

    public string? AssignedCeemail { get; set; }

    public string? PspId { get; set; }

    public string? ContractId { get; set; }

    public string? CephoneNumber { get; set; }

    public DateTime? InsertGmtTimestamp { get; set; }

    public DateTime? UpdatedGmtTimestamp { get; set; }

    public bool? BlackOutSitesFlagC { get; set; }

    public double? CkswGeolocationLatitudeS { get; set; }

    public double? CkswGeolocationLongitudeS { get; set; }

    public DateTime? LastReferencedDate { get; set; }

    public DateTime? LastViewedDate { get; set; }

    public bool? RevisitOnlyMeC { get; set; }

    public string? AccountId { get; set; }

    public string? AccountNameC { get; set; }

    public string? ActionTypeC { get; set; }

    public string? StreetC { get; set; }

    public string? AllSdiShortC { get; set; }

    public string? AlternateContactEmailC { get; set; }

    public string? AlternateContactFirstNameC { get; set; }

    public string? AlternateContactLastNameC { get; set; }

    public string? AlternateContactMobileC { get; set; }

    public string? AlternateContactNameC { get; set; }

    public string? AlternateContactPhoneNumberC { get; set; }

    public string? AlternativeContactC { get; set; }

    public string? AssetLocationDetailC { get; set; }

    public string? AssignedPartnerC { get; set; }

    public string BcpTaskIdC { get; set; } = null!;

    public string? BusinessCenterC { get; set; }

    public string? CaseCountryTimezoneC { get; set; }

    public string? CaseCreatedUserFirstNameC { get; set; }

    public string? CaseCreatedUserLastNameC { get; set; }

    public DateTime? CaseCreationDateC { get; set; }

    public string? CaseExchangeIdentifierC { get; set; }

    public string? CaseExchangeProviderTaskAliasC { get; set; }

    public string? CaseExchangeStatusC { get; set; }

    public string? CaseId { get; set; }

    public string? CaseOwnerC { get; set; }

    public string? CaseQuoteC { get; set; }

    public string? CaseSeverityC { get; set; }

    public string? CaseSubscribedWesUsersC { get; set; }

    public bool? CeCarLicensePlateC { get; set; }

    public bool? DriverLicenseNumberC { get; set; }

    public bool? CeEmailAddressC { get; set; }

    public bool? CeNameC { get; set; }

    public bool? CePhoneNumberC { get; set; }

    public string? City { get; set; }

    public bool? CleanTaskManualCheckedC { get; set; }

    public DateTime? CloseDateC { get; set; }

    public string? ClosingSummaryC { get; set; }

    public string? CompanyDepartmentC { get; set; }

    public DateTime? CompletionDateC { get; set; }

    public DateTime? ContactDateC { get; set; }

    public string? ContactEmailC { get; set; }

    public string? ContactFirstNameC { get; set; }

    public string? ContactLastNameC { get; set; }

    public string? ContactMobileC { get; set; }

    public string? ContactNameC { get; set; }

    public string? ContactPhoneNumberC { get; set; }

    public string? ContactPhoneNumberC1 { get; set; }

    public string? Country { get; set; }

    public bool? CourierAssistC { get; set; }

    public string? Status { get; set; }

    public string? CustomerCaseIdC { get; set; }

    public decimal? CustomerDedicatedPartnerSelectCountC { get; set; }

    public string? CustomerReferenceIdC { get; set; }

    public string? CustomerTrackingNumberC { get; set; }

    public string? CustomerRequestedEndDayC { get; set; }

    public string? CustomerRequestedEndMonthC { get; set; }

    public string? CustomerRequestedEndTimeC { get; set; }

    public string? CustomerRequestedEndYearC { get; set; }

    public string? CustomerRequestedStartDayC { get; set; }

    public string? CustomerRequestedStartMonthC { get; set; }

    public string? CustomerRequestedStartTimeC { get; set; }

    public string? CustomerRequestedStartYearC { get; set; }

    public string? CustomerServiceWindowEndDateTimeC { get; set; }

    public string? CustomerServiceWindowStartDateTimeC { get; set; }

    public string? CustomerTimezoneC { get; set; }

    public double? Duration { get; set; }

    public string? DelayCodeC { get; set; }

    public string? DelayRequestReasonC { get; set; }

    public string? DeliverableNameC { get; set; }

    public bool? DiagnosisOwnByPspC { get; set; }

    public string? DispatchContactC { get; set; }

    public DateTime? DispatchDateC { get; set; }

    public bool? DispatchEmailSentC { get; set; }

    public string? DispatchSdiShortC { get; set; }

    public string? DispatchServiceDeliveryInstructionsC { get; set; }

    public string? ServiceTerritory { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? EarliestStartTime { get; set; }

    public DateTime? EntitledServiceWindowEndDateTimeC { get; set; }

    public string? EntitledServiceWindowEndDateTimeC1 { get; set; }

    public DateTime? EntitledServiceWindowStartDateTimeC { get; set; }

    public string? EntitledServiceWindowStartDateTimeC1 { get; set; }

    public string? EntitlementMobileTextC { get; set; }

    public string? ExternalCaseIdC { get; set; }

    public string? FinishDelayReasonC { get; set; }

    public bool? FirstTimeScheduleEmailSentC { get; set; }

    public string? GsemCaseAgentKeyC { get; set; }

    public string? GsemCaseAgentNameC { get; set; }

    public string? GsemSubKAgentKeyC { get; set; }

    public string? GuaranteedFixTimeTextC { get; set; }

    public string? CommentsC { get; set; }

    public string? IgnorePartnerReasonC { get; set; }

    public bool? IgnorePspC { get; set; }

    public bool? IsTaskAssignedInBcpC { get; set; }

    public bool? IsWessrcC { get; set; }

    public string? LatestServiceDeliveryTimeTextC { get; set; }

    public DateOnly? LeadDateToContactCustomerC { get; set; }

    public string? LeadNotesC { get; set; }

    public bool? LogLeadC { get; set; }

    public bool? MaintenanceWindowFlagC { get; set; }

    public bool? ManualDispatchFlagC { get; set; }

    public string? ManualDispatchReasonNewC { get; set; }

    public string? ManualDispatchReasonC { get; set; }

    public bool? ManualTaskClosureC { get; set; }

    public string? MediaRetentionEligibilityC { get; set; }

    public string? ModifierNameC { get; set; }

    public string? ModifierValueC { get; set; }

    public DateTime? NotificationTimestampC { get; set; }

    public string? OnsiteActionC { get; set; }

    public string? Contact { get; set; }

    public DateTime? OnsiteDateC { get; set; }

    public string? OnsiteSdiShortC { get; set; }

    public string? OnsiteSupplierEngineerC { get; set; }

    public DateTime? OpenDateJeopardyC { get; set; }

    public string? OpenDateDateTimeC { get; set; }

    public DateTime? OpenDateC { get; set; }

    public string? OpenDateTime24C { get; set; }

    public string? OpenDateTimeAmpmC { get; set; }

    public string? OrderTypeCodeC { get; set; }

    public string? OrderTypeCodePrefixC { get; set; }

    public string? OrganizationNameC { get; set; }

    public string? PartnerAssignmentReasonC { get; set; }

    public string? PartnerEmailC { get; set; }

    public bool? PartnerRejectedC { get; set; }

    public string? PartnerRejectReasonC { get; set; }

    public string? PartnerRescheduledReasonC { get; set; }

    public bool? PartnerSelectedC { get; set; }

    public int? PartnerSelectionCountC { get; set; }

    public bool? PartsRequestPendingC { get; set; }

    public string? ProblemDescriptionC { get; set; }

    public string? ProductDescriptionC { get; set; }

    public string? ProductNumberC { get; set; }

    public string? ProductSeriesC { get; set; }

    public string? ProjectIdC { get; set; }

    public string? GsdProjectTaskC { get; set; }

    public string? RegionC { get; set; }

    public string? RepairClassC { get; set; }

    public string? RepairComplexityC { get; set; }

    public DateTime? RequestedServiceWindowEndDateTimeC { get; set; }

    public DateTime? RequestedServiceWindowStartDateTimeC { get; set; }

    public bool? RescheduleManualDispatchC { get; set; }

    public string? RescheduleNotesC { get; set; }

    public bool? Resident24x7C { get; set; }

    public bool? ResidentLocationC { get; set; }

    public string? ResolutionCodeC { get; set; }

    public bool? RevisitManualDispatchC { get; set; }

    public bool? AccessOnlyForHpEngineersFlagC { get; set; }

    public string? CkswStatusC { get; set; }

    public string? SendNotifToC { get; set; }

    public string? SerialNumberC { get; set; }

    public string? ServiceDeliveryInstructionsC { get; set; }

    public string? ServiceDeliveryLocationC { get; set; }

    public string? ServiceLocationIdC { get; set; }

    public string? ServiceNoteC { get; set; }

    public DateTime? ServiceWindowEndC { get; set; }

    public DateTime? ServiceWindowStartC { get; set; }

    public string? Priority { get; set; }

    public bool? SiteAccessCodeC { get; set; }

    public string? SiteAccessContactC { get; set; }

    public string? SiteAccessDetailsOthersC { get; set; }

    public string? SiteAccessInstructionsC { get; set; }

    public bool? SiteAccessPermanentChangeC { get; set; }

    public string? SiteAccessRequiredC { get; set; }

    public string? SiteIdC { get; set; }

    public bool? SpecialAccessOnsiteResourcesC { get; set; }

    public decimal? SpecialAccessTimeMinC { get; set; }

    public int? AdditionalSiteAccessTimeSecC { get; set; }

    public decimal? SpecialLaborChargeC { get; set; }

    public string? Statuscategory { get; set; }

    public string? StartDelayReasonC { get; set; }

    public string? State { get; set; }

    public string? StatusIconC { get; set; }

    public string? Street { get; set; }

    public bool? SupplierResidentEngineerC { get; set; }

    public decimal? SystemDownDurationC { get; set; }

    public DateTime? SystemFixTimeC { get; set; }

    public string? SystemSerialNumberC { get; set; }

    public string? TaskIdC { get; set; }

    public string? WorkTypeId { get; set; }

    public string? Description { get; set; }

    public string? TravelZoneC { get; set; }

    public bool? TriggerPartsUsageForOnsiteOrdersC { get; set; }

    public string? PostalcodeC { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedById { get; set; }

    public string? RecordTypeId { get; set; }

    public string? TypeC { get; set; }

    public DateTime? CkswAssignmentStartC { get; set; }

    public bool? CkswCriticalC { get; set; }

    public string? StreetLine2 { get; set; }

    public string? WorkOrderId { get; set; }

    public string? AssignedCe { get; set; }

    public bool? IsFsmEnabled { get; set; }

    public string? CkswAssignedResourceC { get; set; }

    public DateTime? CkswAssignmentFinishC { get; set; }

    public bool IsWorkOrderSubmitFlag { get; set; }

    public bool? IsTaskAssignedInBcp { get; set; }

    public string? StreetLine3 { get; set; }
}
