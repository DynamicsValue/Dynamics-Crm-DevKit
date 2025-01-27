﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.MetadataDifferenceOptionSets
{

}

namespace Dev.DevKit.Shared.Entities
{
	public partial class MetadataDifference : EntityBase
	{
		public struct Fields
		{
			public const string CreatedOn = "createdon";
			public const string DifferenceXml = "differencexml";
			public const string IntroducedVersion = "introducedversion";
			public const string IntroducedVersionString = "introducedversionstring";
			public const string MetadataDifferenceId = "metadatadifferenceid";
			public const string ModifiedOn = "modifiedon";
			public const string SolutionId = "solutionid";
		}

		public const string EntityLogicalName = "metadatadifference";

		public const int EntityTypeCode = 4231;

		[DebuggerNonUserCode()]
		public MetadataDifference()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MetadataDifference(Guid MetadataDifferenceId)
		{
			Entity = new Entity(EntityLogicalName, MetadataDifferenceId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MetadataDifference(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MetadataDifference(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MetadataDifference(Entity entity, Entity merge)
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
		public MetadataDifference(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Date and time when the metadata difference was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Difference Xml</para>
		/// <para>String - MaxLength: 100</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string DifferenceXml
		{
			get { return Entity.GetAttributeValue<string>(Fields.DifferenceXml); }
			set { Entity.Attributes[Fields.DifferenceXml] = value; }
		}

		/// <summary>
		/// <para>Introduced Version</para>
		/// <para>Double - MinValue: 0 - MaxValue: 1,000,000,000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public double? IntroducedVersion
		{
			get { return Entity.GetAttributeValue<double?>(Fields.IntroducedVersion); }
			set { Entity.Attributes[Fields.IntroducedVersion] = value; }
		}

		/// <summary>
		/// <para>Version in which the differences were introduced.</para>
		/// <para>String - MaxLength: 48</para>
		/// <para>Introduced Version String</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string IntroducedVersionString
		{
			get { return Entity.GetAttributeValue<string>(Fields.IntroducedVersionString); }
			set { Entity.Attributes[Fields.IntroducedVersionString] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the metadata difference.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid MetadataDifferenceId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.MetadataDifferenceId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Date and time when the metadata difference was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
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
	}
}
