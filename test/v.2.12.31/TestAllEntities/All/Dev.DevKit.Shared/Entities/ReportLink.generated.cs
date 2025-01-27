﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.ReportLinkOptionSets
{
	public enum LinkTypeCode
	{
		/// <summary>
		/// Drill_through = 1
		/// </summary>
		Drill_through = 1,
		/// <summary>
		/// Drill_through_and_sub_report = 3
		/// </summary>
		Drill_through_and_sub_report = 3,
		/// <summary>
		/// Sub_report = 2
		/// </summary>
		Sub_report = 2
	}
}

namespace Dev.DevKit.Shared.Entities
{
	public partial class ReportLink : EntityBase
	{
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string LinkedReportId = "linkedreportid";
			public const string LinkedReportName = "linkedreportname";
			public const string LinkTypeCode = "linktypecode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string ReportId = "reportid";
			public const string ReportLinkId = "reportlinkid";
			public const string ReportLinkIdUnique = "reportlinkidunique";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "reportlink";

		public const int EntityTypeCode = 9104;

		[DebuggerNonUserCode()]
		public ReportLink()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ReportLink(Guid ReportLinkId)
		{
			Entity = new Entity(EntityLogicalName, ReportLinkId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ReportLink(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ReportLink(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ReportLink(Entity entity, Entity merge)
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
		public ReportLink(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the report link.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Date and time when the report link record was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the reportlink.</para>
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
		/// <para>Unique identifier of the linked report.</para>
		/// <para>Lookup to report</para>
		/// <para>Linked Report</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference LinkedReportId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.LinkedReportId); }
			set { Entity.Attributes[Fields.LinkedReportId] = value; }
		}

		/// <summary>
		/// <para>Name of the linked report.</para>
		/// <para>String - MaxLength: 255</para>
		/// <para>Linked Report Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string LinkedReportName
		{
			get { return Entity.GetAttributeValue<string>(Fields.LinkedReportName); }
			set { Entity.Attributes[Fields.LinkedReportName] = value; }
		}

		/// <summary>
		/// <para>Link type of the report.</para>
		/// <para>Picklist</para>
		/// <para>Link Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.ReportLinkOptionSets.LinkTypeCode? LinkTypeCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.LinkTypeCode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.ReportLinkOptionSets.LinkTypeCode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.LinkTypeCode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.LinkTypeCode] = null;
			}
		}

		/// <summary>
		/// <para>Unique identifier of the user who last modified the report link.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Date and time when the report link was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who last modified the reportlink.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Unique identifier of the user or team who owns the report link.</para>
		/// <para>ReadOnly - Required - Owner</para>
		/// <para>Owner</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwnerId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwnerId); }
		}

		/// <summary>
		/// <para>Unique identifier of the business unit that owns the report link.</para>
		/// <para>ReadOnly - Required - Uniqueidentifier</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who owns the report link.</para>
		/// <para>ReadOnly - Required - Uniqueidentifier</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? OwningUser
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>Unique identifier of the main report.</para>
		/// <para>Lookup to report</para>
		/// <para>Main Report</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ReportId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ReportId); }
			set { Entity.Attributes[Fields.ReportId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the report link.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Report Link</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid ReportLinkId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.ReportLinkId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? ReportLinkIdUnique
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.ReportLinkIdUnique); }
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
