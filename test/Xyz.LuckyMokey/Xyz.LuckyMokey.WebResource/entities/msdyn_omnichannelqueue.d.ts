﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace Formmsdyn_omnichannelqueue_Information {
		interface tab__F28EE33D_6D01_4FA5_9DF7_131948622080_Sections {
			_C536D941_D9FA_4E1A_91FA_C098869D1913: DevKit.Form.Controls.ControlSection;
			_F28EE33D_6D01_4FA5_9DF7_131948622080_SECTION_2: DevKit.Form.Controls.ControlSection;
		}
		interface tab__F28EE33D_6D01_4FA5_9DF7_131948622080 extends DevKit.Form.Controls.IControlTab {
			Section: tab__F28EE33D_6D01_4FA5_9DF7_131948622080_Sections;
		}
		interface Tabs {
			_F28EE33D_6D01_4FA5_9DF7_131948622080: tab__F28EE33D_6D01_4FA5_9DF7_131948622080;
		}
		interface Body {
			Tab: Tabs;
			Agents: DevKit.Form.Controls.ControlGrid;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Form.Controls.ControlString;
			msdyn_Priority: DevKit.Form.Controls.ControlInteger;
			/** Owner Id */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
	}
	class Formmsdyn_omnichannelqueue_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_omnichannelqueue_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form msdyn_omnichannelqueue_Information */
		Body: LuckyMokey.Formmsdyn_omnichannelqueue_Information.Body;
	}
}
declare namespace OptionSet {
	namespace msdyn_omnichannelqueue {
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
//{'JsForm':['Information'],'JsWebApi':false,'IsDebugForm':true,'IsDebugWebApi':false}