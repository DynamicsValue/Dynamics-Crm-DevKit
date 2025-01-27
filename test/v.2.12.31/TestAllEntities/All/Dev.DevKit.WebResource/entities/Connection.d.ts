﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace FormConnection_Information {
		interface Header extends DevKit.Controls.IHeader {
			/** Choose the primary account, contact, or other record involved in the connection. */
			Record1Id: DevKit.Controls.Lookup;
		}
		interface tab_details_Sections {
			connect_from: DevKit.Controls.Section;
			details: DevKit.Controls.Section;
		}
		interface tab_info_Sections {
			description: DevKit.Controls.Section;
			info_s: DevKit.Controls.Section;
		}
		interface tab_details extends DevKit.Controls.ITab {
			Section: tab_details_Sections;
		}
		interface tab_info extends DevKit.Controls.ITab {
			Section: tab_info_Sections;
		}
		interface Tabs {
			details: tab_details;
			info: tab_info;
		}
		interface Body {
			Tab: Tabs;
			/** Type additional information to describe the connection, such as the length or quality of the relationship. */
			Description: DevKit.Controls.String;
			/** Enter the end date of the connection. */
			EffectiveEnd: DevKit.Controls.Date;
			/** Enter the start date of the connection. */
			EffectiveStart: DevKit.Controls.Date;
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Controls.Lookup;
			/** Choose the primary account, contact, or other record involved in the connection. */
			Record1Id: DevKit.Controls.Lookup;
			/** Choose the primary party's role or relationship with the second party. */
			Record1RoleId: DevKit.Controls.Lookup;
			/** Select the secondary account, contact, or other record involved in the connection. */
			Record2Id: DevKit.Controls.Lookup;
			/** Choose the secondary party's role or relationship with the primary party. */
			Record2RoleId: DevKit.Controls.Lookup;
		}
		interface Footer extends DevKit.Controls.IFooter {
			/** Shows whether the connection is active or inactive. Inactive connections are read-only and can't be edited unless they are reactivated. */
			StateCode: DevKit.Controls.OptionSet;
		}
	}
	class FormConnection_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Connection_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Connection_Information */
		Body: DevKit.FormConnection_Information.Body;
		/** The Footer section of form Connection_Information */
		Footer: DevKit.FormConnection_Information.Footer;
		/** The Header section of form Connection_Information */
		Header: DevKit.FormConnection_Information.Header;
	}
	class ConnectionApi {
		/**
		* DynamicsCrm.DevKit ConnectionApi
		* @param entity The entity object
		*/
		constructor(entity?: any);
		/**
		 * Get the value of alias
		 * @param alias the alias value
		 * @param isMultiOptionSet true if the alias is multi OptionSet
		 */
		getAliasedValue(alias: string, isMultiOptionSet?: boolean): any;
		/**
		 * Get the formatted value of alias
		 * @param alias the alias value
		 * @param isMultiOptionSet true if the alias is multi OptionSet
		 */
		getAliasedFormattedValue(alias: string, isMultiOptionSet?: boolean): string;
		/** The entity object */
		Entity: any;
		/** The entity name */
		EntityName: string;
		/** The entity collection name */
		EntityCollectionName: string;
		/** The @odata.etag is then used to build a cache of the response that is dependant on the fields that are retrieved */
		"@odata.etag": string;
		/** Unique identifier of the connection. */
		ConnectionId: DevKit.WebApi.GuidValue;
		/** Shows who created the record. */
		CreatedBy: DevKit.WebApi.LookupValueReadonly;
		/** Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. */
		CreatedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Shows who created the record on behalf of another user. */
		CreatedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Type additional information to describe the connection, such as the length or quality of the relationship. */
		Description: DevKit.WebApi.StringValue;
		/** Enter the end date of the connection. */
		EffectiveEnd_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Enter the start date of the connection. */
		EffectiveStart_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** The default image for the entity. */
		EntityImage: DevKit.WebApi.StringValue;
		EntityImage_Timestamp: DevKit.WebApi.BigIntValueReadonly;
		EntityImage_URL: DevKit.WebApi.StringValueReadonly;
		/** For internal use only. */
		EntityImageId: DevKit.WebApi.GuidValueReadonly;
		/** Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency. */
		ExchangeRate: DevKit.WebApi.DecimalValueReadonly;
		/** Unique identifier of the data import or data migration that created this record. */
		ImportSequenceNumber: DevKit.WebApi.IntegerValue;
		/** Indicates that this is the master record. */
		IsMaster: DevKit.WebApi.BooleanValueReadonly;
		/** Shows who last updated the record. */
		ModifiedBy: DevKit.WebApi.LookupValueReadonly;
		/** Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Shows who last updated the record on behalf of another user. */
		ModifiedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Name of the connection. */
		Name: DevKit.WebApi.StringValueReadonly;
		/** Date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user */
		OwnerId_systemuser: DevKit.WebApi.LookupValue;
		/** Enter the team who is assigned to manage the record. This field is updated every time the record is assigned to a different team */
		OwnerId_team: DevKit.WebApi.LookupValue;
		/** Shows the business unit that the record owner belongs to. */
		OwningBusinessUnit: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier of the team who owns the connection. */
		OwningTeam: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier of the user who owns the connection. */
		OwningUser: DevKit.WebApi.LookupValueReadonly;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_account: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_activitypointer: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_appointment: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		profileruleid1: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_contact: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_email: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_fax: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_goal: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_knowledgearticle: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_knowledgebaserecord: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_letter: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_phonecall: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_position: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_processsession: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_recurringappointmentmaster: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_socialactivity: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_socialprofile: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_systemuser: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_task: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_team: DevKit.WebApi.LookupValue;
		/** Choose the primary account, contact, or other record involved in the connection. */
		record1id_territory: DevKit.WebApi.LookupValue;
		/** Shows the record type of the source record. */
		Record1ObjectTypeCode: DevKit.WebApi.OptionSetValueReadonly;
		/** Choose the primary party's role or relationship with the second party. */
		Record1RoleId: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_account: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_activitypointer: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_appointment: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		channelaccessprofileruleid: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_contact: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_email: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_fax: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_goal: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_knowledgearticle: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_knowledgebaserecord: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_letter: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_phonecall: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_position: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_processsession: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_recurringappointmentmaster: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_socialactivity: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_socialprofile: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_systemuser: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_task: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_team: DevKit.WebApi.LookupValue;
		/** Select the secondary account, contact, or other record involved in the connection. */
		record2id_territory: DevKit.WebApi.LookupValue;
		/** Shows the record type of the target record. */
		Record2ObjectTypeCode: DevKit.WebApi.OptionSetValueReadonly;
		/** Choose the secondary party's role or relationship with the primary party. */
		Record2RoleId: DevKit.WebApi.LookupValue;
		/** Unique identifier for the reciprocal connection record. */
		RelatedConnectionId: DevKit.WebApi.LookupValueReadonly;
		/** Shows whether the connection is active or inactive. Inactive connections are read-only and can't be edited unless they are reactivated. */
		StateCode: DevKit.WebApi.OptionSetValue;
		/** Reason for the status of the connection. */
		StatusCode: DevKit.WebApi.OptionSetValue;
		/** Choose the local currency for the record to make sure budgets are reported in the correct currency. */
		TransactionCurrencyId: DevKit.WebApi.LookupValue;
		/** Version number of the connection. */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
	}
}
declare namespace OptionSet {
	namespace Connection {
		enum Record1ObjectTypeCode {
			/** 1 */
			Account,
			/** 4200 */
			Activity,
			/** 4201 */
			Appointment,
			/** 9400 */
			Channel_Access_Profile_Rule,
			/** 2 */
			Contact,
			/** 4202 */
			Email,
			/** 4204 */
			Fax,
			/** 9600 */
			Goal,
			/** 9953 */
			Knowledge_Article,
			/** 9930 */
			Knowledge_Base_Record,
			/** 4207 */
			Letter,
			/** 4210 */
			Phone_Call,
			/** 50 */
			Position,
			/** 4710 */
			Process_Session,
			/** 4251 */
			Recurring_Appointment,
			/** 4216 */
			Social_Activity,
			/** 99 */
			Social_Profile,
			/** 4212 */
			Task,
			/** 9 */
			Team,
			/** 2013 */
			Territory,
			/** 8 */
			User
		}
		enum Record2ObjectTypeCode {
			/** 1 */
			Account,
			/** 4200 */
			Activity,
			/** 4201 */
			Appointment,
			/** 9400 */
			Channel_Access_Profile_Rule,
			/** 2 */
			Contact,
			/** 4202 */
			Email,
			/** 4204 */
			Fax,
			/** 9600 */
			Goal,
			/** 9953 */
			Knowledge_Article,
			/** 9930 */
			Knowledge_Base_Record,
			/** 4207 */
			Letter,
			/** 4210 */
			Phone_Call,
			/** 50 */
			Position,
			/** 4710 */
			Process_Session,
			/** 4251 */
			Recurring_Appointment,
			/** 4216 */
			Social_Activity,
			/** 99 */
			Social_Profile,
			/** 4212 */
			Task,
			/** 9 */
			Team,
			/** 2013 */
			Territory,
			/** 8 */
			User
		}
		enum StateCode {
			/** 0 */
			Active,
			/** 1 */
			Inactive
		}
		enum StatusCode {
			/** 1 */
			Active,
			/** 2 */
			Inactive
		}
        enum RollupState {
            /** 0 - Attribute value is yet to be calculated */
            NotCalculated,
            /** 1 - Attribute value has been calculated per the last update time in <AttributeSchemaName>_Date attribute */
            Calculated,
            /** 2 - Attribute value calculation lead to overflow error */
            OverflowError,
            /** 3 - Attribute value calculation failed due to an internal error, next run of calculation job will likely fix it */
            OtherError,
            /** 4 - Attribute value calculation failed because the maximum number of retry attempts to calculate the value were exceeded likely due to high number of concurrency and locking conflicts */
            RetryLimitExceeded,
            /** 5 - Attribute value calculation failed because maximum hierarchy depth limit for calculation was reached */
            HierarchicalRecursionLimitReached,
            /** 6 - Attribute value calculation failed because a recursive loop was detected in the hierarchy of the record */
            LoopDetected
        }
	}
}
//{'JsForm':['Information'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true,'Version':'2.12.31','JsFormVersion':'v2'}