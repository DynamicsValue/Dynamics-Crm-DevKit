﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace Formadobe_agreementmappingtemplate_Information {
		interface Header {
			adobe_setasdefault: DevKit.Form.Controls.ControlBoolean;
			/** Owner Id */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
		interface tab__4052F79C_C150_4DE2_8BC9_0A7745401436_Sections {
			_4052F79C_C150_4DE2_8BC9_0A7745401436_SECTION_2: DevKit.Form.Controls.ControlSection;
			_4052F79C_C150_4DE2_8BC9_0A7745401436_SECTION_3: DevKit.Form.Controls.ControlSection;
		}
		interface tab_tab_2_Sections {
			_4052F79C_C150_4DE2_8BC9_0A7745401436_SECTION_4: DevKit.Form.Controls.ControlSection;
			_4052F79C_C150_4DE2_8BC9_0A7745401436_SECTION_6: DevKit.Form.Controls.ControlSection;
			_4052F79C_C150_4DE2_8BC9_0A7745401436_SECTION_5: DevKit.Form.Controls.ControlSection;
		}
		interface tab__4052F79C_C150_4DE2_8BC9_0A7745401436 extends DevKit.Form.Controls.IControlTab {
			Section: tab__4052F79C_C150_4DE2_8BC9_0A7745401436_Sections;
		}
		interface tab_tab_2 extends DevKit.Form.Controls.IControlTab {
			Section: tab_tab_2_Sections;
		}
		interface Tabs {
			_4052F79C_C150_4DE2_8BC9_0A7745401436: tab__4052F79C_C150_4DE2_8BC9_0A7745401436;
			tab_2: tab_tab_2;
		}
		interface Body {
			Tab: Tabs;
			WebResource_EntitiesOptionSet: DevKit.Form.Controls.ControlWebResource;
			WebResource_AddDataMap: DevKit.Form.Controls.ControlWebResource;
			DataMappingsSubgrid: DevKit.Form.Controls.ControlGrid;
			WebResource_datamapattachment: DevKit.Form.Controls.ControlWebResource;
			DataMappingAttachments: DevKit.Form.Controls.ControlGrid;
			WebResource_DataMapReverse: DevKit.Form.Controls.ControlWebResource;
			AdobetoCRMMappingsubgrid: DevKit.Form.Controls.ControlGrid;
			adobe_AgreementField: DevKit.Form.Controls.ControlString;
			/** The name of the custom entity. */
			adobe_name: DevKit.Form.Controls.ControlString;
			adobe_SelectedAttribute: DevKit.Form.Controls.ControlString;
			adobe_SelectedEntity: DevKit.Form.Controls.ControlString;
			adobe_selectedentitylogical: DevKit.Form.Controls.ControlString;
			adobe_setasdefault: DevKit.Form.Controls.ControlBoolean;
		}
		interface Navigation {
			nav_adobe_adobe_agreementmapping_adobe_data: DevKit.Form.Controls.ControlNavigationItem,
			nav_adobe_adobe_agreementmappingtemplate_adobe_data: DevKit.Form.Controls.ControlNavigationItem,
			navAudit: DevKit.Form.Controls.ControlNavigationItem,
			nav_adobe_adobe_agreementmappingtemplate_adobe_agre: DevKit.Form.Controls.ControlNavigationItem,
			nav_adobe_adobe_mappingtemplate_adobe_mappattachmen: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class Formadobe_agreementmappingtemplate_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form adobe_agreementmappingtemplate_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form adobe_agreementmappingtemplate_Information */
		Body: LuckyMokey.Formadobe_agreementmappingtemplate_Information.Body;
		/** The Header section of form adobe_agreementmappingtemplate_Information */
		Header: LuckyMokey.Formadobe_agreementmappingtemplate_Information.Header;
		/** The Navigation of form adobe_agreementmappingtemplate_Information */
		Navigation: LuckyMokey.Formadobe_agreementmappingtemplate_Information.Navigation;
	}
}
declare namespace OptionSet {
	namespace adobe_agreementmappingtemplate {
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