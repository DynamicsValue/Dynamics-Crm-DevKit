﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Xyz.LuckyMokey.Shared.Entities.CanvasAppOptionSets
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
}

namespace Xyz.LuckyMokey.Shared.Entities
{
	public partial class CanvasApp : EntityBase
	{
		public struct Fields
		{
			public const string AADCreatedById = "aadcreatedbyid";
			public const string AADLastModifiedById = "aadlastmodifiedbyid";
			public const string AADLastPublishedById = "aadlastpublishedbyid";
			public const string AdminControlBypassConsent = "admincontrolbypassconsent";
			public const string AppOpenUri = "appopenuri";
			public const string AppVersion = "appversion";
			public const string AuthorizationReferences = "authorizationreferences";
			public const string BackgroundColor = "backgroundcolor";
			public const string BypassConsent = "bypassconsent";
			public const string CanvasAppId = "canvasappid";
			public const string CanvasAppRowId = "canvasapprowid";
			public const string CdsDependencies = "cdsdependencies";
			public const string CommitMessage = "commitmessage";
			public const string ComponentState = "componentstate";
			public const string ConnectionReferences = "connectionreferences";
			public const string CreatedByClientVersion = "createdbyclientversion";
			public const string CreatedTime = "createdtime";
			public const string DatabaseReferences = "databasereferences";
			public const string Description = "description";
			public const string DisplayName = "displayname";
			public const string EmbeddedApp = "embeddedapp";
			public const string GalleryItemId = "galleryitemid";
			public const string IntroducedVersion = "introducedversion";
			public const string IsCdsUpgraded = "iscdsupgraded";
			public const string IsFeaturedApp = "isfeaturedapp";
			public const string IsHeroApp = "isheroapp";
			public const string IsHidden = "ishidden";
			public const string IsManaged = "ismanaged";
			public const string LastModifiedTime = "lastmodifiedtime";
			public const string LastPublishTime = "lastpublishtime";
			public const string MinClientVersion = "minclientversion";
			public const string Name = "name";
			public const string OverwriteTime = "overwritetime";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string Publisher = "publisher";
			public const string SolutionId = "solutionid";
			public const string Status = "status";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string Tags = "tags";
			public const string VersionNumber = "versionnumber";
		}

		public const string EntityLogicalName = "canvasapp";

		public const int EntityTypeCode = 300;

