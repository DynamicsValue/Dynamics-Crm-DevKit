﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_agreementOptionSets
{
	public enum msdyn_SystemStatus
	{
		/// <summary>
		/// Active = 690970001
		/// </summary>
		Active = 690970001,
		/// <summary>
		/// Canceled = 690970003
		/// </summary>
		Canceled = 690970003,
		/// <summary>
		/// Estimate = 690970000
		/// </summary>
		Estimate = 690970000,
		/// <summary>
		/// Expired = 690970002
		/// </summary>
		Expired = 690970002
	}

	public enum statecode
	{
		/// <summary>
		/// Active = 0
		/// </summary>
		Active = 0,
		/// <summary>
		/// Inactive = 1
		/// </summary>
		Inactive = 1
	}

	public enum statuscode
	{
		/// <summary>
		/// Active = 1
		/// </summary>
		Active = 1,
		/// <summary>
		/// Inactive = 2
		/// </summary>
		Inactive = 2
	}
}

namespace Dev.DevKit.Shared.Entities
{
	public partial class msdyn_agreement : EntityBase
	{
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msdyn_AgreementDetails = "msdyn_agreementdetails";
			public const string msdyn_agreementId = "msdyn_agreementid";
			public const string msdyn_AgreementRecordGeneration = "msdyn_agreementrecordgeneration";
			public const string msdyn_AutoNumbering = "msdyn_autonumbering";
			public const string msdyn_BillingAccount = "msdyn_billingaccount";
			public const string msdyn_ChildIndex = "msdyn_childindex";
			public const string msdyn_DateCanceled = "msdyn_datecanceled";
			public const string msdyn_Description = "msdyn_description";
			public const string msdyn_Duration = "msdyn_duration";
			public const string msdyn_EndDate = "msdyn_enddate";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_OriginatingAgreement = "msdyn_originatingagreement";
			public const string msdyn_PriceList = "msdyn_pricelist";
			public const string msdyn_ProcessStartedOn = "msdyn_processstartedon";
			public const string msdyn_SalesTaxCode = "msdyn_salestaxcode";
			public const string msdyn_ServiceAccount = "msdyn_serviceaccount";
			public const string msdyn_ServiceTerritory = "msdyn_serviceterritory";
			public const string msdyn_StartDate = "msdyn_startdate";
			public const string msdyn_SubStatus = "msdyn_substatus";
			public const string msdyn_SystemStatus = "msdyn_systemstatus";
			public const string msdyn_Taxable = "msdyn_taxable";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string processid = "processid";
			public const string stageid = "stageid";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string traversedpath = "traversedpath";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "msdyn_agreement";

		[System.Obsolete("This value is different for each instance. Please don't use it.")]
		public const int EntityTypeCode = 10477;

		[DebuggerNonUserCode()]
		public msdyn_agreement()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_agreement(Guid msdyn_agreementId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_agreementId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_agreement(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_agreement(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_agreement(Entity entity, Entity merge)
		{
			Entity = entity;
			foreach (var property in merge?.Attributes)
			{
				var key = property.Key;
				var value = property.Value;
				Entity[key] = value;
			}
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_agreement(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Shows who created the record on behalf of another user.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Shows the sequence number of the import that created this record.</para>
		/// <para>Integer - MinValue: -2,147,483,648 - MaxValue: 2,147,483,647</para>
		/// <para>Import Sequence Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? ImportSequenceNumber
		{
			get { return Entity.GetAttributeValue<int?>(Fields.ImportSequenceNumber); }
			set { Entity.Attributes[Fields.ImportSequenceNumber] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user who modified the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Shows who last updated the record on behalf of another user.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Shows the details of this agreement, as presented to the customer</para>
		/// <para>Memo - MaxLength: 100000</para>
		/// <para>Agreement Details</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_AgreementDetails
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_AgreementDetails); }
			set { Entity.Attributes[Fields.msdyn_AgreementDetails] = value; }
		}

		/// <summary>
		/// <para>Shows the entity instances.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Agreement</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_agreementId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_agreementId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>This field defines the time of day when Work Orders and Invoices are generated by the Agreement Booking Setups and Agreement Invoice Setups defined on this Agreement. If this field is blank, the logic will look to the overall setting on the Field Service Settings record.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Agreement Record Generation</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_AgreementRecordGenerationUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_AgreementRecordGeneration); }
			set { Entity.Attributes[Fields.msdyn_AgreementRecordGeneration] = value; }
		}

		/// <summary>
		/// <para>Internal field used to generate the next name upon entity creation. It is optionally copied to the msdyn_name field.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Auto-Numbering</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_AutoNumbering
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_AutoNumbering); }
			set { Entity.Attributes[Fields.msdyn_AutoNumbering] = value; }
		}

