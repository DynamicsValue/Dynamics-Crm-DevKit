﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets
{
	public enum msdyn_SystemStatus
	{
		/// <summary>
		/// Canceled = 690970005
		/// </summary>
		Canceled = 690970005,
		/// <summary>
		/// Completed = 690970004
		/// </summary>
		Completed = 690970004,
		/// <summary>
		/// In_Progress = 690970003
		/// </summary>
		In_Progress = 690970003,
		/// <summary>
		/// On_Break = 690970002
		/// </summary>
		On_Break = 690970002,
		/// <summary>
		/// Scheduled = 690970000
		/// </summary>
		Scheduled = 690970000,
		/// <summary>
		/// Traveling = 690970001
		/// </summary>
		Traveling = 690970001
	}

	public enum msdyn_TimestampSource
	{
		/// <summary>
		/// Desktop = 690970000
		/// </summary>
		Desktop = 690970000,
		/// <summary>
		/// Mobile = 690970001
		/// </summary>
		Mobile = 690970001
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
	public partial class msdyn_bookingtimestamp : EntityBase
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
			public const string msdyn_Booking = "msdyn_booking";
			public const string msdyn_BookingStatus = "msdyn_bookingstatus";
			public const string msdyn_bookingtimestampId = "msdyn_bookingtimestampid";
			public const string msdyn_GenerateJournals = "msdyn_generatejournals";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_SystemStatus = "msdyn_systemstatus";
			public const string msdyn_TimestampSource = "msdyn_timestampsource";
			public const string msdyn_TimestampTime = "msdyn_timestamptime";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "msdyn_bookingtimestamp";

		public const int EntityTypeCode = 10425;

		[DebuggerNonUserCode()]
		public msdyn_bookingtimestamp()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_bookingtimestamp(Guid msdyn_bookingtimestampId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_bookingtimestampId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_bookingtimestamp(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_bookingtimestamp(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_bookingtimestamp(Entity entity, Entity merge)
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
		public msdyn_bookingtimestamp(KeyAttributeCollection keys)
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
		/// <para>Unique identifier for Resource Booking associated with Booking Timestamp.</para>
		/// <para>Required - Lookup to bookableresourcebooking</para>
		/// <para>Booking</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_Booking
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_Booking); }
			set { Entity.Attributes[Fields.msdyn_Booking] = value; }
		}

		/// <summary>
		/// <para>Booking Status of the booking</para>
		/// <para>Lookup to bookingstatus</para>
		/// <para>Booking Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_BookingStatus
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_BookingStatus); }
			set { Entity.Attributes[Fields.msdyn_BookingStatus] = value; }
		}

		/// <summary>
		/// <para>Shows the entity instances.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Booking Timestamp</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_bookingtimestampId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_bookingtimestampId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>System internal field. Indicates that journals must be generated after saving timestamp from mobile.</para>
		/// <para>Boolean</para>
		/// <para>Generate Journals</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_GenerateJournals
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_GenerateJournals); }
			set { Entity.Attributes[Fields.msdyn_GenerateJournals] = value; }
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
		/// <para>Required - Picklist</para>
		/// <para>System Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets.msdyn_SystemStatus? msdyn_SystemStatus
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_SystemStatus);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets.msdyn_SystemStatus)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyn_SystemStatus] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Picklist</para>
		/// <para>Timestamp Source</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets.msdyn_TimestampSource? msdyn_TimestampSource
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_TimestampSource);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets.msdyn_TimestampSource)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_TimestampSource] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyn_TimestampSource] = null;
			}
		}

		/// <summary>
		/// <para>Required - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Timestamp Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_TimestampTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_TimestampTime); }
			set { Entity.Attributes[Fields.msdyn_TimestampTime] = value; }
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
		/// <para>Status of the Booking Timestamp</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the Booking Timestamp</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_bookingtimestampOptionSets.statuscode)value.Value;
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