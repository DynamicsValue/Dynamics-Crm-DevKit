﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyStar {
	namespace Formmsdyn_componentlayer_Information {
		interface Tabs {
		}
		interface Body {
			/** The name of the component. */
			msdyn_name: DevKit.Form.Controls.ControlString;
		}
	}
	class Formmsdyn_componentlayer_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_componentlayer_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form msdyn_componentlayer_Information */
		Body: LuckyStar.Formmsdyn_componentlayer_Information.Body;
	}
	class msdyn_componentlayerApi {
		/**
		* DynamicsCrm.DevKit msdyn_componentlayerApi
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
		msdyn_changes: DevKit.WebApi.StringValue;
		msdyn_componentid: DevKit.WebApi.StringValue;
		msdyn_componentjson: DevKit.WebApi.StringValue;
		/** Unique identifier for entity instances */
		msdyn_componentlayerId: DevKit.WebApi.GuidValue;
		msdyn_endtime_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValue;
		/** The name of the component. */
		msdyn_name: DevKit.WebApi.StringValue;
		msdyn_order: DevKit.WebApi.IntegerValue;
		msdyn_publishername: DevKit.WebApi.StringValue;
		msdyn_solutioncomponentname: DevKit.WebApi.StringValue;
		msdyn_solutionname: DevKit.WebApi.StringValue;
	}
}
declare namespace OptionSet {
	namespace msdyn_componentlayer {
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
//{'JsForm':['Information'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true}