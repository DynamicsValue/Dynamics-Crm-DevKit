﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.ActionCardOptionSets
{
	public enum Source
	{
		/// <summary>
		/// CRM = 1
		/// </summary>
		CRM = 1,
		/// <summary>
		/// Exchange = 2
		/// </summary>
		Exchange = 2
	}

	public enum State
	{
		/// <summary>
		/// Active = 0
		/// </summary>
		Active = 0,
		/// <summary>
		/// Completed = 2
		/// </summary>
		Completed = 2,
		/// <summary>
		/// Dismissed = 1
		/// </summary>
		Dismissed = 1
	}
}

namespace Dev.DevKit.Shared.Entities
{
	public partial class ActionCard : EntityBase
	{
		public struct Fields
		{
			public const string ActionCardId = "actioncardid";
			public const string CardType = "cardtype";
			public const string CardTypeId = "cardtypeid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Data = "data";
			public const string Description = "description";
			public const string ExchangeRate = "exchangerate";
			public const string ExpiryDate = "expirydate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msdyn_actioncardregardingid = "msdyn_actioncardregardingid";
			public const string msdyn_regardingobjectid = "msdyn_regardingobjectid";
			public const string msdyn_regardingobjectlogicalname = "msdyn_regardingobjectlogicalname";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string ParentRegardingObjectId = "parentregardingobjectid";
			public const string ParentRegardingObjectIdData = "parentregardingobjectiddata";
			public const string Priority = "priority";
			public const string RecordId = "recordid";
			public const string RecordIdObjectTypeCode2 = "recordidobjecttypecode2";
			public const string ReferenceTokens = "referencetokens";
			public const string RegardingObjectId = "regardingobjectid";
			public const string Source = "source";
			public const string StartDate = "startdate";
			public const string State = "state";
			public const string Title = "title";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string Visibility = "visibility";
		}

		public const string EntityLogicalName = "actioncard";

		public const int EntityTypeCode = 9962;

