﻿'use strict';
/** @namespace LuckyStar */
var LuckyStar;
(function (LuckyStar) {
	'use strict';
	LuckyStar.FormSharePointSite_Information = function(executionContext, defaultWebResourceName) {
		var formContext = null;
		if (executionContext !== undefined) {
			if (executionContext.getFormContext === undefined) {
				formContext = executionContext;
			}
			else {
				formContext = executionContext.getFormContext();
			}
		}
		var form = devKit.LoadForm(formContext);
		var body = {
			AbsoluteURL: {},
			Description: {},
			IsGridPresent: {},
			IsPowerBISite: {},
			LastValidated: {},
			Name: {},
			OwnerId: {},
			ParentSite: {},
			RelativeUrl: {},
			urloption: {},
			ValidationStatus: {},
			ValidationStatusErrorCode: {}
		};
		devKit.LoadFields(formContext, body);
		var tab = {
			general: {
				Section: {
					section_1: {},
					url_option: {},
					url_validation: {}
				}
			}
		};
		devKit.LoadTabs(formContext, tab);
		body.Tab = tab;
		form.Body = body;
		var footer = {
			StateCode: {}
		};
		devKit.LoadFields(formContext, footer, "footer_");
		form.Footer = footer;
		var quickForm = {

		};
		devKit.LoadQuickForms(formContext, quickForm);
		form.QuickForm = quickForm;
		var navigation = {
			navSharePointSubSites: {},
			navSubDocumentLocations: {}
		};
		devKit.LoadNavigations(formContext, navigation);
		form.Navigation = navigation;
		form.Utility = devKit.LoadUtility(defaultWebResourceName);
		return form;
	};
})(LuckyStar || (LuckyStar = {}));
/** @namespace OptionSet */
var OptionSet;
(function (OptionSet) {
	OptionSet.SharePointSite = {
		ServiceType : {
			SharePoint: 0,
			OneDrive: 1,
			Shared_with_me: 2,
			MS_Teams: 3
		},
		StateCode : {
			Active: 0,
			Inactive: 1
		},
		StatusCode : {
			Active: 1,
			Inactive: 2
		},
		ValidationStatus : {
			Not_Validated: 1,
			In_Progress: 2,
			Invalid: 3,
			Valid: 4,
			Could_not_validate: 5
		},
		ValidationStatusErrorCode : {
			This_records_URL_has_not_been_validated: 1,
			This_records_URL_is_valid: 2,
			This_records_URL_is_not_valid: 3,
			The_URL_schemes_of_Microsoft_Dynamics_365_and_SharePoint_are_different: 4,
			The_URL_could_not_be_accessed_because_of_Internet_Explorer_security_settings: 5,
			Authentication_failure: 6,
			Invalid_certificates: 7
		},
        RollupState : {
            NotCalculated: 0,
            Calculated: 1,
            OverflowError: 2,
            OtherError: 3,
            RetryLimitExceeded: 4,
            HierarchicalRecursionLimitReached: 5,
            LoopDetected: 6
        }

	};
})(OptionSet || (OptionSet = {}));