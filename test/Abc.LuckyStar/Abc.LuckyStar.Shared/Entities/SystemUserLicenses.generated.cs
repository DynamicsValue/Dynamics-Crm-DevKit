﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.LuckyStar.Shared.Entities.SystemUserLicensesOptionSets
{

}

namespace Abc.LuckyStar.Shared.Entities
{
	public partial class SystemUserLicenses : EntityBase
	{
		public struct Fields
		{
			public const string LicenseId = "licenseid";
			public const string SystemUserId = "systemuserid";
			public const string SystemUserLicenseId = "systemuserlicenseid";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "systemuserlicenses";

		public const int EntityTypeCode = 13;

		[DebuggerNonUserCode()]
		public SystemUserLicenses()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public SystemUserLicenses(Guid SystemUserLicensesId)
		{
			Entity = new Entity(EntityLogicalName, SystemUserLicensesId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public SystemUserLicenses(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public SystemUserLicenses(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public SystemUserLicenses(Entity entity, Entity merge)
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
		public SystemUserLicenses(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? LicenseId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.LicenseId); }
		}

		/// <summary>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? SystemUserId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.SystemUserId); }
		}

		/// <summary>
		/// <para>Unique identifier of the user licenses.</para>
		/// <para>Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? SystemUserLicenseId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.SystemUserLicenseId); }
			set { Entity.Attributes[Fields.SystemUserLicenseId] = value; }
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