﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Xyz.LuckyMokey.Shared.Entities.PluginTypeStatisticOptionSets
{

}

namespace Xyz.LuckyMokey.Shared.Entities
{
	public partial class PluginTypeStatistic : EntityBase
	{
		public struct Fields
		{
			public const string AverageExecuteTimeInMilliseconds = "averageexecutetimeinmilliseconds";
			public const string CrashContributionPercent = "crashcontributionpercent";
			public const string CrashCount = "crashcount";
			public const string CrashPercent = "crashpercent";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ExecuteCount = "executecount";
			public const string FailureCount = "failurecount";
			public const string FailurePercent = "failurepercent";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string PluginTypeId = "plugintypeid";
			public const string PluginTypeStatisticId = "plugintypestatisticid";
			public const string TerminateCpuContributionPercent = "terminatecpucontributionpercent";
			public const string TerminateHandlesContributionPercent = "terminatehandlescontributionpercent";
			public const string TerminateMemoryContributionPercent = "terminatememorycontributionpercent";
			public const string TerminateOtherContributionPercent = "terminateothercontributionpercent";
		}

		public const string EntityLogicalName = "plugintypestatistic";

		public const int EntityTypeCode = 4603;

		[DebuggerNonUserCode()]
		public PluginTypeStatistic()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public PluginTypeStatistic(Guid PluginTypeStatisticId)
		{
			Entity = new Entity(EntityLogicalName, PluginTypeStatisticId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public PluginTypeStatistic(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public PluginTypeStatistic(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public PluginTypeStatistic(Entity entity, Entity merge)
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
		public PluginTypeStatistic(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>The average execution time (in milliseconds) for the plug-in type.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>The average execution time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? AverageExecuteTimeInMilliseconds
		{
			get { return Entity.GetAttributeValue<int?>(Fields.AverageExecuteTimeInMilliseconds); }
		}

		/// <summary>
		/// <para>The plug-in type percentage contribution to crashes.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 100</para>
		/// <para>Percentage contribution to crashes</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? CrashContributionPercent
		{
			get { return Entity.GetAttributeValue<int?>(Fields.CrashContributionPercent); }
		}

		/// <summary>
		/// <para>Number of times the plug-in type has crashed.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Number of times crashed</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? CrashCount
		{
			get { return Entity.GetAttributeValue<int?>(Fields.CrashCount); }
		}

		/// <summary>
		/// <para>Percentage of crashes for the plug-in type.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 100</para>
		/// <para>Percentage of crashes</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? CrashPercent
		{
			get { return Entity.GetAttributeValue<int?>(Fields.CrashPercent); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the plug-in type statistic.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedBy); }
		}

		/// <summary>
		/// <para>Date and time when the plug-in type statistic was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who created the plug-in type statistic.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Created By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference CreatedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.CreatedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Number of times the plug-in type has been executed.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Execution Count</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? ExecuteCount
		{
			get { return Entity.GetAttributeValue<int?>(Fields.ExecuteCount); }
		}

		/// <summary>
		/// <para>Number of times the plug-in type has failed.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Failure Count</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? FailureCount
		{
			get { return Entity.GetAttributeValue<int?>(Fields.FailureCount); }
		}

		/// <summary>
		/// <para>Percentage of failures for the plug-in type.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 100</para>
		/// <para>Failure Percent</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? FailurePercent
		{
			get { return Entity.GetAttributeValue<int?>(Fields.FailurePercent); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who last modified the plug-in type statistic.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedBy); }
		}

		/// <summary>
		/// <para>Date and time when the plug-in type statistic was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Unique identifier of the delegate user who modified the plug-in type statistic.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Modified By (Delegate)</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference ModifiedOnBehalfBy
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.ModifiedOnBehalfBy); }
		}

		/// <summary>
		/// <para>Unique identifier of the organization with which the plug-in type statistic is associated.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OrganizationId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OrganizationId); }
		}

		/// <summary>
		/// <para>Unique identifier of the plug-in type associated with this plug-in type statistic.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Plugin Type</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference PluginTypeId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.PluginTypeId); }
		}

		/// <summary>
		/// <para>Unique identifier of the plug-in type statistic.</para>
		/// <para>ReadOnly - Primary Key - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid PluginTypeStatisticId
		{
			get { return Id; }
		}

		/// <summary>
		/// <para>The plug-in type percentage contribution to Worker process termination due to excessive CPU usage.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 100</para>
		/// <para>Terminate CPU Contribution Percent</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? TerminateCpuContributionPercent
		{
			get { return Entity.GetAttributeValue<int?>(Fields.TerminateCpuContributionPercent); }
		}

		/// <summary>
		/// <para>The plug-in type percentage contribution to Worker process termination due to excessive handle usage.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 100</para>
		/// <para>Terminate Handles Contribution Percent</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? TerminateHandlesContributionPercent
		{
			get { return Entity.GetAttributeValue<int?>(Fields.TerminateHandlesContributionPercent); }
		}

		/// <summary>
		/// <para>The plug-in type percentage contribution to Worker process termination due to excessive memory usage.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 100</para>
		/// <para>Terminate Memory Contribution Percent</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? TerminateMemoryContributionPercent
		{
			get { return Entity.GetAttributeValue<int?>(Fields.TerminateMemoryContributionPercent); }
		}

		/// <summary>
		/// <para>The plug-in type percentage contribution to Worker process termination due to unknown reasons.</para>
		/// <para>ReadOnly - Integer - MinValue: 0 - MaxValue: 100</para>
		/// <para>Terminate Other Contribution Percent</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? TerminateOtherContributionPercent
		{
			get { return Entity.GetAttributeValue<int?>(Fields.TerminateOtherContributionPercent); }
		}
	}
}