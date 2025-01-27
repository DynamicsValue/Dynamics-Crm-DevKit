﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//		Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//		Generated by DynamicsCrm.DevKit - https://github.com/phuocle/Dynamics-Crm-DevKit
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using Microsoft.Xrm.Sdk;
using System;
using System.Diagnostics;

namespace Dev.DevKit.Shared.Entities.msdyn_suggestedcontactOptionSets
{

}

namespace Dev.DevKit.Shared.Entities
{
	public partial class msdyn_suggestedcontact : EntityBase
	{
		public struct Fields
		{
			public const string msdyn_accountid = "msdyn_accountid";
			public const string msdyn_accountidname = "msdyn_accountidname";
			public const string msdyn_accountname = "msdyn_accountname";
			public const string msdyn_addresscity = "msdyn_addresscity";
			public const string msdyn_addressline1 = "msdyn_addressline1";
			public const string msdyn_addressline2 = "msdyn_addressline2";
			public const string msdyn_addresspostalcode = "msdyn_addresspostalcode";
			public const string msdyn_companyname = "msdyn_companyname";
			public const string msdyn_createdon = "msdyn_createdon";
			public const string msdyn_description = "msdyn_description";
			public const string msdyn_email = "msdyn_email";
			public const string msdyn_firstname = "msdyn_firstname";
			public const string msdyn_fullname = "msdyn_fullname";
			public const string msdyn_jobtitle = "msdyn_jobtitle";
			public const string msdyn_lastname = "msdyn_lastname";
			public const string msdyn_mobilephone = "msdyn_mobilephone";
			public const string msdyn_preferredcontactmethodcode = "msdyn_preferredcontactmethodcode";
			public const string msdyn_suggestedcontactId = "msdyn_suggestedcontactid";
			public const string msdyn_telephone = "msdyn_telephone";
		}

		public const string EntityLogicalName = "msdyn_suggestedcontact";

		public const int EntityTypeCode = 10229;

		[DebuggerNonUserCode()]
		public msdyn_suggestedcontact()
		{
			Entity = new Entity(EntityLogicalName);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_suggestedcontact(Guid msdyn_suggestedcontactId)
		{
			Entity = new Entity(EntityLogicalName, msdyn_suggestedcontactId);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_suggestedcontact(string keyName, object keyValue)
		{
			Entity = new Entity(EntityLogicalName, keyName, keyValue);
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_suggestedcontact(Entity entity)
		{
			Entity = entity;
			PreEntity = CloneThisEntity(Entity);
		}

		[DebuggerNonUserCode()]
		public msdyn_suggestedcontact(Entity entity, Entity merge)
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
		public msdyn_suggestedcontact(KeyAttributeCollection keys)
		{
			Entity = new Entity(EntityLogicalName, keys);
			PreEntity = CloneThisEntity(Entity);
		}

		/// <summary>
		/// <para>Account Name</para>
		/// <para>Lookup to </para>
		/// <para>Account Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public EntityReference msdyn_accountid
		{
			get { return Entity.GetAttributeValue<EntityReference>(Fields.msdyn_accountid); }
			set { Entity.Attributes[Fields.msdyn_accountid] = value; }
		}

		/// <summary>
		/// <para>Account Name</para>
		/// <para>String - MaxLength: 100</para>
		/// <para>Account Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_accountidname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_accountidname); }
			set { Entity.Attributes[Fields.msdyn_accountidname] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Account Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_accountname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_accountname); }
			set { Entity.Attributes[Fields.msdyn_accountname] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Address City</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_addresscity
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_addresscity); }
			set { Entity.Attributes[Fields.msdyn_addresscity] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>AddressLine1</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_addressline1
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_addressline1); }
			set { Entity.Attributes[Fields.msdyn_addressline1] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>AddressLine2</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_addressline2
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_addressline2); }
			set { Entity.Attributes[Fields.msdyn_addressline2] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Address Postal Code</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_addresspostalcode
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_addresspostalcode); }
			set { Entity.Attributes[Fields.msdyn_addresspostalcode] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Company Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_companyname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_companyname); }
			set { Entity.Attributes[Fields.msdyn_companyname] = value; }
		}

		/// <summary>
		/// <para>Date and time when the record was created.</para>
		/// <para>DateTimeBehavior: UserLocal - DateTimeFormat: DateAndTime</para>
		/// <para>Date</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public DateTime? msdyn_createdonUtc
		{
			get { return Entity.GetAttributeValue<DateTime?>(Fields.msdyn_createdon); }
			set { Entity.Attributes[Fields.msdyn_createdon] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Description</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_description
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_description); }
			set { Entity.Attributes[Fields.msdyn_description] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Email</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_email
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_email); }
			set { Entity.Attributes[Fields.msdyn_email] = value; }
		}

		/// <summary>
		/// <para>first name</para>
		/// <para>Required - String - MaxLength: 100</para>
		/// <para>First Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_firstname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_firstname); }
			set { Entity.Attributes[Fields.msdyn_firstname] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 250</para>
		/// <para>Full Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_fullname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_fullname); }
			set { Entity.Attributes[Fields.msdyn_fullname] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Job Title</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_jobtitle
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_jobtitle); }
			set { Entity.Attributes[Fields.msdyn_jobtitle] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Last Name</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_lastname
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_lastname); }
			set { Entity.Attributes[Fields.msdyn_lastname] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Mobile Phone</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_mobilephone
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_mobilephone); }
			set { Entity.Attributes[Fields.msdyn_mobilephone] = value; }
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Preferred Contact Method Code</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_preferredcontactmethodcode
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_preferredcontactmethodcode); }
			set { Entity.Attributes[Fields.msdyn_preferredcontactmethodcode] = value; }
		}

		/// <summary>
		/// <para>Unique identifier for entity instances</para>
		/// <para>Primary Key - Uniqueidentifier</para>
		/// <para>Suggested Contact</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public Guid msdyn_suggestedcontactId
		{
			get { return Id; }
			set
			{
				Entity.Attributes[Fields.msdyn_suggestedcontactId] = value;
				Entity.Id = value;
			}
		}

		/// <summary>
		/// <para>String - MaxLength: 100</para>
		/// <para>Telephone</para>
		/// </summary>
		[DebuggerNonUserCode()]
		public string msdyn_telephone
		{
			get { return Entity.GetAttributeValue<string>(Fields.msdyn_telephone); }
			set { Entity.Attributes[Fields.msdyn_telephone] = value; }
		}
	}
}
