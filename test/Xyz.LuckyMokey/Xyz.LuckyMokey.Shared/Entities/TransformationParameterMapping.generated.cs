﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Xyz.LuckyMokey.Shared.Entities.TransformationParameterMappingOptionSets
{
	public enum ComponentState
	{
		/// <summary>
		/// Published = 0
		/// </summary>
		Published = 0,
		/// <summary>
		/// Unpublished = 1
		/// </summary>
		Unpublished = 1,
		/// <summary>
		/// Deleted = 2
		/// </summary>
		Deleted = 2,
		/// <summary>
		/// Deleted_Unpublished = 3
		/// </summary>
		Deleted_Unpublished = 3
	}

	public enum DataTypeCode
	{
		/// <summary>
		/// Reference = 0
		/// </summary>
		Reference = 0,
		/// <summary>
		/// Value = 1
		/// </summary>
		Value = 1
	}

	public enum ParameterTypeCode
	{
		/// <summary>
		/// Input = 0
		/// </summary>
		Input = 0,
		/// <summary>
		/// Output = 1
		/// </summary>
		Output = 1
	}
}

namespace Xyz.LuckyMokey.Shared.Entities
{
	public partial class TransformationParameterMapping : EntityBase
	{
		public struct Fields
		{
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Data = "data";
			public const string DataTypeCode = "datatypecode";
			public const string IntroducedVersion = "introducedversion";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OverwriteTime = "overwritetime";
			public const string ParameterArrayIndex = "parameterarrayindex";
			public const string ParameterSequence = "parametersequence";
			public const string ParameterTypeCode = "parametertypecode";
			public const string SolutionId = "solutionid";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string TransformationMappingId = "transformationmappingid";
			public const string TransformationParameterMappingId = "transformationparametermappingid";
			public const string TransformationParameterMappingIdUnique = "transformationparametermappingidunique";
		}

		public const string EntityLogicalName = "transformationparametermapping";

		public const int EntityTypeCode = 4427;

		[DebuggerNonUserCode()]
		public TransformationParameterMapping()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TransformationParameterMapping(Guid TransformationParameterMappingId)
		{
			Entity = new Entity(EntityLogicalName, TransformationParameterMappingId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TransformationParameterMapping(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TransformationParameterMapping(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public TransformationParameterMapping(Entity entity, Entity merge)
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
		public TransformationParameterMapping(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Picklist</para>
		/// <para>Component State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Xyz.LuckyMokey.Shared.Entities.TransformationParameterMappingOptionSets.ComponentState? ComponentState
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ComponentState);
				if (value == null) return null;
				return (Xyz.LuckyMokey.Shared.Entities.TransformationParameterMappingOptionSets.ComponentState)value.Value;
			}
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the parameter mapping.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Date and time when the transformation parameter mapping was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the transformationparametermapping.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Transformation data for transformation parameter</para>
		/// <para>String - MaxLength: 500</para>
		/// <para>Data</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Data
		{
			get { return Entity.GetAttributeValue<string>(Fields.Data); }
			set { Entity.Attributes[Fields.Data] = value; }
		}

		/// <summary>
		/// <para>Data type of the transformation parameter.</para>
		/// <para>Picklist</para>
		/// <para>Parameter Data Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Xyz.LuckyMokey.Shared.Entities.TransformationParameterMappingOptionSets.DataTypeCode? DataTypeCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.DataTypeCode);
				if (value == null) return null;
				return (Xyz.LuckyMokey.Shared.Entities.TransformationParameterMappingOptionSets.DataTypeCode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.DataTypeCode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.DataTypeCode] = null;
			}
		}

		/// <summary>
		/// <para>Version in which the component is introduced.</para>
		/// <para>String - MaxLength: 48</para>
		/// <para>Introduced Version</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string IntroducedVersion
		{
			get { return Entity.GetAttributeValue<string>(Fields.IntroducedVersion); }
			set { Entity.Attributes[Fields.IntroducedVersion] = value; }
		}

		/// <summary>
		/// <para>Information that specifies whether this component is managed.</para>
		/// <para>ReadOnly - Boolean</para>
		/// <para>State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsManaged
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsManaged); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who last modified the transformation parameter mapping.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Date and time when the transformation parameter mapping was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who last modified the transformationparametermapping.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateOnly</para>
		/// <para>Record Overwrite Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? OverwriteTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.OverwriteTime); }
		}

		/// <summary>
		/// <para>Index of the array if the input parameter is an array.</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Parameter Array Index</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? ParameterArrayIndex
		{
			get { return Entity.GetAttributeValue<int?>(Fields.ParameterArrayIndex); }
			set { Entity.Attributes[Fields.ParameterArrayIndex] = value; }
		}

		/// <summary>
		/// <para>Parameter sequence number.</para>
		/// <para>Integer - MinValue: 1 - MaxValue: 2,147,483,647</para>
		/// <para>Parameter Sequence</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? ParameterSequence
		{
			get { return Entity.GetAttributeValue<int?>(Fields.ParameterSequence); }
			set { Entity.Attributes[Fields.ParameterSequence] = value; }
		}

		/// <summary>
		/// <para>Type of transformation parameter.</para>
		/// <para>Picklist</para>
		/// <para>Parameter Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Xyz.LuckyMokey.Shared.Entities.TransformationParameterMappingOptionSets.ParameterTypeCode? ParameterTypeCode
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ParameterTypeCode);
				if (value == null) return null;
				return (Xyz.LuckyMokey.Shared.Entities.TransformationParameterMappingOptionSets.ParameterTypeCode)value.Value;
			}
			set
			{
				if (value.HasValue)
					Entity.Attributes[Fields.ParameterTypeCode] = new OptionSetValue((int)value.Value);
				else
					Entity.Attributes[Fields.ParameterTypeCode] = null;
			}
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

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para>Solution</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? SupportingSolutionId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.SupportingSolutionId); }
		}

		/// <summary>
		/// <para>Unique identifier of the transformation with which the parameter is associated.</para>
		/// <para>Lookup</para>
		/// <para>Transformation Mapping Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference TransformationMappingId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.TransformationMappingId); }
			set { Entity.Attributes[Fields.TransformationMappingId] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the transformation parameter mapping.</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid TransformationParameterMappingId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.TransformationParameterMappingId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>Unique identifier of the Transformation Parameter Mapping.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? TransformationParameterMappingIdUnique
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.TransformationParameterMappingIdUnique); }
		}
	}
}