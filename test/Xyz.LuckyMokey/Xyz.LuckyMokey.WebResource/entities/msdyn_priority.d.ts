﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace Formmsdyn_priority_Information {
		interface Tabs {
		}
		interface Body {
			WebResource_colorPicker: DevKit.Form.Controls.ControlWebResource;
			notescontrol: DevKit.Form.Controls.ControlNote;
			/** Enter the importance level of the priority. */
			msdyn_LevelofImportance: DevKit.Form.Controls.ControlOptionSet;
			/** Enter the priority name. */
			msdyn_name: DevKit.Form.Controls.ControlString;
			/** Select the color to be used to visualize the priority on the schedule board. */
			msdyn_PriorityColor: DevKit.Form.Controls.ControlString;
			/** Owner Id */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
		interface Footer {
			/** Status of the Priority */
			statecode: DevKit.Form.Controls.ControlOptionSet;
		}
		interface Navigation {
			nav_msdyn_msdyn_priority_msdyn_agreementbookingsetup_Priority: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_msdyn_priority_msdyn_workorder_Priority: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class Formmsdyn_priority_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_priority_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form msdyn_priority_Information */
		Body: LuckyMokey.Formmsdyn_priority_Information.Body;
		/** The Footer section of form msdyn_priority_Information */
		Footer: LuckyMokey.Formmsdyn_priority_Information.Footer;
		/** The Navigation of form msdyn_priority_Information */
		Navigation: LuckyMokey.Formmsdyn_priority_Information.Navigation;
	}
}
declare namespace OptionSet {
	namespace msdyn_priority {
		enum msdyn_LevelofImportance {
			/** 1 */
			_1,
			/** 2 */
			_2,
			/** 3 */
			_3,
			/** 4 */
			_4,
			/** 5 */
			_5,
			/** 6 */
			_6,
			/** 7 */
			_7,
			/** 8 */
			_8,
			/** 9 */
			_9,
			/** 10 */
			_10
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
//{'JsForm':['Information'],'JsWebApi':false,'IsDebugForm':true,'IsDebugWebApi':false}