﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Abc.MyDog.Shared.Entities.EmailHashOptionSets
{

}

namespace Abc.MyDog.Shared.Entities
{
	public partial class EmailHash : EntityBase
	{
		public struct Fields
		{
			public const string ActivityId = "activityid";
			public const string EmailHashId = "emailhashid";
			public const string Hash = "hash";
			public const string HashType = "hashtype";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "emailhash";

		public const int EntityTypeCode = 4023;

		[DebuggerNonUserCode()]
		public EmailHash()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public EmailHash(Guid EmailHashId)
		{
			Entity = new Entity(EntityLogicalName, EmailHashId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public EmailHash(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public EmailHash(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public EmailHash(Entity entity, Entity merge)
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
		public EmailHash(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the activity with which the hash is associated.</para>
		/// <para>Lookup</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ActivityId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ActivityId); }
			set { Entity.Attributes[Fields.ActivityId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the email hash.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid EmailHashId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.EmailHashId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Hash value.</para>
		/// <para>Integer - MinValue: -2,147,483,648 - MaxValue: 2,147,483,647</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? Hash
		{
			get { return Entity.GetAttributeValue<int?>(Fields.Hash); }
			set { Entity.Attributes[Fields.Hash] = value; }
		}

		/// <summary>
		/// <para>Hash type.</para>
		/// <para>Integer - MinValue: -2,147,483,648 - MaxValue: 2,147,483,647</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? HashType
		{
			get { return Entity.GetAttributeValue<int?>(Fields.HashType); }
			set { Entity.Attributes[Fields.HashType] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user or team who owns the email hash.</para>
		/// <para>ReadOnly - Required - Owner</para>
		/// <para>Owner</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwnerId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwnerId); }
		}

		/// <summary>
		/// <para>Unique identifier of the business unit that owns the email hash.</para>
		/// <para>ReadOnly - Required - Uniqueidentifier</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who owns the email hash.</para>
		/// <para>ReadOnly - Required - Uniqueidentifier</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? OwningUser
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.OwningUser); }
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