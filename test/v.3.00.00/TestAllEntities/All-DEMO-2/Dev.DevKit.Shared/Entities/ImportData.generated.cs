﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.ImportDataOptionSets
{
	public enum ErrorType
	{
		/// <summary>
		/// Create = 0
		/// </summary>
		Create = 0,
		/// <summary>
		/// Update = 1
		/// </summary>
		Update = 1
	}

	public enum StateCode
	{
		/// <summary>
		/// Active = 0
		/// </summary>
		Active = 0
	}

	public enum StatusCode
	{
		/// <summary>
		/// Active = 0
		/// </summary>
		Active = 0
	}
}

namespace Dev.DevKit.Shared.Entities
{
	public partial class ImportData : EntityBase
	{
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Data = "data";
			public const string ErrorType = "errortype";
			public const string HasError = "haserror";
			public const string ImportDataId = "importdataid";
			public const string ImportFileId = "importfileid";
			public const string LineNumber = "linenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string RecordId = "recordid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
		}

		public const string EntityLogicalName = "importdata";

		public const int EntityTypeCode = 4413;

		[DebuggerNonUserCode()]
		public ImportData()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ImportData(Guid ImportDataId)
		{
			Entity = new Entity(EntityLogicalName, ImportDataId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ImportData(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ImportData(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public ImportData(Entity entity, Entity merge)
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
		public ImportData(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the import data.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Date and time when the import data was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the importdata.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Data row of the import file.</para>
		/// <para>String - MaxLength: 1073741823</para>
		/// <para>Data</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Data
		{
			get { return Entity.GetAttributeValue<string>(Fields.Data); }
			set { Entity.Attributes[Fields.Data] = value; }
		}

		/// <summary>
		/// <para>Type of the import error.</para>
		/// <para>Picklist</para>
		/// <para>Error Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.ImportDataOptionSets.ErrorType? ErrorType
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ErrorType);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.ImportDataOptionSets.ErrorType)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.ErrorType] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.ErrorType] = null;
			}
		}

		/// <summary>
		/// <para>Information about whether this import data has an error.</para>
		/// <para>Boolean</para>
		/// <para>Has Error</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? HasError
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.HasError); }
			set { Entity.Attributes[Fields.HasError] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the import data.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid ImportDataId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.ImportDataId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Unique identifier of the import file for this import data.</para>
		/// <para>Lookup to importfile</para>
		/// <para>Import File Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ImportFileId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ImportFileId); }
			set { Entity.Attributes[Fields.ImportFileId] = value; }
		}

		/// <summary>
		/// <para>Original line number of the data present in the file.</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Line Number</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? LineNumber
		{
			get { return Entity.GetAttributeValue<int?>(Fields.LineNumber); }
			set { Entity.Attributes[Fields.LineNumber] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user who last modified the import data.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Date and time when the import data was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who last modified the importdata.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Unique identifier of the user or team who owns the import data.</para>
		/// <para>Owner</para>
		/// <para>Owner</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwnerId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwnerId); }
			set { Entity.Attributes[Fields.OwnerId] = value; }
		}

		/// <summary>
		/// <para>Business unit that owns the import data.</para>
		/// <para>ReadOnly - Lookup to businessunit</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the team who owns the import data.</para>
		/// <para>ReadOnly - Lookup to team</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who owns the import data.</para>
		/// <para>ReadOnly - Lookup to systemuser</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>Unique identifier of the record.</para>
		/// <para>Uniqueidentifier</para>
		/// <para>Record</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? RecordId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.RecordId); }
			set { Entity.Attributes[Fields.RecordId] = value; }
		}

		/// <summary>
		/// <para>Status of the import data.</para>
		/// <para>ReadOnly - State</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.ImportDataOptionSets.StateCode? StateCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.StateCode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.ImportDataOptionSets.StateCode)value.Value;
			}
		}

		/// <summary>
		/// <para>Reason for the status of the import data.</para>
		/// <para>Status</para>
		/// <para>Status Reason</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Dev.DevKit.Shared.Entities.ImportDataOptionSets.StatusCode? StatusCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.StatusCode);
				if (value == null) return null;
				return (Dev.DevKit.Shared.Entities.ImportDataOptionSets.StatusCode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.StatusCode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.StatusCode] = null;
			}
		}
	}
}