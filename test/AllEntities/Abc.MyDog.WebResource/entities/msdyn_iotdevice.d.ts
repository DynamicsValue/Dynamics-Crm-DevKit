﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace MyDog {
	namespace Formmsdyn_iotdevice_Information {
		interface Header extends DevKit.Controls.IHeader {
			/** Owner Id */
			OwnerId: DevKit.Controls.Lookup;
		}
		interface tab__1BCFF70D_5615_4084_953F_2196583D6E79_Sections {
			_A9378EBB_2FCC_41B7_8039_B2B2A89490E2: DevKit.Controls.Section;
			DeviceStatusSection: DevKit.Controls.Section;
			DeviceSettingsSection: DevKit.Controls.Section;
			Device_Summary_Visualization: DevKit.Controls.Section;
			Connected_Device_Readings: DevKit.Controls.Section;
		}
		interface tab_Device_Data_Sections {
			Device_Data: DevKit.Controls.Section;
		}
		interface tab_AlertsTab_Sections {
			AlertsSection: DevKit.Controls.Section;
		}
		interface tab_DeviceInsightsTab_Sections {
			DeviceInsightsSection: DevKit.Controls.Section;
		}
		interface tab_CommandsTab_Sections {
			CommandsSection: DevKit.Controls.Section;
		}
		interface tab_RegistrationHistory_Sections {
			RegistrationHistorySection: DevKit.Controls.Section;
		}
		interface tab__1BCFF70D_5615_4084_953F_2196583D6E79 extends DevKit.Controls.ITab {
			Section: tab__1BCFF70D_5615_4084_953F_2196583D6E79_Sections;
		}
		interface tab_Device_Data extends DevKit.Controls.ITab {
			Section: tab_Device_Data_Sections;
		}
		interface tab_AlertsTab extends DevKit.Controls.ITab {
			Section: tab_AlertsTab_Sections;
		}
		interface tab_DeviceInsightsTab extends DevKit.Controls.ITab {
			Section: tab_DeviceInsightsTab_Sections;
		}
		interface tab_CommandsTab extends DevKit.Controls.ITab {
			Section: tab_CommandsTab_Sections;
		}
		interface tab_RegistrationHistory extends DevKit.Controls.ITab {
			Section: tab_RegistrationHistory_Sections;
		}
		interface Tabs {
			_1BCFF70D_5615_4084_953F_2196583D6E79: tab__1BCFF70D_5615_4084_953F_2196583D6E79;
			Device_Data: tab_Device_Data;
			AlertsTab: tab_AlertsTab;
			DeviceInsightsTab: tab_DeviceInsightsTab;
			CommandsTab: tab_CommandsTab;
			RegistrationHistory: tab_RegistrationHistory;
		}
		interface Body {
			Tab: Tabs;
			WebResource_PowerBIDevice: DevKit.Controls.WebResource;
			/** Parent customer of this device */
			msdyn_Account: DevKit.Controls.Lookup;
			/** The device category that this IoT device belongs to. */
			msdyn_Category: DevKit.Controls.Lookup;
			/** The connection status of the device (Disconnected or Connected) */
			msdyn_ConnectionState: DevKit.Controls.Boolean;
			/** Device ID used to register with the IoT provider. */
			msdyn_DeviceId: DevKit.Controls.String;
			/** Device ID used to register with the IoT provider. */
			msdyn_DeviceId_1: DevKit.Controls.String;
			/** Device ID used to register with the IoT provider. */
			msdyn_DeviceId_2: DevKit.Controls.String;
			/** Reported Properties data for Device */
			msdyn_DeviceReportedProperties: DevKit.Controls.String;
			/** Reported Properties data for Device */
			msdyn_DeviceReportedProperties_1: DevKit.Controls.String;
			/** The editable properties for a device. */
			msdyn_DeviceSettings: DevKit.Controls.String;
			/** The editable properties for a device. */
			msdyn_DeviceSettings_1: DevKit.Controls.String;
			/** The IoT Provider Instance to which this device belongs. */
			msdyn_IoTProviderInstance: DevKit.Controls.Lookup;
			/** Select “Yes” if this device is simulated for testing and development purposes. Select “No” if this is a real device.​ */
			msdyn_IsSimulated: DevKit.Controls.OptionSet;
			/** The last activity time of the device */
			msdyn_LastActivityTime: DevKit.Controls.DateTime;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
			/** A message field that explains the IoT Registration Status. */
			msdyn_RegistrationMessage: DevKit.Controls.String;
			/** A status field that denotes whether the device is registered with the IoT provider. */
			msdyn_RegistrationStatus: DevKit.Controls.OptionSet;
			/** Identifying Tags for the Device */
			msdyn_Tags: DevKit.Controls.String;
			/** Identifying Tags for the Device */
			msdyn_Tags_1: DevKit.Controls.String;
			/** The device's time zone. */
			msdyn_Timezone: DevKit.Controls.Integer;
		}
		interface Grid {
			DeviceDataHistory: DevKit.Controls.Grid;
			AlertsGrid: DevKit.Controls.Grid;
			CommandsGrid: DevKit.Controls.Grid;
			RegistrationHistory: DevKit.Controls.Grid;
		}
	}
	class Formmsdyn_iotdevice_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_iotdevice_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_iotdevice_Information */
		Body: MyDog.Formmsdyn_iotdevice_Information.Body;
		/** The Header section of form msdyn_iotdevice_Information */
		Header: MyDog.Formmsdyn_iotdevice_Information.Header;
		/** The Grid of form msdyn_iotdevice_Information */
		Grid: MyDog.Formmsdyn_iotdevice_Information.Grid;
	}
	namespace FormIoT_Device_MFD {
		interface tab__D56B7A88_6981_4F4B_9AE2_6D1AEC457231_Sections {
			_804F2D0A_D93D_400B_9A90_B1C0D9992B5F: DevKit.Controls.Section;
			_column_2_section_1: DevKit.Controls.Section;
			_column_3_section_1: DevKit.Controls.Section;
			Device_Data: DevKit.Controls.Section;
		}
		interface tab__D56B7A88_6981_4F4B_9AE2_6D1AEC457231 extends DevKit.Controls.ITab {
			Section: tab__D56B7A88_6981_4F4B_9AE2_6D1AEC457231_Sections;
		}
		interface Tabs {
			_D56B7A88_6981_4F4B_9AE2_6D1AEC457231: tab__D56B7A88_6981_4F4B_9AE2_6D1AEC457231;
		}
		interface Body {
			Tab: Tabs;
			/** The connection status of the device (Disconnected or Connected) */
			msdyn_ConnectionState: DevKit.Controls.Boolean;
			/** Reported Properties data for Device */
			msdyn_DeviceReportedProperties: DevKit.Controls.String;
			/** The editable properties for a device. */
			msdyn_DeviceSettings: DevKit.Controls.String;
			/** The last activity time of the device */
			msdyn_LastActivityTime: DevKit.Controls.DateTime;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
			/** Identifying Tags for the Device */
			msdyn_Tags: DevKit.Controls.String;
			/** Owner Id */
			OwnerId: DevKit.Controls.Lookup;
		}
		interface Grid {
			DeviceDataHistory: DevKit.Controls.Grid;
		}
	}
	class FormIoT_Device_MFD extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form IoT_Device_MFD
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form IoT_Device_MFD */
		Body: MyDog.FormIoT_Device_MFD.Body;
		/** The Grid of form IoT_Device_MFD */
		Grid: MyDog.FormIoT_Device_MFD.Grid;
	}
}
declare namespace OptionSet {
	namespace msdyn_iotdevice {
		enum msdyn_IsSimulated {
			/** 192350001 */
			No,
			/** 192350000 */
			Yes
		}
		enum msdyn_RegistrationStatus {
			/** 192350004 */
			Error,
			/** 192350002 */
			In_Progress,
			/** 192350003 */
			Registered,
			/** 192350000 */
			Unknown,
			/** 192350001 */
			Unregistered
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
//{'JsForm':['Information','IoT Device MFD'],'JsWebApi':false,'IsDebugForm':true,'IsDebugWebApi':false,'Version':'2.12.31','JsFormVersion':'v2'}