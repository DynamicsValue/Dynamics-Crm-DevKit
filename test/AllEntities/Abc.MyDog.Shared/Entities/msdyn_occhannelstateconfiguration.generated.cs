﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.MyDog.Shared.Entities.msdyn_occhannelstateconfigurationOptionSets
{
	public enum msdyn_ocliveworkitemstate
	{
		/// <summary>
		/// Active = 1
		/// </summary>
		Active = 1,
		/// <summary>
		/// Closed = 3
		/// </summary>
		Closed = 3,
		/// <summary>
		/// Open = 0
		/// </summary>
		Open = 0,
		/// <summary>
		/// Waiting = 2
		/// </summary>
		Waiting = 2,
		/// <summary>
		/// Wrap_up = 4
		/// </summary>
		Wrap_up = 4
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

namespace Abc.MyDog.Shared.Entities
{
	public partial class msdyn_occhannelstateconfiguration : EntityBase
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
			public const string msdyn_autocloseliveworkitemafter = "msdyn_autocloseliveworkitemafter";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_occhannelconfigurationid = "msdyn_occhannelconfigurationid";
			public const string msdyn_occhannelstateconfigurationId = "msdyn_occhannelstateconfigurationid";
			public const string msdyn_ocliveworkitemstate = "msdyn_ocliveworkitemstate";
			public const string msdyn_showconfirmationonsessionclose = "msdyn_showconfirmationonsessionclose";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "msdyn_occhannelstateconfiguration";

		public const int EntityTypeCode = 10479;

		[DebuggerNonUserCode()]
		public msdyn_occhannelstateconfiguration()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_occhannelstateconfiguration(Guid msdyn_occhannelstateconfigurationId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_occhannelstateconfigurationId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_occhannelstateconfiguration(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_occhannelstateconfiguration(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_occhannelstateconfiguration(Entity entity, Entity merge)
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
		public msdyn_occhannelstateconfiguration(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the record.</para>
		/// <para>ReadOnly - Lookup</para>
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
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
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
		/// <para>ReadOnly - Lookup</para>
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
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Time duration in minutes after which the work item becomes target for auto closure</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Auto close conversation after</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyn_autocloseliveworkitemafter
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyn_autocloseliveworkitemafter); }
			set { Entity.Attributes[Fields.msdyn_autocloseliveworkitemafter] = value; }
		}

		/// <summary>
		/// <para>The name of the custom entity.</para>
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
		/// <para>Unique Identifier of the associated channel configuration</para>
		/// <para>Required - Lookup</para>
		/// <para>Channel Configuration</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_occhannelconfigurationid
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_occhannelconfigurationid); }
			set { Entity.Attributes[Fields.msdyn_occhannelconfigurationid] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Channel State Configuration</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_occhannelstateconfigurationId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_occhannelstateconfigurationId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>State of the conversation where the config is applicable</para>
		/// <para>Required - Picklist</para>
		/// <para>Conversation State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.MyDog.Shared.Entities.msdyn_occhannelstateconfigurationOptionSets.msdyn_ocliveworkitemstate? msdyn_ocliveworkitemstate
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_ocliveworkitemstate);
				if (value == null) return null;
				return (Abc.MyDog.Shared.Entities.msdyn_occhannelstateconfigurationOptionSets.msdyn_ocliveworkitemstate)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyn_ocliveworkitemstate] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>(Currently unused)</para>
		/// <para>Required - Boolean</para>
		/// <para>Show confirmation on session close</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_showconfirmationonsessionclose
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_showconfirmationonsessionclose); }
			set { Entity.Attributes[Fields.msdyn_showconfirmationonsessionclose] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for the organization</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Organization Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OrganizationId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OrganizationId); }
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
		/// <para>Status of the Channel State Configuration</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.MyDog.Shared.Entities.msdyn_occhannelstateconfigurationOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Abc.MyDog.Shared.Entities.msdyn_occhannelstateconfigurationOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the Channel State Configuration</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.MyDog.Shared.Entities.msdyn_occhannelstateconfigurationOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Abc.MyDog.Shared.Entities.msdyn_occhannelstateconfigurationOptionSets.statuscode)value.Value;
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