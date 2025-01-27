﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets
{
	public enum msdyusd_Action
	{
		/// <summary>
		/// Create_Session = 803750000
		/// </summary>
		Create_Session = 803750000,
		/// <summary>
		/// Default = 803750004
		/// </summary>
		Default = 803750004,
		/// <summary>
		/// In_Place = 803750005
		/// </summary>
		In_Place = 803750005,
		/// <summary>
		/// None = 803750003
		/// </summary>
		None = 803750003,
		/// <summary>
		/// Route_Window = 803750002
		/// </summary>
		Route_Window = 803750002,
		/// <summary>
		/// Show_Outside = 803750001
		/// </summary>
		Show_Outside = 803750001
	}

	public enum msdyusd_Destination
	{
		/// <summary>
		/// Entity_Search = 803750001
		/// </summary>
		Entity_Search = 803750001,
		/// <summary>
		/// Tab = 803750000
		/// </summary>
		Tab = 803750000
	}

	public enum msdyusd_Direction
	{
		/// <summary>
		/// Both = 2
		/// </summary>
		Both = 2,
		/// <summary>
		/// Inbound = 1
		/// </summary>
		Inbound = 1,
		/// <summary>
		/// Outbound = 0
		/// </summary>
		Outbound = 0
	}

	public enum msdyusd_MultipleMatchesDecision
	{
		/// <summary>
		/// Create_Session_then_Do_Action = 803750002
		/// </summary>
		Create_Session_then_Do_Action = 803750002,
		/// <summary>
		/// Do_Action = 803750000
		/// </summary>
		Do_Action = 803750000,
		/// <summary>
		/// Next_Rule = 803750001
		/// </summary>
		Next_Rule = 803750001
	}

	public enum msdyusd_NoMatchDecision
	{
		/// <summary>
		/// Create_Session_then_Do_Action = 803750002
		/// </summary>
		Create_Session_then_Do_Action = 803750002,
		/// <summary>
		/// Do_Action = 803750000
		/// </summary>
		Do_Action = 803750000,
		/// <summary>
		/// Next_Rule = 803750001
		/// </summary>
		Next_Rule = 803750001
	}

	public enum msdyusd_RouteType
	{
		/// <summary>
		/// In_Place = 803750003
		/// </summary>
		In_Place = 803750003,
		/// <summary>
		/// Menu_Chosen = 803750002
		/// </summary>
		Menu_Chosen = 803750002,
		/// <summary>
		/// OnLoad = 803750001
		/// </summary>
		OnLoad = 803750001,
		/// <summary>
		/// Popup = 803750000
		/// </summary>
		Popup = 803750000
	}

	public enum msdyusd_SingleMatchDecision
	{
		/// <summary>
		/// Create_Session_Load_Match_then_Do_Action = 803750003
		/// </summary>
		Create_Session_Load_Match_then_Do_Action = 803750003,
		/// <summary>
		/// Create_Session_then_Do_Action = 803750002
		/// </summary>
		Create_Session_then_Do_Action = 803750002,
		/// <summary>
		/// Do_Action = 803750000
		/// </summary>
		Do_Action = 803750000,
		/// <summary>
		/// Next_Rule = 803750001
		/// </summary>
		Next_Rule = 803750001
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
	public partial class msdyusd_windowroute : EntityBase
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
			public const string msdyusd_Action = "msdyusd_action";
			public const string msdyusd_Application = "msdyusd_application";
			public const string msdyusd_ApplicationAction = "msdyusd_applicationaction";
			public const string msdyusd_Condition = "msdyusd_condition";
			public const string msdyusd_DashboardFrame = "msdyusd_dashboardframe";
			public const string msdyusd_Destination = "msdyusd_destination";
			public const string msdyusd_Direction = "msdyusd_direction";
			public const string msdyusd_Entity = "msdyusd_entity";
			public const string msdyusd_EntitySearch = "msdyusd_entitysearch";
			public const string msdyusd_field = "msdyusd_field";
			public const string msdyusd_From = "msdyusd_from";
			public const string msdyusd_FromSearch = "msdyusd_fromsearch";
			public const string msdyusd_HideNavBar = "msdyusd_hidenavbar";
			public const string msdyusd_HideRibbon = "msdyusd_hideribbon";
			public const string msdyusd_InitiatingActivity = "msdyusd_initiatingactivity";
			public const string msdyusd_loadarea = "msdyusd_loadarea";
			public const string msdyusd_MultipleMatches = "msdyusd_multiplematches";
			public const string msdyusd_MultipleMatchesDecision = "msdyusd_multiplematchesdecision";
			public const string msdyusd_name = "msdyusd_name";
			public const string msdyusd_NoMatchDecision = "msdyusd_nomatchdecision";
			public const string msdyusd_NoMatchesAction = "msdyusd_nomatchesaction";
			public const string msdyusd_Order = "msdyusd_order";
			public const string msdyusd_RouteType = "msdyusd_routetype";
			public const string msdyusd_showtab = "msdyusd_showtab";
			public const string msdyusd_SingleMatchAction = "msdyusd_singlematchaction";
			public const string msdyusd_SingleMatchDecision = "msdyusd_singlematchdecision";
			public const string msdyusd_SourceFrame = "msdyusd_sourceframe";
			public const string msdyusd_url = "msdyusd_url";
			public const string msdyusd_windowrouteId = "msdyusd_windowrouteid";
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

		public const string EntityLogicalName = "msdyusd_windowroute";

		public const int EntityTypeCode = 10708;

		[DebuggerNonUserCode()]
		public msdyusd_windowroute()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyusd_windowroute(Guid msdyusd_windowrouteId)
		{
			Entity = new Entity(EntityLogicalName, msdyusd_windowrouteId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyusd_windowroute(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyusd_windowroute(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyusd_windowroute(Entity entity, Entity merge)
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
		public msdyusd_windowroute(KeyAttributeCollection keys)
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
		/// <para>Required - Picklist</para>
		/// <para>Action</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_Action? msdyusd_Action
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyusd_Action);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_Action)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyusd_Action] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Unique identifier for UII Hosted Application associated with Window Route.</para>
		/// <para>Lookup to uii_hostedapplication</para>
		/// <para>Target Tab</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_Application
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_Application); }
			set { Entity.Attributes[Fields.msdyusd_Application] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for Agent Script Action associated with Window Route.</para>
		/// <para>Lookup to msdyusd_agentscriptaction</para>
		/// <para>Application Action</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_ApplicationAction
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_ApplicationAction); }
			set { Entity.Attributes[Fields.msdyusd_ApplicationAction] = value; }
		}

		/// <summary>
		/// <para>Memo - MaxLength: 8000</para>
		/// <para>Condition</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyusd_Condition
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyusd_Condition); }
			set { Entity.Attributes[Fields.msdyusd_Condition] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Frame</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyusd_DashboardFrame
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyusd_DashboardFrame); }
			set { Entity.Attributes[Fields.msdyusd_DashboardFrame] = value; }
		}

		/// <summary>
		/// <para>Required - Picklist</para>
		/// <para>Destination</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_Destination? msdyusd_Destination
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyusd_Destination);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_Destination)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyusd_Destination] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Picklist</para>
		/// <para>Direction</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_Direction? msdyusd_Direction
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyusd_Direction);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_Direction)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyusd_Direction] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyusd_Direction] = null;
			}
		}

		/// <summary>
		/// <para>Unique identifier for Entity Numeric Mapping associated with Window Route.</para>
		/// <para>Lookup to msdyusd_entityassignment</para>
		/// <para>Entity</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_Entity
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_Entity); }
			set { Entity.Attributes[Fields.msdyusd_Entity] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for Entity Search associated with Routing Rule.</para>
		/// <para>Lookup to msdyusd_entitysearch</para>
		/// <para>Entity Search</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_EntitySearch
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_EntitySearch); }
			set { Entity.Attributes[Fields.msdyusd_EntitySearch] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Field</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyusd_field
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyusd_field); }
			set { Entity.Attributes[Fields.msdyusd_field] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for UII Hosted Application associated with Window Route.</para>
		/// <para>Lookup to uii_hostedapplication</para>
		/// <para>From</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_From
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_From); }
			set { Entity.Attributes[Fields.msdyusd_From] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for Entity Search associated with Window Route.</para>
		/// <para>Lookup to msdyusd_entitysearch</para>
		/// <para>From Search</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_FromSearch
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_FromSearch); }
			set { Entity.Attributes[Fields.msdyusd_FromSearch] = value; }
		}

		/// <summary>
		/// <para>Boolean</para>
		/// <para>Hide Navigation Bar</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyusd_HideNavBar
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyusd_HideNavBar); }
			set { Entity.Attributes[Fields.msdyusd_HideNavBar] = value; }
		}

		/// <summary>
		/// <para>Boolean</para>
		/// <para>Hide Command Bar</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? msdyusd_HideRibbon
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.msdyusd_HideRibbon); }
			set { Entity.Attributes[Fields.msdyusd_HideRibbon] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for Entity Type associated with Routing Rule.</para>
		/// <para>Lookup to msdyusd_entityassignment</para>
		/// <para>Initiating Activity</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_InitiatingActivity
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_InitiatingActivity); }
			set { Entity.Attributes[Fields.msdyusd_InitiatingActivity] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Load Area</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyusd_loadarea
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyusd_loadarea); }
			set { Entity.Attributes[Fields.msdyusd_loadarea] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for Action Call associated with Routing Rule.</para>
		/// <para>Lookup to msdyusd_agentscriptaction</para>
		/// <para>Multiple Matches</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_MultipleMatches
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_MultipleMatches); }
			set { Entity.Attributes[Fields.msdyusd_MultipleMatches] = value; }
		}

		/// <summary>
		/// <para>Picklist</para>
		/// <para>Decision</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_MultipleMatchesDecision? msdyusd_MultipleMatchesDecision
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyusd_MultipleMatchesDecision);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_MultipleMatchesDecision)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyusd_MultipleMatchesDecision] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyusd_MultipleMatchesDecision] = null;
			}
		}

		/// <summary>
		/// <para>The name of the custom entity.</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyusd_name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyusd_name); }
			set { Entity.Attributes[Fields.msdyusd_name] = value; }
		}

		/// <summary>
		/// <para>Picklist</para>
		/// <para>Decision</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_NoMatchDecision? msdyusd_NoMatchDecision
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyusd_NoMatchDecision);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_NoMatchDecision)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyusd_NoMatchDecision] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyusd_NoMatchDecision] = null;
			}
		}

		/// <summary>
		/// <para>Unique identifier for Action Call associated with Routing Rule.</para>
		/// <para>Lookup to msdyusd_agentscriptaction</para>
		/// <para>Action</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_NoMatchesAction
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_NoMatchesAction); }
			set { Entity.Attributes[Fields.msdyusd_NoMatchesAction] = value; }
		}

		/// <summary>
		/// <para>Required - Integer - MinValue: 1 - MaxValue: 2,147,483,647</para>
		/// <para>Order</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? msdyusd_Order
		{
			get { return Entity.GetAttributeValue<int?>(Fields.msdyusd_Order); }
			set { Entity.Attributes[Fields.msdyusd_Order] = value; }
		}

		/// <summary>
		/// <para>Required - Picklist</para>
		/// <para>Route Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_RouteType? msdyusd_RouteType
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyusd_RouteType);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_RouteType)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.msdyusd_RouteType] = new OptionSetValue((int)value);
}
		}

		/// <summary>
		/// <para>Unique identifier for UII Hosted Application associated with Window Route.</para>
		/// <para>Lookup to uii_hostedapplication</para>
		/// <para>showtab</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_showtab
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_showtab); }
			set { Entity.Attributes[Fields.msdyusd_showtab] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for Action Call associated with Routing Rule.</para>
		/// <para>Lookup to msdyusd_agentscriptaction</para>
		/// <para>Action</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyusd_SingleMatchAction
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyusd_SingleMatchAction); }
			set { Entity.Attributes[Fields.msdyusd_SingleMatchAction] = value; }
		}

		/// <summary>
		/// <para>Picklist</para>
		/// <para>Decision</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_SingleMatchDecision? msdyusd_SingleMatchDecision
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.msdyusd_SingleMatchDecision);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.msdyusd_SingleMatchDecision)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.msdyusd_SingleMatchDecision] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.msdyusd_SingleMatchDecision] = null;
			}
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Source Frame</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyusd_SourceFrame
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyusd_SourceFrame); }
			set { Entity.Attributes[Fields.msdyusd_SourceFrame] = value; }
		}

		/// <summary>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para>Url</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyusd_url
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyusd_url); }
			set { Entity.Attributes[Fields.msdyusd_url] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Window Route</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyusd_windowrouteId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyusd_windowrouteId] = value;
				Entity.Id = value;
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
		/// <para>Status of the Window Route</para>
		/// <para>State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.statecode? statecode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statecode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.statecode)value.Value;
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
		/// <para>Reason for the status of the Window Route</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.statuscode? statuscode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.statuscode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.msdyusd_windowrouteOptionSets.statuscode)value.Value;
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
