﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_suggestedactivityOptionSets
{

}

namespace Dev.DevKit.Shared.Entities
{
	public partial class msdyn_suggestedactivity : EntityBase
	{
		public struct Fields
		{
			public const string msdyn_ActivityType = "msdyn_activitytype";
			public const string msdyn_BodyPreview = "msdyn_bodypreview";
			public const string msdyn_createddate = "msdyn_createddate";
			public const string msdyn_duration = "msdyn_duration";
			public const string msdyn_endtime = "msdyn_endtime";
			public const string msdyn_exchangeweblink = "msdyn_exchangeweblink";
			public const string msdyn_Importance = "msdyn_importance";
			public const string msdyn_location = "msdyn_location";
			public const string msdyn_regardingid = "msdyn_regardingid";
			public const string msdyn_regardingname = "msdyn_regardingname";
			public const string msdyn_sender = "msdyn_sender";
			public const string msdyn_sendername = "msdyn_sendername";
			public const string msdyn_starttime = "msdyn_starttime";
			public const string msdyn_Subject = "msdyn_subject";
			public const string msdyn_suggestedactivityId = "msdyn_suggestedactivityid";
			public const string msdyn_to = "msdyn_to";
		}

		public const string EntityLogicalName = "msdyn_suggestedactivity";

		public const int EntityTypeCode = 10227;

		[DebuggerNonUserCode()]
		public msdyn_suggestedactivity()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_suggestedactivity(Guid msdyn_suggestedactivityId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_suggestedactivityId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_suggestedactivity(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_suggestedactivity(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_suggestedactivity(Entity entity, Entity merge)
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
		public msdyn_suggestedactivity(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Activity</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_ActivityType
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_ActivityType); }
			set { Entity.Attributes[Fields.msdyn_ActivityType] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 300</para>
		/// <para>BodyPreview</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_BodyPreview
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_BodyPreview); }
			set { Entity.Attributes[Fields.msdyn_BodyPreview] = value; }
		}

		/// <summary>
		/// <para>Created Date</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created Date</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_createddateUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_createddate); }
			set { Entity.Attributes[Fields.msdyn_createddate] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 300</para>
		/// <para>Duration</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_duration
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_duration); }
			set { Entity.Attributes[Fields.msdyn_duration] = value; }
		}

		/// <summary>
		/// <para>End Time</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>End Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_endtimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_endtime); }
			set { Entity.Attributes[Fields.msdyn_endtime] = value; }
		}

		/// <summary>
		/// <para>Exchange web link</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Exchange web link</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_exchangeweblink
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_exchangeweblink); }
			set { Entity.Attributes[Fields.msdyn_exchangeweblink] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Importance</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Importance
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Importance); }
			set { Entity.Attributes[Fields.msdyn_Importance] = value; }
		}

		/// <summary>
		/// <para>Location</para>
		/// <para>String - MaxLength: 300</para>
		/// <para>Location</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_location
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_location); }
			set { Entity.Attributes[Fields.msdyn_location] = value; }
		}

		/// <summary>
		/// <para>Regarding</para>
		/// <para>Lookup to </para>
		/// <para>Regarding</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_regardingid
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_regardingid); }
			set { Entity.Attributes[Fields.msdyn_regardingid] = value; }
		}

		/// <summary>
		/// <para>Regarding Name</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Regarding Entity</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_regardingname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_regardingname); }
			set { Entity.Attributes[Fields.msdyn_regardingname] = value; }
		}

		/// <summary>
		/// <para>Sender</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Sender</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_sender
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_sender); }
			set { Entity.Attributes[Fields.msdyn_sender] = value; }
		}

		/// <summary>
		/// <para>Sender's Name</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Sender's Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_sendername
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_sendername); }
			set { Entity.Attributes[Fields.msdyn_sendername] = value; }
		}

		/// <summary>
		/// <para>Start Time</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Start Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_starttimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_starttime); }
			set { Entity.Attributes[Fields.msdyn_starttime] = value; }
		}

		/// <summary>
		/// <para>Required - String - MaxLength: 300</para>
		/// <para>Subject</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_Subject
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_Subject); }
			set { Entity.Attributes[Fields.msdyn_Subject] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Suggested Activity</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_suggestedactivityId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_suggestedactivityId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>To</para>
		/// <para>String - MaxLength: 300</para>
		/// <para>To</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_to
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_to); }
			set { Entity.Attributes[Fields.msdyn_to] = value; }
		}
	}
}