﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_fieldservicepricelistitemOptionSets
{
	public enum msdyn_DurationRoundingPolicy
	{
		/// <summary>
		/// Down = 690970002
		/// </summary>
		Down = 690970002,
		/// <summary>
		/// Nearest = 690970003
		/// </summary>
		Nearest = 690970003,
		/// <summary>
		/// None = 690970000
		/// </summary>
		None = 690970000,
		/// <summary>
		/// Up = 690970001
		/// </summary>
		Up = 690970001
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
	public partial class msdyn_fieldservicepricelistitem : EntityBase
	{
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msdyn_DurationRoundingPolicy = "msdyn_durationroundingpolicy";
			public const string msdyn_DurationRoundTo = "msdyn_durationroundto";
			public const string msdyn_fieldservicepricelistitemId = "msdyn_fieldservicepricelistitemid";
			public const string msdyn_FlatFee = "msdyn_flatfee";
			public const string msdyn_MinimumChargeAmount = "msdyn_minimumchargeamount";
			public const string msdyn_minimumchargeamount_Base = "msdyn_minimumchargeamount_base";
			public const string msdyn_MinimumChargeDuration = "msdyn_minimumchargeduration";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_PriceList = "msdyn_pricelist";
			public const string msdyn_ProductService = "msdyn_productservice";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "msdyn_fieldservicepricelistitem";

		public const int EntityTypeCode = 10431;

		[DebuggerNonUserCode()]
		public msdyn_fieldservicepricelistitem()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_fieldservicepricelistitem(Guid msdyn_fieldservicepricelistitemId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_fieldservicepricelistitemId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_fieldservicepricelistitem(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_fieldservicepricelistitem(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_fieldservicepricelistitem(Entity entity, Entity merge)
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
		public msdyn_fieldservicepricelistitem(KeyAttributeCollection keys)
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
		/// <para>Shows the exchange rate for the currency associated with the entity with respect to the base currency.</para>
		/// <para>ReadOnly - Decimal - MinValue: 0 - MaxValue: 100,000,000,000</para>
		/// <para>Exchange Rate</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? ExchangeRate
		{
			get { return Entity.GetAttributeValue<decimal?>(Fields.ExchangeRate); }
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
		/// <para>Specify how the system should round the Duration To Bill on the Work Order Service</para>
		/// <para>Picklist</para>
		/// <para>Duration Rounding Policy</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_fieldservicepricelistitemOptionSets.msdyn_DurationRoundingPolicy? msdyn_DurationRoundingPolicy
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_DurationRoundingPolicy);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_fieldservicepricelistitemOptionSets.msdyn_DurationRoundingPolicy)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_DurationRoundingPolicy] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyn_DurationRoundingPolicy] = null;
			}
		}

		/// <summary>
		/// <para>Specify the rounding duration.</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Duration Round To</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_DurationRoundTo
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_DurationRoundTo); }
			set { Entity.Attributes[Fields.msdyn_DurationRoundTo] = value; }
		}

		/// <summary>
		/// <para>Shows the entity instances.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Field Service Price List Item</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_fieldservicepricelistitemId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_fieldservicepricelistitemId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>If enabled then the pricing of this item will not be multiplied by quantity</para>
		/// <para>Required - Boolean</para>
		/// <para>Flat Fee</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_FlatFee
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_FlatFee); }
			set { Entity.Attributes[Fields.msdyn_FlatFee] = value; }
		}

		/// <summary>
		/// <para>Specify the minimum charge you wish to charge for this service. See note on Minimum Charge Duration</para>
		/// <para>Money - MinValue: 0 - MaxValue: 1,000,000,000</para>
		/// <para>Minimum Charge Amount</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_MinimumChargeAmount
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_MinimumChargeAmount);
				if (value == null) return null;
				return value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_MinimumChargeAmount] = new Money(value.Value);
				else
					Entity.Attributes[Fields.msdyn_MinimumChargeAmount] = null;
			}
		}

		/// <summary>
		/// <para>Shows the value of the minimum charge amount in the base currency.</para>
		/// <para>ReadOnly - Money - MinValue: -922,337,203,685,477 - MaxValue: 922,337,203,685,477</para>
		/// <para>Minimum Charge Amount (Base)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_minimumchargeamount_Base
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_minimumchargeamount_Base);
				if (value == null) return null;
				return value.Value;
			}
		}

		/// <summary>
		/// <para>If this field has a value, the Minimum Charge Amount will first apply to the Minimum Duration and beyond the minimum duration the regular fee will apply</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Minimum Charge Duration</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_MinimumChargeDuration
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_MinimumChargeDuration); }
			set { Entity.Attributes[Fields.msdyn_MinimumChargeDuration] = value; }
		}

		/// <summary>
		/// <para>Enter the name of the custom entity.</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_name); }
			set { Entity.Attributes[Fields.msdyn_name] = value; }
		}

		/// <summary>
		/// <para>Shows the price list associated with the field service price list item.</para>
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
		/// <para>If you wish to limit this price list item to a certain product or service you can specify it. Otherwise this should be left blank</para>
		/// <para>Lookup to product</para>
		/// <para>Product / Service</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_ProductService
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_ProductService); }
			set { Entity.Attributes[Fields.msdyn_ProductService] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for the organization</para>
		/// <para>ReadOnly - Lookup to organization</para>
		/// <para>Organization Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OrganizationId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OrganizationId); }
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
		/// <para>Status of the Field Service Price List Item</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_fieldservicepricelistitemOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_fieldservicepricelistitemOptionSets.statecode)value.Value;
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
		/// <para>Shows the reason for the status of the field service price list item.</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_fieldservicepricelistitemOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_fieldservicepricelistitemOptionSets.statuscode)value.Value;
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
		/// <para>Unique identifier of the currency associated with the entity.</para>
		/// <para>Lookup to transactioncurrency</para>
		/// <para>Currency</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference TransactionCurrencyId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.TransactionCurrencyId); }
			set { Entity.Attributes[Fields.TransactionCurrencyId] = value; }
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
