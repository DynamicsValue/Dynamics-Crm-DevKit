﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.OfflineCommandDefinitionOptionSets
{

}

namespace Dev.DevKit.Shared.Entities
{
	public partial class OfflineCommandDefinition : EntityBase
	{
		public struct Fields
		{
			public const string CommandDefinition = "commanddefinition";
			public const string CommandDefinitionId = "commanddefinitionid";
			public const string CommandName = "commandname";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string PrimaryEntityLogicalName = "primaryentitylogicalname";
			public const string SolutionName = "solutionname";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "offlinecommanddefinition";

		public const int EntityTypeCode = 9870;

		[DebuggerNonUserCode()]
		public OfflineCommandDefinition()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public OfflineCommandDefinition(Guid OfflineCommandDefinitionId)
		{
			Entity = new Entity(EntityLogicalName, OfflineCommandDefinitionId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public OfflineCommandDefinition(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public OfflineCommandDefinition(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public OfflineCommandDefinition(Entity entity, Entity merge)
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
		public OfflineCommandDefinition(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Command Definition of Non Crud Command</para>
		/// <para>Memo - MaxLength: 1073741823</para>
		/// <para>Command Definition data in JSON format.</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string CommandDefinition
		{
			get { return Entity.GetAttributeValue<string>(Fields.CommandDefinition); }
			set { Entity.Attributes[Fields.CommandDefinition] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the Command Definition for the Microsoft Dynamics 365.</para>
		/// <para>Uniqueidentifier</para>
		/// <para>Command Definition Identifier</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? CommandDefinitionId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.CommandDefinitionId); }
			set { Entity.Attributes[Fields.CommandDefinitionId] = value; }
		}

		/// <summary>
		/// <para>Command Name of Non Crud Command.</para>
		/// <para>String - MaxLength: 200</para>
		/// <para>Command Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string CommandName
		{
			get { return Entity.GetAttributeValue<string>(Fields.CommandName); }
			set { Entity.Attributes[Fields.CommandName] = value; }
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
		/// <para>Unique identifier of the organization associated with the non crud command.</para>
		/// <para>ReadOnly - Lookup to organization</para>
		/// <para>Organization</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OrganizationId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OrganizationId); }
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
		/// <para>Primary Entity Logical Name of entity for which command is used</para>
		/// <para>String - MaxLength: 256</para>
		/// <para>Primary Entity Logical Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string PrimaryEntityLogicalName
		{
			get { return Entity.GetAttributeValue<string>(Fields.PrimaryEntityLogicalName); }
			set { Entity.Attributes[Fields.PrimaryEntityLogicalName] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the solution.</para>
		/// <para>String - MaxLength: 256</para>
		/// <para>Solution Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string SolutionName
		{
			get { return Entity.GetAttributeValue<string>(Fields.SolutionName); }
			set { Entity.Attributes[Fields.SolutionName] = value; }
		}

		/// <summary>
		/// <para>Internal use Only</para>
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