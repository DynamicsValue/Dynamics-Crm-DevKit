﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.LuckyStar.Shared.Entities.MobileOfflineProfileItemOptionSets
{
	public enum ComponentState
	{
		/// <summary>
		/// Published = 0
		/// </summary>
		Published = 0,
		/// <summary>
		/// Unpublished = 1
		/// </summary>
		Unpublished = 1,
		/// <summary>
		/// Deleted = 2
		/// </summary>
		Deleted = 2,
		/// <summary>
		/// Deleted_Unpublished = 3
		/// </summary>
		Deleted_Unpublished = 3
	}

	public enum RecordDistributionCriteria
	{
		/// <summary>
		/// Download_related_data_only = 0
		/// </summary>
		Download_related_data_only = 0,
		/// <summary>
		/// All_records = 1
		/// </summary>
		All_records = 1,
		/// <summary>
		/// Other_data_filter = 2
		/// </summary>
		Other_data_filter = 2,
		/// <summary>
		/// Custom_data_filter = 3
		/// </summary>
		Custom_data_filter = 3
	}
}

namespace Abc.LuckyStar.Shared.Entities
{
	public partial class MobileOfflineProfileItem : EntityBase
	{
		public struct Fields
		{
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string EntityObjectTypeCode = "entityobjecttypecode";
			public const string IntroducedVersion = "introducedversion";
			public const string IsManaged = "ismanaged";
			public const string IsValidated = "isvalidated";
			public const string IsVisibleInGrid = "isvisibleingrid";
			public const string MobileOfflineProfileItemId = "mobileofflineprofileitemid";
			public const string MobileOfflineProfileItemIdUnique = "mobileofflineprofileitemidunique";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string ProcessId = "processid";
			public const string ProfileItemEntityFilter = "profileitementityfilter";
			public const string PublishedOn = "publishedon";
			public const string RecordDistributionCriteria = "recorddistributioncriteria";
			public const string RecordsOwnedByMe = "recordsownedbyme";
			public const string RecordsOwnedByMyBusinessUnit = "recordsownedbymybusinessunit";
			public const string RecordsOwnedByMyTeam = "recordsownedbymyteam";
			public const string RegardingObjectId = "regardingobjectid";
			public const string RelationshipData = "relationshipdata";
			public const string SelectedEntityMetadata = "selectedentitymetadata";
			public const string SelectedEntityTypeCode = "selectedentitytypecode";
			public const string SolutionId = "solutionid";
			public const string StageId = "stageid";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string TraversedPath = "traversedpath";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "mobileofflineprofileitem";

		public const int EntityTypeCode = 9867;

		[DebuggerNonUserCode()]
		public MobileOfflineProfileItem()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MobileOfflineProfileItem(Guid MobileOfflineProfileItemId)
		{
			Entity = new Entity(EntityLogicalName, MobileOfflineProfileItemId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MobileOfflineProfileItem(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MobileOfflineProfileItem(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MobileOfflineProfileItem(Entity entity, Entity merge)
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
		public MobileOfflineProfileItem(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Picklist</para>
		/// <para>Component State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.LuckyStar.Shared.Entities.MobileOfflineProfileItemOptionSets.ComponentState? ComponentState
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ComponentState);
				if (value == null) return null;
				return (Abc.LuckyStar.Shared.Entities.MobileOfflineProfileItemOptionSets.ComponentState)value.Value;
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
		/// <para>Internal Use Only</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 1,000,000,000</para>
		/// <para>Internal Use Only</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? EntityObjectTypeCode
		{
			get { return Entity.GetAttributeValue<int?>(Fields.EntityObjectTypeCode); }
		}

		/// <summary>
		/// <para>Version in which the Mobile offline Profile Item is introduced.</para>
		/// <para>String - MaxLength: 48</para>
		/// <para>Introduced Version</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string IntroducedVersion
		{
			get { return Entity.GetAttributeValue<string>(Fields.IntroducedVersion); }
			set { Entity.Attributes[Fields.IntroducedVersion] = value; }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Boolean</para>
		/// <para>Is Managed</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsManaged
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsManaged); }
		}

		/// <summary>
		/// <para>Information about whether profile item is validated or not</para>
		/// <para>ReadOnly - Boolean</para>
		/// <para>Is Valid For Mobile Offline</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsValidated
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsValidated); }
		}

