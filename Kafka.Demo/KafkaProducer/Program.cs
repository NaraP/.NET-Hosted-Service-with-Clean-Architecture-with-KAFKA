using Confluent.Kafka;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092",
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        // Add all kafka topics here if you use testing in local
        var topics = new[]
            {
            "workorder-topic",
            "partorder-topic"
            };

        Console.WriteLine("Producing messages...");

        int counter = 0;

        while (true)
        {
            foreach (var topic in topics)
            {
                var message = GetJsonDummy();

                await producer.ProduceAsync(topic, new Message<Null, string>
                {
                    Value = message
                });

                Console.WriteLine($"Sent: {message}");
            }

            counter++;
            await Task.Delay(1000);
        }
    }

    private static string GetJsonDummy()
    {
        return @"
        [
          {
            ""id"": 1001,
            ""ownerId"": ""0058Z00ABCQ"",
            ""isDeleted"": false,
            ""name"": ""PO-2026-0001"",
            ""currencyIsoCode"": ""USD"",
            ""recordTypeId"": ""0128Z0000XYZ"",
            ""createdDate"": ""2026-05-19T10:15:30Z"",
            ""createdById"": ""000001CREATOR"",
            ""lastModifiedDate"": ""2026-05-19T12:00:00Z"",
            ""lastModifiedById"": ""0058Z000001MER"",
            ""systemModstamp"": ""2026-05-19T12:00:00Z"",
            ""lastActivityDate"": ""2026-05-19T13:00:00Z"",
            ""lastViewedDate"": ""2026-05-19T14:00:00Z"",
            ""lastReferencedDate"": ""2026-05-19T15:00:00Z"",
            ""addressTypeCodeC"": ""Business"",
            ""advisoryNoteIdentifierC"": ""ADV-1001"",
            ""cityC"": ""Hyderabad"",
            ""companyNameC"": ""Contoso Pvt Ltd"",
            ""contactFirstNameC"": ""John"",
            ""contactLastNameC"": ""Doe"",
            ""contactPhoneC"": ""+91-9876543210"",
            ""countryC"": ""India"",
            ""deliveryPriorityCodeC"": ""HIGH"",
            ""iso2CharacterCountryCodeC"": ""IN"",
            ""latitudeC"": 17.3850,
            ""legacyPartOrderNumberC"": ""LEG-PO-1001"",
            ""locationLatitudeS"": 17.3850,
            ""locationLongitudeS"": 78.4867,
            ""logisticOrderIdentifierC"": ""LOG-1001"",
            ""longitudeC"": 78.4867,
            ""orderEstimatedArrivalTimeStampC"": ""2026-05-20T09:00:00Z"",
            ""orderReasonCodeC"": ""Replacement"",
            ""orderStatusCodeC"": ""Open"",
            ""orderTypeCodeIdentifierC"": ""Emergency"",
            ""partDeliveryRequestedTimeStampC"": ""2026-05-20T08:00:00Z"",
            ""partOrderIdentifierC"": ""PART-ORD-9988"",
            ""partOrderTypeCodeC"": ""Hardware"",
            ""partPickupLocationC"": ""Warehouse-A"",
            ""pickPackInstructionsC"": ""Handle with care"",
            ""pickupTaskC"": ""PICKUP-001"",
            ""preferredLangugeCodeC"": ""EN"",
            ""receivedInstructionsC"": ""Deliver before noon"",
            ""repairTaskC"": ""REPAIR-001"",
            ""responsiblePartyIdC"": ""RESP-001"",
            ""securityStatusCodeC"": ""SECURE"",
            ""sentInstructionsC"": ""Call before delivery"",
            ""serviceNotificationIdentifierC"": ""SN-1001"",
            ""shippingCarrierCodeC"": ""DHL"",
            ""shippingConditionCodeC"": ""NORMAL"",
            ""shippingConditionUpgradeReasonCodeC"": ""Critical outage"",
            ""specialDeliveryProcessCodeC"": ""EXPRESS"",
            ""stateC"": ""Telangana"",
            ""street2C"": ""Madhapur"",
            ""streetC"": ""Hitech City Road"",
            ""trunkStockIndicatorC"": true,
            ""zipPostalCodeC"": ""500081"",
            ""availabilityCheckCompleteC"": true,
            ""serviceDeliveryTypeC"": ""Onsite"",
            ""pendingTransactionTypeC"": ""NONE"",
            ""messageC"": ""Order created successfully"",
            ""messageTypeC"": ""INFO"",
            ""orderPlacedInBcpC"": true,
            ""caseNumberC"": ""CASE-445566"",
            ""skuC"": ""SKU-998877"",
            ""anyPartLineInJeopardyStatusC"": false,
            ""calculatedArrivalTimeStampC"": ""2026-05-20T10:00:00Z"",
            ""partTransferDestinationTaskC"": ""TRANSFER-001"",
            ""updateBadgeDestinationEngineerC"": ""ENG-001"",
            ""sbdDeferredC"": false,
            ""crsIdC"": ""CRS-1001"",
            ""mediaRetentionEligibilityC"": ""Eligible"",
            ""privateC"": false,
            ""dualDispatchC"": true,
            ""insertGmtTimestamp"": ""2026-05-19T10:15:30Z"",
            ""createdby"": ""system-user"",
            ""updatedGmtTimestamp"": ""2026-05-19T12:00:00Z"",
            ""updatedby"": ""admin-user"",
            ""badgeC"": ""BDG-001"",
            ""partsUsageLoggingCompleteC"": true,
            ""contactEmailC"": ""john.doe@example.com"",
            ""triggerAutomaticPartsOrderingC"": true,
            ""triggerImmediatePartsOrderingC"": false,
            ""partLineCountC"": 5,
            ""countOfOpenPartLinesC"": 2,
            ""contactNameC"": ""John Doe"",
            ""countOfJeapodyPartLinesC"": 0,
            ""triggerCsrPartsUsageC"": false,
            ""countOfNonPodPartLinesC"": 1,
            ""rohsProductNumberC"": ""ROHS-001"",
            ""rohsOverrideC"": false,
            ""isRevisitOrderC"": false,
            ""missionCriticalC"": true,
            ""coverageResponseC"": ""Covered"",
            ""entitlementSlaResponseC"": ""4 Hours"",
            ""requestorTimeZoneC"": ""Asia/Kolkata"",
            ""modifierName"": ""Priority"",
            ""modifierValue"": ""Critical"",
            ""serialNumber"": ""SN123456789"",
            ""productNumber"": ""PRD-001122"",
            ""bcppartOrderId"": ""BCP-PO-000123"",
            ""bcpcaseNumber"": ""BCP-CASE"",
            ""bcptaskId"": ""BCP-TASK-1001"",
            ""outageId"": 5001,
            ""region"": ""APAC"",
            ""expoPartOrderNumber"": ""EXPO-9988"",
            ""cename"": ""Ravi Kumar"",
            ""ceemail"": ""ravi.kumar@example.com"",
            ""sfdcpartOrderId"": ""SFDC-PO-7788"",
            ""sfdccaseNumber"": ""SFDC-CASE-1122"",
            ""sfdctaskNumber"": ""SFDC-TASK-7788"",
            ""cephoneNumber"": ""+91-9000011111""
          }
        ]
        ";
    }
}