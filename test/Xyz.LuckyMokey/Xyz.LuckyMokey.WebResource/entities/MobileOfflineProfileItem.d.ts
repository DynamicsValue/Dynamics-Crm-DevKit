﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace FormMobile_Offline_Profile_Item {
		interface tab_GENERALINFORMATION_TAB_Sections {
			Entity_Selection: DevKit.Form.Controls.ControlSection;
			MOBILE_OFFLINE_PROFILE_ITEM_ASSOCIATIONS: DevKit.Form.Controls.ControlSection;
		}
		interface tab_GENERALINFORMATION_TAB extends DevKit.Form.Controls.IControlTab {
			Section: tab_GENERALINFORMATION_TAB_Sections;
		}
		interface Tabs {
			GENERALINFORMATION_TAB: tab_GENERALINFORMATION_TAB;
		}
		interface Body {
			Tab: Tabs;
			profileassociationgrid: DevKit.Form.Controls.ControlGrid;
			/** Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options. */
			CreatedOn: DevKit.Form.Controls.ControlDateTime;
			/** Enter the name of the mobile offline profile item. */
			Name: DevKit.Form.Controls.ControlString;
			/** Specify data download filter for selected entity */
			RecordDistributionCriteria: DevKit.Form.Controls.ControlOptionSet;
			/** Download my records */
			RecordsOwnedByMe: DevKit.Form.Controls.ControlBoolean;
			/** Download my business unit's records */
			RecordsOwnedByMyBusinessUnit: DevKit.Form.Controls.ControlBoolean;
			/** Download my team's records */
			RecordsOwnedByMyTeam: DevKit.Form.Controls.ControlBoolean;
			/** Mobile offline enabled entity */
			SelectedEntityTypeCode: DevKit.Form.Controls.ControlString;
		}
	}
	class FormMobile_Offline_Profile_Item extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form Mobile_Offline_Profile_Item
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form Mobile_Offline_Profile_Item */
		Body: LuckyMokey.FormMobile_Offline_Profile_Item.Body;
	}
}
declare namespace OptionSet {
	namespace MobileOfflineProfileItem {
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
		enum RecordDistributionCriteria {
			/** 0 */
			Download_related_data_only,
			/** 1 */
			All_records,
			/** 2 */
			Other_data_filter,
			/** 3 */
			Custom_data_filter
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
//{'JsForm':['Mobile Offline Profile Item'],'JsWebApi':false,'IsDebugForm':true,'IsDebugWebApi':false}