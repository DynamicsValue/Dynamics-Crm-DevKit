﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_SessionDataOptionSets
{
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
	public partial class msdyn_SessionData : EntityBase
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
			public const string msdyn_ConversationId = "msdyn_conversationid";
			public const string msdyn_CustomAttribute1 = "msdyn_customattribute1";
			public const string msdyn_CustomAttribute2 = "msdyn_customattribute2";
			public const string msdyn_CustomAttribute3 = "msdyn_customattribute3";
			public const string msdyn_CustomAttribute4 = "msdyn_customattribute4";
			public const string msdyn_CustomAttribute5 = "msdyn_customattribute5";
			public const string msdyn_ExternalCorrelationId = "msdyn_externalcorrelationid";
			public const string msdyn_Name = "msdyn_name";
			public const string msdyn_ProviderSessionId = "msdyn_providersessionid";
			public const string msdyn_QueueId = "msdyn_queueid";
			public const string msdyn_QueueName = "msdyn_queuename";
			public const string msdyn_SessionAdditionalData = "msdyn_sessionadditionaldata";
			public const string msdyn_SessionAgentAssignedTimestamp = "msdyn_sessionagentassignedtimestamp";
			public const string msdyn_SessionChannel = "msdyn_sessionchannel";
			public const string msdyn_SessionCreatedTimestamp = "msdyn_sessioncreatedtimestamp";
			public const string msdyn_SessionCreationReason = "msdyn_sessioncreationreason";
			public const string msdyn_SessionDataId = "msdyn_sessiondataid";
			public const string msdyn_SessionQueueAssignedTimestamp = "msdyn_sessionqueueassignedtimestamp";
			public const string msdyn_UCISessionId = "msdyn_ucisessionid";
			public const string msdyn_UCISessionName = "msdyn_ucisessionname";
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

		public const string EntityLogicalName = "msdyn_sessiondata";

		[System.Obsolete("This value is different for each instance. Please don't use it.")]
		public const int EntityTypeCode = 10222;

		[DebuggerNonUserCode()]
		public msdyn_SessionData()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_SessionData(Guid msdyn_SessionDataId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_SessionDataId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_SessionData(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_SessionData(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_SessionData(Entity entity, Entity merge)
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
		public msdyn_SessionData(KeyAttributeCollection keys)
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
		/// <para>Conversation Identifier</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Conversation Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_ConversationId
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_ConversationId); }
			set { Entity.Attributes[Fields.msdyn_ConversationId] = value; }
		}

		/// <summary>
		/// <para>Custom Attribute 1</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Custom Attribute 1</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_CustomAttribute1
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_CustomAttribute1); }
			set { Entity.Attributes[Fields.msdyn_CustomAttribute1] = value; }
		}

		/// <summary>
		/// <para>Custom Attribute 2</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Custom Attribute 2</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_CustomAttribute2
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_CustomAttribute2); }
			set { Entity.Attributes[Fields.msdyn_CustomAttribute2] = value; }
		}

		/// <summary>
		/// <para>Custom Attribute 3</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Custom Attribute 3</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_CustomAttribute3
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_CustomAttribute3); }
			set { Entity.Attributes[Fields.msdyn_CustomAttribute3] = value; }
		}

		/// <summary>
		/// <para>Custom Attribute 4</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Custom Attribute 4</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_CustomAttribute4
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_CustomAttribute4); }
			set { Entity.Attributes[Fields.msdyn_CustomAttribute4] = value; }
		}

		/// <summary>
		/// <para>Custom Attribute 5</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Custom Attribute 5</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_CustomAttribute5
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_CustomAttribute5); }
			set { Entity.Attributes[Fields.msdyn_CustomAttribute5] = value; }
		}

		/// <summary>
		/// <para>External System Correlation Id</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>External Correlation Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_ExternalCorrelationId
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_ExternalCorrelationId); }
			set { Entity.Attributes[Fields.msdyn_ExternalCorrelationId] = value; }
		}

		/// <summary>
		/// <para>Required name field</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Name); }
			set { Entity.Attributes[Fields.msdyn_Name] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the provider session</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Provider Session Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_ProviderSessionId
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_ProviderSessionId); }
			set { Entity.Attributes[Fields.msdyn_ProviderSessionId] = value; }
		}

		/// <summary>
		/// <para>Identifier of the queue to which this session belongs to</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Queue Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_QueueId
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_QueueId); }
			set { Entity.Attributes[Fields.msdyn_QueueId] = value; }
		}

		/// <summary>
		/// <para>Name of the queue to which this session belongs to</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Queue Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_QueueName
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_QueueName); }
			set { Entity.Attributes[Fields.msdyn_QueueName] = value; }
		}

		/// <summary>
		/// <para>Additional data related to the session</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Additional Data</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_SessionAdditionalData
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_SessionAdditionalData); }
			set { Entity.Attributes[Fields.msdyn_SessionAdditionalData] = value; }
		}

		/// <summary>
		/// <para>Timestamp at which the agent was assigned to the session</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Agent Assigned Timestamp</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_SessionAgentAssignedTimestampUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_SessionAgentAssignedTimestamp); }
			set { Entity.Attributes[Fields.msdyn_SessionAgentAssignedTimestamp] = value; }
		}

		/// <summary>
		/// <para>Channel for the session</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Channel</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_SessionChannel
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_SessionChannel); }
			set { Entity.Attributes[Fields.msdyn_SessionChannel] = value; }
		}

		/// <summary>
		/// <para>Timestamp at which the session was created</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created Timestamp</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_SessionCreatedTimestampUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_SessionCreatedTimestamp); }
			set { Entity.Attributes[Fields.msdyn_SessionCreatedTimestamp] = value; }
		}

		/// <summary>
		/// <para>Reason for the session creation</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Creation Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_SessionCreationReason
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_SessionCreationReason); }
			set { Entity.Attributes[Fields.msdyn_SessionCreationReason] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Session Data Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_SessionDataId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_SessionDataId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Timestamp at which the queue was assigned to the session</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Queue Assigned Timestamp</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_SessionQueueAssignedTimestampUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_SessionQueueAssignedTimestamp); }
			set { Entity.Attributes[Fields.msdyn_SessionQueueAssignedTimestamp] = value; }
		}

		/// <summary>
		/// <para>Identifier of the client session</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Client Session Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_UCISessionId
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_UCISessionId); }
			set { Entity.Attributes[Fields.msdyn_UCISessionId] = value; }
		}

		/// <summary>
		/// <para>Name of the client session</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Client Session Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_UCISessionName
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_UCISessionName); }
			set { Entity.Attributes[Fields.msdyn_UCISessionName] = value; }
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
		/// <para>Status of the SessionData</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_SessionDataOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_SessionDataOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the SessionData</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_SessionDataOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_SessionDataOptionSets.statuscode)value.Value;
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