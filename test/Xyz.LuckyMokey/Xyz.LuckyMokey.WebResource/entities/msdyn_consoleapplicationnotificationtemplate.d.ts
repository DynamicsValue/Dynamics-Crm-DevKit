﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace Formmsdyn_consoleapplicationnotificationtemplate_Information {
		interface tab__9730037D_AB23_4A34_9B05_5A0E50E1C401_Sections {
			_9730037D_AB23_4A34_9B05_5A0E50E1C401_SECTION_2: DevKit.Form.Controls.ControlSection;
		}
		interface tab__9730037D_AB23_4A34_9B05_5A0E50E1C401 extends DevKit.Form.Controls.IControlTab {
			Section: tab__9730037D_AB23_4A34_9B05_5A0E50E1C401_Sections;
		}
		interface Tabs {
			_9730037D_AB23_4A34_9B05_5A0E50E1C401: tab__9730037D_AB23_4A34_9B05_5A0E50E1C401;
		}
		interface Body {
			Tab: Tabs;
			NotificationFields: DevKit.Form.Controls.ControlGrid;
			msdyn_AcceptButtonText: DevKit.Form.Controls.ControlString;
			/** Display icon for this notification. Can be either an image URL or a font-icon */
			msdyn_Icon: DevKit.Form.Controls.ControlString;
			/** The name of this Notification template. */
			msdyn_name: DevKit.Form.Controls.ControlString;
			msdyn_notificationbuttons: DevKit.Form.Controls.ControlActionCards;
			msdyn_RejectButtonText: DevKit.Form.Controls.ControlString;
			/** Show timeout for the Notification template */
			msdyn_Showtimeout: DevKit.Form.Controls.ControlOptionSet;
			/** Theme color for Notification template. */
			msdyn_Theme: DevKit.Form.Controls.ControlOptionSet;
			/** Notification time out period. */
			msdyn_Timeout: DevKit.Form.Controls.ControlInteger;
			/** The title to be displayed for this notification. */
			msdyn_Title: DevKit.Form.Controls.ControlString;
		}
		interface Navigation {
			nav_msdyn_msdyn_consoleapplicationnotificationtag: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class Formmsdyn_consoleapplicationnotificationtemplate_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_consoleapplicationnotificationtemplate_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form msdyn_consoleapplicationnotificationtemplate_Information */
		Body: LuckyMokey.Formmsdyn_consoleapplicationnotificationtemplate_Information.Body;
		/** The Navigation of form msdyn_consoleapplicationnotificationtemplate_Information */
		Navigation: LuckyMokey.Formmsdyn_consoleapplicationnotificationtemplate_Information.Navigation;
	}
}
declare namespace OptionSet {
	namespace msdyn_consoleapplicationnotificationtemplate {
		enum msdyn_ActionButtons {
			/** 100000000 */
			Allow,
			/** 100000001 */
			Deny
		}
		enum msdyn_Showtimeout {
			/** 100000000 */
			Yes,
			/** 100000001 */
			No
		}
		enum msdyn_Theme {
			/** 100000000 */
			Dark,
			/** 100000001 */
			Light
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