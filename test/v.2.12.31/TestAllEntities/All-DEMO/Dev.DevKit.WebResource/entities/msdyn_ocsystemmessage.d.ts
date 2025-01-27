﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace Formmsdyn_ocsystemmessage_Information {
		interface tab_MessageTemplate_GeneralTab_Sections {
			_F86C374B_46E7_4B2F_9BC6_2D41E13AAFE2: DevKit.Controls.Section;
			MessageTemplate_LocalizationDataGridSection: DevKit.Controls.Section;
		}
		interface tab_MessageTemplate_GeneralTab extends DevKit.Controls.ITab {
			Section: tab_MessageTemplate_GeneralTab_Sections;
		}
		interface Tabs {
			MessageTemplate_GeneralTab: tab_MessageTemplate_GeneralTab;
		}
		interface Body {
			Tab: Tabs;
			/** Default language of the message template. */
			msdyn_defaultlanguage: DevKit.Controls.Lookup;
			/** ID of the instance this system message is related to, represented in text form. */
			msdyn_instanceid: DevKit.Controls.String;
			/** Stores the list of message receivers. */
			msdyn_messagereceiver: DevKit.Controls.OptionSet;
			/** Stores the list of event types for message template */
			msdyn_messagetemplatetrigger: DevKit.Controls.OptionSet;
			/** Text sent to the message receiver. */
			msdyn_messagetext: DevKit.Controls.String;
			/** Stores the list of event types for system messages. */
			msdyn_messagetype: DevKit.Controls.OptionSet;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
			/** List of all available channels. */
			msdyn_streamsource: DevKit.Controls.OptionSet;
		}
		interface Grid {
			MessageTemplate_LocalizationDataGrid: DevKit.Controls.Grid;
		}
	}
	class Formmsdyn_ocsystemmessage_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_ocsystemmessage_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_ocsystemmessage_Information */
		Body: DevKit.Formmsdyn_ocsystemmessage_Information.Body;
		/** The Grid of form msdyn_ocsystemmessage_Information */
		Grid: DevKit.Formmsdyn_ocsystemmessage_Information.Grid;
	}
	class msdyn_ocsystemmessageApi {
		/**
		* DynamicsCrm.DevKit msdyn_ocsystemmessageApi
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
		/** Default language of the message template. */
		msdyn_defaultlanguage: DevKit.WebApi.LookupValue;
		/** ID of the instance this system message is related to, represented in text form. */
		msdyn_instanceid: DevKit.WebApi.StringValue;
		/** Description of the message. */
		msdyn_messagedescription: DevKit.WebApi.StringValue;
		/** Stores the list of message receivers. */
		msdyn_messagereceiver: DevKit.WebApi.OptionSetValue;
		/** Stores the list of event types for message template */
		msdyn_messagetemplatetrigger: DevKit.WebApi.OptionSetValue;
		/** Text sent to the message receiver. */
		msdyn_messagetext: DevKit.WebApi.StringValue;
		/** Stores the list of event types for system messages. */
		msdyn_messagetype: DevKit.WebApi.OptionSetValue;
		/** The name of the custom entity. */
		msdyn_name: DevKit.WebApi.StringValue;
		/** Unique identifier for entity instances */
		msdyn_ocsystemmessageId: DevKit.WebApi.GuidValue;
		/** List of all available channels. */
		msdyn_streamsource: DevKit.WebApi.OptionSetValue;
		/** Stores the list of event types for system messages. */
		msdyn_systemmessageeventtype: DevKit.WebApi.OptionSetValue;
		/** Unique identifier for Chat Widget associated with System Message. */
		msdyn_widgetid: DevKit.WebApi.LookupValue;
		/** Unique identifier for the organization */
		OrganizationId: DevKit.WebApi.LookupValueReadonly;
		/** Date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Status of the System Message */
		statecode: DevKit.WebApi.OptionSetValue;
		/** Reason for the status of the System Message */
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
	namespace msdyn_ocsystemmessage {
		enum msdyn_messagereceiver {
			/** 192350000 */
			Agent,
			/** 192350001 */
			Customer
		}
		enum msdyn_messagetemplatetrigger {
			/** 1 */
			Outside_24_hour_conversation_window
		}
		enum msdyn_messagetype {
			/** 2 */
			Automated_Message,
			/** 3 */
			Message_Template
		}
		enum msdyn_streamsource {
			/** 192390000 */
			Co_browse,
			/** 192350002 */
			Custom,
			/** 192350000 */
			Entity_Records,
			/** 192330000 */
			Facebook,
			/** 192310000 */
			LINE,
			/** 192360000 */
			Live_chat,
			/** 19241000 */
			Microsoft_Teams,
			/** 192400000 */
			Screen_sharing,
			/** 192340000 */
			SMS,
			/** 192350001 */
			Twitter,
			/** 192380000 */
			Video,
			/** 192370000 */
			Voice,
			/** 192320000 */
			WeChat,
			/** 192300000 */
			WhatsApp
		}
		enum msdyn_systemmessageeventtype {
			/** 192350017 */
			Agent_assigned_to_conversation,
			/** 192350018 */
			Agent_couldnt_be_assigned_to_conversation,
			/** 192350013 */
			Agent_disconnected_from_conversation,
			/** 192350014 */
			Agent_ended_conversation,
			/** 192350000 */
			Agent_joined_conversation,
			/** 192350022 */
			Agents_message_couldnt_be_sent,
			/** 192350031 */
			Average_wait_time_for_customers_Hours,
			/** 192350032 */
			Average_wait_time_for_customers_Hours_and_minutes,
			/** 192350030 */
			Average_wait_time_for_customers_Minutes,
			/** 192350001 */
			Consult_accepted,
			/** 192350007 */
			Consult_rejected,
			/** 192350004 */
			Consult_request_failed,
			/** 192350009 */
			Consult_request_timed_out,
			/** 192350016 */
			Consult_session_ended,
			/** 192350003 */
			Consult_started,
			/** 192350037 */
			Couldnt_find_the_channel_account_in_Omnichannel,
			/** 192350020 */
			Customer_disconnected,
			/** 192350019 */
			Customer_ended_conversation,
			/** 192350024 */
			Customer_is_next_in_line,
			/** 192350043 */
			Customer_no_longer_on_hold,
			/** 192350042 */
			Customer_put_on_hold,
			/** 192350038 */
			Customers_file_couldnt_be_attached_because_its_too_big,
			/** 192350023 */
			Customers_message_couldnt_be_sent_Outside_of_operation_hours,
			/** 192350021 */
			Customers_position_in_queue,
			/** 192350035 */
			Holiday_message_to_customer,
			/** 192350041 */
			Leave_as_many_messages_as_youd_like_and_well_get_back_to_you_as_soon_as_possible_Well_save_your_chat_history_so_you_can_leave_and_come_back_anytime,
			/** 192350025 */
			Message_couldnt_be_delivered_Unsupported_message_type,
			/** 192350034 */
			Message_couldnt_be_sent_A_channel_account_cant_message_another_account_within_Omnichannel,
			/** 192350040 */
			Message_couldnt_be_sent_File_couldnt_be_attached,
			/** 192350029 */
			Message_couldnt_be_sent_Outside_allowed_timeframe,
			/** 192350044 */
			Message_or_attachment_failed_to_send_Providing_error_details_including_error_code_reason_for_failure_message_id_timestamp_and_transaction_id,
			/** 192350036 */
			Out_of_operating_hour_message_to_customer,
			/** 192350050 */
			Recording_and_transcription_paused,
			/** 192350051 */
			Recording_and_transcription_resumed,
			/** 192350049 */
			Recording_and_transcription_started,
			/** 192350052 */
			Recording_and_transcription_stopped,
			/** 192350015 */
			Session_ended,
			/** 192350046 */
			Transcription_paused,
			/** 192350047 */
			Transcription_resumed,
			/** 192350045 */
			Transcription_started,
			/** 192350048 */
			Transcription_stopped,
			/** 192350002 */
			Transfer_to_agent_accepted,
			/** 192350006 */
			Transfer_to_agent_failed,
			/** 192350008 */
			Transfer_to_agent_rejected,
			/** 192350005 */
			Transfer_to_agent_requested,
			/** 192350010 */
			Transfer_to_agent_timed_out,
			/** 192350039 */
			Transfer_to_out_of_operating_hour_queue,
			/** 192350012 */
			Transfer_to_queue_failed,
			/** 192350011 */
			Transfer_to_queue_started,
			/** 192350027 */
			Voice_call_accepted,
			/** 192350028 */
			Voice_call_declined,
			/** 192350033 */
			Voice_call_ended,
			/** 192350026 */
			Voice_call_requested
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
//{'JsForm':['Information'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true,'Version':'2.12.31','JsFormVersion':'v2'}