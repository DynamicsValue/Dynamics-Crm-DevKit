﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace Formmsdyn_liveworkstream_Information {
		interface Header {
			msdyn_streamsource: DevKit.Form.Controls.ControlOptionSet;
			/** Specifies the mode i.e Push/Pick for the workstream */
			msdyn_workdistributionmode: DevKit.Form.Controls.ControlOptionSet;
			/** Owner Id */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
		interface tab_tab1_summary_Sections {
			tab_3_section_1: DevKit.Form.Controls.ControlSection;
			tab1_summary_section_6: DevKit.Form.Controls.ControlSection;
		}
		interface tab_tab_3_Sections {
			tab_3_section_2: DevKit.Form.Controls.ControlSection;
		}
		interface tab_smsSettings_Sections {
			SMSProviderDetails: DevKit.Form.Controls.ControlSection;
			RESTAPIDetails: DevKit.Form.Controls.ControlSection;
			SMSConnectionParameters: DevKit.Form.Controls.ControlSection;
			MSFlowOutboundNotifications: DevKit.Form.Controls.ControlSection;
		}
		interface tab_smsNumbers_Sections {
			tab_4_section_1: DevKit.Form.Controls.ControlSection;
		}
		interface tab_SkillAttachmentRulesTab_Sections {
			SkillAttachmentSection: DevKit.Form.Controls.ControlSection;
		}
		interface tab_RoutingRuleItems_Sections {
		}
		interface tab_BotAssistedAgentGuidance_Sections {
			tab_4_section_1: DevKit.Form.Controls.ControlSection;
		}
		interface tab_tab_templates_Sections {
			tab_templates_section_1: DevKit.Form.Controls.ControlSection;
			tab_templates_section_2: DevKit.Form.Controls.ControlSection;
		}
		interface tab_tab1_summary extends DevKit.Form.Controls.IControlTab {
			Section: tab_tab1_summary_Sections;
		}
		interface tab_tab_3 extends DevKit.Form.Controls.IControlTab {
			Section: tab_tab_3_Sections;
		}
		interface tab_smsSettings extends DevKit.Form.Controls.IControlTab {
			Section: tab_smsSettings_Sections;
		}
		interface tab_smsNumbers extends DevKit.Form.Controls.IControlTab {
			Section: tab_smsNumbers_Sections;
		}
		interface tab_SkillAttachmentRulesTab extends DevKit.Form.Controls.IControlTab {
			Section: tab_SkillAttachmentRulesTab_Sections;
		}
		interface tab_RoutingRuleItems extends DevKit.Form.Controls.IControlTab {
			Section: tab_RoutingRuleItems_Sections;
		}
		interface tab_BotAssistedAgentGuidance extends DevKit.Form.Controls.IControlTab {
			Section: tab_BotAssistedAgentGuidance_Sections;
		}
		interface tab_tab_templates extends DevKit.Form.Controls.IControlTab {
			Section: tab_tab_templates_Sections;
		}
		interface Tabs {
			tab1_summary: tab_tab1_summary;
			tab_3: tab_tab_3;
			smsSettings: tab_smsSettings;
			smsNumbers: tab_smsNumbers;
			SkillAttachmentRulesTab: tab_SkillAttachmentRulesTab;
			RoutingRuleItems: tab_RoutingRuleItems;
			BotAssistedAgentGuidance: tab_BotAssistedAgentGuidance;
			tab_templates: tab_tab_templates;
		}
		interface Body {
			Tab: Tabs;
			contextvariables: DevKit.Form.Controls.ControlGrid;
			WebResource_TwilioDisclaimer: DevKit.Form.Controls.ControlWebResource;
			SMSNumbers: DevKit.Form.Controls.ControlGrid;
			WebResource_HelpDialog: DevKit.Form.Controls.ControlWebResource;
			AttachmentRulesSubGrid: DevKit.Form.Controls.ControlGrid;
			RuleItems: DevKit.Form.Controls.ControlGrid;
			BotAssistedAgentGuidanceSubGrid: DevKit.Form.Controls.ControlGrid;
			/** Allowed base presences for the work stream */
			msdyn_AllowedPresences: DevKit.Form.Controls.ControlMultiOptionSet;
			/** The API Key equivalent to password of account set up with TeleSign */
			msdyn_APIKey: DevKit.Form.Controls.ControlString;
			/** Set the time after which a work item can be assigned to the agent again after he/she has declined the work item or the request has timed out */
			msdyn_AssignWorkItemAfterDecline: DevKit.Form.Controls.ControlInteger;
			/** Set the time after which the work item will be closed if there is no activity on the work item. */
			msdyn_AutoCloseAfterInactivity: DevKit.Form.Controls.ControlInteger;
			/** The units of capacity that should be available for an item of this work stream to be processed. */
			msdyn_CapacityRequired: DevKit.Form.Controls.ControlInteger;
			/** Flow URL for Dynamics 365 connector */
			msdyn_ConnectorsURL: DevKit.Form.Controls.ControlString;
			/** The Customer Id equivalent to username of account set up with TeleSign */
			msdyn_CustomerID: DevKit.Form.Controls.ControlString;
			/** Option for allowing automated messages or not */
			msdyn_enableautomatedmessages: DevKit.Form.Controls.ControlBoolean;
			/** Unique identifier for Workstream Entity Configuration associated with Work Stream. */
			msdyn_EntityRoutingConfigurationId: DevKit.Form.Controls.ControlLookup;
			/** The time when Validation api was last run */
			msdyn_LastValidationOn: DevKit.Form.Controls.ControlDateTime;
			/** The status of the last Validation results */
			msdyn_LastValidationStatus: DevKit.Form.Controls.ControlString;
			msdyn_matchinglogic: DevKit.Form.Controls.ControlOptionSet;
			/** Maximum number of concurrent sessions that an agent can work for a work item of a particular stream. */
			msdyn_MaxConcurrentConnection: DevKit.Form.Controls.ControlInteger;
			/** Name of Work stream */
			msdyn_name: DevKit.Form.Controls.ControlString;
			msdyn_Notification: DevKit.Form.Controls.ControlOptionSet;
			msdyn_notificationscenarioplaceholder: DevKit.Form.Controls.ControlString;
			msdyn_Screenpoptimeout_optionSet: DevKit.Form.Controls.ControlOptionSet;
			msdyn_sessionscenarioplaceholder: DevKit.Form.Controls.ControlString;
			/** SMS Provider */
			msdyn_smsprovider: DevKit.Form.Controls.ControlOptionSet;
			msdyn_streamsource: DevKit.Form.Controls.ControlOptionSet;
			/** URL for TeleSign Inbound link */
			msdyn_TelesignInboundURL: DevKit.Form.Controls.ControlString;
			/** URL for Twilio Inbound link */
			msdyn_TwilioInboundURL: DevKit.Form.Controls.ControlString;
			/** Specifies the mode i.e Push/Pick for the workstream */
			msdyn_workdistributionmode: DevKit.Form.Controls.ControlOptionSet;
		}
	}
	class Formmsdyn_liveworkstream_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_liveworkstream_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form msdyn_liveworkstream_Information */
		Body: LuckyMokey.Formmsdyn_liveworkstream_Information.Body;
		/** The Header section of form msdyn_liveworkstream_Information */
		Header: LuckyMokey.Formmsdyn_liveworkstream_Information.Header;
	}
}
declare namespace OptionSet {
	namespace msdyn_liveworkstream {
		enum msdyn_AllowedPresences {
			/** 192360000 */
			Available,
			/** 192360001 */
			Busy,
			/** 192360002 */
			Busy_DND,
			/** 192360003 */
			Away,
			/** 192360004 */
			Offline
		}
		enum msdyn_matchinglogic {
			/** 192350000 */
			Exact_Match,
			/** 192350001 */
			Closest_Match
		}
		enum msdyn_Notification {
			/** 100000000 */
			Directly_open_session,
			/** 100000001 */
			Screen_pop_with_timeout,
			/** 100000002 */
			Screen_pop_with_decline
		}
		enum msdyn_Screenpoptimeout_optionSet {
			/** 30 */
			_30,
			/** 60 */
			_60,
			/** 90 */
			_90,
			/** 120 */
			_120,
			/** 150 */
			_150,
			/** 180 */
			_180,
			/** 210 */
			_210,
			/** 240 */
			_240,
			/** 270 */
			_270,
			/** 300 */
			_300
		}
		enum msdyn_smsprovider {
			/** 192350000 */
			TeleSign
		}
		enum msdyn_streamsource {
			/** 192350000 */
			Entity_Records,
			/** 192360000 */
			Live_chat,
			/** 192370000 */
			Voice,
			/** 192380000 */
			Video,
			/** 192390000 */
			Co_browse,
			/** 192400000 */
			Screen_sharing,
			/** 192340000 */
			SMS,
			/** 192330000 */
			Facebook
		}
		enum msdyn_workdistributionmode {
			/** 192350000 */
			Push,
			/** 192350001 */
			Pick
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