﻿//@ts-check
///<reference path="devkit.d.ts" />
declare namespace DevKit {
	namespace Formmsdyn_quotebookingproduct_Information {
		interface tab__79CC9DB9_6812_4613_8C6D_1A07F7AFF8B3_Sections {
			_79CC9DB9_6812_4613_8C6D_1A07F7AFF8B3_COLUMN_3_SECTION_1: DevKit.Controls.Section;
			_79CC9DB9_6812_4613_8C6D_1A07F7AFF8B3_SECTION_3: DevKit.Controls.Section;
			_CC746554_B3E2_4B34_89C7_121A8D992983: DevKit.Controls.Section;
		}
		interface tab__79CC9DB9_6812_4613_8C6D_1A07F7AFF8B3 extends DevKit.Controls.ITab {
			Section: tab__79CC9DB9_6812_4613_8C6D_1A07F7AFF8B3_Sections;
		}
		interface Tabs {
			_79CC9DB9_6812_4613_8C6D_1A07F7AFF8B3: tab__79CC9DB9_6812_4613_8C6D_1A07F7AFF8B3;
		}
		interface Body {
			Tab: Tabs;
			/** The estimated cost of this quote booking product */
			msdyn_EstimatedCost: DevKit.Controls.Money;
			/** The estimated sales amount of this quote booking product */
			msdyn_EstimatedSalesAmount: DevKit.Controls.Money;
			/** The name of the custom entity. */
			msdyn_name: DevKit.Controls.String;
			/** Unique identifier for Product/Service associated with Quote Booking Product. */
			msdyn_product: DevKit.Controls.Lookup;
			/** Shows the actual quantity of the product. */
			msdyn_quantity: DevKit.Controls.Double;
			/** Unique identifier for Quote Booking Setup associated with Quote  Booking Product. */
			msdyn_quotebookingsetup: DevKit.Controls.Lookup;
			/** The unit that determines the pricing for this product when Price List is set */
			msdyn_unit: DevKit.Controls.Lookup;
			/** Enter the amount you wish to charge the customer per unit. This field is optional. */
			msdyn_unitamount: DevKit.Controls.Money;
			/** Enter the  unit cost amount. This field is optional. */
			msdyn_unitcostamount: DevKit.Controls.Money;
			/** Owner Id */
			OwnerId: DevKit.Controls.Lookup;
		}
	}
	class Formmsdyn_quotebookingproduct_Information extends DevKit.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_quotebookingproduct_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Utility;
		/** The Body section of form msdyn_quotebookingproduct_Information */
		Body: DevKit.Formmsdyn_quotebookingproduct_Information.Body;
	}
	class msdyn_quotebookingproductApi {
		/**
		* DynamicsCrm.DevKit msdyn_quotebookingproductApi
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
		/** Exchange rate for the currency associated with the entity with respect to the base currency. */
		ExchangeRate: DevKit.WebApi.DecimalValueReadonly;
		/** Sequence number of the import that created this record. */
		ImportSequenceNumber: DevKit.WebApi.IntegerValue;
		/** Unique identifier of the user who modified the record. */
		ModifiedBy: DevKit.WebApi.LookupValueReadonly;
		/** Date and time when the record was modified. */
		ModifiedOn_UtcDateAndTime: DevKit.WebApi.UtcDateAndTimeValueReadonly;
		/** Unique identifier of the delegate user who modified the record. */
		ModifiedOnBehalfBy: DevKit.WebApi.LookupValueReadonly;
		/** The currency that will be used to charge this product */
		msdyn_currency: DevKit.WebApi.MoneyValue;
		/** Value of the Currency in base currency. */
		msdyn_currency_Base: DevKit.WebApi.MoneyValueReadonly;
		/** Customer asset related to this Product */
		msdyn_customerasset: DevKit.WebApi.LookupValue;
		/** The estimated cost of this quote booking product */
		msdyn_EstimatedCost: DevKit.WebApi.MoneyValue;
		/** Value of the EstimatedCost in base currency. */
		msdyn_estimatedcost_Base: DevKit.WebApi.MoneyValueReadonly;
		/** The estimated sales amount of this quote booking product */
		msdyn_EstimatedSalesAmount: DevKit.WebApi.MoneyValue;
		/** Value of the EstimatedSalesAmount in base currency. */
		msdyn_estimatedsalesamount_Base: DevKit.WebApi.MoneyValueReadonly;
		/** For internal use only. */
		msdyn_Internalflags: DevKit.WebApi.StringValue;
		/** Internal use only */
		msdyn_iscopied: DevKit.WebApi.BooleanValue;
		/** Shows the order of this task within the quote booking products. */
		msdyn_lineorder: DevKit.WebApi.IntegerValue;
		/** The name of the custom entity. */
		msdyn_name: DevKit.WebApi.StringValue;
		/** Optionally set Price List that will determine the pricing for this product on the Work Order */
		msdyn_pricelist: DevKit.WebApi.LookupValue;
		/** Unique identifier for Product/Service associated with Quote Booking Product. */
		msdyn_product: DevKit.WebApi.LookupValue;
		/** Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity." */
		msdyn_qtytobill: DevKit.WebApi.DoubleValue;
		/** Shows the actual quantity of the product. */
		msdyn_quantity: DevKit.WebApi.DoubleValue;
		/** Unique identifier for Quote associated with Quote Booking Product. */
		msdyn_quote: DevKit.WebApi.LookupValue;
		/** The Quote Booking Incident related to this product */
		msdyn_quotebookingincident: DevKit.WebApi.LookupValue;
		/** Unique identifier for entity instances */
		msdyn_quotebookingproductId: DevKit.WebApi.GuidValue;
		/** Unique identifier for Quote Booking Setup associated with Quote  Booking Product. */
		msdyn_quotebookingsetup: DevKit.WebApi.LookupValue;
		/** The unit that determines the pricing for this product when Price List is set */
		msdyn_unit: DevKit.WebApi.LookupValue;
		/** Enter the amount you wish to charge the customer per unit. This field is optional. */
		msdyn_unitamount: DevKit.WebApi.MoneyValue;
		/** Value of the Unit Amount in base currency. */
		msdyn_unitamount_Base: DevKit.WebApi.MoneyValueReadonly;
		/** Enter the  unit cost amount. This field is optional. */
		msdyn_unitcostamount: DevKit.WebApi.MoneyValue;
		/** Value of the Unit Cost in base currency. */
		msdyn_unitcostamount_Base: DevKit.WebApi.MoneyValueReadonly;
		/** Date and time that the record was migrated. */
		OverriddenCreatedOn_UtcDateOnly: DevKit.WebApi.UtcDateOnlyValue;
		/** Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user */
		OwnerId_systemuser: DevKit.WebApi.LookupValue;
		/** Enter the team who is assigned to manage the record. This field is updated every time the record is assigned to a different team */
		OwnerId_team: DevKit.WebApi.LookupValue;
		/** Unique identifier for the business unit that owns the record */
		OwningBusinessUnit: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for the team that owns the record. */
		OwningTeam: DevKit.WebApi.LookupValueReadonly;
		/** Unique identifier for the user that owns the record. */
		OwningUser: DevKit.WebApi.LookupValueReadonly;
		/** Status of the Quote Booking Product */
		statecode: DevKit.WebApi.OptionSetValue;
		/** Reason for the status of the Quote Booking Product */
		statuscode: DevKit.WebApi.OptionSetValue;
		/** For internal use only. */
		TimeZoneRuleVersionNumber: DevKit.WebApi.IntegerValue;
		/** Unique identifier of the currency associated with the entity. */
		TransactionCurrencyId: DevKit.WebApi.LookupValue;
		/** Time zone code that was in use when the record was created. */
		UTCConversionTimeZoneCode: DevKit.WebApi.IntegerValue;
		/** Version Number */
		VersionNumber: DevKit.WebApi.BigIntValueReadonly;
	}
}
declare namespace OptionSet {
	namespace msdyn_quotebookingproduct {
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