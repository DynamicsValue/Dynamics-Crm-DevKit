﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace FormCompetitor {
		interface Header extends DevKit.Controls.IHeader {
			/** Type the amount of revenue reported in the competitor's annual report or other source. */
			ReportedRevenue: DevKit.Controls.Money;
			/** Type the stock exchange symbol for the competitor to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money. */
			TickerSymbol: DevKit.Controls.String;
		}
		interface tab_COMPETITOR_Sections {
			analysis: DevKit.Controls.Section;
			Competitor_Information: DevKit.Controls.Section;
			notes: DevKit.Controls.Section;
		}
		interface tab_opportunities_Sections {
			OpportunitiesChart: DevKit.Controls.Section;
			Opportunity: DevKit.Controls.Section;
		}
		interface tab_COMPETITOR extends DevKit.Controls.ITab {
			Section: tab_COMPETITOR_Sections;
		}
		interface tab_opportunities extends DevKit.Controls.ITab {
			Section: tab_opportunities_Sections;
		}
		interface Tabs {
			COMPETITOR: tab_COMPETITOR;
			opportunities: tab_opportunities;
		}
		interface Body {
			Tab: Tabs;
			/** Shows the complete primary address. */
			Address1_Composite: DevKit.Controls.String;
			/** Type the company or business name used to identify the competitor in data views and related records. */
			Name: DevKit.Controls.String;
			notescontrol: DevKit.Controls.Note;
			/** Type notes or other information about the competitor's strengths, such as top-selling products and targeted industries or markets. */
			Strengths: DevKit.Controls.String;
			/** Choose the local currency for the record to make sure budgets are reported in the correct currency. */
			TransactionCurrencyId: DevKit.Controls.Lookup;
			/** Type notes or other information about the competitor's weaknesses or areas in which your organization outperforms the competitor. */
			Weaknesses: DevKit.Controls.String;
			/** Type the website URL for the competitor. */
			WebSiteUrl: DevKit.Controls.String;
		}
		interface Navigation {
			navAsyncOperations: DevKit.Controls.NavigationItem,
			navConnections: DevKit.Controls.NavigationItem,
			navOpportunities: DevKit.Controls.NavigationItem,
			navProcessSessions: DevKit.Controls.NavigationItem
		}
		interface Grid {
			OpportunityCurrentFiscalYear: DevKit.Controls.Grid;
			ChartTest: DevKit.Controls.Grid;
		}
	}
	class FormCompetitor extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Competitor
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Competitor */
		Body: DevKit.FormCompetitor.Body;
		/** The Header section of form Competitor */
		Header: DevKit.FormCompetitor.Header;
		/** The Navigation of form Competitor */
		Navigation: DevKit.FormCompetitor.Navigation;
		/** The Grid of form Competitor */
		Grid: DevKit.FormCompetitor.Grid;
	}
	namespace FormCompetitor_Information {
		interface tab_analysis_Sections {
			analysis: DevKit.Controls.Section;
		}
		interface tab_general_Sections {
			address: DevKit.Controls.Section;
			competitor_information: DevKit.Controls.Section;
		}
		interface tab_notes_Sections {
			notes: DevKit.Controls.Section;
		}
		interface tab_analysis extends DevKit.Controls.ITab {
			Section: tab_analysis_Sections;
		}
		interface tab_general extends DevKit.Controls.ITab {
			Section: tab_general_Sections;
		}
		interface tab_notes extends DevKit.Controls.ITab {
			Section: tab_notes_Sections;
		}
		interface Tabs {
			analysis: tab_analysis;
			general: tab_general;
			notes: tab_notes;
		}
		interface Body {
			Tab: Tabs;
			/** Type the city for the primary address. */
			Address1_City: DevKit.Controls.String;
			/** Type the country or region for the primary address. */
			Address1_Country: DevKit.Controls.String;
			/** Type the first line of the primary address. */
			Address1_Line1: DevKit.Controls.String;
			/** Type the second line of the primary address. */
			Address1_Line2: DevKit.Controls.String;
			/** Type the third line of the primary address. */
			Address1_Line3: DevKit.Controls.String;
			/** Type the ZIP Code or postal code for the primary address. */
			Address1_PostalCode: DevKit.Controls.String;
			/** Type the state or province of the primary address. */
			Address1_StateOrProvince: DevKit.Controls.String;
			/** Type the competitor's primary product, service, or specialty. */
			KeyProduct: DevKit.Controls.String;
			/** Type the company or business name used to identify the competitor in data views and related records. */
			Name: DevKit.Controls.String;
			notescontrol: DevKit.Controls.Note;
			/** Type notes or other information about the competitive opportunities or selling points you can make. */
			Opportunities: DevKit.Controls.String;
			/** Type notes or other information about the competitor's business, such as location, revenue, or distribution channel. */
			Overview: DevKit.Controls.String;
			/** Type the amount of revenue reported in the competitor's annual report or other source. */
			ReportedRevenue: DevKit.Controls.Money;
			/** Type the stock exchange at which the competitor is listed to track their stock and financial performance of the company. */
			StockExchange: DevKit.Controls.String;
			/** Type notes or other information about the competitor's strengths, such as top-selling products and targeted industries or markets. */
			Strengths: DevKit.Controls.String;
			/** Type notes or other information about the competitor's threats to your organization when you sell to the same prospect or customer. */
			Threats: DevKit.Controls.String;
			/** Choose the local currency for the record to make sure budgets are reported in the correct currency. */
			TransactionCurrencyId: DevKit.Controls.Lookup;
			/** Type notes or other information about the competitor's weaknesses or areas in which your organization outperforms the competitor. */
			Weaknesses: DevKit.Controls.String;
			/** Type the website URL for the competitor. */
			WebSiteUrl: DevKit.Controls.String;
		}
	}
	class FormCompetitor_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form Competitor_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form Competitor_Information */
		Body: DevKit.FormCompetitor_Information.Body;
	}
	class CompetitorApi {
		/**
		* DynamicsCrm.DevKit CompetitorApi
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
		/** Unique identifier for address 1. */
		Address1_AddressId: DevKit.WebApi.GuidValue;
		/** Select the primary address type. */
		Address1_AddressTypeCode: DevKit.WebApi.OptionSetValue;
		/** Type the city for the primary address. */
		Address1_City: DevKit.WebApi.StringValue;
		/** Shows the complete primary address. */
		Address1_Composite: DevKit.WebApi.StringValueReadonly;
		/** Type the country or region for the primary address. */
		Address1_Country: DevKit.WebApi.StringValue;
		/** Type the county for the primary address. */
		Address1_County: DevKit.WebApi.StringValue;
		/** Type the fax number associated with the primary address. */
		Address1_Fax: DevKit.WebApi.StringValue;
		/** Type the latitude value for the primary address for use in mapping and other applications. */
		Address1_Latitude: DevKit.WebApi.DoubleValue;
		/** Type the first line of the primary address. */
		Address1_Line1: DevKit.WebApi.StringValue;
		/** Type the second line of the primary address. */
		Address1_Line2: DevKit.WebApi.StringValue;
		/** Type the third line of the primary address. */
		Address1_Line3: DevKit.WebApi.StringValue;
		/** Type the longitude value for the primary address for use in mapping and other applications. */
		Address1_Longitude: DevKit.WebApi.DoubleValue;
		/** Type a descriptive name for the primary address, such as Corporate Headquarters. */
		Address1_Name: DevKit.WebApi.StringValue;
		/** Type the ZIP Code or postal code for the primary address. */
		Address1_PostalCode: DevKit.WebApi.StringValue;
		/** Type the post office box number of the primary address. */
		Address1_PostOfficeBox: DevKit.WebApi.StringValue;
		/** Select a shipping method for deliveries sent to this address. */
		Address1_ShippingMethodCode: DevKit.WebApi.OptionSetValue;
		/** Type the state or province of the primary address. */
		Address1_StateOrProvince: DevKit.WebApi.StringValue;
		/** Type the main phone number associated with the primary address. */
		Address1_Telephone1: DevKit.WebApi.StringValue;
		/** Type a second phone number associated with the primary address. */
		Address1_Telephone2: DevKit.WebApi.StringValue;
		/** Type a third phone number associated with the primary address. */
		Address1_Telephone3: DevKit.WebApi.StringValue;
		/** Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS. */
		Address1_UPSZone: DevKit.WebApi.StringValue;
		/** Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address. */
		Address1_UTCOffset: DevKit.WebApi.IntegerValue;
		/** Unique identifier for address 2. */
		Address2_AddressId: DevKit.WebApi.GuidValue;
		/** Select the secondary address type. */
		Address2_AddressTypeCode: DevKit.WebApi.OptionSetValue;
		/** Type the city for the secondary address. */
		Address2_City: DevKit.WebApi.StringValue;
		/** Shows the complete secondary address. */
		Address2_Composite: DevKit.WebApi.StringValueReadonly;
		/** Type the country or region for the secondary address. */
		Address2_Country: DevKit.WebApi.StringValue;
		/** Type the county for the secondary address. */
		Address2_County: DevKit.WebApi.StringValue;
		/** Type the fax number associated with the secondary address. */
		Address2_Fax: DevKit.WebApi.StringValue;
		/** Type the latitude value for the secondary address for use in mapping and other applications. */
		Address2_Latitude: DevKit.WebApi.DoubleValue;
		/** Type the first line of the secondary address. */
		Address2_Line1: DevKit.WebApi.StringValue;
		/** Type the second line of the secondary address. */
		Address2_Line2: DevKit.WebApi.StringValue;
		/** Type the third line of the secondary address. */
		Address2_Line3: DevKit.WebApi.StringValue;
		/** Type the longitude value for the secondary address for use in mapping and other applications. */
		Address2_Longitude: DevKit.WebApi.DoubleValue;
		/** Type a descriptive name for the secondary address, such as Corporate Headquarters. */
		Address2_Name: DevKit.WebApi.StringValue;
		/** Type the ZIP Code or postal code for the secondary address. */
		Address2_PostalCode: DevKit.WebApi.StringValue;
		/** Type the post office box number of the secondary address. */
		Address2_PostOfficeBox: DevKit.WebApi.StringValue;
		/** Select a shipping method for deliveries sent to this address. */
		Address2_ShippingMethodCode: DevKit.WebApi.OptionSetValue;
		/** Type the state or province of the secondary address. */
		Address2_StateOrProvince: DevKit.WebApi.StringValue;
		/** Type the main phone number associated with the secondary address. */
		Address2_Telephone1: DevKit.WebApi.StringValue;
		/** Type a second phone number associated with the secondary address. */
		Address2_Telephone2: DevKit.WebApi.StringValue;
		/** Type a third phone number associated with the secondary address. */
		Address2_Telephone3: DevKit.WebApi.StringValue;
		/** Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly , if shipped by UPS. */
		Address2_UPSZone: DevKit.WebApi.StringValue;
		/** Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address. */
		Address2_UTCOffset: DevKit.WebApi.IntegerValue;
		/** Unique identifier of the competitor. */
		CompetitorId: DevKit.WebApi.GuidValue;
		/** Shows who created the record. */
		CreatedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was created. */
		CreatedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Shows who created the record on behalf of another user. */
		CreatedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Shows the default image for the record. */
		EntityImage: DevKit.WebApi.StringValue;
		EntityImage_Timestamp: DevKit.WebApi.BigIntValueReadonly;
		EntityImage_URL: DevKit.WebApi.StringValueReadonly;
		EntityImageId: DevKit.WebApi.GuidValueReadonly;
		/** Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency. */
		ExchangeRate: DevKit.WebApi.DecimalValueReadonly;
		/** Sequence number of the import that created this record. */
		ImportSequenceNumber: DevKit.WebApi.IntegerValue;
		/** Type the competitor's primary product, service, or specialty. */
		KeyProduct: DevKit.WebApi.StringValue;
		/** Shows who last updated the record. */
		ModifiedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was modified. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Shows who last updated the record on behalf of another user. */
		ModifiedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** Type the company or business name used to identify the competitor in data views and related records. */
		Name: DevKit.WebApi.StringValue;
		/** Type notes or other information about the competitive opportunities or selling points you can make. */
		Opportunities: DevKit.WebApi.StringValue;
		/** Unique identifier for the organization */
		OrganizationId: DevKit.WebApi.LookupValueReadonly;
		/** Date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Type notes or other information about the competitor's business, such as location, revenue, or distribution channel. */
		Overview: DevKit.WebApi.StringValue;
		/** Contains the id of the process associated with the entity. */
		ProcessId: DevKit.WebApi.GuidValue;
		/** Type the URL for the website used to obtain reference information about the competitor. */
		ReferenceInfoUrl: DevKit.WebApi.StringValue;
		/** Type the amount of revenue reported in the competitor's annual report or other source. */
		ReportedRevenue: DevKit.WebApi.MoneyValue;
		/** Value of the Reported Revenue in base currency. */
		ReportedRevenue_Base: DevKit.WebApi.MoneyValueReadonly;
		/** Type the quarter number during which the competitor's reported revenue was recorded or announced for use in reporting and analysis. */
		ReportingQuarter: DevKit.WebApi.IntegerValue;
		/** Type the fiscal year during which the competitor's reported revenue was announced for use in reporting and analysis. */
		ReportingYear: DevKit.WebApi.IntegerValue;
		/** Contains the id of the stage where the entity is located. */
		StageId: DevKit.WebApi.GuidValue;
		/** Type the stock exchange at which the competitor is listed to track their stock and financial performance of the company. */
		StockExchange: DevKit.WebApi.StringValue;
		/** Type notes or other information about the competitor's strengths, such as top-selling products and targeted industries or markets. */
		Strengths: DevKit.WebApi.StringValue;
		/** Type notes or other information about the competitor's threats to your organization when you sell to the same prospect or customer. */
		Threats: DevKit.WebApi.StringValue;
		/** Type the stock exchange symbol for the competitor to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money. */
		TickerSymbol: DevKit.WebApi.StringValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Choose the local currency for the record to make sure budgets are reported in the correct currency. */
		TransactionCurrencyId: DevKit.WebApi.LookupValue;
		/** A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur. */
		TraversedPath: DevKit.WebApi.StringValue;
		/** Time zone code that was in use when the record was created. */
		UTCConversionTimeZoneCode: DevKit.WebApi.IntegerValue;
		/** Version Number */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
		/** Type notes or other information about the competitor's weaknesses or areas in which your organization outperforms the competitor. */
		Weaknesses: DevKit.WebApi.StringValue;
		/** Type the website URL for the competitor. */
		WebSiteUrl: DevKit.WebApi.StringValue;
		/** Type the percentage of your organization's lost opportunities that are won by the competitor to identify your strongest competitors. */
		WinPercentage: DevKit.WebApi.DoubleValue;
		/** Type the phonetic spelling of the competitor's name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications. */
		YomiName: DevKit.WebApi.StringValue;
	}
}
declare namespace OptionSet {
	namespace Competitor {
		enum Address1_AddressTypeCode {
			/** 1 */
			Default_Value
		}
		enum Address1_ShippingMethodCode {
			/** 1 */
			Default_Value
		}
		enum Address2_AddressTypeCode {
			/** 1 */
			Default_Value
		}
		enum Address2_ShippingMethodCode {
			/** 1 */
			Default_Value
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
//{'JsForm':['Competitor','Information'],'JsWebApi':true,'IsDebugForm':true,'IsDebugWebApi':true,'Version':'2.12.31','JsFormVersion':'v2'}