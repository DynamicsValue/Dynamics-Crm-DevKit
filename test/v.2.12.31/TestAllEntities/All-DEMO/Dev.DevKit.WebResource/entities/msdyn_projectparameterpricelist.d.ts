﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace Formmsdyn_projectparameterpricelist_Information {
		interface tab__6C6C63A1_20B3_4780_9C4C_C1275A68A1EE_Sections {
			_6C6C63A1_20B3_4780_9C4C_C1275A68A1EE_SECTION_2: DevKit.Controls.Section;
		}
		interface tab__6C6C63A1_20B3_4780_9C4C_C1275A68A1EE extends DevKit.Controls.ITab {
			Section: tab__6C6C63A1_20B3_4780_9C4C_C1275A68A1EE_Sections;
		}
		interface Tabs {
			_6C6C63A1_20B3_4780_9C4C_C1275A68A1EE: tab__6C6C63A1_20B3_4780_9C4C_C1275A68A1EE;
		}
		interface Body {
			Tab: Tabs;
			/** Type the name of the custom entity. */
			msdyn_description: DevKit.Controls.String;
			/** Select the price list that is being associated to the project parameter record. */
			msdyn_PriceList: DevKit.Controls.Lookup;
			/** Select the project parameter record that this price list linked to. */
			msdyn_ProjectParameter: DevKit.Controls.Lookup;
		}
	}
	class Formmsdyn_projectparameterpricelist_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_projectparameterpricelist_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_projectparameterpricelist_Information */
		Body: DevKit.Formmsdyn_projectparameterpricelist_Information.Body;
	}
	namespace Formmsdyn_projectparameterpricelist_Quick_Create {
		interface tab_tab_1_Sections {
			tab_1_column_1_section_1: DevKit.Controls.Section;
			tab_1_column_2_section_1: DevKit.Controls.Section;
			tab_1_column_3_section_1: DevKit.Controls.Section;
		}
		interface tab_tab_1 extends DevKit.Controls.ITab {
			Section: tab_tab_1_Sections;
		}
		interface Tabs {
			tab_1: tab_tab_1;
		}
		interface Body {
			Tab: Tabs;
			/** Select the price list that is being associated to the project parameter record. */
			msdyn_PriceList: DevKit.Controls.Lookup;
		}
	}
	class Formmsdyn_projectparameterpricelist_Quick_Create extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_projectparameterpricelist_Quick_Create
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_projectparameterpricelist_Quick_Create */
		Body: DevKit.Formmsdyn_projectparameterpricelist_Quick_Create.Body;
	}
	class msdyn_projectparameterpricelistApi {
		/**
		* DynamicsCrm.DevKit msdyn_projectparameterpricelistApi
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
		/** Date and time when the record was created. */
		CreatedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Unique identifier of the delegate user who created the record. */
		CreatedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Sequence number of the import that created this record. */
		ImportSequenceNumber: DevKit.WebApi.IntegerValue;
		/** Unique identifier of the user who modified the record. */
		ModifiedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was modified. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Unique identifier of the delegate user who modified the record. */
		ModifiedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Type the name of the custom entity. */
		msdyn_description: DevKit.WebApi.StringValue;
		/** Select the price list that is being associated to the project parameter record. */
		msdyn_PriceList: DevKit.WebApi.LookupValue;
		/** Select the project parameter record that this price list linked to. */
		msdyn_ProjectParameter: DevKit.WebApi.LookupValue;
		/** Unique identifier for entity instances */
		msdyn_projectparameterpricelistId: DevKit.WebApi.GuidValue;
		/** Unique identifier for the organization */
		OrganizationId: DevKit.WebApi.LookupValueReadonly;
		/** Date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Status of the Project Parameter Price List */
		statecode: DevKit.WebApi.OptionSetValue;
		/** Reason for the status of the Project Parameter Price List */
		statuscode: DevKit.WebApi.OptionSetValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Time zone code that was in use when the record was created. */
		UTCConversionTimeZoneCode: DevKit.WebApi.IntegerValue;
		/** Version Number */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
	}
}
declare namespace OptionSet {
	namespace msdyn_projectparameterpricelist {
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
//{'JsForm':['Information','Quick Create'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true,'Version':'2.12.31','JsFormVersion':'v2'}