﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets
{
	public enum msdyn_HigherTotalCost
	{
		/// <summary>
		/// No = 0
		/// </summary>
		No = 0,
		/// <summary>
		/// Yes = 1
		/// </summary>
		Yes = 1
	}

	public enum msdyn_HigherWorkOrderCount
	{
		/// <summary>
		/// No = 0
		/// </summary>
		No = 0,
		/// <summary>
		/// Yes = 1
		/// </summary>
		Yes = 1
	}

	public enum msdyn_NumberofDays
	{
		/// <summary>
		/// _0 = 192350000
		/// </summary>
		_0 = 192350000,
		/// <summary>
		/// _15 = 192350001
		/// </summary>
		_15 = 192350001,
		/// <summary>
		/// _30 = 192350002
		/// </summary>
		_30 = 192350002,
		/// <summary>
		/// _60 = 192350003
		/// </summary>
		_60 = 192350003,
		/// <summary>
		/// _90 = 192350004
		/// </summary>
		_90 = 192350004
	}

	public enum msdyn_Suggestion
	{
		/// <summary>
		/// None = 192350002
		/// </summary>
		None = 192350002,
		/// <summary>
		/// Repair = 192350000
		/// </summary>
		Repair = 192350000,
		/// <summary>
		/// Replace = 192350001
		/// </summary>
		Replace = 192350001
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
	public partial class msdyn_problematicasset : EntityBase
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
			public const string msdyn_Asset = "msdyn_asset";
			public const string msdyn_AssetId = "msdyn_assetid";
			public const string msdyn_BreakfixCost = "msdyn_breakfixcost";
			public const string msdyn_breakfixcost_Base = "msdyn_breakfixcost_base";
			public const string msdyn_BreakfixSale = "msdyn_breakfixsale";
			public const string msdyn_breakfixsale_Base = "msdyn_breakfixsale_base";
			public const string msdyn_BreakfixWorkOrderCount = "msdyn_breakfixworkordercount";
			public const string msdyn_Confidence = "msdyn_confidence";
			public const string msdyn_HigherTotalCost = "msdyn_highertotalcost";
			public const string msdyn_HigherWorkOrderCount = "msdyn_higherworkordercount";
			public const string msdyn_MaintenanceCost = "msdyn_maintenancecost";
			public const string msdyn_maintenancecost_Base = "msdyn_maintenancecost_base";
			public const string msdyn_MaintenanceSale = "msdyn_maintenancesale";
			public const string msdyn_maintenancesale_Base = "msdyn_maintenancesale_base";
			public const string msdyn_MaintenanceWorkOrderCount = "msdyn_maintenanceworkordercount";
			public const string msdyn_Name = "msdyn_name";
			public const string msdyn_NumberofDays = "msdyn_numberofdays";
			public const string msdyn_problematicassetId = "msdyn_problematicassetid";
			public const string msdyn_ReplacementCost = "msdyn_replacementcost";
			public const string msdyn_replacementcost_Base = "msdyn_replacementcost_base";
			public const string msdyn_ReplacementSale = "msdyn_replacementsale";
			public const string msdyn_replacementsale_Base = "msdyn_replacementsale_base";
			public const string msdyn_RunId = "msdyn_runid";
			public const string msdyn_Score = "msdyn_score";
			public const string msdyn_Suggestion = "msdyn_suggestion";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "msdyn_problematicasset";

		public const int EntityTypeCode = 10506;

		[DebuggerNonUserCode()]
		public msdyn_problematicasset()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_problematicasset(Guid msdyn_problematicassetId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_problematicassetId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_problematicasset(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_problematicasset(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_problematicasset(Entity entity, Entity merge)
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
		public msdyn_problematicasset(KeyAttributeCollection keys)
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
		/// <para>Date and time when the record was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Exchange rate for the currency associated with the entity with respect to the base currency.</para>
		/// <para>ReadOnly - Decimal - MinValue: 0 - MaxValue: 100,000,000,000</para>
		/// <para>Exchange Rate</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? ExchangeRate
		{
			get { return Entity.GetAttributeValue<decimal?>(Fields.ExchangeRate); }
		}

		/// <summary>
		/// <para>Sequence number of the import that created this record.</para>
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
		/// <para>Date and time when the record was modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who modified the record.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Lookup field for customer asset</para>
		/// <para>Lookup to msdyn_customerasset</para>
		/// <para>Asset</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_Asset
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_Asset); }
			set { Entity.Attributes[Fields.msdyn_Asset] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of customer asset</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>Asset Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_AssetId
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_AssetId); }
			set { Entity.Attributes[Fields.msdyn_AssetId] = value; }
		}

		/// <summary>
		/// <para>Value of breakfix cost for customer asset</para>
		/// <para>Required - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Breakfix Cost</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_BreakfixCost
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_BreakfixCost);
				if (value == null) return null;
				return value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_BreakfixCost] = new Money(value.Value);
				else
					Entity.Attributes[Fields.msdyn_BreakfixCost] = null;
			}
		}

		/// <summary>
		/// <para>Value of the Breakfix Cost in base currency.</para>
		/// <para>ReadOnly - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Breakfix Cost (Base)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_breakfixcost_Base
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_breakfixcost_Base);
				if (value == null) return null;
				return value.Value;
			}
		}

		/// <summary>
		/// <para>Value of breakfix sale of customer asset</para>
		/// <para>Required - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Breakfix Sale</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_BreakfixSale
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_BreakfixSale);
				if (value == null) return null;
				return value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_BreakfixSale] = new Money(value.Value);
				else
					Entity.Attributes[Fields.msdyn_BreakfixSale] = null;
			}
		}

		/// <summary>
		/// <para>Value of the Breakfix Sale in base currency.</para>
		/// <para>ReadOnly - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Breakfix Sale (Base)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_breakfixsale_Base
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_breakfixsale_Base);
				if (value == null) return null;
				return value.Value;
			}
		}

		/// <summary>
		/// <para>Expected break/fix work order count for customer asset</para>
		/// <para>Required - Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Expected Break/fix Work Order Count</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_BreakfixWorkOrderCount
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_BreakfixWorkOrderCount); }
			set { Entity.Attributes[Fields.msdyn_BreakfixWorkOrderCount] = value; }
		}

		/// <summary>
		/// <para>Probability of predicting customer asset to be problematic in current date</para>
		/// <para>Double - MinValue: 0 - MaxValue: 1</para>
		/// <para>Confidence</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public double? msdyn_Confidence
		{
			get { return Entity.GetAttributeValue<double?>(Fields.msdyn_Confidence); }
			set { Entity.Attributes[Fields.msdyn_Confidence] = value; }
		}

		/// <summary>
		/// <para>Flag value indicating if customer asset has higher total cost than similar assets or not</para>
		/// <para>Required - Picklist</para>
		/// <para>Higher Total Cost?</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.msdyn_HigherTotalCost? msdyn_HigherTotalCost
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_HigherTotalCost);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.msdyn_HigherTotalCost)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyn_HigherTotalCost] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Flag value indicating if customer asset work order count is higher than similar assets or not</para>
		/// <para>Required - Picklist</para>
		/// <para>Higher Work Order Count?</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.msdyn_HigherWorkOrderCount? msdyn_HigherWorkOrderCount
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_HigherWorkOrderCount);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.msdyn_HigherWorkOrderCount)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyn_HigherWorkOrderCount] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Value of maintenance cost of customer asset</para>
		/// <para>Required - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Maintenance Cost</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_MaintenanceCost
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_MaintenanceCost);
				if (value == null) return null;
				return value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_MaintenanceCost] = new Money(value.Value);
				else
					Entity.Attributes[Fields.msdyn_MaintenanceCost] = null;
			}
		}

		/// <summary>
		/// <para>Value of the Maintenance Cost in base currency.</para>
		/// <para>ReadOnly - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Maintenance Cost (Base)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_maintenancecost_Base
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_maintenancecost_Base);
				if (value == null) return null;
				return value.Value;
			}
		}

		/// <summary>
		/// <para>Value of maintenance sale of customer asset</para>
		/// <para>Required - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Maintenance Sale</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_MaintenanceSale
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_MaintenanceSale);
				if (value == null) return null;
				return value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_MaintenanceSale] = new Money(value.Value);
				else
					Entity.Attributes[Fields.msdyn_MaintenanceSale] = null;
			}
		}

		/// <summary>
		/// <para>Value of the Maintenance Sale in base currency.</para>
		/// <para>ReadOnly - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Maintenance Sale (Base)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_maintenancesale_Base
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_maintenancesale_Base);
				if (value == null) return null;
				return value.Value;
			}
		}

		/// <summary>
		/// <para>Expected maintenance work order count from model output</para>
		/// <para>Required - Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Expected Maintenance Work Order Count</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_MaintenanceWorkOrderCount
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_MaintenanceWorkOrderCount); }
			set { Entity.Attributes[Fields.msdyn_MaintenanceWorkOrderCount] = value; }
		}

		/// <summary>
		/// <para>The name of the custom entity.</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Name); }
			set { Entity.Attributes[Fields.msdyn_Name] = value; }
		}

		/// <summary>
		/// <para>The option set value indicating how many days the record is preficted from current</para>
		/// <para>Required - Picklist</para>
		/// <para>Number Of Days</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.msdyn_NumberofDays? msdyn_NumberofDays
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_NumberofDays);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.msdyn_NumberofDays)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyn_NumberofDays] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Problematic Asset</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_problematicassetId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_problematicassetId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Value of replacement cost of customer asset</para>
		/// <para>Required - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Replacement Cost</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_ReplacementCost
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_ReplacementCost);
				if (value == null) return null;
				return value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_ReplacementCost] = new Money(value.Value);
				else
					Entity.Attributes[Fields.msdyn_ReplacementCost] = null;
			}
		}

		/// <summary>
		/// <para>Value of the Replacement Cost in base currency.</para>
		/// <para>ReadOnly - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Replacement Cost (Base)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_replacementcost_Base
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_replacementcost_Base);
				if (value == null) return null;
				return value.Value;
			}
		}

		/// <summary>
		/// <para>Value of replacement sale of customer asset</para>
		/// <para>Required - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Replacement Sale</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_ReplacementSale
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_ReplacementSale);
				if (value == null) return null;
				return value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_ReplacementSale] = new Money(value.Value);
				else
					Entity.Attributes[Fields.msdyn_ReplacementSale] = null;
			}
		}

		/// <summary>
		/// <para>Value of the Replacement Sale in base currency.</para>
		/// <para>ReadOnly - Money - MinValue: 0 - MaxValue: 922,337,203,685,477</para>
		/// <para>Replacement Sale (Base)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? msdyn_replacementsale_Base
		{
			get
			{
				var value = Entity.GetAttributeValue<Money>(Fields.msdyn_replacementsale_Base);
				if (value == null) return null;
				return value.Value;
			}
		}

		/// <summary>
		/// <para>Unique identifier of model run id</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Run Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_RunId
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_RunId); }
			set { Entity.Attributes[Fields.msdyn_RunId] = value; }
		}

		/// <summary>
		/// <para>Probability of customer asset to be problematic asset</para>
		/// <para>Required - Double - MinValue: 0 - MaxValue: 1</para>
		/// <para>Score</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public double? msdyn_Score
		{
			get { return Entity.GetAttributeValue<double?>(Fields.msdyn_Score); }
			set { Entity.Attributes[Fields.msdyn_Score] = value; }
		}

		/// <summary>
		/// <para>Optionset value of suggestions for customer asset</para>
		/// <para>Required - Picklist</para>
		/// <para>Suggestion</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.msdyn_Suggestion? msdyn_Suggestion
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_Suggestion);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.msdyn_Suggestion)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyn_Suggestion] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Date and time that the record was migrated.</para>
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
		/// <para>Owner</para>
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
		/// <para>Status of the Problematic Asset</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the Problematic Asset</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_problematicassetOptionSets.statuscode)value.Value;
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
		/// <para>Time zone code that was in use when the record was created.</para>
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