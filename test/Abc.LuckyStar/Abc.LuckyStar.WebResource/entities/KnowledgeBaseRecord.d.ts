﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyStar {
	namespace FormKnowledge_Base_Articles {
		interface Header {
			/** Shows the unique ID of the linked knowledge base (KB) article. */
			UniqueId: DevKit.Form.Controls.ControlString;
		}
		interface Tabs {
		}
		interface Body {
			notescontrol: DevKit.Form.Controls.ControlNote;
			/** Shows the internal Parature service desk URL of the knowledge base records. */
			PrivateUrl: DevKit.Form.Controls.ControlString;
			/** Shows the public Parature portal URL of the knowledge base records. */
			PublicUrl: DevKit.Form.Controls.ControlString;
			/** Shows the title of the knowledge base (KB) Record. */
			Title: DevKit.Form.Controls.ControlString;
			/** Shows the unique ID of the linked knowledge base (KB) article. */
			UniqueId: DevKit.Form.Controls.ControlString;
		}
	}
	class FormKnowledge_Base_Articles extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form Knowledge_Base_Articles
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form Knowledge_Base_Articles */
		Body: LuckyStar.FormKnowledge_Base_Articles.Body;
		/** The Header section of form Knowledge_Base_Articles */
		Header: LuckyStar.FormKnowledge_Base_Articles.Header;
	}
	class KnowledgeBaseRecordApi {
		/**
		* DynamicsCrm.DevKit KnowledgeBaseRecordApi
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
		/** Exchange rate for the currency associated with the knowledge base record with respect to the base currency. */
		ExchangeRate: DevKit.WebApi.DecimalValueReadonly;
		/** This field will be used to store the Unique ID of the associated Knowledge Base records */
		KnowledgeBaseRecordId: DevKit.WebApi.GuidValue;
		/** Unique identifier of the user who modified the record. */
		ModifiedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was modified. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Unique identifier of the delegate user who modified the record. */
		ModifiedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for the organization */
		OrganizationId: DevKit.WebApi.LookupValueReadonly;
		/** Shows the internal Parature service desk URL of the knowledge base records. */
		PrivateUrl: DevKit.WebApi.StringValue;
		/** Shows the public Parature portal URL of the knowledge base records. */
		PublicUrl: DevKit.WebApi.StringValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Shows the title of the knowledge base (KB) Record. */
		Title: DevKit.WebApi.StringValue;
		/** Exchange rate for the currency associated with the Knowledge Base Record with respect to the base currency. */
		TransactionCurrencyId: DevKit.WebApi.LookupValue;
		/** Shows the unique ID of the linked knowledge base (KB) article. */
		UniqueId: DevKit.WebApi.StringValue;
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
	}
}
declare namespace OptionSet {
	namespace KnowledgeBaseRecord {
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
//{'JsForm':['Knowledge Base Articles'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true}