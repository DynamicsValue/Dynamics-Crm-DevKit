﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.MyDog.Shared.Entities.msdyn_livechatengagementctxOptionSets
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
	public partial class msdyn_livechatengagementctx : EntityBase
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
			public const string msdyn_browser = "msdyn_browser";
			public const string msdyn_City = "msdyn_city";
			public const string msdyn_country = "msdyn_country";
			public const string msdyn_device = "msdyn_device";
			public const string msdyn_isauthenticated = "msdyn_isauthenticated";
			public const string msdyn_isproactivechat = "msdyn_isproactivechat";
			public const string msdyn_latitude = "msdyn_latitude";
			public const string msdyn_livechatengagementctxId = "msdyn_livechatengagementctxid";
			public const string msdyn_livechatengagementid = "msdyn_livechatengagementid";
			public const string msdyn_liveworkitemid = "msdyn_liveworkitemid";
			public const string msdyn_locale = "msdyn_locale";
			public const string msdyn_longitude = "msdyn_longitude";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_originurl = "msdyn_originurl";
			public const string msdyn_os = "msdyn_os";
			public const string msdyn_portalcontactid = "msdyn_portalcontactid";
			public const string msdyn_PostalCode = "msdyn_postalcode";
			public const string msdyn_State = "msdyn_state";
			public const string msdyn_Street1 = "msdyn_street1";
			public const string msdyn_Street2 = "msdyn_street2";
			public const string msdyn_Street3 = "msdyn_street3";
			public const string msdyn_widgetappid = "msdyn_widgetappid";
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

		public const string EntityLogicalName = "msdyn_livechatengagementctx";

		public const int EntityTypeCode = 10538;

		[DebuggerNonUserCode()]
		public msdyn_livechatengagementctx()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_livechatengagementctx(Guid msdyn_livechatengagementctxId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_livechatengagementctxId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_livechatengagementctx(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_livechatengagementctx(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_livechatengagementctx(Entity entity, Entity merge)
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
		public msdyn_livechatengagementctx(KeyAttributeCollection keys)
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
		/// <para>Browser where customer initiated chat</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Browser</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_browser
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_browser); }
			set { Entity.Attributes[Fields.msdyn_browser] = value; }
		}

		/// <summary>
		/// <para>City where customer initiated chat</para>
		/// <para>String - MaxLength: 300</para>
		/// <para>City</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_City
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_City); }
			set { Entity.Attributes[Fields.msdyn_City] = value; }
		}

		/// <summary>
		/// <para>Country where customer initiated chat</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Country/Region</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_country
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_country); }
			set { Entity.Attributes[Fields.msdyn_country] = value; }
		}

		/// <summary>
		/// <para>Device where customer initiated chat</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Device</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_device
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_device); }
			set { Entity.Attributes[Fields.msdyn_device] = value; }
		}

		/// <summary>
		/// <para>Indicates if chat is authenticated</para>
		/// <para>Boolean</para>
		/// <para>Is Authenticated Engagement</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_isauthenticated
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_isauthenticated); }
			set { Entity.Attributes[Fields.msdyn_isauthenticated] = value; }
		}

		/// <summary>
		/// <para>Indicates if chat was initiated from proactive chat</para>
		/// <para>Boolean</para>
		/// <para>Is Proactivechat</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_isproactivechat
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_isproactivechat); }
			set { Entity.Attributes[Fields.msdyn_isproactivechat] = value; }
		}

		/// <summary>
		/// <para>Latitude where customer initiated chat</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Latitude</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_latitude
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_latitude); }
			set { Entity.Attributes[Fields.msdyn_latitude] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Live Chat Context</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_livechatengagementctxId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_livechatengagementctxId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Unique identifier for engagement context</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Live Chat Engagement Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_livechatengagementid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_livechatengagementid); }
			set { Entity.Attributes[Fields.msdyn_livechatengagementid] = value; }
		}

		/// <summary>
		/// <para>Corresponding conversation identifier for the chat</para>
		/// <para>Lookup</para>
		/// <para>Conversation</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_liveworkitemid
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_liveworkitemid); }
			set { Entity.Attributes[Fields.msdyn_liveworkitemid] = value; }
		}

		/// <summary>
		/// <para>Locale for this chat</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Locale</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_locale
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_locale); }
			set { Entity.Attributes[Fields.msdyn_locale] = value; }
		}

		/// <summary>
		/// <para>Longitude where customer initiated chat</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Longitude</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_longitude
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_longitude); }
			set { Entity.Attributes[Fields.msdyn_longitude] = value; }
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
		/// <para>Browser URL where customer initiated chat</para>
		/// <para>String - MaxLength: 2048</para>
		/// <para>Origin Url</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_originurl
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_originurl); }
			set { Entity.Attributes[Fields.msdyn_originurl] = value; }
		}

		/// <summary>
		/// <para>Operating system where customer initiated chat</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Operating System</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_os
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_os); }
			set { Entity.Attributes[Fields.msdyn_os] = value; }
		}

		/// <summary>
		/// <para>Customer portal identifier if exists</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Portal Contact Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_portalcontactid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_portalcontactid); }
			set { Entity.Attributes[Fields.msdyn_portalcontactid] = value; }
		}

		/// <summary>
		/// <para>Postal code where customer initiated chat</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Zip/Postal Code</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_PostalCode
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_PostalCode); }
			set { Entity.Attributes[Fields.msdyn_PostalCode] = value; }
		}

		/// <summary>
		/// <para>State where customer initiated chat</para>
		/// <para>String - MaxLength: 300</para>
		/// <para>State/Province</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_State
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_State); }
			set { Entity.Attributes[Fields.msdyn_State] = value; }
		}

		/// <summary>
		/// <para>Street 1 where customer initiated chat</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Street 1</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Street1
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Street1); }
			set { Entity.Attributes[Fields.msdyn_Street1] = value; }
		}

		/// <summary>
		/// <para>Street 2 where customer initiated chat</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Street 2</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Street2
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Street2); }
			set { Entity.Attributes[Fields.msdyn_Street2] = value; }
		}

		/// <summary>
		/// <para>Street 3 where customer initiated chat</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Street 3</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Street3
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Street3); }
			set { Entity.Attributes[Fields.msdyn_Street3] = value; }
		}

		/// <summary>
		/// <para>Corresponding widget application identifier for the chat</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Chat Widget App Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_widgetappid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_widgetappid); }
			set { Entity.Attributes[Fields.msdyn_widgetappid] = value; }
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
		/// <para>Status of the Live chat context</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.MyDog.Shared.Entities.msdyn_livechatengagementctxOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Abc.MyDog.Shared.Entities.msdyn_livechatengagementctxOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the Live chat context</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.MyDog.Shared.Entities.msdyn_livechatengagementctxOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Abc.MyDog.Shared.Entities.msdyn_livechatengagementctxOptionSets.statuscode)value.Value;
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