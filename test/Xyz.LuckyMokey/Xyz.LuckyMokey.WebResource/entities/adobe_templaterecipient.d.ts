﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace Formadobe_templaterecipient_Information {
		interface Tabs {
		}
		interface Body {
			adobe_dynamicrecipient: DevKit.Form.Controls.ControlBoolean;
			adobe_emaildisplay: DevKit.Form.Controls.ControlString;
			/** The name of the custom entity. */
			adobe_name: DevKit.Form.Controls.ControlString;
			adobe_primaryentity: DevKit.Form.Controls.ControlString;
			/** Owner Id */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
	}
	class Formadobe_templaterecipient_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form adobe_templaterecipient_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form adobe_templaterecipient_Information */
		Body: LuckyMokey.Formadobe_templaterecipient_Information.Body;
	}
}
declare namespace OptionSet {
	namespace adobe_templaterecipient {
		enum adobe_accountoptions {
			/** 648770000 */
			Lead_Contact_Only,
			/** 648770001 */
			All_Contacts_associated_with_Account
		}
		enum adobe_customentityoptions {
			/** 648770000 */
			Lead_Contact_Only,
			/** 648770001 */
			All_Contacts_associated_with_Entity,
			/** 648770002 */
			Lead_Contact_from_associated_Account,
			/** 648770003 */
			All_Contacts_from_associated_Account
		}
		enum adobe_identityverification {
			/** 648770003 */
			EMAIL,
			/** 648770004 */
			PHONE,
			/** 648770000 */
			PASSWORD,
			/** 648770001 */
			KNOWLEDGE_BASE,
			/** 648770002 */
			WEB_IDENTITY
		}
		enum adobe_opportunityoptions {
			/** 648770000 */
			Lead_Contact_Only,
			/** 648770001 */
			All_Contacts_Associated_With_Opportunity
		}
		enum adobe_recipientrole {
			/** 648770000 */
			SIGNER,
			/** 648770001 */
			APPROVER,
			/** 648770002 */
			CC
		}
		enum adobe_recipienttype {
			/** 648770000 */
			New,
			/** 648770001 */
			Contact,
			/** 648770002 */
			Lead,
			/** 648770003 */
			User
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