﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.MyDog.Shared.Entities.msdyn_routingrequestOptionSets
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

namespace Abc.MyDog.Shared.Entities
{
	public partial class msdyn_routingrequest : EntityBase
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
			public const string msdyn_entitylogicalname = "msdyn_entitylogicalname";
			public const string msdyn_entityrecordid = "msdyn_entityrecordid";
			public const string msdyn_entitysetname = "msdyn_entitysetname";
			public const string msdyn_queueid = "msdyn_queueid";
			public const string msdyn_queueitemid = "msdyn_queueitemid";
			public const string msdyn_relationshipnamewithliveworkitem = "msdyn_relationshipnamewithliveworkitem";
			public const string msdyn_routingrequestId = "msdyn_routingrequestid";
			public const string msdyn_routingrequesttitle = "msdyn_routingrequesttitle";
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

		public const string EntityLogicalName = "msdyn_routingrequest";

		public const int EntityTypeCode = 10496;

		[DebuggerNonUserCode()]
		public msdyn_routingrequest()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_routingrequest(Guid msdyn_routingrequestId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_routingrequestId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_routingrequest(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_routingrequest(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_routingrequest(Entity entity, Entity merge)
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
		public msdyn_routingrequest(KeyAttributeCollection keys)
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
		/// <para>The name of the custom entity.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>entitylogicalname</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_entitylogicalname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_entitylogicalname); }
			set { Entity.Attributes[Fields.msdyn_entitylogicalname] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the record to be routed to Omnichannel.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>entityrecordid</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_entityrecordid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_entityrecordid); }
			set { Entity.Attributes[Fields.msdyn_entityrecordid] = value; }
		}

		/// <summary>
		/// <para>entitysetname of the entity being routed.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>entitysetname</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_entitysetname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_entitysetname); }
			set { Entity.Attributes[Fields.msdyn_entitysetname] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the queue.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>queueid</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_queueid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_queueid); }
			set { Entity.Attributes[Fields.msdyn_queueid] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the queue item.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>queueitemid</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_queueitemid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_queueitemid); }
			set { Entity.Attributes[Fields.msdyn_queueitemid] = value; }
		}

		/// <summary>
		/// <para>Name that tells the relationship of the Entity with Live Work Item</para>
		/// <para>String - MaxLength: 400</para>
		/// <para>RelationshipNameWithLiveWorkItem</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_relationshipnamewithliveworkitem
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_relationshipnamewithliveworkitem); }
			set { Entity.Attributes[Fields.msdyn_relationshipnamewithliveworkitem] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>RoutingRequest</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_routingrequestId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_routingrequestId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Primary display name value of the record.</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Title</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_routingrequesttitle
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_routingrequesttitle); }
			set { Entity.Attributes[Fields.msdyn_routingrequesttitle] = value; }
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
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier for the team that owns the record.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier for the user that owns the record.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>Status of the RoutingRequest</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.MyDog.Shared.Entities.msdyn_routingrequestOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Abc.MyDog.Shared.Entities.msdyn_routingrequestOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the RoutingRequest</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.MyDog.Shared.Entities.msdyn_routingrequestOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Abc.MyDog.Shared.Entities.msdyn_routingrequestOptionSets.statuscode)value.Value;
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