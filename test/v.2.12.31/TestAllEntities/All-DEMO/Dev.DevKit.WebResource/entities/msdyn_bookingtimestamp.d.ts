﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace FormBooking_Timestamp_Mobile {
		interface tab_fstab_general_Sections {
			fstab_general_section_2: DevKit.Controls.Section;
			fstab_general_section_3: DevKit.Controls.Section;
			fstab_general_section_general: DevKit.Controls.Section;
		}
		interface tab_fstab_other_Sections {
			tab_3_section_1: DevKit.Controls.Section;
			tab_3_section_2: DevKit.Controls.Section;
			tab_3_section_3: DevKit.Controls.Section;
		}
		interface tab_fstab_sub_grids_Sections {
			fstab_sub_grids_section: DevKit.Controls.Section;
			fstab_sub_grids_section_2: DevKit.Controls.Section;
			fstab_sub_grids_section_3: DevKit.Controls.Section;
		}
		interface tab_fstab_general extends DevKit.Controls.ITab {
			Section: tab_fstab_general_Sections;
		}
		interface tab_fstab_other extends DevKit.Controls.ITab {
			Section: tab_fstab_other_Sections;
		}
		interface tab_fstab_sub_grids extends DevKit.Controls.ITab {
			Section: tab_fstab_sub_grids_Sections;
		}
		interface Tabs {
			fstab_general: tab_fstab_general;
			fstab_other: tab_fstab_other;
			fstab_sub_grids: tab_fstab_sub_grids;
		}
		interface Body {
			Tab: Tabs;
			/** Unique identifier for Resource Booking associated with Booking Timestamp. */
			msdyn_Booking: DevKit.Controls.Lookup;
			/** Enter the name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
			msdyn_SystemStatus: DevKit.Controls.OptionSet;
			msdyn_TimestampTime: DevKit.Controls.DateTime;
			notescontrol: DevKit.Controls.Note;
			/** Owner Id */
			OwnerId: DevKit.Controls.Lookup;
		}
		interface Navigation {
			navProcessSessions: DevKit.Controls.NavigationItem
		}
	}
	class FormBooking_Timestamp_Mobile extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Booking_Timestamp_Mobile
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Booking_Timestamp_Mobile */
		Body: DevKit.FormBooking_Timestamp_Mobile.Body;
		/** The Navigation of form Booking_Timestamp_Mobile */
		Navigation: DevKit.FormBooking_Timestamp_Mobile.Navigation;
	}
	namespace Formmsdyn_bookingtimestamp_Information {
		interface Tabs {
		}
		interface Body {
			/** Unique identifier for Resource Booking associated with Booking Timestamp. */
			msdyn_Booking: DevKit.Controls.Lookup;
			/** Booking Status of the booking */
			msdyn_BookingStatus: DevKit.Controls.Lookup;
			/** Enter the name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
			msdyn_SystemStatus: DevKit.Controls.OptionSet;
			msdyn_TimestampTime: DevKit.Controls.DateTime;
			notescontrol: DevKit.Controls.Note;
			/** Owner Id */
			OwnerId: DevKit.Controls.Lookup;
		}
		interface Footer extends DevKit.Controls.IFooter {
			/** Status of the Booking Timestamp */
			statecode: DevKit.Controls.OptionSet;
		}
		interface Navigation {
			navProcessSessions: DevKit.Controls.NavigationItem
		}
	}
	class Formmsdyn_bookingtimestamp_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_bookingtimestamp_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_bookingtimestamp_Information */
		Body: DevKit.Formmsdyn_bookingtimestamp_Information.Body;
		/** The Footer section of form msdyn_bookingtimestamp_Information */
		Footer: DevKit.Formmsdyn_bookingtimestamp_Information.Footer;
		/** The Navigation of form msdyn_bookingtimestamp_Information */
		Navigation: DevKit.Formmsdyn_bookingtimestamp_Information.Navigation;
	}
	class msdyn_bookingtimestampApi {
		/**
		* DynamicsCrm.DevKit msdyn_bookingtimestampApi
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
		/** Unique identifier of the user who created the record. */
		CreatedBy: DevKit.WebApi.LookupValueReadonly;
		/** Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. */
		CreatedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Shows who created the record on behalf of another user. */
		CreatedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Shows the sequence number of the import that created this record. */
		ImportSequenceNumber: DevKit.WebApi.IntegerValue;
		/** Unique identifier of the user who modified the record. */
		ModifiedBy: DevKit.WebApi.LookupValueReadonly;
		/** Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Shows who last updated the record on behalf of another user. */
		ModifiedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for Resource Booking associated with Booking Timestamp. */
		msdyn_Booking: DevKit.WebApi.LookupValue;
		/** Booking Status of the booking */
		msdyn_BookingStatus: DevKit.WebApi.LookupValue;
		/** Shows the entity instances. */
		msdyn_bookingtimestampId: DevKit.WebApi.GuidValue;
		/** System internal field. Indicates that journals must be generated after saving timestamp from mobile. */
		msdyn_GenerateJournals: DevKit.WebApi.BooleanValue;
		/** Enter the name of the custom entity. */
		msdyn_name: DevKit.WebApi.StringValue;
		msdyn_SystemStatus: DevKit.WebApi.OptionSetValue;
		msdyn_TimestampSource: DevKit.WebApi.OptionSetValue;
		msdyn_TimestampTime_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValue;
		/** Shows the date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user */
		OwnerId_systemuser: DevKit.WebApi.LookupValue;
		/** Enter the team who is assigned to manage the record. This field is updated every time the record is assigned to a different team */
		OwnerId_team: DevKit.WebApi.LookupValue;
		/** Unique identifier for the business unit that owns the record */
		OwningBusinessUnit: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for the team that owns the record. */
		OwningTeam: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for the user that owns the record. */
		OwningUser: DevKit.WebApi.LookupValueReadonly;
		/** Status of the Booking Timestamp */
		statecode: DevKit.WebApi.OptionSetValue;
		/** Reason for the status of the Booking Timestamp */
		statuscode: DevKit.WebApi.OptionSetValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Shows the time zone code that was in use when the record was created. */
		UTCConversionTimeZoneCode: DevKit.WebApi.IntegerValue;
		/** Version Number */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
	}
}
declare namespace OptionSet {
	namespace msdyn_bookingtimestamp {
		enum msdyn_SystemStatus {
			/** 690970005 */
			Canceled,
			/** 690970004 */
			Completed,
			/** 690970003 */
			In_Progress,
			/** 690970002 */
			On_Break,
			/** 690970000 */
			Scheduled,
			/** 690970001 */
			Traveling
		}
		enum msdyn_TimestampSource {
			/** 690970000 */
			Desktop,
			/** 690970001 */
			Mobile
		}
		enum statecode {
			/** 0 */
			Active,
			/** 1 */
			Inactive
		}
		enum statuscode {
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
//{'JsForm':['Booking Timestamp - Mobile','Information'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true,'Version':'2.12.31','JsFormVersion':'v2'}