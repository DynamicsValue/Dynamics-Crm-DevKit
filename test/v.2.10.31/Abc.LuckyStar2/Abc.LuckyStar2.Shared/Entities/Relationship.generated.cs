﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.LuckyStar2.Shared.Entities.RelationshipOptionSets
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

namespace Abc.LuckyStar2.Shared.Entities
{
	public partial class Relationship : EntityBase
	{
		public struct Fields
		{
			public const string ComponentState = "componentstate";
			public const string EntityKeyId = "entitykeyid";
			public const string Name = "name";
			public const string OverwriteTime = "overwritetime";
			public const string RelationshipId = "relationshipid";
			public const string SolutionId = "solutionid";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "relationship";

		public const int EntityTypeCode = 9813;

		[DebuggerNonUserCode()]
		public Relationship()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Relationship(Guid RelationshipId)
		{
			Entity = new Entity(EntityLogicalName, RelationshipId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Relationship(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Relationship(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public Relationship(Entity entity, Entity merge)
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
		public Relationship(KeyAttributeCollection keys)
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
		public Abc.LuckyStar2.Shared.Entities.RelationshipOptionSets.ComponentState? ComponentState
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ComponentState);
				if (value == null) return null;
				return (Abc.LuckyStar2.Shared.Entities.RelationshipOptionSets.ComponentState)value.Value;
			}
		}

		/// <summary>
		/// <para>Referenced Entity's Alternate Key</para>
		/// <para>Uniqueidentifier</para>
		/// <para>Entity Key Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? EntityKeyId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.EntityKeyId); }
			set { Entity.Attributes[Fields.EntityKeyId] = value; }
		}

		/// <summary>
		/// <para>Name of the relationship.</para>
		/// <para>String - MaxLength: 255</para>
		/// <para>Relationship Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
			set { Entity.Attributes[Fields.Name] = value; }
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
		/// <para>Unique identifier of the entity relationship.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Relationship Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid RelationshipId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.RelationshipId] = value;
				Entity.Id = value;
			}
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
		/// <para>The version number of this relationship.</para>
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