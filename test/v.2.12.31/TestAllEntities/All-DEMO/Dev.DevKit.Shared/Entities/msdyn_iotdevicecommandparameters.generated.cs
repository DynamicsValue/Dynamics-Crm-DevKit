﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_iotdevicecommandparametersOptionSets
{

}

namespace Dev.DevKit.Shared.Entities
{
	public partial class msdyn_iotdevicecommandparameters : EntityBase
	{
		public struct Fields
		{
			public const string msdyn_iotdevicecommanddefinitionid = "msdyn_iotdevicecommanddefinitionid";
			public const string msdyn_iotdevicecommandparametersId = "msdyn_iotdevicecommandparametersid";
			public const string msdyn_iotpropertydefinitionid = "msdyn_iotpropertydefinitionid";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "msdyn_iotdevicecommandparameters";

		public const int EntityTypeCode = 10141;

		[DebuggerNonUserCode()]
		public msdyn_iotdevicecommandparameters()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_iotdevicecommandparameters(Guid msdyn_iotdevicecommandparametersId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_iotdevicecommandparametersId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_iotdevicecommandparameters(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_iotdevicecommandparameters(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_iotdevicecommandparameters(Entity entity, Entity merge)
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
		public msdyn_iotdevicecommandparameters(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? msdyn_iotdevicecommanddefinitionid
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.msdyn_iotdevicecommanddefinitionid); }
		}

		/// <summary>
		/// <para>ReadOnly - Primary Key - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_iotdevicecommandparametersId
		{
			get { return Id; }
		}

		/// <summary>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? msdyn_iotpropertydefinitionid
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.msdyn_iotpropertydefinitionid); }
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