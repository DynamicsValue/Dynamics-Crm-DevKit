﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.MyDog.Shared.Entities.RelationshipAttributeOptionSets
{
	public enum ComponentState
	{
		/// <summary>
		/// Deleted = 2
		/// </summary>
		Deleted = 2,
		/// <summary>
		/// Deleted_Unpublished = 3
		/// </summary>
		Deleted_Unpublished = 3,
		/// <summary>
		/// Published = 0
		/// </summary>
		Published = 0,
		/// <summary>
		/// Unpublished = 1
		/// </summary>
		Unpublished = 1
	}
}

namespace Abc.MyDog.Shared.Entities
{
	public partial class RelationshipAttribute : EntityBase
	{
		public struct Fields
		{
			public const string ComponentIdUnique = "componentidunique";
			public const string ComponentState = "componentstate";
			public const string IsManaged = "ismanaged";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string ReferencedAttributeId = "referencedattributeid";
			public const string ReferencingAttributeId = "referencingattributeid";
			public const string RelationshipAttributeId = "relationshipattributeid";
			public const string RelationshipId = "relationshipid";
			public const string SolutionId = "solutionid";
			public const string SupportingSolutionId = "supportingsolutionid";
		}

		public const string EntityLogicalName = "relationshipattribute";

		public const int EntityTypeCode = 9814;

		[DebuggerNonUserCode()]
		public RelationshipAttribute()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public RelationshipAttribute(Guid RelationshipAttributeId)
		{
			Entity = new Entity(EntityLogicalName, RelationshipAttributeId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public RelationshipAttribute(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public RelationshipAttribute(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public RelationshipAttribute(Entity entity, Entity merge)
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
		public RelationshipAttribute(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Row id unique</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? ComponentIdUnique
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.ComponentIdUnique); }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Picklist</para>
		/// <para>Component State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Abc.MyDog.Shared.Entities.RelationshipAttributeOptionSets.ComponentState? ComponentState
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ComponentState);
				if (value == null) return null;
				return (Abc.MyDog.Shared.Entities.RelationshipAttributeOptionSets.ComponentState)value.Value;
			}
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
		/// <para>Display Name</para>
		/// <para>String - MaxLength: 128</para>
		/// <para>Display Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
			set { Entity.Attributes[Fields.Name] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for the organization</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Organization Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OrganizationId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OrganizationId); }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Record Overwrite Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? OverwriteTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.OverwriteTime); }
		}

		/// <summary>
		/// <para>Referenced Attribute Id</para>
		/// <para>Lookup</para>
		/// <para>Referenced Attribute Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ReferencedAttributeId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ReferencedAttributeId); }
			set { Entity.Attributes[Fields.ReferencedAttributeId] = value; }
		}

		/// <summary>
		/// <para>Referencing Attribute Id</para>
		/// <para>Lookup</para>
		/// <para>Referencing Attribute Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ReferencingAttributeId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ReferencingAttributeId); }
			set { Entity.Attributes[Fields.ReferencingAttributeId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the relationship attribute</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Relationship Attribute Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid RelationshipAttributeId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.RelationshipAttributeId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Relationship Id</para>
		/// <para>Lookup</para>
		/// <para>Relationship Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference RelationshipId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.RelationshipId); }
			set { Entity.Attributes[Fields.RelationshipId] = value; }
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
	}
}