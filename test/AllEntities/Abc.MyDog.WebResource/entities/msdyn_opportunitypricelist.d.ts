﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace MyDog {
	namespace Formmsdyn_opportunitypricelist_Information {
		interface Tabs {
		}
		interface Body {
			notescontrol: DevKit.Controls.Note;
			/** Type the name of the custom entity. */
			msdyn_description: DevKit.Controls.String;
			/** Select the opportunity that the price list is associated to. */
			msdyn_Opportunity: DevKit.Controls.Lookup;
			/** Select the price list that is associated to the opportunity. */
			msdyn_PriceList: DevKit.Controls.Lookup;
			/** Owner Id */
			OwnerId: DevKit.Controls.Lookup;
		}
	}
	class Formmsdyn_opportunitypricelist_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_opportunitypricelist_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_opportunitypricelist_Information */
		Body: MyDog.Formmsdyn_opportunitypricelist_Information.Body;
	}
}
declare namespace OptionSet {
	namespace msdyn_opportunitypricelist {
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
//{'JsForm':['Information'],'JsWebApi':false,'IsDebugForm':true,'IsDebugWebApi':false,'Version':'2.12.31','JsFormVersion':'v2'}