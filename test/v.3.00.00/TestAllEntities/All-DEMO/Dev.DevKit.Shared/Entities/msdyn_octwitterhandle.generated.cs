﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_octwitterhandleOptionSets
{
	public enum msdyn_PostConversationSurveyMode
	{
		/// <summary>
		/// Insert survey in conversation = 192350000
		/// </summary>
		Insert_survey_in_conversation = 192350000,
		/// <summary>
		/// Send survey link to conversation = 192350001
		/// </summary>
		Send_survey_link_to_conversation = 192350001
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
	public partial class msdyn_octwitterhandle : EntityBase
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
			public const string msdyn_enablefileattachmentsforagents = "msdyn_enablefileattachmentsforagents";
			public const string msdyn_enablefileattachmentsforcustomers = "msdyn_enablefileattachmentsforcustomers";
			public const string msdyn_liveworkstreamid = "msdyn_liveworkstreamid";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_octwitterapplicationid = "msdyn_octwitterapplicationid";
			public const string msdyn_octwitterhandleId = "msdyn_octwitterhandleid";
			public const string msdyn_octwitterscreenname = "msdyn_octwitterscreenname";
			public const string msdyn_octwitteruniquehandleid = "msdyn_octwitteruniquehandleid";
			public const string msdyn_ocwidgetlanguage = "msdyn_ocwidgetlanguage";
			public const string msdyn_PostConversationSurvey = "msdyn_postconversationsurvey";
			public const string msdyn_PostConversationSurveyEnable = "msdyn_postconversationsurveyenable";
			public const string msdyn_PostConversationSurveyMessageText = "msdyn_postconversationsurveymessagetext";
			public const string msdyn_PostConversationSurveyMode = "msdyn_postconversationsurveymode";
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

		public const string EntityLogicalName = "msdyn_octwitterhandle";

		[System.Obsolete("This value is different for each instance. Please don't use it.")]
		public const int EntityTypeCode = 10741;

		[DebuggerNonUserCode()]
		public msdyn_octwitterhandle()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_octwitterhandle(Guid msdyn_octwitterhandleId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_octwitterhandleId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_octwitterhandle(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_octwitterhandle(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_octwitterhandle(Entity entity, Entity merge)
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
		public msdyn_octwitterhandle(KeyAttributeCollection keys)
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
		/// <para>Option set to enable or disable attachments for agents</para>
		/// <para>Boolean</para>
		/// <para>Enable file attachments for agents</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_enablefileattachmentsforagents
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_enablefileattachmentsforagents); }
			set { Entity.Attributes[Fields.msdyn_enablefileattachmentsforagents] = value; }
		}

		/// <summary>
		/// <para>Optionset to enable or disable attachments for customers</para>
		/// <para>Boolean</para>
		/// <para>Enable file attachments for customers</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_enablefileattachmentsforcustomers
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_enablefileattachmentsforcustomers); }
			set { Entity.Attributes[Fields.msdyn_enablefileattachmentsforcustomers] = value; }
		}

		/// <summary>
		/// <para>Lookup for Live Work Stream</para>
		/// <para>Required - Lookup to msdyn_liveworkstream</para>
		/// <para>Work stream</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_liveworkstreamid
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_liveworkstreamid); }
			set { Entity.Attributes[Fields.msdyn_liveworkstreamid] = value; }
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
		/// <para>Lookup for Twitter Application</para>
		/// <para>Required - Lookup to msdyn_octwitterapplication</para>
		/// <para>Twitter application</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_octwitterapplicationid
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_octwitterapplicationid); }
			set { Entity.Attributes[Fields.msdyn_octwitterapplicationid] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Twitter handle id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_octwitterhandleId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_octwitterhandleId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Twitter Customer Screen Handle Name</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>Twitter handle</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_octwitterscreenname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_octwitterscreenname); }
			set { Entity.Attributes[Fields.msdyn_octwitterscreenname] = value; }
		}

		/// <summary>
		/// <para>Twitter Customer Unique Handle Id</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Twitter unique handle id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_octwitteruniquehandleid
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_octwitteruniquehandleid); }
			set { Entity.Attributes[Fields.msdyn_octwitteruniquehandleid] = value; }
		}

		/// <summary>
		/// <para>The language setting for the Twitter handle</para>
		/// <para>Required - Lookup to msdyn_oclanguage</para>
		/// <para>Twitter handle language</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_ocwidgetlanguage
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_ocwidgetlanguage); }
			set { Entity.Attributes[Fields.msdyn_ocwidgetlanguage] = value; }
		}

		/// <summary>
		/// <para>Lookup to Dynamics 365 Customer Voice survey field</para>
		/// <para>Lookup to msfp_survey</para>
		/// <para>Survey</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_PostConversationSurvey
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_PostConversationSurvey); }
			set { Entity.Attributes[Fields.msdyn_PostConversationSurvey] = value; }
		}

		/// <summary>
		/// <para>To enable or disable post conversation survey</para>
		/// <para>Boolean</para>
		/// <para>Enable</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyn_PostConversationSurveyEnable
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyn_PostConversationSurveyEnable); }
			set { Entity.Attributes[Fields.msdyn_PostConversationSurveyEnable] = value; }
		}

		/// <summary>
		/// <para>Prefix text for survey link message that will be sent to the user.</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Message</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_PostConversationSurveyMessageText
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_PostConversationSurveyMessageText); }
			set { Entity.Attributes[Fields.msdyn_PostConversationSurveyMessageText] = value; }
		}

		/// <summary>
		/// <para>Mode of the survey to be sent</para>
		/// <para>Picklist</para>
		/// <para>Survey Mode</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_octwitterhandleOptionSets.msdyn_PostConversationSurveyMode? msdyn_PostConversationSurveyMode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyn_PostConversationSurveyMode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_octwitterhandleOptionSets.msdyn_PostConversationSurveyMode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyn_PostConversationSurveyMode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyn_PostConversationSurveyMode] = null;
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
		/// <para>Status of the Twitter Handle</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_octwitterhandleOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_octwitterhandleOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the Twitter Handle</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyn_octwitterhandleOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyn_octwitterhandleOptionSets.statuscode)value.Value;
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