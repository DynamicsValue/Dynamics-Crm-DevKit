﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	class ResourceGroupExpansionApi {
		/**
		* DynamicsCrm.DevKit ResourceGroupExpansionApi
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
		/** Sequence number of the import that created this record. */
		ImportSequenceNumber: DevKit.WebApi.IntegerValue;
		/** Item that is part of expansion of resource identified by object ID. One object ID can have many item IDs. */
		ItemId: DevKit.WebApi.GuidValue;
		/** Code for retrieval method. */
		MethodCode: DevKit.WebApi.OptionSetValue;
		/** Date and time when the record was last modified. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValue;
		/** name */
		Name: DevKit.WebApi.StringValue;
		/** Object being expanded. */
		ObjectId: DevKit.WebApi.GuidValue;
		/** Date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Unique identifier of the resource expansion record. */
		ResourceGroupExpansionId: DevKit.WebApi.GuidValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Time zone code that was in use when the record was created. */
		UTCConversionTimeZoneCode: DevKit.WebApi.IntegerValue;
		/** Version Number */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
	}
}
declare namespace OptionSet {
	namespace ResourceGroupExpansion {
		enum MethodCode {
			/** 5 */
			All_Resources,
			/** 8 */
			All_Subgroups,
			/** 0 */
			None,
			/** 7 */
			Parent_Groups,
			/** 1 */
			Participating_Resources,
			/** 4 */
			Resources,
			/** 2 */
			Schedulable_Resources,
			/** 6 */
			Subgroups,
			/** 3 */
			Supported_Services
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
//{'JsForm':[],'JsWebApi':true,'IsDebugForm':false,'IsDebugWebApi':true,'Version':'2.12.31','JsFormVersion':'v2'}