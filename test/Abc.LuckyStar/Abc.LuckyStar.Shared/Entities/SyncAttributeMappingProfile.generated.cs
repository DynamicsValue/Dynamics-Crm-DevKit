﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.LuckyStar.Shared.Entities.SyncAttributeMappingProfileOptionSets
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
}

namespace Abc.LuckyStar.Shared.Entities
{
	public partial class SyncAttributeMappingProfile : EntityBase
	{
		public struct Fields
		{
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string SolutionId = "solutionid";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string SyncAttributeMappingProfileId = "syncattributemappingprofileid";
			public const string SyncAttributeMappingProfileIdUnique = "syncattributemappingprofileidunique";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "syncattributemappingprofile";

		public const int EntityTypeCode = 1400;

		[DebuggerNonUserCode()]
		public SyncAttributeMappingProfile()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public SyncAttributeMappingProfile(Guid SyncAttributeMappingProfileId)
		{
			Entity = new Entity(EntityLogicalName, SyncAttributeMappingProfileId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public SyncAttributeMappingProfile(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public SyncAttributeMappingProfile(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public SyncAttributeMappingProfile(Entity entity, Entity merge)
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
		public SyncAttributeMappingProfile(KeyAttributeCollection keys)
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
		public Abc.LuckyStar.Shared.Entities.SyncAttributeMappingProfileOptionSets.ComponentState? ComponentState
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ComponentState);
				if (value == null) return null;
				return (Abc.LuckyStar.Shared.Entities.SyncAttributeMappingProfileOptionSets.ComponentState)value.Value;
			}
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the profile.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Date and time when the profile was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the role.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By Impersonator</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Description of the Profile</para>
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
		/// <para>Indicates whether the solution component is part of a managed solution.</para>
		/// <para>ReadOnly - Boolean</para>
		/// <para>Is Managed</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsManaged
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsManaged); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who last modified the profile.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Date and time when the profile was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who last modified the profile.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Name of the profile.</para>
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
		/// <para>Unique identifier of the associated organization.</para>
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
		/// <para>Unique identifier of the profile.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Sync-Attribute Mapping Profile</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid SyncAttributeMappingProfileId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.SyncAttributeMappingProfileId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Sync-Attribute Mapping Profile</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? SyncAttributeMappingProfileIdUnique
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.SyncAttributeMappingProfileIdUnique); }
		}

		/// <summary>
		/// <para>ReadOnly - BigInt</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? VersionNumber
		{
			get { return Entity.GetAttributeValue<long?>(Fields.VersionNumber); }
		}
	}
}