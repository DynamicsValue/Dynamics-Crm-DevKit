﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Xyz.LuckyMokey.Shared.Entities.TopicHistoryOptionSets
{

}

namespace Xyz.LuckyMokey.Shared.Entities
{
	public partial class TopicHistory : EntityBase
	{
		public struct Fields
		{
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string KeyPhrase = "keyphrase";
			public const string Name = "name";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TopicHistoryId = "topichistoryid";
			public const string TopicModelExecutionHistoryId = "topicmodelexecutionhistoryid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string Weight = "weight";
		}

		public const string EntityLogicalName = "topichistory";

		public const int EntityTypeCode = 9946;

		[DebuggerNonUserCode()]
		public TopicHistory()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TopicHistory(Guid TopicHistoryId)
		{
			Entity = new Entity(EntityLogicalName, TopicHistoryId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TopicHistory(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TopicHistory(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TopicHistory(Entity entity, Entity merge)
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
		public TopicHistory(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Sequence number of the import that created this record.</para>
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
		/// <para>Key Phrase of the custom entity.</para>
		/// <para>String - MaxLength: 1024</para>
		/// <para>KeyPhrase</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string KeyPhrase
		{
			get { return Entity.GetAttributeValue<string>(Fields.KeyPhrase); }
			set { Entity.Attributes[Fields.KeyPhrase] = value; }
		}

		/// <summary>
		/// <para>name</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
			set { Entity.Attributes[Fields.Name] = value; }
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
		/// <para>For internal use only.</para>
		/// <para>Integer - MinValue: -1 - MaxValue: 2,147,483,647</para>
		/// <para>Time Zone Rule Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? TimeZoneRuleVersionNumber
		{
			get { return Entity.GetAttributeValue<int?>(Fields.TimeZoneRuleVersionNumber); }
			set { Entity.Attributes[Fields.TimeZoneRuleVersionNumber] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>TopicHistory</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid TopicHistoryId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.TopicHistoryId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Unique identifier for Model associated with Topic Model Execution History.</para>
		/// <para>Required - Lookup</para>
		/// <para>TopicModelExecutionHistoryId</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference TopicModelExecutionHistoryId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.TopicModelExecutionHistoryId); }
			set { Entity.Attributes[Fields.TopicModelExecutionHistoryId] = value; }
		}

		/// <summary>
		/// <para>Time zone code that was in use when the record was created.</para>
		/// <para>Integer - MinValue: -1 - MaxValue: 2,147,483,647</para>
		/// <para>UTC Conversion Time Zone Code</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? UTCConversionTimeZoneCode
		{
			get { return Entity.GetAttributeValue<int?>(Fields.UTCConversionTimeZoneCode); }
			set { Entity.Attributes[Fields.UTCConversionTimeZoneCode] = value; }
		}

		/// <summary>
		/// <para>Version Number</para>
		/// <para>ReadOnly - BigInt</para>
		/// <para>Version Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public long? VersionNumber
		{
			get { return Entity.GetAttributeValue<long?>(Fields.VersionNumber); }
		}

		/// <summary>
		/// <para>Weight</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Weight</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? Weight
		{
			get { return Entity.GetAttributeValue<int?>(Fields.Weight); }
			set { Entity.Attributes[Fields.Weight] = value; }
		}
	}
}