﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.MailboxTrackingCategoryOptionSets
{

}

namespace Dev.DevKit.Shared.Entities
{
	public partial class MailboxTrackingCategory : EntityBase
	{
		public struct Fields
		{
			public const string CategoryOnboardingStatus = "categoryonboardingstatus";
			public const string CreatedOn = "createdon";
			public const string ExchangeCategoryColor = "exchangecategorycolor";
			public const string ExchangeCategoryId = "exchangecategoryid";
			public const string ExchangeCategoryName = "exchangecategoryname";
			public const string MailboxId = "mailboxid";
			public const string MailboxTrackingCategoryId = "mailboxtrackingcategoryid";
			public const string ModifiedOn = "modifiedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
		}

		public const string EntityLogicalName = "mailboxtrackingcategory";

		public const int EntityTypeCode = 9609;

		[DebuggerNonUserCode()]
		public MailboxTrackingCategory()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MailboxTrackingCategory(Guid MailboxTrackingCategoryId)
		{
			Entity = new Entity(EntityLogicalName, MailboxTrackingCategoryId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MailboxTrackingCategory(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MailboxTrackingCategory(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public MailboxTrackingCategory(Entity entity, Entity merge)
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
		public MailboxTrackingCategory(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Information to indicate whether the category has been created in Exchange or not.</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 2,147,483,647</para>
		/// <para>Category on boarding Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? CategoryOnboardingStatus
		{
			get { return Entity.GetAttributeValue<int?>(Fields.CategoryOnboardingStatus); }
			set { Entity.Attributes[Fields.CategoryOnboardingStatus] = value; }
		}

		/// <summary>
		/// <para>Date and time when the entry was created.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedOn); }
		}

		/// <summary>
		/// <para>Color for category in Exchange.</para>
		/// <para>Integer - MinValue: 0 - MaxValue: 25</para>
		/// <para>Color for category in Exchange.</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public int? ExchangeCategoryColor
		{
			get { return Entity.GetAttributeValue<int?>(Fields.ExchangeCategoryColor); }
			set { Entity.Attributes[Fields.ExchangeCategoryColor] = value; }
		}

		/// <summary>
		/// <para>Category Id for a category in Exchange</para>
		/// <para>Uniqueidentifier</para>
		/// <para>Exchange Category Id</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? ExchangeCategoryId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.ExchangeCategoryId); }
			set { Entity.Attributes[Fields.ExchangeCategoryId] = value; }
		}

		/// <summary>
		/// <para>Exchange Category Name</para>
		/// <para>String - MaxLength: 512</para>
		/// <para>Exchange Category Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string ExchangeCategoryName
		{
			get { return Entity.GetAttributeValue<string>(Fields.ExchangeCategoryName); }
			set { Entity.Attributes[Fields.ExchangeCategoryName] = value; }
		}

		/// <summary>
		/// <para>Mailbox id associated with this record.</para>
		/// <para>Lookup to organization</para>
		/// <para>MailboxId</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference MailboxId
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.MailboxId); }
			set { Entity.Attributes[Fields.MailboxId] = value; }
		}

		/// <summary>
		/// <para>ReadOnly - Primary Key - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid MailboxTrackingCategoryId
		{
			get { return Id; }
		}

		/// <summary>
		/// <para>Date and time when the entry was last modified.</para>
		/// <para>ReadOnly - DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Modified On</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? ModifiedOnUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.ModifiedOn); }
		}

		/// <summary>
		/// <para>Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.</para>
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
		/// <para>Unique identifier of the business unit that owns the category.</para>
		/// <para>ReadOnly - Lookup to businessunit</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the team who owns the category.</para>
		/// <para>ReadOnly - Lookup to team</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier for the user that owns the record.</para>
		/// <para>ReadOnly - Lookup to </para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}
	}
}
