﻿//@ts-check
///<reference path="DevKit.d.ts" />
declare namespace LuckyMokey {
	namespace FormContact_AI_for_Sales {
		interface Header {
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
		interface tab_SUMMARY_TAB_Sections {
			CONTACT_INFORMATION: DevKit.Form.Controls.ControlSection;
			MapSection: DevKit.Form.Controls.ControlSection;
			SOCIAL_PANE_TAB: DevKit.Form.Controls.ControlSection;
			TalkingPoints_section: DevKit.Form.Controls.ControlSection;
			Summary_section_6: DevKit.Form.Controls.ControlSection;
			CUSTOMER_DETAILS_TAB: DevKit.Form.Controls.ControlSection;
		}
		interface tab_DETAILS_TAB_Sections {
			PERSONAL_INFORMATION: DevKit.Form.Controls.ControlSection;
			PERSONAL_NOTES_SECTION: DevKit.Form.Controls.ControlSection;
			marketing_information: DevKit.Form.Controls.ControlSection;
			CONTACT_PREFERENCES: DevKit.Form.Controls.ControlSection;
			billing_information: DevKit.Form.Controls.ControlSection;
			shipping_information: DevKit.Form.Controls.ControlSection;
		}
		interface tab_SUMMARY_TAB extends DevKit.Form.Controls.IControlTab {
			Section: tab_SUMMARY_TAB_Sections;
		}
		interface tab_DETAILS_TAB extends DevKit.Form.Controls.IControlTab {
			Section: tab_DETAILS_TAB_Sections;
		}
		interface Tabs {
			SUMMARY_TAB: tab_SUMMARY_TAB;
			DETAILS_TAB: tab_DETAILS_TAB;
		}
		interface Body {
			Tab: Tabs;
			mapcontrol: DevKit.Form.Controls.ControlMap;
			notescontrol: DevKit.Form.Controls.ControlNote;
			TalkingPoints: DevKit.Form.Controls.ControlActionCards;
			ActionCards: DevKit.Form.Controls.ControlActionCards;
			contactopportunitiesgrid: DevKit.Form.Controls.ControlGrid;
			/** Shows the complete primary address. */
			Address1_Composite: DevKit.Form.Controls.ControlString;
			/** Select the freight terms for the primary address to make sure shipping orders are processed correctly. */
			Address1_FreightTermsCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select a shipping method for deliveries sent to this address. */
			Address1_ShippingMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications. */
			Anniversary: DevKit.Form.Controls.ControlDate;
			/** Enter the contact's birthday for use in customer gift programs or other communications. */
			BirthDate: DevKit.Form.Controls.ControlDate;
			/** Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer. */
			CreditLimit: DevKit.Form.Controls.ControlMoney;
			/** Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues. */
			CreditOnHold: DevKit.Form.Controls.ControlBoolean;
			/** Type additional information to describe the contact, such as an excerpt from the company's website. */
			Description: DevKit.Form.Controls.ControlString;
			/** Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email. */
			DoNotBulkEMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email. */
			DoNotEMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns. */
			DoNotFax: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns. */
			DoNotPhone: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns. */
			DoNotPostalMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives. */
			DoNotSendMM: DevKit.Form.Controls.ControlBoolean;
			/** Type the primary email address for the contact. */
			EMailAddress1: DevKit.Form.Controls.ControlString;
			/** Select the marital status of the contact for reference in follow-up phone calls and other communications. */
			FamilyStatusCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the fax number for the contact. */
			Fax: DevKit.Form.Controls.ControlString;
			/** Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact. */
			FollowEmail: DevKit.Form.Controls.ControlBoolean;
			/** Combines and shows the contact's first and last names so that the full name can be displayed in views and reports. */
			FullName: DevKit.Form.Controls.ControlString;
			/** Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			GenderCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			JobTitle: DevKit.Form.Controls.ControlString;
			/** Shows the date when the contact was last included in a marketing campaign or quick campaign. */
			LastUsedInCampaign: DevKit.Form.Controls.ControlDate;
			/** Type the mobile phone number for the contact. */
			MobilePhone: DevKit.Form.Controls.ControlString;
			/** Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics. */
			OriginatingLeadId: DevKit.Form.Controls.ControlLookup;
			/** Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities. */
			ParentCustomerId: DevKit.Form.Controls.ControlLookup;
			/** Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities. */
			ParentCustomerId_1: DevKit.Form.Controls.ControlLookup;
			contactquickform: DevKit.Form.Controls.ControlQuickView;
			/** Select the payment terms to indicate when the customer needs to pay the total amount. */
			PaymentTermsCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode_1: DevKit.Form.Controls.ControlOptionSet;
			/** Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact. */
			SpousesName: DevKit.Form.Controls.ControlString;
			/** Type the main phone number for this contact. */
			Telephone1: DevKit.Form.Controls.ControlString;
			/** Choose the local currency for the record to make sure budgets are reported in the correct currency. */
			TransactionCurrencyId: DevKit.Form.Controls.ControlLookup;
		}
		interface Navigation {
			navInvoices: DevKit.Form.Controls.ControlNavigationItem,
			navOrders: DevKit.Form.Controls.ControlNavigationItem,
			navQuotes: DevKit.Form.Controls.ControlNavigationItem,
			navAddresses: DevKit.Form.Controls.ControlNavigationItem,
			navSubConts: DevKit.Form.Controls.ControlNavigationItem,
			navRelationships: DevKit.Form.Controls.ControlNavigationItem,
			navAsyncOperations: DevKit.Form.Controls.ControlNavigationItem,
			navProcessSessions: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class FormContact_AI_for_Sales extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form Contact_AI_for_Sales
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form Contact_AI_for_Sales */
		Body: LuckyMokey.FormContact_AI_for_Sales.Body;
		/** The Header section of form Contact_AI_for_Sales */
		Header: LuckyMokey.FormContact_AI_for_Sales.Header;
		/** The Navigation of form Contact_AI_for_Sales */
		Navigation: LuckyMokey.FormContact_AI_for_Sales.Navigation;
	}
	namespace FormContact {
		interface Header {
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
		interface tab_SUMMARY_TAB_Sections {
			CONTACT_INFORMATION: DevKit.Form.Controls.ControlSection;
			MapSection: DevKit.Form.Controls.ControlSection;
			BusinessCard: DevKit.Form.Controls.ControlSection;
			SOCIAL_PANE_TAB: DevKit.Form.Controls.ControlSection;
			TalkingPoints_section: DevKit.Form.Controls.ControlSection;
			Summary_section_6: DevKit.Form.Controls.ControlSection;
			CUSTOMER_DETAILS_TAB: DevKit.Form.Controls.ControlSection;
		}
		interface tab_DETAILS_TAB_Sections {
			PERSONAL_INFORMATION: DevKit.Form.Controls.ControlSection;
			PERSONAL_NOTES_SECTION: DevKit.Form.Controls.ControlSection;
			marketing_information: DevKit.Form.Controls.ControlSection;
			CONTACT_PREFERENCES: DevKit.Form.Controls.ControlSection;
			billing_information: DevKit.Form.Controls.ControlSection;
			shipping_information: DevKit.Form.Controls.ControlSection;
		}
		interface tab_urstab_Sections {
			urstab_section_general: DevKit.Form.Controls.ControlSection;
			tab_3_section_2: DevKit.Form.Controls.ControlSection;
			tab_3_section_3: DevKit.Form.Controls.ControlSection;
		}
		interface tab_documents_sharepoint_Sections {
			documents_sharepoint_section: DevKit.Form.Controls.ControlSection;
		}
		interface tab_SUMMARY_TAB extends DevKit.Form.Controls.IControlTab {
			Section: tab_SUMMARY_TAB_Sections;
		}
		interface tab_DETAILS_TAB extends DevKit.Form.Controls.IControlTab {
			Section: tab_DETAILS_TAB_Sections;
		}
		interface tab_urstab extends DevKit.Form.Controls.IControlTab {
			Section: tab_urstab_Sections;
		}
		interface tab_documents_sharepoint extends DevKit.Form.Controls.IControlTab {
			Section: tab_documents_sharepoint_Sections;
		}
		interface Tabs {
			SUMMARY_TAB: tab_SUMMARY_TAB;
			DETAILS_TAB: tab_DETAILS_TAB;
			urstab: tab_urstab;
			documents_sharepoint: tab_documents_sharepoint;
		}
		interface Body {
			Tab: Tabs;
			mapcontrol: DevKit.Form.Controls.ControlMap;
			notescontrol: DevKit.Form.Controls.ControlNote;
			TalkingPoints: DevKit.Form.Controls.ControlActionCards;
			ActionCards: DevKit.Form.Controls.ControlActionCards;
			contactopportunitiesgrid: DevKit.Form.Controls.ControlGrid;
			contactcasessgrid: DevKit.Form.Controls.ControlGrid;
			subgrid_Entitlement: DevKit.Form.Controls.ControlGrid;
			DocumentsSubGrid: DevKit.Form.Controls.ControlGrid;
			/** Shows the complete primary address. */
			Address1_Composite: DevKit.Form.Controls.ControlString;
			/** Select the freight terms for the primary address to make sure shipping orders are processed correctly. */
			Address1_FreightTermsCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the latitude value for the primary address for use in mapping and other applications. */
			Address1_Latitude: DevKit.Form.Controls.ControlDouble;
			/** Type the longitude value for the primary address for use in mapping and other applications. */
			Address1_Longitude: DevKit.Form.Controls.ControlDouble;
			/** Select a shipping method for deliveries sent to this address. */
			Address1_ShippingMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications. */
			Anniversary: DevKit.Form.Controls.ControlDate;
			/** Enter the contact's birthday for use in customer gift programs or other communications. */
			BirthDate: DevKit.Form.Controls.ControlDate;
			/** Stores Image of the Business Card */
			BusinessCard: DevKit.Form.Controls.ControlString;
			/** Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer. */
			CreditLimit: DevKit.Form.Controls.ControlMoney;
			/** Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues. */
			CreditOnHold: DevKit.Form.Controls.ControlBoolean;
			/** Type additional information to describe the contact, such as an excerpt from the company's website. */
			Description: DevKit.Form.Controls.ControlString;
			/** Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email. */
			DoNotBulkEMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email. */
			DoNotEMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns. */
			DoNotFax: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns. */
			DoNotPhone: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns. */
			DoNotPostalMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives. */
			DoNotSendMM: DevKit.Form.Controls.ControlBoolean;
			/** Type the primary email address for the contact. */
			EMailAddress1: DevKit.Form.Controls.ControlString;
			/** Select the marital status of the contact for reference in follow-up phone calls and other communications. */
			FamilyStatusCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the fax number for the contact. */
			Fax: DevKit.Form.Controls.ControlString;
			/** Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact. */
			FollowEmail: DevKit.Form.Controls.ControlBoolean;
			/** Combines and shows the contact's first and last names so that the full name can be displayed in views and reports. */
			FullName: DevKit.Form.Controls.ControlString;
			/** Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			GenderCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			JobTitle: DevKit.Form.Controls.ControlString;
			/** Shows the date when the contact was last included in a marketing campaign or quick campaign. */
			LastUsedInCampaign: DevKit.Form.Controls.ControlDate;
			/** Type the mobile phone number for the contact. */
			MobilePhone: DevKit.Form.Controls.ControlString;
			msdyusd_CurrentProfile: DevKit.Form.Controls.ControlString;
			msdyusd_Facebook: DevKit.Form.Controls.ControlString;
			msdyusd_Twitter: DevKit.Form.Controls.ControlString;
			/** Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics. */
			OriginatingLeadId: DevKit.Form.Controls.ControlLookup;
			/** Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities. */
			ParentCustomerId: DevKit.Form.Controls.ControlLookup;
			/** Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities. */
			ParentCustomerId_1: DevKit.Form.Controls.ControlLookup;
			contactquickform: DevKit.Form.Controls.ControlQuickView;
			/** Select the payment terms to indicate when the customer needs to pay the total amount. */
			PaymentTermsCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode_1: DevKit.Form.Controls.ControlOptionSet;
			/** Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact. */
			SpousesName: DevKit.Form.Controls.ControlString;
			/** Type the main phone number for this contact. */
			Telephone1: DevKit.Form.Controls.ControlString;
			/** Choose the local currency for the record to make sure budgets are reported in the correct currency. */
			TransactionCurrencyId: DevKit.Form.Controls.ControlLookup;
		}
		interface Navigation {
			navAddresses: DevKit.Form.Controls.ControlNavigationItem,
			navSubConts: DevKit.Form.Controls.ControlNavigationItem,
			navRelationships: DevKit.Form.Controls.ControlNavigationItem,
			navQuotes: DevKit.Form.Controls.ControlNavigationItem,
			navOrders: DevKit.Form.Controls.ControlNavigationItem,
			navInvoices: DevKit.Form.Controls.ControlNavigationItem,
			navProcessSessions: DevKit.Form.Controls.ControlNavigationItem,
			navAsyncOperations: DevKit.Form.Controls.ControlNavigationItem,
			nav_contact_bookableresource_ContactId: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_contact_msdyn_purchaseorder_VendorSalesPerson: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_contact_msdyn_rma_RequestedByContact: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_contact_msdyn_rtv_VendorContact: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_contact_msdyn_workorder_ReportedByContact: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class FormContact extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form Contact
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form Contact */
		Body: LuckyMokey.FormContact.Body;
		/** The Header section of form Contact */
		Header: LuckyMokey.FormContact.Header;
		/** The Navigation of form Contact */
		Navigation: LuckyMokey.FormContact.Navigation;
	}
	namespace FormContact_Mobile {
		interface tab_fstab_summary_Sections {
			fstab_summary_section_contact_information: DevKit.Form.Controls.ControlSection;
		}
		interface tab_fstab_address_Sections {
			fstab_address_section_address: DevKit.Form.Controls.ControlSection;
			tab_2_section_2: DevKit.Form.Controls.ControlSection;
			tab_2_section_3: DevKit.Form.Controls.ControlSection;
		}
		interface tab_fstab_other_Sections {
			tab_4_section_1: DevKit.Form.Controls.ControlSection;
			tab_4_section_2: DevKit.Form.Controls.ControlSection;
			tab_4_section_3: DevKit.Form.Controls.ControlSection;
		}
		interface tab_fstab_sub_grids_Sections {
			fstab_sub_grids_section: DevKit.Form.Controls.ControlSection;
			tab_3_section_2: DevKit.Form.Controls.ControlSection;
			tab_3_section_3: DevKit.Form.Controls.ControlSection;
		}
		interface tab_fstab_summary extends DevKit.Form.Controls.IControlTab {
			Section: tab_fstab_summary_Sections;
		}
		interface tab_fstab_address extends DevKit.Form.Controls.IControlTab {
			Section: tab_fstab_address_Sections;
		}
		interface tab_fstab_other extends DevKit.Form.Controls.IControlTab {
			Section: tab_fstab_other_Sections;
		}
		interface tab_fstab_sub_grids extends DevKit.Form.Controls.IControlTab {
			Section: tab_fstab_sub_grids_Sections;
		}
		interface Tabs {
			fstab_summary: tab_fstab_summary;
			fstab_address: tab_fstab_address;
			fstab_other: tab_fstab_other;
			fstab_sub_grids: tab_fstab_sub_grids;
		}
		interface Body {
			Tab: Tabs;
			CONTACTS: DevKit.Form.Controls.ControlGrid;
			QUOTES: DevKit.Form.Controls.ControlGrid;
			ORDERS: DevKit.Form.Controls.ControlGrid;
			INVOICES: DevKit.Form.Controls.ControlGrid;
			notescontrol: DevKit.Form.Controls.ControlNote;
			/** Shows the complete primary address. */
			Address1_Composite: DevKit.Form.Controls.ControlString;
			/** Type the primary email address for the contact. */
			EMailAddress1: DevKit.Form.Controls.ControlString;
			/** Type the fax number for the contact. */
			Fax: DevKit.Form.Controls.ControlString;
			/** Combines and shows the contact's first and last names so that the full name can be displayed in views and reports. */
			FullName: DevKit.Form.Controls.ControlString;
			/** Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			JobTitle: DevKit.Form.Controls.ControlString;
			/** Type the mobile phone number for the contact. */
			MobilePhone: DevKit.Form.Controls.ControlString;
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Form.Controls.ControlLookup;
			/** Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities. */
			ParentCustomerId: DevKit.Form.Controls.ControlLookup;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the main phone number for this contact. */
			Telephone1: DevKit.Form.Controls.ControlString;
		}
		interface Navigation {
			navInvoices: DevKit.Form.Controls.ControlNavigationItem,
			navQuotes: DevKit.Form.Controls.ControlNavigationItem,
			navContracts: DevKit.Form.Controls.ControlNavigationItem,
			navRelationships: DevKit.Form.Controls.ControlNavigationItem,
			navAddresses: DevKit.Form.Controls.ControlNavigationItem,
			navOrders: DevKit.Form.Controls.ControlNavigationItem,
			navSubConts: DevKit.Form.Controls.ControlNavigationItem,
			navListsInSFA: DevKit.Form.Controls.ControlNavigationItem,
			navEntitlement: DevKit.Form.Controls.ControlNavigationItem,
			navCampaignsInSFA: DevKit.Form.Controls.ControlNavigationItem,
			navAsyncOperations: DevKit.Form.Controls.ControlNavigationItem,
			navProcessSessions: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_contact_msdyn_rma_RequestedByContact: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_contact_msdyn_rtv_VendorContact: DevKit.Form.Controls.ControlNavigationItem,
			nav_msdyn_contact_msdyn_workorder_ReportedByContact: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class FormContact_Mobile extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form Contact_Mobile
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form Contact_Mobile */
		Body: LuckyMokey.FormContact_Mobile.Body;
		/** The Navigation of form Contact_Mobile */
		Navigation: LuckyMokey.FormContact_Mobile.Navigation;
	}
	namespace FormContact_for_Interactive_experience {
		interface Header {
			/** Type the primary email address for the contact. */
			EMailAddress1: DevKit.Form.Controls.ControlString;
			/** Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			JobTitle: DevKit.Form.Controls.ControlString;
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Form.Controls.ControlLookup;
			/** Type the main phone number for this contact. */
			Telephone1: DevKit.Form.Controls.ControlString;
		}
		interface tab_SUMMARY_TAB_Sections {
			CONTACT_INFORMATION: DevKit.Form.Controls.ControlSection;
			Timeline: DevKit.Form.Controls.ControlSection;
		}
		interface tab_DETAILS_TAB_Sections {
			PERSONAL_INFORMATION: DevKit.Form.Controls.ControlSection;
			PERSONAL_NOTES_SECTION: DevKit.Form.Controls.ControlSection;
			marketing_information: DevKit.Form.Controls.ControlSection;
			CONTACT_PREFERENCES: DevKit.Form.Controls.ControlSection;
			billing_information: DevKit.Form.Controls.ControlSection;
			shipping_information: DevKit.Form.Controls.ControlSection;
		}
		interface tab_conflictstab_Sections {
			conflictssection: DevKit.Form.Controls.ControlSection;
		}
		interface tab_SUMMARY_TAB extends DevKit.Form.Controls.IControlTab {
			Section: tab_SUMMARY_TAB_Sections;
		}
		interface tab_DETAILS_TAB extends DevKit.Form.Controls.IControlTab {
			Section: tab_DETAILS_TAB_Sections;
		}
		interface tab_conflictstab extends DevKit.Form.Controls.IControlTab {
			Section: tab_conflictstab_Sections;
		}
		interface Tabs {
			SUMMARY_TAB: tab_SUMMARY_TAB;
			DETAILS_TAB: tab_DETAILS_TAB;
			conflictstab: tab_conflictstab;
		}
		interface Body {
			Tab: Tabs;
			notescontrol: DevKit.Form.Controls.ControlNote;
			/** Shows the complete primary address. */
			Address1_Composite: DevKit.Form.Controls.ControlString;
			/** Select the freight terms for the primary address to make sure shipping orders are processed correctly. */
			Address1_FreightTermsCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select a shipping method for deliveries sent to this address. */
			Address1_ShippingMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications. */
			Anniversary: DevKit.Form.Controls.ControlDate;
			/** Enter the contact's birthday for use in customer gift programs or other communications. */
			BirthDate: DevKit.Form.Controls.ControlDate;
			/** Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer. */
			CreditLimit: DevKit.Form.Controls.ControlMoney;
			/** Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues. */
			CreditOnHold: DevKit.Form.Controls.ControlBoolean;
			/** Type additional information to describe the contact, such as an excerpt from the company's website. */
			Description: DevKit.Form.Controls.ControlString;
			/** Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email. */
			DoNotBulkEMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email. */
			DoNotEMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns. */
			DoNotFax: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns. */
			DoNotPhone: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns. */
			DoNotPostalMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives. */
			DoNotSendMM: DevKit.Form.Controls.ControlBoolean;
			/** Type the primary email address for the contact. */
			EMailAddress1: DevKit.Form.Controls.ControlString;
			/** Type the primary email address for the contact. */
			EMailAddress1_1: DevKit.Form.Controls.ControlString;
			/** Select the marital status of the contact for reference in follow-up phone calls and other communications. */
			FamilyStatusCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the fax number for the contact. */
			Fax: DevKit.Form.Controls.ControlString;
			/** Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			FirstName: DevKit.Form.Controls.ControlString;
			/** Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the contact. */
			FollowEmail: DevKit.Form.Controls.ControlBoolean;
			/** Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			GenderCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			LastName: DevKit.Form.Controls.ControlString;
			/** Shows the date when the contact was last included in a marketing campaign or quick campaign. */
			LastUsedInCampaign: DevKit.Form.Controls.ControlDate;
			/** Type the mobile phone number for the contact. */
			MobilePhone: DevKit.Form.Controls.ControlString;
			/** Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics. */
			OriginatingLeadId: DevKit.Form.Controls.ControlLookup;
			contactquickform: DevKit.Form.Controls.ControlQuickView;
			/** Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities. */
			ParentCustomerId: DevKit.Form.Controls.ControlLookup;
			/** Select the payment terms to indicate when the customer needs to pay the total amount. */
			PaymentTermsCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode_1: DevKit.Form.Controls.ControlOptionSet;
			/** Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact. */
			SpousesName: DevKit.Form.Controls.ControlString;
			/** Choose the local currency for the record to make sure budgets are reported in the correct currency. */
			TransactionCurrencyId: DevKit.Form.Controls.ControlLookup;
		}
		interface Navigation {
			navAddresses: DevKit.Form.Controls.ControlNavigationItem,
			navSubConts: DevKit.Form.Controls.ControlNavigationItem,
			navRelationships: DevKit.Form.Controls.ControlNavigationItem,
			navCampaignsInSFA: DevKit.Form.Controls.ControlNavigationItem,
			navProcessSessions: DevKit.Form.Controls.ControlNavigationItem,
			navAsyncOperations: DevKit.Form.Controls.ControlNavigationItem,
			navContracts: DevKit.Form.Controls.ControlNavigationItem,
			navQuotes: DevKit.Form.Controls.ControlNavigationItem,
			navOrders: DevKit.Form.Controls.ControlNavigationItem,
			navInvoices: DevKit.Form.Controls.ControlNavigationItem,
			navListsInSFA: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class FormContact_for_Interactive_experience extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form Contact_for_Interactive_experience
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form Contact_for_Interactive_experience */
		Body: LuckyMokey.FormContact_for_Interactive_experience.Body;
		/** The Header section of form Contact_for_Interactive_experience */
		Header: LuckyMokey.FormContact_for_Interactive_experience.Header;
		/** The Navigation of form Contact_for_Interactive_experience */
		Navigation: LuckyMokey.FormContact_for_Interactive_experience.Navigation;
	}
	namespace FormContact_Information {
		interface Header {
			/** Type the primary email address for the contact. */
			EMailAddress1: DevKit.Form.Controls.ControlString;
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Form.Controls.ControlLookup;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode: DevKit.Form.Controls.ControlOptionSet;
		}
		interface tab_tab_recordwall_Sections {
			tab_recordwall_section_1: DevKit.Form.Controls.ControlSection;
		}
		interface tab_general_Sections {
			name: DevKit.Form.Controls.ControlSection;
			address: DevKit.Form.Controls.ControlSection;
			shipping_information: DevKit.Form.Controls.ControlSection;
			description: DevKit.Form.Controls.ControlSection;
		}
		interface tab_details_Sections {
			professional_information: DevKit.Form.Controls.ControlSection;
			personal_information: DevKit.Form.Controls.ControlSection;
		}
		interface tab_notes_and_activities_Sections {
			activities: DevKit.Form.Controls.ControlSection;
			notes: DevKit.Form.Controls.ControlSection;
		}
		interface tab_administration_Sections {
			internal_information: DevKit.Form.Controls.ControlSection;
			billing_information: DevKit.Form.Controls.ControlSection;
			contact_methods: DevKit.Form.Controls.ControlSection;
		}
		interface tab_conflictstab_Sections {
			conflictssection: DevKit.Form.Controls.ControlSection;
			marketing_information: DevKit.Form.Controls.ControlSection;
			service_preferences: DevKit.Form.Controls.ControlSection;
		}
		interface tab_tab_recordwall extends DevKit.Form.Controls.IControlTab {
			Section: tab_tab_recordwall_Sections;
		}
		interface tab_general extends DevKit.Form.Controls.IControlTab {
			Section: tab_general_Sections;
		}
		interface tab_details extends DevKit.Form.Controls.IControlTab {
			Section: tab_details_Sections;
		}
		interface tab_notes_and_activities extends DevKit.Form.Controls.IControlTab {
			Section: tab_notes_and_activities_Sections;
		}
		interface tab_administration extends DevKit.Form.Controls.IControlTab {
			Section: tab_administration_Sections;
		}
		interface tab_conflictstab extends DevKit.Form.Controls.IControlTab {
			Section: tab_conflictstab_Sections;
		}
		interface Tabs {
			tab_recordwall: tab_tab_recordwall;
			general: tab_general;
			details: tab_details;
			notes_and_activities: tab_notes_and_activities;
			administration: tab_administration;
			conflictstab: tab_conflictstab;
		}
		interface Body {
			Tab: Tabs;
			WebResource_RecordWall: DevKit.Form.Controls.ControlWebResource;
			contactactivitiesgrid: DevKit.Form.Controls.ControlGrid;
			notescontrol: DevKit.Form.Controls.ControlNote;
			/** Select the contact's role within the company or sales process, such as decision maker, employee, or influencer. */
			AccountRoleCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the primary address type. */
			Address1_AddressTypeCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the city for the primary address. */
			Address1_City: DevKit.Form.Controls.ControlString;
			/** Type the country or region for the primary address. */
			Address1_Country: DevKit.Form.Controls.ControlString;
			/** Select the freight terms for the primary address to make sure shipping orders are processed correctly. */
			Address1_FreightTermsCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the first line of the primary address. */
			Address1_Line1: DevKit.Form.Controls.ControlString;
			/** Type the second line of the primary address. */
			Address1_Line2: DevKit.Form.Controls.ControlString;
			/** Type the third line of the primary address. */
			Address1_Line3: DevKit.Form.Controls.ControlString;
			/** Type a descriptive name for the primary address, such as Corporate Headquarters. */
			Address1_Name: DevKit.Form.Controls.ControlString;
			/** Type the ZIP Code or postal code for the primary address. */
			Address1_PostalCode: DevKit.Form.Controls.ControlString;
			/** Select a shipping method for deliveries sent to this address. */
			Address1_ShippingMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the state or province of the primary address. */
			Address1_StateOrProvince: DevKit.Form.Controls.ControlString;
			/** Type the main phone number associated with the primary address. */
			Address1_Telephone1: DevKit.Form.Controls.ControlString;
			/** Enter the date of the contact's wedding or service anniversary for use in customer gift programs or other communications. */
			Anniversary: DevKit.Form.Controls.ControlDate;
			/** Type the name of the contact's assistant. */
			AssistantName: DevKit.Form.Controls.ControlString;
			/** Type the phone number for the contact's assistant. */
			AssistantPhone: DevKit.Form.Controls.ControlString;
			/** Enter the contact's birthday for use in customer gift programs or other communications. */
			BirthDate: DevKit.Form.Controls.ControlDate;
			/** Type the credit limit of the contact for reference when you address invoice and accounting issues with the customer. */
			CreditLimit: DevKit.Form.Controls.ControlMoney;
			/** Select whether the contact is on a credit hold, for reference when addressing invoice and accounting issues. */
			CreditOnHold: DevKit.Form.Controls.ControlBoolean;
			/** Choose the default price list associated with the contact to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders. */
			DefaultPriceLevelId: DevKit.Form.Controls.ControlLookup;
			/** Type the department or business unit where the contact works in the parent company or business. */
			Department: DevKit.Form.Controls.ControlString;
			/** Type additional information to describe the contact, such as an excerpt from the company's website. */
			Description: DevKit.Form.Controls.ControlString;
			/** Select whether the contact accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the contact can be added to marketing lists, but will be excluded from the email. */
			DoNotBulkEMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows direct email sent from Microsoft Dynamics 365. If Do Not Allow is selected, Microsoft Dynamics 365 will not send the email. */
			DoNotEMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows faxes. If Do Not Allow is selected, the contact will be excluded from any fax activities distributed in marketing campaigns. */
			DoNotFax: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact accepts phone calls. If Do Not Allow is selected, the contact will be excluded from any phone call activities distributed in marketing campaigns. */
			DoNotPhone: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact allows direct mail. If Do Not Allow is selected, the contact will be excluded from letter activities distributed in marketing campaigns. */
			DoNotPostalMail: DevKit.Form.Controls.ControlBoolean;
			/** Select whether the contact accepts marketing materials, such as brochures or catalogs. Contacts that opt out can be excluded from marketing initiatives. */
			DoNotSendMM: DevKit.Form.Controls.ControlBoolean;
			/** Type the primary email address for the contact. */
			EMailAddress1: DevKit.Form.Controls.ControlString;
			/** Select the marital status of the contact for reference in follow-up phone calls and other communications. */
			FamilyStatusCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the fax number for the contact. */
			Fax: DevKit.Form.Controls.ControlString;
			/** Type the contact's first name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			FirstName: DevKit.Form.Controls.ControlString;
			/** Select the contact's gender to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			GenderCode: DevKit.Form.Controls.ControlOptionSet;
			/** Type the job title of the contact to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			JobTitle: DevKit.Form.Controls.ControlString;
			/** Type the contact's last name to make sure the contact is addressed correctly in sales calls, email, and marketing campaigns. */
			LastName: DevKit.Form.Controls.ControlString;
			/** Shows the date when the contact was last included in a marketing campaign or quick campaign. */
			LastUsedInCampaign: DevKit.Form.Controls.ControlDate;
			/** Type the name of the contact's manager for use in escalating issues or other follow-up communications with the contact. */
			ManagerName: DevKit.Form.Controls.ControlString;
			/** Type the phone number for the contact's manager. */
			ManagerPhone: DevKit.Form.Controls.ControlString;
			/** Type the contact's middle name or initial to make sure the contact is addressed correctly. */
			MiddleName: DevKit.Form.Controls.ControlString;
			/** Type the mobile phone number for the contact. */
			MobilePhone: DevKit.Form.Controls.ControlString;
			/** Shows the lead that the contact was created if the contact was created by converting a lead in Microsoft Dynamics 365. This is used to relate the contact to the data on the originating lead for use in reporting and analytics. */
			OriginatingLeadId: DevKit.Form.Controls.ControlLookup;
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Form.Controls.ControlLookup;
			/** Select the parent account or parent contact for the contact to provide a quick link to additional details, such as financial information, activities, and opportunities. */
			ParentCustomerId: DevKit.Form.Controls.ControlLookup;
			/** Select the payment terms to indicate when the customer needs to pay the total amount. */
			PaymentTermsCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred day of the week for service appointments. */
			PreferredAppointmentDayCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred time of day for service appointments. */
			PreferredAppointmentTimeCode: DevKit.Form.Controls.ControlOptionSet;
			/** Select the preferred method of contact. */
			PreferredContactMethodCode: DevKit.Form.Controls.ControlOptionSet;
			/** Choose the contact's preferred service facility or equipment to make sure services are scheduled correctly for the customer. */
			PreferredEquipmentId: DevKit.Form.Controls.ControlLookup;
			/** Choose the contact's preferred service to make sure services are scheduled correctly for the customer. */
			PreferredServiceId: DevKit.Form.Controls.ControlLookup;
			/** Choose the regular or preferred customer service representative for reference when scheduling service activities for the contact. */
			PreferredSystemUserId: DevKit.Form.Controls.ControlLookup;
			/** Type the salutation of the contact to make sure the contact is addressed correctly in sales calls, email messages, and marketing campaigns. */
			Salutation: DevKit.Form.Controls.ControlString;
			/** Type the name of the contact's spouse or partner for reference during calls, events, or other communications with the contact. */
			SpousesName: DevKit.Form.Controls.ControlString;
			/** Type the main phone number for this contact. */
			Telephone1: DevKit.Form.Controls.ControlString;
			/** Type a second phone number for this contact. */
			Telephone2: DevKit.Form.Controls.ControlString;
			/** Choose the local currency for the record to make sure budgets are reported in the correct currency. */
			TransactionCurrencyId: DevKit.Form.Controls.ControlLookup;
		}
		interface Navigation {
			navAddresses: DevKit.Form.Controls.ControlNavigationItem,
			navSubConts: DevKit.Form.Controls.ControlNavigationItem,
			navActivities: DevKit.Form.Controls.ControlNavigationItem,
			navActivityHistory: DevKit.Form.Controls.ControlNavigationItem,
			navRelationships: DevKit.Form.Controls.ControlNavigationItem
		}
	}
	class FormContact_Information extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form Contact_Information
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form Contact_Information */
		Body: LuckyMokey.FormContact_Information.Body;
		/** The Header section of form Contact_Information */
		Header: LuckyMokey.FormContact_Information.Header;
		/** The Navigation of form Contact_Information */
		Navigation: LuckyMokey.FormContact_Information.Navigation;
	}
	namespace FormTimelineWallControl_Contact_Main {
		interface Header {
			/** Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user. */
			OwnerId: DevKit.Form.Controls.ControlLookup;
		}
		interface tab_SUMMARY_TAB_Sections {
			SOCIAL_PANE_TAB: DevKit.Form.Controls.ControlSection;
		}
		interface tab_SUMMARY_TAB extends DevKit.Form.Controls.IControlTab {
			Section: tab_SUMMARY_TAB_Sections;
		}
		interface Tabs {
			SUMMARY_TAB: tab_SUMMARY_TAB;
		}
		interface Body {
			Tab: Tabs;
			notescontrol: DevKit.Form.Controls.ControlNote;
		}
	}
	class FormTimelineWallControl_Contact_Main extends DevKit.Form.IForm {
		/**
		* DynamicsCrm.DevKit form TimelineWallControl_Contact_Main
		* @param executionContext the execution context
		* @param defaultWebResourceName default resource name. E.g.: "devkit_/resources/Resource"
		*/
		constructor(executionContext: any, defaultWebResourceName?: string);
		/** Utility functions/methods/objects for Dynamics 365 form */
		Utility: DevKit.Form.Utility;
		/** Provides properties and methods to use Web API to create and manage records and execute Web API actions and functions in Customer Engagement */
		WebApi: DevKit.Form.WebApi;
		/** The Body section of form TimelineWallControl_Contact_Main */
		Body: LuckyMokey.FormTimelineWallControl_Contact_Main.Body;
		/** The Header section of form TimelineWallControl_Contact_Main */
		Header: LuckyMokey.FormTimelineWallControl_Contact_Main.Header;
	}
}
declare namespace OptionSet {
	namespace Contact {
		enum AccountRoleCode {
			/** 1 */
			Decision_Maker,
			/** 2 */
			Employee,
			/** 3 */
			Influencer
		}
		enum Address1_AddressTypeCode {
			/** 1 */
			Bill_To,
			/** 2 */
			Ship_To,
			/** 3 */
			Primary,
			/** 4 */
			Other
		}
		enum Address1_FreightTermsCode {
			/** 1 */
			FOB,
			/** 2 */
			No_Charge
		}
		enum Address1_ShippingMethodCode {
			/** 1 */
			Airborne,
			/** 2 */
			DHL,
			/** 3 */
			FedEx,
			/** 4 */
			UPS,
			/** 5 */
			Postal_Mail,
			/** 6 */
			Full_Load,
			/** 7 */
			Will_Call
		}
		enum Address2_AddressTypeCode {
			/** 1 */
			Default_Value
		}
		enum Address2_FreightTermsCode {
			/** 1 */
			Default_Value
		}
		enum Address2_ShippingMethodCode {
			/** 1 */
			Default_Value
		}
		enum Address3_AddressTypeCode {
			/** 1 */
			Default_Value
		}
		enum Address3_FreightTermsCode {
			/** 1 */
			Default_Value
		}
		enum Address3_ShippingMethodCode {
			/** 1 */
			Default_Value
		}
		enum CustomerSizeCode {
			/** 1 */
			Default_Value
		}
		enum CustomerTypeCode {
			/** 1 */
			Default_Value
		}
		enum EducationCode {
			/** 1 */
			Default_Value
		}
		enum FamilyStatusCode {
			/** 1 */
			Single,
			/** 2 */
			Married,
			/** 3 */
			Divorced,
			/** 4 */
			Widowed
		}
		enum GenderCode {
			/** 1 */
			Male,
			/** 2 */
			Female
		}
		enum HasChildrenCode {
			/** 1 */
			Default_Value
		}
		enum LeadSourceCode {
			/** 1 */
			Default_Value
		}
		enum msdyn_orgchangestatus {
			/** 0 */
			No_Feedback,
			/** 1 */
			Not_at_Company,
			/** 2 */
			Ignore
		}
		enum PaymentTermsCode {
			/** 1 */
			Net_30,
			/** 2 */
			_2_10_Net_30,
			/** 3 */
			Net_45,
			/** 4 */
			Net_60
		}
		enum PreferredAppointmentDayCode {
			/** 0 */
			Sunday,
			/** 1 */
			Monday,
			/** 2 */
			Tuesday,
			/** 3 */
			Wednesday,
			/** 4 */
			Thursday,
			/** 5 */
			Friday,
			/** 6 */
			Saturday
		}
		enum PreferredAppointmentTimeCode {
			/** 1 */
			Morning,
			/** 2 */
			Afternoon,
			/** 3 */
			Evening
		}
		enum PreferredContactMethodCode {
			/** 1 */
			Any,
			/** 2 */
			Email,
			/** 3 */
			Phone,
			/** 4 */
			Fax,
			/** 5 */
			Mail
		}
		enum ShippingMethodCode {
			/** 1 */
			Default_Value
		}
		enum StateCode {
			/** 0 */
			Active,
			/** 1 */
			Inactive
		}
		enum StatusCode {
			/** 1 */
			Active,
			/** 2 */
			Inactive
		}
		enum TerritoryCode {
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
//{'JsForm':['AI for Sales','Contact','Contact - Mobile','Contact for Interactive experience','Information','TimelineWallControl - Contact - Main'],'JsWebApi':false,'IsDebugForm':true,'IsDebugWebApi':false}