		/// <summary>
		/// <para>Account to be billed. If a billing account has been set on service account it will be populated by default. Otherwise, the billing account will be the same as the service account.</para>
		/// <para>Lookup to account</para>
		/// <para>Billing Account</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_BillingAccount
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_BillingAccount); }
			set { Entity.Attributes[Fields.msdyn_BillingAccount] = value; }
		}

		/// <summary>
		/// <para>Integer - MinValue: -2,147,483,648 - MaxValue: 2,147,483,647</para>
		/// <para>Child Index</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_ChildIndex
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_ChildIndex); }
			set { Entity.Attributes[Fields.msdyn_ChildIndex] = value; }
		}

		/// <summary>
		/// <para>Enter the date this agreement was canceled.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Date Canceled</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_DateCanceledUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_DateCanceled); }
			set { Entity.Attributes[Fields.msdyn_DateCanceled] = value; }
		}

		/// <summary>
		/// <para>Type a description of the agreement.</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Description</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Description
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Description); }
			set { Entity.Attributes[Fields.msdyn_Description] = value; }
		}

		/// <summary>
		/// <para>Shows the duration how long this agreement is active.</para>
		/// <para>Required - Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Duration</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_Duration
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_Duration); }
			set { Entity.Attributes[Fields.msdyn_Duration] = value; }
		}

		/// <summary>
		/// <para>Enter the date when this agreement is no longer active.</para>
		/// <para>Required - DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>End Date</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_EndDateUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_EndDate); }
			set { Entity.Attributes[Fields.msdyn_EndDate] = value; }
		}

		/// <summary>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>Agreement Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_name); }
			set { Entity.Attributes[Fields.msdyn_name] = value; }
		}

		/// <summary>
		/// <para>If this agreement originates from another agreement, you should specify the originating agreement here</para>
		/// <para>Lookup to msdyn_agreement</para>
		/// <para>Originating Agreement</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_OriginatingAgreement
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_OriginatingAgreement); }
			set { Entity.Attributes[Fields.msdyn_OriginatingAgreement] = value; }
		}

		/// <summary>
		/// <para>Price List that controls pricing for products added to this Agreement. By default the system will use the Price List specified on the account</para>
		/// <para>Required - Lookup to pricelevel</para>
		/// <para>Price List</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_PriceList
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_PriceList); }
			set { Entity.Attributes[Fields.msdyn_PriceList] = value; }
		}

		/// <summary>
		/// <para>For internal use only</para>
		/// <para>DateTimeBehavior: TimeZoneIndependent - DateTimeFormat: DateAndTime</para>
		/// <para>Process Started On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_ProcessStartedOn
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_ProcessStartedOn); }
			set { Entity.Attributes[Fields.msdyn_ProcessStartedOn] = value; }
		}

		/// <summary>
		/// <para>Tax Code to be used to calculate tax when Agreement is taxable. By default the system will use the tax code specified on the service account</para>
		/// <para>Lookup to msdyn_taxcode</para>
		/// <para>Sales Tax Code</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_SalesTaxCode
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_SalesTaxCode); }
			set { Entity.Attributes[Fields.msdyn_SalesTaxCode] = value; }
		}

		/// <summary>
		/// <para>Account to be serviced</para>
		/// <para>Required - Lookup to account</para>
		/// <para>Service Account</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_ServiceAccount
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_ServiceAccount); }
			set { Entity.Attributes[Fields.msdyn_ServiceAccount] = value; }
		}

		/// <summary>
		/// <para>The service territory this Agreement relates to. By default this will be set to the Service Territory defined on the service account</para>
		/// <para>Lookup to territory</para>
		/// <para>Service Territory</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_ServiceTerritory
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_ServiceTerritory); }
			set { Entity.Attributes[Fields.msdyn_ServiceTerritory] = value; }
		}

		/// <summary>
		/// <para>Enter the date from when this agreement is active.</para>
		/// <para>Required - DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Start Date</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_StartDateUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_StartDate); }
			set { Entity.Attributes[Fields.msdyn_StartDate] = value; }
		}

		/// <summary>
		/// <para>Agreement Substatus</para>
		/// <para>Lookup to msdyn_agreementsubstatus</para>
		/// <para>Substatus</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_SubStatus
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_SubStatus); }
			set { Entity.Attributes[Fields.msdyn_SubStatus] = value; }
		}

		/// <summary>
		/// <para>Tracks the current system status.</para>
		/// <para>Required - Picklist</para>
		/// <para>System Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_agreementOptionSets.msdyn_SystemStatus? msdyn_SystemStatus
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_SystemStatus);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_agreementOptionSets.msdyn_SystemStatus)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_SystemStatus] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyn_SystemStatus] = null;
			}
		}

		/// <summary>
		/// <para>Specify if Agreement is taxable. By default an Agreement is taxable if billing account is not tax exempt, and Agreement type is taxable. If any of the above is false it will be set to non-taxable.</para>
		/// <para>Required - Boolean</para>
		/// <para>Taxable</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_Taxable
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_Taxable); }
			set { Entity.Attributes[Fields.msdyn_Taxable] = value; }
		}

		/// <summary>
		/// <para>Shows the date and time that the record was migrated.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Record Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? OverriddenCreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.OverriddenCreatedOn); }
			set { Entity.Attributes[Fields.OverriddenCreatedOn] = value; }
		}

		/// <summary>
		/// <para>Owner Id</para>
		/// <para>Lookup to systemuser, team</para>
		/// <para>Owner</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwnerId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwnerId); }
			set { Entity.Attributes[Fields.OwnerId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for the business unit that owns the record</para>
		/// <para>ReadOnly - Lookup to businessunit</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier for the team that owns the record.</para>
		/// <para>ReadOnly - Lookup to team</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier for the user that owns the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>Contains the ID of the process associated with the entity.</para>
		/// <para>Uniqueidentifier</para>
		/// <para>Process Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? processid
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.processid); }
			set { Entity.Attributes[Fields.processid] = value; }
		}

		/// <summary>
		/// <para>Contains the ID of the stage where the entity is located.</para>
		/// <para>Uniqueidentifier</para>
		/// <para>Stage Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? stageid
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.stageid); }
			set { Entity.Attributes[Fields.stageid] = value; }
		}

		/// <summary>
		/// <para>Status of the Agreement</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_agreementOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_agreementOptionSets.statecode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.statecode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.statecode] = null;
			}
		}

		/// <summary>
		/// <para>Reason for the status of the Agreement</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_agreementOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_agreementOptionSets.statuscode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.statuscode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.statuscode] = null;
			}
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>Integer - MinValue: -1 - MaxValue: 2,147,483,647</para>
		/// <para>Time Zone Rule Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? TimeZoneRuleVersionNumber
		{
			get { return Entity.GetAttributeValue<int?>(Fields.TimeZoneRuleVersionNumber); }
			set { Entity.Attributes[Fields.TimeZoneRuleVersionNumber] = value; }
		}

		/// <summary>
		/// <para>Shows a comma-separated list of string values that represent the unique identifiers of stages in a business process flow instance in the order that they occur.</para>
		/// <para>String - MaxLength: 1250</para>
		/// <para>Traversed Path</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string traversedpath
		{
			get { return Entity.GetAttributeValue<string>(Fields.traversedpath); }
			set { Entity.Attributes[Fields.traversedpath] = value; }
		}

		/// <summary>
		/// <para>Shows the time zone code that was in use when the record was created.</para>
		/// <para>Integer - MinValue: -1 - MaxValue: 2,147,483,647</para>
		/// <para>UTC Conversion Time Zone Code</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? UTCConversionTimeZoneCode
		{
			get { return Entity.GetAttributeValue<int?>(Fields.UTCConversionTimeZoneCode); }
			set { Entity.Attributes[Fields.UTCConversionTimeZoneCode] = value; }
		}

		/// <summary>
		/// <para>Version Number</para>
		/// <para>ReadOnly - BigInt</para>
		/// <para>Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? VersionNumber
		{
			get { return Entity.GetAttributeValue<long?>(Fields.VersionNumber); }
		}
	}
}