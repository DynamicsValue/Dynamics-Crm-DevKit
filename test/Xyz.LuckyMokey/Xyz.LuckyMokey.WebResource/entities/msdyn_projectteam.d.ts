﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace Formmsdyn_projectteam_Information {
		interface tab_General_Sections {
			_DC58EBA6_D467_4B9A_AAD8_0C471EBDE29F: DevKit.Form.Controls.ControlSection;
			General_section_2: DevKit.Form.Controls.ControlSection;
		}
		interface tab_Resource_Requirement_Sections {
			RequirementSection: DevKit.Form.Controls.ControlSection;
			tab_2_section_2: DevKit.Form.Controls.ControlSection;
			tab_2_section_3: DevKit.Form.Controls.ControlSection;
		}
		interface tab_Proposed_Resources_Sections {
			tab_4_section_2: DevKit.Form.Controls.ControlSection;
		}
		interface tab_General extends DevKit.Form.Controls.IControlTab {
			Section: tab_General_Sections;
		}
		interface tab_Resource_Requirement extends DevKit.Form.Controls.IControlTab {
			Section: tab_Resource_Requirement_Sections;
		}
		interface tab_Proposed_Resources extends DevKit.Form.Controls.IControlTab {
			Section: tab_Proposed_Resources_Sections;
		}
		interface Tabs {
			General: tab_General;
			Resource_Requirement: tab_Resource_Requirement;
			Proposed_Resources: tab_Proposed_Resources;
		}
		interface Body {
			Tab: Tabs;
			IFRAME_ProposalScheduleBoard: DevKit.Form.Controls.ControlIFrame;
			/** Select whether the team member is billable */
			msdyn_BillingType: DevKit.Form.Controls.ControlOptionSet;
			/** Shows the resource. */
			msdyn_bookableresourceid: DevKit.Form.Controls.ControlLookup;
			/** Enter the resource team membership start date. */
			msdyn_From: DevKit.Form.Controls.ControlDate;
			/** Type the name of the custom entity. */
			msdyn_name: DevKit.Form.Controls.ControlString;
			/** The organizational unit of the resource performing the work. */
			msdyn_organizationalunit: DevKit.Form.Controls.ControlLookup;
			/** Select the project that this team members are part of. */
			msdyn_project: DevKit.Form.Controls.ControlLookup;
			/** Select whether the team member can approve time and expenses. */
			msdyn_ProjectApprover: DevKit.Form.Controls.ControlBoolean;
			/** Select the role this team member is playing in this team. */
			msdyn_resourcecategory: DevKit.Form.Controls.ControlLookup;
			/** Unique identifier for Resource Requirement associated with Project Team Member. */
			msdyn_resourcerequirementid: DevKit.Form.Controls.ControlLookup;
			Requirement_General: DevKit.Form.Controls.ControlQuickView;
			ProjectTeam_Requirement_Competencies: DevKit.Form.Controls.ControlQuickView;
			ProjectTeam_Requirement_Others: DevKit.Form.Controls.ControlQuickView;
			/** Enter a description of the role for this team member. */
			msdyn_RoleDescription: DevKit.Form.Controls.ControlString;
			/** Enter the end date of the resource membership in a team. */
			msdyn_To: DevKit.Form.Controls.ControlDate;
			/** Owner Id */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
		interface Navigation {
			nav_msdyn_msdyn_projectteam_bookableresourcebooking_projectteamid: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_msdyn_projectteam_bookableresourcebookingheader_projectteamid: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class Formmsdyn_projectteam_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form msdyn_projectteam_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form msdyn_projectteam_Information */
		Body: LuckyMokey.Formmsdyn_projectteam_Information.Body;
		/** The Navigation of form msdyn_projectteam_Information */
		Navigation: LuckyMokey.Formmsdyn_projectteam_Information.Navigation;
	}
}
declare namespace OptionSet {
	namespace msdyn_projectteam {
		enum msdyn_allocationmethod {
			/** 192350000 */
			None,
			/** 192350001 */
			Full_Capacity,
			/** 192350004 */
			Percentage_Capacity,
			/** 192350003 */
			By_Hours_Distribute_evenly,
			/** 192350005 */
			By_Hours_Front_load
		}
		enum msdyn_BillingType {
			/** 192350000 */
			Non_Chargeable,
			/** 192350001 */
			Chargeable,
			/** 192350002 */
			Complimentary,
			/** 192350003 */
			Not_Available
		}
		enum msdyn_MembershipStatus {
			/** 1 */
			Requested,
			/** 2 */
			Assigned,
			/** 3 */
			Declined
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