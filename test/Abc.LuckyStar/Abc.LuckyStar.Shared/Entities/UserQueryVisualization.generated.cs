﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.LuckyStar.Shared.Entities.UserQueryVisualizationOptionSets
{
	public enum ChartType
	{
		/// <summary>
		/// ASPNET_Charts = 0
		/// </summary>
		ASPNET_Charts = 0,
		/// <summary>
		/// Power_BI = 1
		/// </summary>
		Power_BI = 1
	}
}

namespace Abc.LuckyStar.Shared.Entities
{
	public partial class UserQueryVisualization : EntityBase
	{
		public struct Fields
		{
			public const string ChartType = "charttype";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DataDescription = "datadescription";
			public const string Description = "description";
			public const string IsDefault = "isdefault";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string PresentationDescription = "presentationdescription";
			public const string PrimaryEntityTypeCode = "primaryentitytypecode";
			public const string UserQueryVisualizationId = "userqueryvisualizationid";
			public const string VersionNumber = "versionnumber";
			public const string WebResourceId = "webresourceid";
		}

		public const string EntityLogicalName = "userqueryvisualization";

		public const int EntityTypeCode = 1112;

		[DebuggerNonUserCode()]
		public UserQueryVisualization()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public UserQueryVisualization(Guid UserQueryVisualizationId)
		{
			Entity = new Entity(EntityLogicalName, UserQueryVisualizationId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public UserQueryVisualization(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public UserQueryVisualization(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public UserQueryVisualization(Entity entity, Entity merge)
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
		public UserQueryVisualization(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Indicates the library used to render the visualization.</para>
		/// <para>Required - Picklist</para>
		/// <para>Chart Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.LuckyStar.Shared.Entities.UserQueryVisualizationOptionSets.ChartType? ChartType
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ChartType);
				if (value == null) return null;
				return (Abc.LuckyStar.Shared.Entities.UserQueryVisualizationOptionSets.ChartType)value.Value;
			}
			set
	{
		Entity.Attributes[Fields.ChartType] = new OptionSetValue((int)value);
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
		/// <para>Shows the fields that are used to display data in a chart, stored in XML format.</para>
		/// <para>Memo - MaxLength: 1073741823</para>
		/// <para>Data XML</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string DataDescription
		{
			get { return Entity.GetAttributeValue<string>(Fields.DataDescription); }
			set { Entity.Attributes[Fields.DataDescription] = value; }
		}

		/// <summary>
		/// <para>Type additional information to describe the chart, such as the filter criteria or intended audience.</para>
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
		/// <para>Select whether the chart is the default chart for the view that it is associated with.</para>
		/// <para>Boolean</para>
		/// <para>Default Chart</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsDefault
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsDefault); }
			set { Entity.Attributes[Fields.IsDefault] = value; }
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
		/// <para>Last Modified</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Shows who created the record on behalf of another user.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Type a descriptive name for the chart.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
			set { Entity.Attributes[Fields.Name] = value; }
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
		/// <para>ReadOnly - Required - Lookup</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the team who owns the user chart.</para>
		/// <para>ReadOnly - Required - Lookup</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier of the team who owns the user chart.</para>
		/// <para>ReadOnly - Required - Lookup</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>Contains the chart's formatting details and presentation properties, stored in XML format.</para>
		/// <para>Memo - MaxLength: 1073741823</para>
		/// <para>Presentation XML</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string PresentationDescription
		{
			get { return Entity.GetAttributeValue<string>(Fields.PresentationDescription); }
			set { Entity.Attributes[Fields.PresentationDescription] = value; }
		}

		/// <summary>
		/// <para>Type of entity which the user chart is attached.</para>
		/// <para>EntityName</para>
		/// <para>Primary Type Code</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string PrimaryEntityTypeCode
		{
			get { return Entity.GetAttributeValue<string>(Fields.PrimaryEntityTypeCode); }
			set { Entity.Attributes[Fields.PrimaryEntityTypeCode] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user chart.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>User Chart</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid UserQueryVisualizationId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.UserQueryVisualizationId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Version number of the user chart.</para>
		/// <para>ReadOnly - BigInt</para>
		/// <para>Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? VersionNumber
		{
			get { return Entity.GetAttributeValue<long?>(Fields.VersionNumber); }
		}

		/// <summary>
		/// <para>Shows the web resource that will be displayed in the chart to the user.</para>
		/// <para>Lookup</para>
		/// <para>Web Resource</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference WebResourceId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.WebResourceId); }
			set { Entity.Attributes[Fields.WebResourceId] = value; }
		}
	}
}