﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.LuckyStar.Shared.Entities.ConnectionOptionSets
{
	public enum Record1ObjectTypeCode
	{
		/// <summary>
		/// Account = 1
		/// </summary>
		Account = 1,
		/// <summary>
		/// Process_Session = 4710
		/// </summary>
		Process_Session = 4710,
		/// <summary>
		/// Position = 50
		/// </summary>
		Position = 50,
		/// <summary>
		/// Knowledge_Base_Record = 9930
		/// </summary>
		Knowledge_Base_Record = 9930,
		/// <summary>
		/// Task = 4212
		/// </summary>
		Task = 4212,
		/// <summary>
		/// Contact = 2
		/// </summary>
		Contact = 2,
		/// <summary>
		/// Channel_Access_Profile_Rule = 9400
		/// </summary>
		Channel_Access_Profile_Rule = 9400,
		/// <summary>
		/// Social_Profile = 99
		/// </summary>
		Social_Profile = 99,
		/// <summary>
		/// Activity = 4200
		/// </summary>
		Activity = 4200,
		/// <summary>
		/// Team = 9
		/// </summary>
		Team = 9,
		/// <summary>
		/// Letter = 4207
		/// </summary>
		Letter = 4207,
		/// <summary>
		/// Custom_Activity = 10042
		/// </summary>
		Custom_Activity = 10042,
		/// <summary>
		/// WebApi = 10030
		/// </summary>
		WebApi = 10030,
		/// <summary>
		/// Email = 4202
		/// </summary>
		Email = 4202,
		/// <summary>
		/// User = 8
		/// </summary>
		User = 8,
		/// <summary>
		/// Fax = 4204
		/// </summary>
		Fax = 4204,
		/// <summary>
		/// Recurring_Appointment = 4251
		/// </summary>
		Recurring_Appointment = 4251,
		/// <summary>
		/// Phone_Call = 4210
		/// </summary>
		Phone_Call = 4210,
		/// <summary>
		/// Appointment = 4201
		/// </summary>
		Appointment = 4201,
		/// <summary>
		/// Goal = 9600
		/// </summary>
		Goal = 9600,
		/// <summary>
		/// Social_Activity = 4216
		/// </summary>
		Social_Activity = 4216,
		/// <summary>
		/// Territory = 2013
		/// </summary>
		Territory = 2013,
		/// <summary>
		/// Knowledge_Article = 9953
		/// </summary>
		Knowledge_Article = 9953
	}

	public enum Record2ObjectTypeCode
	{
		/// <summary>
		/// Fax = 4204
		/// </summary>
		Fax = 4204,
		/// <summary>
		/// Position = 50
		/// </summary>
		Position = 50,
		/// <summary>
		/// Activity = 4200
		/// </summary>
		Activity = 4200,
		/// <summary>
		/// Letter = 4207
		/// </summary>
		Letter = 4207,
		/// <summary>
		/// Channel_Access_Profile_Rule = 9400
		/// </summary>
		Channel_Access_Profile_Rule = 9400,
		/// <summary>
		/// Territory = 2013
		/// </summary>
		Territory = 2013,
		/// <summary>
		/// Contact = 2
		/// </summary>
		Contact = 2,
		/// <summary>
		/// Appointment = 4201
		/// </summary>
		Appointment = 4201,
		/// <summary>
		/// User = 8
		/// </summary>
		User = 8,
		/// <summary>
		/// Custom_Activity = 10042
		/// </summary>
		Custom_Activity = 10042,
		/// <summary>
		/// Process_Session = 4710
		/// </summary>
		Process_Session = 4710,
		/// <summary>
		/// Goal = 9600
		/// </summary>
		Goal = 9600,
		/// <summary>
		/// Task = 4212
		/// </summary>
		Task = 4212,
		/// <summary>
		/// Email = 4202
		/// </summary>
		Email = 4202,
		/// <summary>
		/// Social_Profile = 99
		/// </summary>
		Social_Profile = 99,
		/// <summary>
		/// Social_Activity = 4216
		/// </summary>
		Social_Activity = 4216,
		/// <summary>
		/// Knowledge_Base_Record = 9930
		/// </summary>
		Knowledge_Base_Record = 9930,
		/// <summary>
		/// WebApi = 10030
		/// </summary>
		WebApi = 10030,
		/// <summary>
		/// Team = 9
		/// </summary>
		Team = 9,
		/// <summary>
		/// Phone_Call = 4210
		/// </summary>
		Phone_Call = 4210,
		/// <summary>
		/// Knowledge_Article = 9953
		/// </summary>
		Knowledge_Article = 9953,
		/// <summary>
		/// Account = 1
		/// </summary>
		Account = 1,
		/// <summary>
		/// Recurring_Appointment = 4251
		/// </summary>
		Recurring_Appointment = 4251
	}

	public enum StateCode
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

	public enum StatusCode
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

namespace Abc.LuckyStar.Shared.Entities
{
	public partial class Connection : EntityBase
	{
		public struct Fields
		{
			public const string ConnectionId = "connectionid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string EffectiveEnd = "effectiveend";
			public const string EffectiveStart = "effectivestart";
			public const string EntityImageId = "entityimageid";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsMaster = "ismaster";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string Record1Id = "record1id";
			public const string Record1ObjectTypeCode = "record1objecttypecode";
			public const string Record1RoleId = "record1roleid";
			public const string Record2Id = "record2id";
			public const string Record2ObjectTypeCode = "record2objecttypecode";
			public const string Record2RoleId = "record2roleid";
			public const string RelatedConnectionId = "relatedconnectionid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "connection";

		public const int EntityTypeCode = 3234;

		[DebuggerNonUserCode()]
		public Connection()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Connection(Guid ConnectionId)
		{
			Entity = new Entity(EntityLogicalName, ConnectionId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Connection(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Connection(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Connection(Entity entity, Entity merge)
		{
			Entity = entity;
			foreach (var property in merge.Attributes)
			{
				var key = property.Key;
				var value = property.Value;
				Entity[key] = value;
			}
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Connection(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the connection.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Connection</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid ConnectionId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.ConnectionId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Shows who created the record.</para>
		/// <para>ReadOnly - Lookup</para>
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
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Type additional information to describe the connection, such as the length or quality of the relationship.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para>Description</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Description
		{
			get { return Entity.GetAttributeValue<string>(Fields.Description); }
			set { Entity.Attributes[Fields.Description] = value; }
		}

		/// <summary>
		/// <para>Enter the end date of the connection.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Ending</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? EffectiveEndUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.EffectiveEnd); }
			set { Entity.Attributes[Fields.EffectiveEnd] = value; }
		}

		/// <summary>
		/// <para>Enter the start date of the connection.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Starting</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? EffectiveStartUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.EffectiveStart); }
			set { Entity.Attributes[Fields.EffectiveStart] = value; }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Entity Image Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? EntityImageId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.EntityImageId); }
		}

		/// <summary>
		/// <para>Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.</para>
		/// <para>ReadOnly - Decimal - MinValue: 0 - MaxValue: 100,000,000,000</para>
		/// <para>Exchange Rate</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? ExchangeRate
		{
			get { return Entity.GetAttributeValue<decimal?>(Fields.ExchangeRate); }
		}

		/// <summary>
		/// <para>Unique identifier of the data import or data migration that created this record.</para>
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
		/// <para>Indicates that this is the master record.</para>
		/// <para>ReadOnly - Boolean</para>
		/// <para>Is Master</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsMaster
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsMaster); }
		}

		/// <summary>
		/// <para>Shows who last updated the record.</para>
		/// <para>ReadOnly - Lookup</para>
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
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Name of the connection.</para>
		/// <para>ReadOnly - Required - String - MaxLength: 500</para>
		/// <para>Connection Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
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
		/// <para>Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.</para>
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
		/// <para>Shows the business unit that the record owner belongs to.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the team who owns the connection.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who owns the connection.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>Choose the primary account, contact, or other record involved in the connection.</para>
		/// <para>Lookup</para>
		/// <para>Connected From</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference Record1Id
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.Record1Id); }
			set { Entity.Attributes[Fields.Record1Id] = value; }
		}

		/// <summary>
		/// <para>Shows the record type of the source record.</para>
		/// <para>ReadOnly - Picklist</para>
		/// <para>Type (From)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.LuckyStar.Shared.Entities.ConnectionOptionSets.Record1ObjectTypeCode? Record1ObjectTypeCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.Record1ObjectTypeCode);
				if (value == null) return null;
				return (Abc.LuckyStar.Shared.Entities.ConnectionOptionSets.Record1ObjectTypeCode)value.Value;
			}
		}

		/// <summary>
		/// <para>Choose the primary party's role or relationship with the second party.</para>
		/// <para>Lookup</para>
		/// <para>Role (From)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference Record1RoleId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.Record1RoleId); }
			set { Entity.Attributes[Fields.Record1RoleId] = value; }
		}

		/// <summary>
		/// <para>Select the secondary account, contact, or other record involved in the connection.</para>
		/// <para>Lookup</para>
		/// <para>Connected To</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference Record2Id
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.Record2Id); }
			set { Entity.Attributes[Fields.Record2Id] = value; }
		}

		/// <summary>
		/// <para>Shows the record type of the target record.</para>
		/// <para>ReadOnly - Picklist</para>
		/// <para>Type (To)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.LuckyStar.Shared.Entities.ConnectionOptionSets.Record2ObjectTypeCode? Record2ObjectTypeCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.Record2ObjectTypeCode);
				if (value == null) return null;
				return (Abc.LuckyStar.Shared.Entities.ConnectionOptionSets.Record2ObjectTypeCode)value.Value;
			}
		}

		/// <summary>
		/// <para>Choose the secondary party's role or relationship with the primary party.</para>
		/// <para>Lookup</para>
		/// <para>Role (To)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference Record2RoleId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.Record2RoleId); }
			set { Entity.Attributes[Fields.Record2RoleId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for the reciprocal connection record.</para>
		/// <para>ReadOnly - Required - Lookup</para>
		/// <para>Reciprocal Connection</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference RelatedConnectionId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.RelatedConnectionId); }
		}

		/// <summary>
		/// <para>Shows whether the connection is active or inactive. Inactive connections are read-only and can't be edited unless they are reactivated.</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.LuckyStar.Shared.Entities.ConnectionOptionSets.StateCode? StateCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.StateCode);
				if (value == null) return null;
				return (Abc.LuckyStar.Shared.Entities.ConnectionOptionSets.StateCode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.StateCode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.StateCode] = null;
			}
		}

		/// <summary>
		/// <para>Reason for the status of the connection.</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.LuckyStar.Shared.Entities.ConnectionOptionSets.StatusCode? StatusCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.StatusCode);
				if (value == null) return null;
				return (Abc.LuckyStar.Shared.Entities.ConnectionOptionSets.StatusCode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.StatusCode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.StatusCode] = null;
			}
		}

		/// <summary>
		/// <para>Choose the local currency for the record to make sure budgets are reported in the correct currency.</para>
		/// <para>Lookup</para>
		/// <para>Currency</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference TransactionCurrencyId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.TransactionCurrencyId); }
			set { Entity.Attributes[Fields.TransactionCurrencyId] = value; }
		}

		/// <summary>
		/// <para>Version number of the connection.</para>
		/// <para>ReadOnly - BigInt</para>
		/// <para>Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? VersionNumber
		{
			get { return Entity.GetAttributeValue<long?>(Fields.VersionNumber); }
		}

		/// <summary>
		/// <para>byte[]</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public byte[] EntityImage
		{
			get { return Entity.GetAttributeValue<byte[]>("entityimage"); }
			set { Entity.Attributes["entityimage"] = value; }
		}

		/// <summary>
		/// <para>ReadOnly - String</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string EntityImageUrl
		{
			get { return Entity.GetAttributeValue<string>("entityimage_url"); }
		}
	}
}