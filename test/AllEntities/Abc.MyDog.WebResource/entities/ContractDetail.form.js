﻿'use strict';
/** @namespace MyDog */
var MyDog;
(function (MyDog) {
	'use strict';
	MyDog.FormContract_Detail = function(executionContext, defaultWebResourceName) {
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
			ActiveOn: {},
			AllotmentsRemaining: {},
			AllotmentsUsed: {},
			CustomerId: {},
			Discount: {},
			DiscountPercentage: {},
			ExpiresOn: {},
			InitialQuantity: {},
			Net: {},
			notescontrol: {},
			Price: {},
			ProductId: {},
			ProductSerialNumber: {},
			Rate: {},
			ServiceAddress: {},
			Title: {},
			TotalAllotments: {},
			UoMId: {}
		};
		devKit.LoadFields(formContext, body);
		var tab = {
			general: {
				Section: {
					contract_detail_information: {},
					pricing: {},
					administration: {},
					notes: {},
					allotment_details: {}
				}
			}
		};
		devKit.LoadTabs(formContext, tab);
		body.Tab = tab;
		form.Body = body;
		var quickForm = {

		};
		devKit.LoadQuickForms(formContext, quickForm);
		form.QuickForm = quickForm;
		var navigation = {

		};
		devKit.LoadNavigations(formContext, navigation);
		form.Navigation = navigation;
		form.Utility = devKit.LoadUtility(defaultWebResourceName);
		form.ExecutionContext = devKit.LoadExecutionContext(executionContext);
		return form;
	};
	MyDog.FormContractDetail_Information = function(executionContext, defaultWebResourceName) {
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
			ActiveOn: {},
			AllotmentsRemaining: {},
			AllotmentsUsed: {},
			CustomerId: {},
			Discount: {},
			DiscountPercentage: {},
			ExpiresOn: {},
			InitialQuantity: {},
			Net: {},
			notescontrol: {},
			Price: {},
			ProductId: {},
			ProductSerialNumber: {},
			Rate: {},
			ServiceAddress: {},
			Title: {},
			TotalAllotments: {},
			UoMId: {}
		};
		devKit.LoadFields(formContext, body);
		var tab = {
			general: {
				Section: {
					contract_detail_information: {},
					allotment_details: {},
					pricing: {}
				}
			},
			administration: {
				Section: {
					customer_information: {},
					serial_number: {}
				}
			},
			notes: {
				Section: {
					notes: {}
				}
			}
		};
		devKit.LoadTabs(formContext, tab);
		body.Tab = tab;
		form.Body = body;
		var quickForm = {

		};
		devKit.LoadQuickForms(formContext, quickForm);
		form.QuickForm = quickForm;
		var navigation = {

		};
		devKit.LoadNavigations(formContext, navigation);
		form.Navigation = navigation;
		form.Utility = devKit.LoadUtility(defaultWebResourceName);
		form.ExecutionContext = devKit.LoadExecutionContext(executionContext);
		return form;
	};
})(MyDog || (MyDog = {}));
/** @namespace OptionSet */
var OptionSet;
(function (OptionSet) {
	OptionSet.ContractDetail = {
		ContractStateCode : {
		},
		ServiceContractUnitsCode : {
			Default_Value: 1
		},
		StateCode : {
			Canceled: 2,
			Existing: 0,
			Expired: 3,
			Renewed: 1
		},
		StatusCode : {
			Canceled: 3,
			Expired: 4,
			New: 1,
			Renewed: 2
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