﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace FormAnalytics_Report_Record {
		interface tab__4659BB92_7C23_42B1_BE09_7F52780E95D0_Sections {
		}
		interface tab__4659BB92_7C23_42B1_BE09_7F52780E95D0 extends DevKit.Form.Controls.IControlTab {
			Section: tab__4659BB92_7C23_42B1_BE09_7F52780E95D0_Sections;
		}
		interface Tabs {
			_4659BB92_7C23_42B1_BE09_7F52780E95D0: tab__4659BB92_7C23_42B1_BE09_7F52780E95D0;
		}
		interface Body {
			Tab: Tabs;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Form.Controls.ControlString;
			/** Owner Id */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
	}
	class FormAnalytics_Report_Record extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form Analytics_Report_Record
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form Analytics_Report_Record */
		Body: LuckyMokey.FormAnalytics_Report_Record.Body;
	}
}
declare namespace OptionSet {
	namespace msdyn_dataanalyticsreport {
		enum ComponentState {
			/** 0 */
			Published,
			/** 1 */
			Unpublished,
			/** 2 */
			Deleted,
			/** 3 */
			Deleted_Unpublished
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
//{'JsForm':['Analytics Report Record'],'JsWebApi':false,'IsDebugForm':true,'IsDebugWebApi':false}