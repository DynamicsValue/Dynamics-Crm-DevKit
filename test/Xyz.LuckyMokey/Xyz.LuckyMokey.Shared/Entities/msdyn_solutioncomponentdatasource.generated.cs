﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Xyz.LuckyMokey.Shared.Entities.msdyn_solutioncomponentdatasourceOptionSets
{

}

namespace Xyz.LuckyMokey.Shared.Entities
{
	public partial class msdyn_solutioncomponentdatasource : EntityBase
	{
		public struct Fields
		{
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_solutioncomponentdatasourceId = "msdyn_solutioncomponentdatasourceid";
			public const string OrganizationId = "organizationid";
		}

		public const string EntityLogicalName = "msdyn_solutioncomponentdatasource";

		public const int EntityTypeCode = 10009;

		[DebuggerNonUserCode()]
		public msdyn_solutioncomponentdatasource()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_solutioncomponentdatasource(Guid msdyn_solutioncomponentdatasourceId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_solutioncomponentdatasourceId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_solutioncomponentdatasource(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_solutioncomponentdatasource(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_solutioncomponentdatasource(Entity entity, Entity merge)
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
		public msdyn_solutioncomponentdatasource(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>msdyn_name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_name
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_name); }
			set { Entity.Attributes[Fields.msdyn_name] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Solution Component Data Source</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_solutioncomponentdatasourceId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_solutioncomponentdatasourceId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Unique identifier for the organization</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Organization Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? OrganizationId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.OrganizationId); }
		}
	}
}