﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace Formmsdyn_omnichannelconfiguration_Information {
		interface tab_tab_skillbasedrouting_new_Sections {
			tab_2_section_1_2: DevKit.Controls.Section;
			tab_skillbasedrouting_section_2_3: DevKit.Controls.Section;
		}
		interface tab_tab_skillbasedrouting_new extends DevKit.Controls.ITab {
			Section: tab_tab_skillbasedrouting_new_Sections;
		}
		interface Tabs {
			tab_skillbasedrouting_new: tab_tab_skillbasedrouting_new;
		}
		interface Body {
			Tab: Tabs;
			/** Enable Skill Based Routing for Agents & Supervisors */
			msdyn_IsSkillBasedRoutingEnabled: DevKit.Controls.Boolean;
			/** This will enable agents to view and update skills for a conversation. */
			msdyn_IsUpdateSkillsEnabled: DevKit.Controls.Boolean;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
		}
		interface Grid {
			RatingModelDetails: DevKit.Controls.Grid;
		}
	}
	class Formmsdyn_omnichannelconfiguration_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_omnichannelconfiguration_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_omnichannelconfiguration_Information */
		Body: DevKit.Formmsdyn_omnichannelconfiguration_Information.Body;
		/** The Grid of form msdyn_omnichannelconfiguration_Information */
		Grid: DevKit.Formmsdyn_omnichannelconfiguration_Information.Grid;
	}
	namespace FormMasking_settings {
		interface tab__DCC1EB86_7EF2_4FF4_8D56_2A0F28FD1B5E_Sections {
			_26FF56C2_88FE_41F2_BE7F_AF3C273CFCE3: DevKit.Controls.Section;
			_44EFFE7C_A18D_4D4C_B111_DB98E28BC808_SECTION_3: DevKit.Controls.Section;
		}
		interface tab_Self_service_settings_Sections {
			_44EFFE7C_A18D_4D4C_B111_DB98E28BC808_SECTION_2: DevKit.Controls.Section;
		}
		interface tab__DCC1EB86_7EF2_4FF4_8D56_2A0F28FD1B5E extends DevKit.Controls.ITab {
			Section: tab__DCC1EB86_7EF2_4FF4_8D56_2A0F28FD1B5E_Sections;
		}
		interface tab_Self_service_settings extends DevKit.Controls.ITab {
			Section: tab_Self_service_settings_Sections;
		}
		interface Tabs {
			_DCC1EB86_7EF2_4FF4_8D56_2A0F28FD1B5E: tab__DCC1EB86_7EF2_4FF4_8D56_2A0F28FD1B5E;
			Self_service_settings: tab_Self_service_settings;
		}
		interface Body {
			Tab: Tabs;
			/** Enables supervisor assign feature for the org */
			msdyn_enable_supervisor_assign: DevKit.Controls.Boolean;
			/** Enables supervisor monitor feature for the org */
			msdyn_enable_supervisor_monitor: DevKit.Controls.Boolean;
			/** Enables self service feature for the org */
			msdyn_enable_visitorjourney: DevKit.Controls.Boolean;
			/** Mask agent data */
			msdyn_maskforagent: DevKit.Controls.Boolean;
			/** Mask customer data */
			msdyn_maskforcustomer: DevKit.Controls.Boolean;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
		}
		interface Grid {
			MaskingRulesInSettings: DevKit.Controls.Grid;
		}
	}
	class FormMasking_settings extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Masking_settings
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Masking_settings */
		Body: DevKit.FormMasking_settings.Body;
		/** The Grid of form Masking_settings */
		Grid: DevKit.FormMasking_settings.Grid;
	}
	namespace FormNotifications {
		interface tab_missed_notification_settings_Sections {
			missed_notifications_settings_section: DevKit.Controls.Section;
		}
		interface tab_notification_templates_Sections {
			notification_templates_section: DevKit.Controls.Section;
		}
		interface tab_tab_sound_notification_settings_Sections {
			tab_sound_notification_settings_section_3: DevKit.Controls.Section;
			tab_sound_notification_settings_section_4: DevKit.Controls.Section;
		}
		interface tab_missed_notification_settings extends DevKit.Controls.ITab {
			Section: tab_missed_notification_settings_Sections;
		}
		interface tab_notification_templates extends DevKit.Controls.ITab {
			Section: tab_notification_templates_Sections;
		}
		interface tab_tab_sound_notification_settings extends DevKit.Controls.ITab {
			Section: tab_tab_sound_notification_settings_Sections;
		}
		interface Tabs {
			missed_notification_settings: tab_missed_notification_settings;
			notification_templates: tab_notification_templates;
			tab_sound_notification_settings: tab_tab_sound_notification_settings;
		}
		interface Body {
			Tab: Tabs;
			/** Setting to change agent status when a notification has been missed. */
			msdyn_enable_missed_notifications: DevKit.Controls.Boolean;
			/** Enable sound notifications feature */
			msdyn_enablesoundnotifications: DevKit.Controls.Boolean;
			/** Lookup to display inactive presence settings. */
			msdyn_inactive_presence_lookup: DevKit.Controls.Lookup;
			msdyn_missednotificationssubheading: DevKit.Controls.ActionCards;
			/** Field to host sound form control */
			msdyn_SoundFormControl: DevKit.Controls.String;
		}
		interface quickForm_missed_notification_presence_update_quick_view_form_Body {
			msdyn_description: DevKit.Controls.QuickView;
			msdyn_presencestatustext: DevKit.Controls.QuickView;
		}
		interface quickForm_missed_notification_presence_update_quick_view_form extends DevKit.Controls.IQuickView {
			Body: quickForm_missed_notification_presence_update_quick_view_form_Body;
		}
		interface QuickForm {
			missed_notification_presence_update_quick_view_form: quickForm_missed_notification_presence_update_quick_view_form;
		}
		interface Grid {
			templates_grid: DevKit.Controls.Grid;
		}
	}
	class FormNotifications extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Notifications
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Notifications */
		Body: DevKit.FormNotifications.Body;
		/** The QuickForm of form Notifications */
		QuickForm: DevKit.FormNotifications.QuickForm;
		/** The Grid of form Notifications */
		Grid: DevKit.FormNotifications.Grid;
	}
	namespace FormPersonal_quick_replies {
		interface tab_personal_message_settings_Sections {
			personal_messaages_settings_section: DevKit.Controls.Section;
		}
		interface tab_personal_message_settings extends DevKit.Controls.ITab {
			Section: tab_personal_message_settings_Sections;
		}
		interface Tabs {
			personal_message_settings: tab_personal_message_settings;
		}
		interface Body {
			Tab: Tabs;
			/** Enable personal messages feature for the org */
			msdyn_isPersonalMessagesEnabled: DevKit.Controls.Boolean;
		}
	}
	class FormPersonal_quick_replies extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Personal_quick_replies
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Personal_quick_replies */
		Body: DevKit.FormPersonal_quick_replies.Body;
	}
	namespace FormReal_Time_Translation_Settings {
		interface tab_Real_Time_Translation_Sections {
			RealTimeTranslation_section_2: DevKit.Controls.Section;
			tab_3_section_1: DevKit.Controls.Section;
		}
		interface tab_Real_Time_Translation extends DevKit.Controls.ITab {
			Section: tab_Real_Time_Translation_Sections;
		}
		interface Tabs {
			Real_Time_Translation: tab_Real_Time_Translation;
		}
		interface Body {
			Tab: Tabs;
			/** Default language in which customer's messages are translated for an org */
			msdyn_defaultAgentInputLanguage: DevKit.Controls.OptionSet;
			/** Enable real time translation feature for the org */
			msdyn_EnableRealTimeTranslation: DevKit.Controls.Boolean;
			/** Webresource URL used for real time translation of the messages */
			msdyn_translationwebresourceurl: DevKit.Controls.String;
			WebResource_featureEnableTerms: DevKit.Controls.WebResource;
			WebResource_ocpreviewterms: DevKit.Controls.WebResource;
		}
	}
	class FormReal_Time_Translation_Settings extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Real_Time_Translation_Settings
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Real_Time_Translation_Settings */
		Body: DevKit.FormReal_Time_Translation_Settings.Body;
	}
	namespace FormSelf_service_settings {
		interface tab__44EFFE7C_A18D_4D4C_B111_DB98E28BC808_Sections {
			_311AD6D5_5179_4AC3_BE91_EF746DE66813: DevKit.Controls.Section;
		}
		interface tab_Self_service_settings_Sections {
			_44EFFE7C_A18D_4D4C_B111_DB98E28BC808_SECTION_2: DevKit.Controls.Section;
		}
		interface tab__44EFFE7C_A18D_4D4C_B111_DB98E28BC808 extends DevKit.Controls.ITab {
			Section: tab__44EFFE7C_A18D_4D4C_B111_DB98E28BC808_Sections;
		}
		interface tab_Self_service_settings extends DevKit.Controls.ITab {
			Section: tab_Self_service_settings_Sections;
		}
		interface Tabs {
			_44EFFE7C_A18D_4D4C_B111_DB98E28BC808: tab__44EFFE7C_A18D_4D4C_B111_DB98E28BC808;
			Self_service_settings: tab_Self_service_settings;
		}
		interface Body {
			Tab: Tabs;
			/** Enables supervisor assign feature for the org */
			msdyn_enable_supervisor_assign: DevKit.Controls.Boolean;
			/** Enables supervisor monitor feature for the org */
			msdyn_enable_supervisor_monitor: DevKit.Controls.Boolean;
			/** Enables self service feature for the org */
			msdyn_enable_visitorjourney: DevKit.Controls.Boolean;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
		}
	}
	class FormSelf_service_settings extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Self_service_settings
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Self_service_settings */
		Body: DevKit.FormSelf_service_settings.Body;
	}
	namespace FormSkill_based_routing_settings {
		interface tab_tab_1_Sections {
			tab_1_section_1: DevKit.Controls.Section;
			tab_1_section_2: DevKit.Controls.Section;
		}
		interface tab_tab_1 extends DevKit.Controls.ITab {
			Section: tab_tab_1_Sections;
		}
		interface Tabs {
			tab_1: tab_tab_1;
		}
		interface Body {
			Tab: Tabs;
			/** This will enable agents to view and update skills for a conversation. */
			msdyn_IsUpdateSkillsEnabled: DevKit.Controls.Boolean;
		}
		interface Grid {
			RatingModelDetails: DevKit.Controls.Grid;
		}
	}
	class FormSkill_based_routing_settings extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Skill_based_routing_settings
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Skill_based_routing_settings */
		Body: DevKit.FormSkill_based_routing_settings.Body;
		/** The Grid of form Skill_based_routing_settings */
		Grid: DevKit.FormSkill_based_routing_settings.Grid;
	}
	namespace FormSupervisor_settings {
		interface tab__44EFFE7C_A18D_4D4C_B111_DB98E28BC808_Sections {
			_26FF56C2_88FE_41F2_BE7F_AF3C273CFCE3: DevKit.Controls.Section;
		}
		interface tab_Supervisor_settings_Sections {
			_44EFFE7C_A18D_4D4C_B111_DB98E28BC808_SECTION_2: DevKit.Controls.Section;
		}
		interface tab__44EFFE7C_A18D_4D4C_B111_DB98E28BC808 extends DevKit.Controls.ITab {
			Section: tab__44EFFE7C_A18D_4D4C_B111_DB98E28BC808_Sections;
		}
		interface tab_Supervisor_settings extends DevKit.Controls.ITab {
			Section: tab_Supervisor_settings_Sections;
		}
		interface Tabs {
			_44EFFE7C_A18D_4D4C_B111_DB98E28BC808: tab__44EFFE7C_A18D_4D4C_B111_DB98E28BC808;
			Supervisor_settings: tab_Supervisor_settings;
		}
		interface Body {
			Tab: Tabs;
			/** Enables supervisor assign feature for the org */
			msdyn_enable_supervisor_assign: DevKit.Controls.Boolean;
			/** Enables supervisor monitor feature for the org */
			msdyn_enable_supervisor_monitor: DevKit.Controls.Boolean;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
		}
	}
	class FormSupervisor_settings extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Supervisor_settings
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Supervisor_settings */
		Body: DevKit.FormSupervisor_settings.Body;
	}
	class msdyn_omnichannelconfigurationApi {
		/**
		* DynamicsCrm.DevKit msdyn_omnichannelconfigurationApi
		* @param entity The entity object
		*/
		constructor(entity?: any);
		/**
		 * Get the value of alias
		 * @param alias the alias value
		 * @param isMultiOptionSet true if the alias is multi OptionSet
		 */
		getAliasedValue(alias: string, isMultiOptionSet?: boolean): any;
		/**
		 * Get the formatted value of alias
		 * @param alias the alias value
		 * @param isMultiOptionSet true if the alias is multi OptionSet
		 */
		getAliasedFormattedValue(alias: string, isMultiOptionSet?: boolean): string;
		/** The entity object */
		Entity: any;
		/** The entity name */
		EntityName: string;
		/** The entity collection name */
		EntityCollectionName: string;
		/** The @odata.etag is then used to build a cache of the response that is dependant on the fields that are retrieved */
		"@odata.etag": string;
		/** Unique identifier of the user who created the record. */
		CreatedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was created. */
		CreatedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Unique identifier of the delegate user who created the record. */
		CreatedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Sequence number of the import that created this record. */
		ImportSequenceNumber: DevKit.WebApi.IntegerValue;
		/** Unique identifier of the user who modified the record. */
		ModifiedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was modified. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Unique identifier of the delegate user who modified the record. */
		ModifiedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Default language in which customer's messages are translated for an org */
		msdyn_defaultAgentInputLanguage: DevKit.WebApi.OptionSetValue;
		/** Setting to change advance entity routing for the org. */
		msdyn_enable_advance_entity_routing: DevKit.WebApi.BooleanValue;
		/** Setting to change agent status when a notification has been missed. */
		msdyn_enable_missed_notifications: DevKit.WebApi.BooleanValue;
		/** Enables supervisor assign feature for the org */
		msdyn_enable_supervisor_assign: DevKit.WebApi.BooleanValue;
		/** Enables supervisor monitor feature for the org */
		msdyn_enable_supervisor_monitor: DevKit.WebApi.BooleanValue;
		/** Setting to change unified routing diagnostic for the org. */
		msdyn_enable_unified_routing_diagnostic: DevKit.WebApi.BooleanValue;
		/** Enables self service feature for the org */
		msdyn_enable_visitorjourney: DevKit.WebApi.BooleanValue;
		/** Enable real time translation feature for the org */
		msdyn_EnableRealTimeTranslation: DevKit.WebApi.BooleanValue;
		/** Enable sound notifications feature */
		msdyn_enablesoundnotifications: DevKit.WebApi.BooleanValue;
		/** Lookup to display inactive presence settings. */
		msdyn_inactive_presence_lookup: DevKit.WebApi.LookupValue;
		msdyn_isdefaultpersonamapped: DevKit.WebApi.BooleanValue;
		/** Allow agents to create personal sound settings */
		msdyn_ispersonalizationofsoundenabled: DevKit.WebApi.BooleanValue;
		/** Enable personal messages feature for the org */
		msdyn_isPersonalMessagesEnabled: DevKit.WebApi.BooleanValue;
		msdyn_ispersonasecurityrolemappingenabled: DevKit.WebApi.BooleanValue;
		/** Enable Skill Based Routing for Agents & Supervisors */
		msdyn_IsSkillBasedRoutingEnabled: DevKit.WebApi.BooleanValue;
		/** This will enable agents to view and update skills for a conversation. */
		msdyn_IsUpdateSkillsEnabled: DevKit.WebApi.BooleanValue;
		/** Mask agent data */
		msdyn_maskforagent: DevKit.WebApi.BooleanValue;
		/** Mask customer data */
		msdyn_maskforcustomer: DevKit.WebApi.BooleanValue;
		/** The name of the custom entity. */
		msdyn_name: DevKit.WebApi.StringValue;
		/** Unique identifier for entity instances */
		msdyn_omnichannelconfigurationId: DevKit.WebApi.GuidValue;
		/** Field to host sound form control */
		msdyn_SoundFormControl: DevKit.WebApi.StringValue;
		/** Webresource URL used for real time translation of the messages */
		msdyn_translationwebresourceurl: DevKit.WebApi.StringValue;
		/** Unique identifier for the organization */
		OrganizationId: DevKit.WebApi.LookupValueReadonly;
		/** Date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Status of the Omnichannel Configuration */
		statecode: DevKit.WebApi.OptionSetValue;
		/** Reason for the status of the Omnichannel Configuration */
		statuscode: DevKit.WebApi.OptionSetValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Time zone code that was in use when the record was created. */
		UTCConversionTimeZoneCode: DevKit.WebApi.IntegerValue;
		/** Version Number */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
	}
}
declare namespace OptionSet {
	namespace msdyn_omnichannelconfiguration {
		enum msdyn_defaultAgentInputLanguage {
			/** 1025 */
			Arabic_Saudi_Arabia,
			/** 1069 */
			Basque_Spain,
			/** 1026 */
			Bulgarian_Bulgaria,
			/** 1027 */
			Catalan_Spain,
			/** 2052 */
			Chinese_China,
			/** 3076 */
			Chinese_Hong_Kong,
			/** 1050 */
			Croatian_Croatia,
			/** 1029 */
			Czech_Czech_Republic,
			/** 1030 */
			Danish_Denmark,
			/** 1043 */
			Dutch_Netherlands,
			/** 1033 */
			English_United_States,
			/** 1061 */
			Estonian_Estonia,
			/** 1035 */
			Finnish_Finland,
			/** 1036 */
			French_France,
			/** 1110 */
			Galician_Spain,
			/** 1031 */
			German_Germany,
			/** 1032 */
			Greek_Greece,
			/** 1037 */
			Hebrew_Israel,
			/** 1081 */
			Hindi_India,
			/** 1038 */
			Hungarian_Hungary,
			/** 1057 */
			Indonesian_Indonesia,
			/** 1040 */
			Italian_Italy,
			/** 1041 */
			Japanese_Japan,
			/** 1087 */
			Kazakh_Kazakhstan,
			/** 1042 */
			Korean_Korea,
			/** 1062 */
			Latvian_Latvia,
			/** 1063 */
			Lithuanian_Lithuania,
			/** 1086 */
			Malay_Malaysia,
			/** 1044 */
			Norwegian_Bokmal_Norway,
			/** 1045 */
			Polish_Poland,
			/** 1046 */
			Portuguese_Brazil,
			/** 2070 */
			Portuguese_Portugal,
			/** 1048 */
			Romanian_Romania,
			/** 1049 */
			Russian_Russia,
			/** 3098 */
			Serbian_Cyrillic_Serbia,
			/** 2074 */
			Serbian_Latin_Serbia,
			/** 1051 */
			Slovak_Slovakia,
			/** 1060 */
			Slovenian_Slovenia,
			/** 3082 */
			Spanish_Spain,
			/** 1053 */
			Swedish_Sweden,
			/** 1054 */
			Thai_Thailand,
			/** 1055 */
			Turkish_Turkey,
			/** 1058 */
			Ukrainian_Ukraine,
			/** 1066 */
			Vietnamese_Vietnam
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
//{'JsForm':['Information','Masking settings','Notifications','Personal quick replies','Real Time Translation Settings','Self service settings','Skill based routing settings','Supervisor settings'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true,'Version':'2.12.31','JsFormVersion':'v2'}