		[DebuggerNonUserCode()]
		public CanvasApp()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public CanvasApp(Guid CanvasAppId)
		{
			Entity = new Entity(EntityLogicalName, CanvasAppId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public CanvasApp(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public CanvasApp(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public CanvasApp(Entity entity, Entity merge)
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
		public CanvasApp(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Unique identifier of the user who created the canvas app.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Created By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string AADCreatedById
		{
			get { return Entity.GetAttributeValue<string>(Fields.AADCreatedById); }
			set { Entity.Attributes[Fields.AADCreatedById] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user who last modified the application.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Last Modified By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string AADLastModifiedById
		{
			get { return Entity.GetAttributeValue<string>(Fields.AADLastModifiedById); }
			set { Entity.Attributes[Fields.AADLastModifiedById] = value; }
		}

		/// <summary>
		/// <para>Unique identifier of the user who last published the application.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Last Published By</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string AADLastPublishedById
		{
			get { return Entity.GetAttributeValue<string>(Fields.AADLastPublishedById); }
			set { Entity.Attributes[Fields.AADLastPublishedById] = value; }
		}

		/// <summary>
		/// <para>Indicates whether the canvas app was marked for bypass consent by an admin.</para>
		/// <para>Boolean</para>
		/// <para>Admin Control Bypass Consent</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? AdminControlBypassConsent
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.AdminControlBypassConsent); }
			set { Entity.Attributes[Fields.AdminControlBypassConsent] = value; }
		}

		/// <summary>
		/// <para>The app open URI.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string AppOpenUri
		{
			get { return Entity.GetAttributeValue<string>(Fields.AppOpenUri); }
			set { Entity.Attributes[Fields.AppOpenUri] = value; }
		}

		/// <summary>
		/// <para>The application version.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string AppVersion
		{
			get { return Entity.GetAttributeValue<string>(Fields.AppVersion); }
			set { Entity.Attributes[Fields.AppVersion] = value; }
		}

		/// <summary>
		/// <para>The authorization references of the application.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string AuthorizationReferences
		{
			get { return Entity.GetAttributeValue<string>(Fields.AuthorizationReferences); }
			set { Entity.Attributes[Fields.AuthorizationReferences] = value; }
		}

		/// <summary>
		/// <para>The background image color.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string BackgroundColor
		{
			get { return Entity.GetAttributeValue<string>(Fields.BackgroundColor); }
			set { Entity.Attributes[Fields.BackgroundColor] = value; }
		}

		/// <summary>
		/// <para>Indicates whether the canvas app should bypass consent from consumers.</para>
		/// <para>Boolean</para>
		/// <para>Bypass Consent</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? BypassConsent
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.BypassConsent); }
			set { Entity.Attributes[Fields.BypassConsent] = value; }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid CanvasAppId
		{
			get { return Entity.GetAttributeValue<Guid>(Fields.CanvasAppId); }
			set
			{
				Entity.Attributes[Fields.CanvasAppId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Uniqueidentifier</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid? CanvasAppRowId
		{
			get { return Entity.GetAttributeValue<Guid?>(Fields.CanvasAppRowId); }
		}

		/// <summary>
		/// <para>Internal use. The app dependency details.</para>
		/// <para>Memo - MaxLength: 768000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string CdsDependencies
		{
			get { return Entity.GetAttributeValue<string>(Fields.CdsDependencies); }
			set { Entity.Attributes[Fields.CdsDependencies] = value; }
		}

		/// <summary>
		/// <para>The commit message of the app.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para>The commit message.</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string CommitMessage
		{
			get { return Entity.GetAttributeValue<string>(Fields.CommitMessage); }
			set { Entity.Attributes[Fields.CommitMessage] = value; }
		}

		/// <summary>
		/// <para>For internal use only.</para>
		/// <para>ReadOnly - Picklist</para>
		/// <para>Component State</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Xyz.LuckyMokey.Shared.Entities.CanvasAppOptionSets.ComponentState? ComponentState
		{
			get
			{
				var value = Entity.GetAttributeValue<OptionSetValue>(Fields.ComponentState);
				if (value == null) return null;
				return (Xyz.LuckyMokey.Shared.Entities.CanvasAppOptionSets.ComponentState)value.Value;
			}
		}

		/// <summary>
		/// <para>The connection references of the application.</para>
		/// <para>Memo - MaxLength: 768000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string ConnectionReferences
		{
			get { return Entity.GetAttributeValue<string>(Fields.ConnectionReferences); }
			set { Entity.Attributes[Fields.ConnectionReferences] = value; }
		}

		/// <summary>
		/// <para>The version of the client that was used to author the application.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string CreatedByClientVersion
		{
			get { return Entity.GetAttributeValue<string>(Fields.CreatedByClientVersion); }
			set { Entity.Attributes[Fields.CreatedByClientVersion] = value; }
		}

		/// <summary>
		/// <para>Date and time when the application was created.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Created Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? CreatedTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.CreatedTime); }
			set { Entity.Attributes[Fields.CreatedTime] = value; }
		}

		/// <summary>
		/// <para>The database references of the application.</para>
		/// <para>Memo - MaxLength: 768000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string DatabaseReferences
		{
			get { return Entity.GetAttributeValue<string>(Fields.DatabaseReferences); }
			set { Entity.Attributes[Fields.DatabaseReferences] = value; }
		}

		/// <summary>
		/// <para>The description of the app.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para>The description.</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Description
		{
			get { return Entity.GetAttributeValue<string>(Fields.Description); }
			set { Entity.Attributes[Fields.Description] = value; }
		}

		/// <summary>
		/// <para>The display name of the app.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string DisplayName
		{
			get { return Entity.GetAttributeValue<string>(Fields.DisplayName); }
			set { Entity.Attributes[Fields.DisplayName] = value; }
		}

		/// <summary>
		/// <para>Internal use. The embedded app information.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string EmbeddedApp
		{
			get { return Entity.GetAttributeValue<string>(Fields.EmbeddedApp); }
			set { Entity.Attributes[Fields.EmbeddedApp] = value; }
		}

		/// <summary>
		/// <para>The gallery item identifier.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para>The gallery item identifier</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string GalleryItemId
		{
			get { return Entity.GetAttributeValue<string>(Fields.GalleryItemId); }
			set { Entity.Attributes[Fields.GalleryItemId] = value; }
		}

		/// <summary>
		/// <para>Version in which the canvas app is introduced.</para>
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
		/// <para>Indicates whether the canvas app contains CDS 1.0 references.</para>
		/// <para>Boolean</para>
		/// <para>Is CDS Upgraded</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsCdsUpgraded
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsCdsUpgraded); }
			set { Entity.Attributes[Fields.IsCdsUpgraded] = value; }
		}

		/// <summary>
		/// <para>Indicates whether the canvas app is a featured app.</para>
		/// <para>Boolean</para>
		/// <para>Is Featured App</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsFeaturedApp
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsFeaturedApp); }
			set { Entity.Attributes[Fields.IsFeaturedApp] = value; }
		}

		/// <summary>
		/// <para>Indicates whether the canvas app is a hero app.</para>
		/// <para>Boolean</para>
		/// <para>Is Hero App</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsHeroApp
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsHeroApp); }
			set { Entity.Attributes[Fields.IsHeroApp] = value; }
		}

		/// <summary>
		/// <para>Indicates whether the canvas app is hidden from a user's list.</para>
		/// <para>Boolean</para>
		/// <para>Is Hidden</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsHidden
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsHidden); }
			set { Entity.Attributes[Fields.IsHidden] = value; }
		}

		/// <summary>
		/// <para>Indicates whether the solution component is part of a managed solution.</para>
		/// <para>ReadOnly - Boolean</para>
		/// <para>Is Managed</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public bool? IsManaged
		{
			get { return Entity.GetAttributeValue<bool?>(Fields.IsManaged); }
		}

		/// <summary>
		/// <para>Date and time when the application was last modified.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Last Modified Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? LastModifiedTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.LastModifiedTime); }
			set { Entity.Attributes[Fields.LastModifiedTime] = value; }
		}

		/// <summary>
		/// <para>Date and time when the application was last published.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Last Publish Time</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? LastPublishTimeUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.LastPublishTime); }
			set { Entity.Attributes[Fields.LastPublishTime] = value; }
		}

		/// <summary>
		/// <para>The version of the client that was used to author the application.</para>
		/// <para>String - MaxLength: 100</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string MinClientVersion
		{
			get { return Entity.GetAttributeValue<string>(Fields.MinClientVersion); }
			set { Entity.Attributes[Fields.MinClientVersion] = value; }
		}

		/// <summary>
		/// <para>Name of the CanvasApp</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>CanvasApp Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Name
		{
			get { return Entity.GetAttributeValue<string>(Fields.Name); }
			set { Entity.Attributes[Fields.Name] = value; }
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
		/// <para>Unique identifier of the user or team who owns the canvas app.</para>
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
		/// <para>Unique identifier of the business unit that owns the process.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning Business Unit</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningBusinessUnit
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningBusinessUnit); }
		}

		/// <summary>
		/// <para>Unique identifier of the team who owns the process.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning Team</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningTeam
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningTeam); }
		}

		/// <summary>
		/// <para>Unique identifier of the user who owns the process.</para>
		/// <para>ReadOnly - Lookup</para>
		/// <para>Owning User</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference OwningUser
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.OwningUser); }
		}

		/// <summary>
		/// <para>The publisher of the app.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Publisher
		{
			get { return Entity.GetAttributeValue<string>(Fields.Publisher); }
			set { Entity.Attributes[Fields.Publisher] = value; }
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
		/// <para>A value indicating whether the application is ready for consumption.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para>Status</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Status
		{
			get { return Entity.GetAttributeValue<string>(Fields.Status); }
			set { Entity.Attributes[Fields.Status] = value; }
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
		/// <para>The metadata tags of the application.</para>
		/// <para>Memo - MaxLength: 2000</para>
		/// <para></para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string Tags
		{
			get { return Entity.GetAttributeValue<string>(Fields.Tags); }
			set { Entity.Attributes[Fields.Tags] = value; }
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