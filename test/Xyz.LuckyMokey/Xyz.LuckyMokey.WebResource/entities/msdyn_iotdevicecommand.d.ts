﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace Formmsdyn_iotdevicecommand_Information {
		interface tab__C820DAE9_B78D_4BBD_8FBE_DD255869040B_Sections {
			_5E35860A_0CC6_4E8A_9288_9E77DDB50B1E: DevKit.Form.Controls.ControlSection;
			_C820DAE9_B78D_4BBD_8FBE_DD255869040B_SECTION_2: DevKit.Form.Controls.ControlSection;
			IoTAlert: DevKit.Form.Controls.ControlSection;
			MessageSection: DevKit.Form.Controls.ControlSection;
			_C820DAE9_B78D_4BBD_8FBE_DD255869040B_SECTION_5: DevKit.Form.Controls.ControlSection;
		}
		interface tab_mfdTab_Sections {
		}
		interface tab__C820DAE9_B78D_4BBD_8FBE_DD255869040B extends DevKit.Form.Controls.IControlTab {
			Section: tab__C820DAE9_B78D_4BBD_8FBE_DD255869040B_Sections;
		}
		interface tab_mfdTab extends DevKit.Form.Controls.IControlTab {
			Section: tab_mfdTab_Sections;
		}
		interface Tabs {
			_C820DAE9_B78D_4BBD_8FBE_DD255869040B: tab__C820DAE9_B78D_4BBD_8FBE_DD255869040B;
			mfdTab: tab_mfdTab;
		}
		interface Body {
			Tab: Tabs;
			/** Date and time when the record was created. */
			CreatedOn: DevKit.Form.Controls.ControlDateTime;
			/** This optional field denotes the command definition that is used to construct the command string. */
			msdyn_Command: DevKit.Form.Controls.ControlLookup;
			/** This optional field denotes the command definition that is used to construct the command string. */
			msdyn_Command_1: DevKit.Form.Controls.ControlLookup;
			/** Describes the status of the command. If this stays at "In Progress" for a long time, verify the IoT endpoint configuration. */
			msdyn_CommandStatus: DevKit.Form.Controls.ControlOptionSet;
			/** A reason field that explains the command status. */
			msdyn_CommandStatusReason: DevKit.Form.Controls.ControlString;
			/** The command will be sent to a device connected to this asset. */
			msdyn_CustomerAsset: DevKit.Form.Controls.ControlLookup;
			/** The command will be sent to a device connected to this asset. */
			msdyn_CustomerAsset_1: DevKit.Form.Controls.ControlLookup;
			/** IoT device to send the message to. */
			msdyn_Device: DevKit.Form.Controls.ControlLookup;
			/** IoT device to send the message to. */
			msdyn_Device_1: DevKit.Form.Controls.ControlLookup;
			/** The ID of the IoT device to send the message to. */
			msdyn_DeviceID: DevKit.Form.Controls.ControlString;
			/** Message to send to the IoT device. E.g.: A Json string. */
			msdyn_Message: DevKit.Form.Controls.ControlString;
			/** Message to send to the IoT device. E.g.: A Json string. */
			msdyn_Message_1: DevKit.Form.Controls.ControlString;
			/** Message to send to the IoT device. E.g.: A Json string. */
			msdyn_Message_2: DevKit.Form.Controls.ControlString;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Form.Controls.ControlString;
			/** The name of the custom entity. */
			msdyn_name_1: DevKit.Form.Controls.ControlString;
			/** Reference to a primary alert in response to which the message is being sent. */
			msdyn_ParentAlert: DevKit.Form.Controls.ControlLookup;
			/** Yes, if a copy of the command should be sent to all registered devices connected under the parent entity of the selected device. No, if this command needs to be sent only to the selected device. */
			msdyn_SendToAllConnectedDevices: DevKit.Form.Controls.ControlBoolean;
			/** Owner Id */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
	}
	class Formmsdyn_iotdevicecommand_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_iotdevicecommand_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form msdyn_iotdevicecommand_Information */
		Body: LuckyMokey.Formmsdyn_iotdevicecommand_Information.Body;
	}
}
declare namespace OptionSet {
	namespace msdyn_iotdevicecommand {
		enum msdyn_CommandStatus {
			/** 192350000 */
			In_Progress,
			/** 192350001 */
			Sent,
			/** 192350002 */
			Error
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