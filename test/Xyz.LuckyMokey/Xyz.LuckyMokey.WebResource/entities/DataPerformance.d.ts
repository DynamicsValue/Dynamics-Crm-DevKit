﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace FormDataPerformance_Information {
		interface tab_Performance_Improvement_Sections {
			Performance_Improvement: DevKit.Form.Controls.ControlSection;
		}
		interface tab_Performance_Improvement extends DevKit.Form.Controls.IControlTab {
			Section: tab_Performance_Improvement_Sections;
		}
		interface Tabs {
			Performance_Improvement: tab_Performance_Improvement;
		}
		interface Body {
			Tab: Tabs;
			/** An internal state which indicates whether at least one optimization is applied. */
			AnyOptimizationApplied: DevKit.Form.Controls.ControlBoolean;
			/** An internal state which indicates whether at least one optimization is available for this record. */
			AnyOptimizationAvailable: DevKit.Form.Controls.ControlBoolean;
			/** Number of times a queries were executed (Aggregated) */
			Count: DevKit.Form.Controls.ControlInteger;
			/** Primary entity */
			Entity: DevKit.Form.Controls.ControlString;
			/** An internal state which shows the result of the last action that was taken on this record. */
			LastActionResult: DevKit.Form.Controls.ControlString;
			/** Maximum execution time in seconds. (Aggregated) */
			MaxTime: DevKit.Form.Controls.ControlDecimal;
			/** Average execution time in seconds. (Aggregated) */
			MedianTime: DevKit.Form.Controls.ControlDecimal;
			/** Minimum execution time in seconds. (Aggregated) */
			MinTime: DevKit.Form.Controls.ControlDecimal;
			/** Data operation that triggered the query (Retrieve Multiple, etc.) */
			Operation: DevKit.Form.Controls.ControlString;
			/** Current optimization status of the record, showed to the customer. */
			OptimizationStatus: DevKit.Form.Controls.ControlString;
			/** Query Weight of the component. Factored with the Optimization Impact to determine the overall importance of applying an optimization. (P2) */
			Weight: DevKit.Form.Controls.ControlDecimal;
		}
	}
	class FormDataPerformance_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form DataPerformance_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form DataPerformance_Information */
		Body: LuckyMokey.FormDataPerformance_Information.Body;
	}
}
declare namespace OptionSet {
	namespace DataPerformance {
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