		[DebuggerNonUserCode()]
		public ActionCard()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ActionCard(Guid ActionCardId)
		{
			Entity = new Entity(EntityLogicalName, ActionCardId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ActionCard(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ActionCard(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ActionCard(Entity entity, Entity merge)
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
		public ActionCard(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the action card.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Action Card</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid ActionCardId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.ActionCardId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>The CardType ENUM value.</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>CardType ENUM</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? CardType
		{
			get { return Entity.GetAttributeValue<int?>(Fields.CardType); }
			set { Entity.Attributes[Fields.CardType] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the card type.</para>
		/// <para>Lookup to cardtype</para>
		/// <para>Card Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CardTypeId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CardTypeId); }
			set { Entity.Attributes[Fields.CardTypeId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the action card.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Date and time when action card was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the action card.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Json formatted string for generic purpose.</para>
		/// <para>Memo - MaxLength: 8192</para>
		/// <para>Data Associated with Card Commandbar Actions</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Data
		{
			get { return Entity.GetAttributeValue<string>(Fields.Data); }
			set { Entity.Attributes[Fields.Data] = value; }
		}

		/// <summary>
		/// <para>Card Description</para>
		/// <para>Memo - MaxLength: 8192</para>
		/// <para>Card Description</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Description
		{
			get { return Entity.GetAttributeValue<string>(Fields.Description); }
			set { Entity.Attributes[Fields.Description] = value; }
		}

		/// <summary>
		/// <para>Exchange rate for the currency associated with the action card with respect to the base currency.</para>
		/// <para>ReadOnly - Decimal - MinValue: 0 - MaxValue: 100,000,000,000</para>
		/// <para>Exchange Rate</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public decimal? ExchangeRate
		{
			get { return Entity.GetAttributeValue<decimal?>(Fields.ExchangeRate); }
		}

		/// <summary>
		/// <para>Shows the Expiry Date</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Expiry Date</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ExpiryDateUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ExpiryDate); }
			set { Entity.Attributes[Fields.ExpiryDate] = value; }
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
		/// <para>Unique identifier of the user who last modified the action card.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Date and time when action card was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who last modified action card.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>String - MaxLength: 36</para>
		/// <para>actioncardregardingid</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_actioncardregardingid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_actioncardregardingid); }
			set { Entity.Attributes[Fields.msdyn_actioncardregardingid] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 36</para>
		/// <para>regardingobjectid</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_regardingobjectid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_regardingobjectid); }
			set { Entity.Attributes[Fields.msdyn_regardingobjectid] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 128</para>
		/// <para>regardingobjectlogicalname</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_regardingobjectlogicalname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_regardingobjectlogicalname); }
			set { Entity.Attributes[Fields.msdyn_regardingobjectlogicalname] = value; }
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
		/// <para>Unique identifier of the user or team who owns the action card.</para>
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
		/// <para>Unique identifier of the business unit that owns the action card.</para>
		/// <para>ReadOnly - Lookup to businessunit</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the team who owns the action card.</para>
		/// <para>ReadOnly - Lookup to team</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who owns the action card.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>ParentRegardingObjectId of the ActionCard</para>
		/// <para>Lookup to </para>
		/// <para>ParentRegardingObjectId</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ParentRegardingObjectId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ParentRegardingObjectId); }
			set { Entity.Attributes[Fields.ParentRegardingObjectId] = value; }
		}

		/// <summary>
		/// <para>Json formatted string for parent regarding object.</para>
		/// <para>Memo - MaxLength: 8192</para>
		/// <para>ParentRegardingObjectIdData</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string ParentRegardingObjectIdData
		{
			get { return Entity.GetAttributeValue<string>(Fields.ParentRegardingObjectIdData); }
			set { Entity.Attributes[Fields.ParentRegardingObjectIdData] = value; }
		}

		/// <summary>
		/// <para>Priority of the ActionCard</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Priority</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? Priority
		{
			get { return Entity.GetAttributeValue<int?>(Fields.Priority); }
			set { Entity.Attributes[Fields.Priority] = value; }
		}

		/// <summary>
		/// <para>Shows the record ID.</para>
		/// <para>Lookup to </para>
		/// <para>RecordId</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference RecordId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.RecordId); }
			set { Entity.Attributes[Fields.RecordId] = value; }
		}

		/// <summary>
		/// <para>RecordIdObjectTypeCode2 of the ActionCard</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>RecordIdObjectTypeCode2</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? RecordIdObjectTypeCode2
		{
			get { return Entity.GetAttributeValue<int?>(Fields.RecordIdObjectTypeCode2); }
			set { Entity.Attributes[Fields.RecordIdObjectTypeCode2] = value; }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>Memo - MaxLength: 8192</para>
		/// <para>Data Associated constructing title and body</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string ReferenceTokens
		{
			get { return Entity.GetAttributeValue<string>(Fields.ReferenceTokens); }
			set { Entity.Attributes[Fields.ReferenceTokens] = value; }
		}

		/// <summary>
		/// <para>Choose the record that the card relates to.</para>
		/// <para>Lookup to account;appointment;contact;email;fax;incident;lead;letter;msdyn_approval;msdyn_bookingalert;msdyn_ocliveworkitem;msdyn_ocoutboundmessage;msdyn_ocsession;msfp_alert;msfp_surveyinvite;msfp_surveyresponse;opportunity;phonecall;recurringappointmentmaster;serviceappointment;task</para>
		/// <para>Regarding</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference RegardingObjectId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.RegardingObjectId); }
			set { Entity.Attributes[Fields.RegardingObjectId] = value; }
		}

		/// <summary>
		/// <para>Source for the Action Card</para>
		/// <para>Picklist</para>
		/// <para>Action Card Source</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.ActionCardOptionSets.Source? Source
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.Source);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.ActionCardOptionSets.Source)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.Source] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.Source] = null;
			}
		}

		/// <summary>
		/// <para>Shows the Start Date</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Start Date</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? StartDateUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.StartDate); }
			set { Entity.Attributes[Fields.StartDate] = value; }
		}

		/// <summary>
		/// <para>State of the Action Card</para>
		/// <para>Picklist</para>
		/// <para>Action Card State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.ActionCardOptionSets.State? State
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.State);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.ActionCardOptionSets.State)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.State] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.State] = null;
			}
		}

		/// <summary>
		/// <para>Title of the ActionCard</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Title</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Title
		{
			get { return Entity.GetAttributeValue<string>(Fields.Title); }
			set { Entity.Attributes[Fields.Title] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the currency associated with the action card.</para>
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
		/// <para>Version number of the action card.</para>
		/// <para>ReadOnly - BigInt</para>
		/// <para>Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? VersionNumber
		{
			get { return Entity.GetAttributeValue<long?>(Fields.VersionNumber); }
		}

		/// <summary>
		/// <para>Select whether the visibility should be set to public/private.</para>
		/// <para>Boolean</para>
		/// <para>Visibiliy Status of ActionCard</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? Visibility
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.Visibility); }
			set { Entity.Attributes[Fields.Visibility] = value; }
		}
	}
}
