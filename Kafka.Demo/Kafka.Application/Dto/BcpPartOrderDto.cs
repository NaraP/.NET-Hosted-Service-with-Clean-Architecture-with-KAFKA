namespace Kafka.Application.Dto
{
    public class BcpPartOrderDto
    {
        public int Id { get; set; }

        public string? OwnerId { get; set; }

        public bool? IsDeleted { get; set; }

        public string? Name { get; set; }

        public string? CurrencyIsoCode { get; set; }

        public string? RecordTypeId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedById { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public string? LastModifiedById { get; set; }

        public DateTime? SystemModstamp { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public DateTime? LastViewedDate { get; set; }

        public DateTime? LastReferencedDate { get; set; }

        public string? AddressTypeCodeC { get; set; }

        public string? AdvisoryNoteIdentifierC { get; set; }

        public string? CityC { get; set; }

        public string? CompanyNameC { get; set; }

        public string? ContactFirstNameC { get; set; }

        public string? ContactLastNameC { get; set; }

        public string? ContactPhoneC { get; set; }

        public string? CountryC { get; set; }

        public string? DeliveryPriorityCodeC { get; set; }

        public string? Iso2CharacterCountryCodeC { get; set; }

        public double? LatitudeC { get; set; }

        public string? LegacyPartOrderNumberC { get; set; }

        public double? LocationLatitudeS { get; set; }

        public double? LocationLongitudeS { get; set; }

        public string? LogisticOrderIdentifierC { get; set; }

        public double? LongitudeC { get; set; }

        public DateTime? OrderEstimatedArrivalTimeStampC { get; set; }

        public string? OrderReasonCodeC { get; set; }

        public string? OrderStatusCodeC { get; set; }

        public string? OrderTypeCodeIdentifierC { get; set; }

        public DateTime? PartDeliveryRequestedTimeStampC { get; set; }

        public string? PartOrderIdentifierC { get; set; }

        public string? PartOrderTypeCodeC { get; set; }

        public string? PartPickupLocationC { get; set; }

        public string? PickPackInstructionsC { get; set; }

        public string? PickupTaskC { get; set; }

        public string? PreferredLangugeCodeC { get; set; }

        public string? ReceivedInstructionsC { get; set; }

        public string? RepairTaskC { get; set; }

        public string? ResponsiblePartyIdC { get; set; }

        public string? SecurityStatusCodeC { get; set; }

        public string? SentInstructionsC { get; set; }

        public string? ServiceNotificationIdentifierC { get; set; }

        public string? ShippingCarrierCodeC { get; set; }

        public string? ShippingConditionCodeC { get; set; }

        public string? ShippingConditionUpgradeReasonCodeC { get; set; }

        public string? SpecialDeliveryProcessCodeC { get; set; }

        public string? StateC { get; set; }

        public string? Street2C { get; set; }

        public string? StreetC { get; set; }

        public bool? TrunkStockIndicatorC { get; set; }

        public string? ZipPostalCodeC { get; set; }

        public bool? AvailabilityCheckCompleteC { get; set; }

        public string? ServiceDeliveryTypeC { get; set; }

        public string? PendingTransactionTypeC { get; set; }

        public string? MessageC { get; set; }

        public string? MessageTypeC { get; set; }

        public bool? OrderPlacedInBcpC { get; set; }

        public string? CaseNumberC { get; set; }

        public string? SkuC { get; set; }

        public bool? AnyPartLineInJeopardyStatusC { get; set; }

        public DateTime? CalculatedArrivalTimeStampC { get; set; }

        public string? PartTransferDestinationTaskC { get; set; }

        public string? UpdateBadgeDestinationEngineerC { get; set; }

        public bool? SbdDeferredC { get; set; }

        public string? CrsIdC { get; set; }

        public string? MediaRetentionEligibilityC { get; set; }

        public bool? PrivateC { get; set; }

        public bool? DualDispatchC { get; set; }

        public DateTime? InsertGmtTimestamp { get; set; }

        public string? Createdby { get; set; }

        public DateTime? UpdatedGmtTimestamp { get; set; }

        public string? Updatedby { get; set; }

        public string? BadgeC { get; set; }

        public bool? PartsUsageLoggingCompleteC { get; set; }

        public string? ContactEmailC { get; set; }

        public bool? TriggerAutomaticPartsOrderingC { get; set; }

        public bool? TriggerImmediatePartsOrderingC { get; set; }

        public int? PartLineCountC { get; set; }

        public int? CountOfOpenPartLinesC { get; set; }

        public string? ContactNameC { get; set; }

        public double? CountOfJeapodyPartLinesC { get; set; }

        public bool? TriggerCsrPartsUsageC { get; set; }

        public int? CountOfNonPodPartLinesC { get; set; }

        public string? RohsProductNumberC { get; set; }

        public bool? RohsOverrideC { get; set; }

        public bool? IsRevisitOrderC { get; set; }

        public bool? MissionCriticalC { get; set; }

        public string? CoverageResponseC { get; set; }

        public string? EntitlementSlaResponseC { get; set; }

        public string? RequestorTimeZoneC { get; set; }

        public string? ModifierName { get; set; }

        public string? ModifierValue { get; set; }

        public string? SerialNumber { get; set; }

        public string? ProductNumber { get; set; }

        public string BcppartOrderId { get; set; } = null!;

        public string? BcpcaseNumber { get; set; }

        public string? BcptaskId { get; set; }

        public int OutageId { get; set; }

        public string? Region { get; set; }

        public string? ExpoPartOrderNumber { get; set; }

        public string? Cename { get; set; }

        public string? Ceemail { get; set; }

        public string? SfdcpartOrderId { get; set; }

        public string? SfdccaseNumber { get; set; }

        public string? SfdctaskNumber { get; set; }

        public string? CephoneNumber { get; set; }
    }
}