		/// <summary>
		/// <para>Information about whether the mobile offline profile item is visible in the Profile Item subgrid.</para>
		/// <para>Boolean</para>
		/// <para>Is Visible In Grid</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsVisibleInGrid
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsVisibleInGrid); }
			set { Entity.Attributes[Fields.IsVisibleInGrid] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the mobile offline profile item.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Mobile Offline Profile Item</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid MobileOfflineProfileItemId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.MobileOfflineProfileItemId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>For Internal Use Only</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Unique Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? MobileOfflineProfileItemIdUnique
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.MobileOfflineProfileItemIdUnique); }
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
		/// <para>Shows who updated the record on behalf of another user.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Enter the name of the mobile offline profile item.</para>
		/// <para>String - MaxLength: 255</para>
		/// <para>Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
			set { Entity.Attributes[Fields.Name] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the organization associated with the Mobile Offline Profile Item.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Organization</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OrganizationId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OrganizationId); }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Record Overwrite Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? OverwriteTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.OverwriteTime); }
		}

		/// <summary>
		/// <para>Shows the ID of the process.</para>
		/// <para>Uniqueidentifier</para>
		/// <para>Process</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? ProcessId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.ProcessId); }
			set { Entity.Attributes[Fields.ProcessId] = value; }
		}

		/// <summary>
		/// <para>Profile item entity filter criteria</para>
		/// <para>Memo - MaxLength: 1073741823</para>
		/// <para>Profile item entity filter</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string ProfileItemEntityFilter
		{
			get { return Entity.GetAttributeValue<string>(Fields.ProfileItemEntityFilter); }
			set { Entity.Attributes[Fields.ProfileItemEntityFilter] = value; }
		}

		/// <summary>
		/// <para>Displays the last published date time.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Published On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? PublishedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.PublishedOn); }
		}

		/// <summary>
		/// <para>Specify data download filter for selected entity</para>
		/// <para>Picklist</para>
		/// <para>Data Download Filter</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.LuckyStar.Shared.Entities.MobileOfflineProfileItemOptionSets.RecordDistributionCriteria? RecordDistributionCriteria
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.RecordDistributionCriteria);
				if (value == null) return null;
				return (Abc.LuckyStar.Shared.Entities.MobileOfflineProfileItemOptionSets.RecordDistributionCriteria)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.RecordDistributionCriteria] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.RecordDistributionCriteria] = null;
			}
		}

		/// <summary>
		/// <para>Download my records</para>
		/// <para>Boolean</para>
		/// <para>Download my records</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? RecordsOwnedByMe
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.RecordsOwnedByMe); }
			set { Entity.Attributes[Fields.RecordsOwnedByMe] = value; }
		}

		/// <summary>
		/// <para>Download my business unit's records</para>
		/// <para>Boolean</para>
		/// <para>Download my business unit's records</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? RecordsOwnedByMyBusinessUnit
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.RecordsOwnedByMyBusinessUnit); }
			set { Entity.Attributes[Fields.RecordsOwnedByMyBusinessUnit] = value; }
		}

		/// <summary>
		/// <para>Download my team's records</para>
		/// <para>Boolean</para>
		/// <para>Download my team's records</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? RecordsOwnedByMyTeam
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.RecordsOwnedByMyTeam); }
			set { Entity.Attributes[Fields.RecordsOwnedByMyTeam] = value; }
		}

		/// <summary>
		/// <para>Items contained with a particular Profile.</para>
		/// <para>Lookup</para>
		/// <para>Regarding</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference RegardingObjectId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.RegardingObjectId); }
			set { Entity.Attributes[Fields.RegardingObjectId] = value; }
		}

		/// <summary>
		/// <para>Internal Use Only</para>
		/// <para>Memo - MaxLength: 1073741823</para>
		/// <para>Internal Use Only</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string RelationshipData
		{
			get { return Entity.GetAttributeValue<string>(Fields.RelationshipData); }
			set { Entity.Attributes[Fields.RelationshipData] = value; }
		}

		/// <summary>
		/// <para>Internal Use Only</para>
		/// <para>ReadOnly - Memo - MaxLength: 1073741823</para>
		/// <para>Internal Use Only</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string SelectedEntityMetadata
		{
			get { return Entity.GetAttributeValue<string>(Fields.SelectedEntityMetadata); }
		}

		/// <summary>
		/// <para>Mobile offline enabled entity</para>
		/// <para>EntityName</para>
		/// <para>Entity</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string SelectedEntityTypeCode
		{
			get { return Entity.GetAttributeValue<string>(Fields.SelectedEntityTypeCode); }
			set { Entity.Attributes[Fields.SelectedEntityTypeCode] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the associated solution.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Solution</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? SolutionId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.SolutionId); }
		}

		/// <summary>
		/// <para>Shows the ID of the stage.</para>
		/// <para>Uniqueidentifier</para>
		/// <para>(Deprecated) Process Stage</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? StageId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.StageId); }
			set { Entity.Attributes[Fields.StageId] = value; }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Solution</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? SupportingSolutionId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.SupportingSolutionId); }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>String - MaxLength: 1250</para>
		/// <para>(Deprecated) Traversed Path</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string TraversedPath
		{
			get { return Entity.GetAttributeValue<string>(Fields.TraversedPath); }
			set { Entity.Attributes[Fields.TraversedPath] = value; }
		}

		/// <summary>
		/// <para>Version number of the Mobile Offline Profile Item.</para>
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