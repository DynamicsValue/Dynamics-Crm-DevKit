﻿'use strict';
/** @namespace LuckyMokey */
var LuckyMokey;
(function (LuckyMokey) {
	'use strict';
	LuckyMokey.msdyn_timeentryApi = function (e) {
		var EMPTY_STRING = '';
		var f = '@OData.Community.Display.V1.FormattedValue';
        function webApiField(entity, logicalName, schemaName, entityLogicalCollectionName, entityLogicalName, readOnly, upsertEntity, isMultiOptionSet) {
            var l = '@Microsoft.Dynamics.CRM.lookuplogicalname';
            var property = {};
            var getFormattedValue = function () {
                if (entity[logicalName + f] === undefined || entity[logicalName + f] === null) {
                    return EMPTY_STRING;
                }
                if (entityLogicalCollectionName !== undefined && entityLogicalCollectionName.length > 0) {
                    if (entity[logicalName + l] === entityLogicalName) {
                        return entity[logicalName + f];
                    }
                    return EMPTY_STRING;
                }
                if (isMultiOptionSet) {
                    return entity[logicalName + f].toString().split(';').map(function (item) { return item.trim(); });
                }
                return entity[logicalName + f];
            };
            var getValue = function () {
                if (entity[logicalName] === undefined || entity[logicalName] === null) {
                    return null;
                }
                if (entityLogicalCollectionName !== undefined && entityLogicalCollectionName.length > 0) {
                    if (entity[logicalName + l] === undefined || entity[logicalName + l] === entityLogicalName) {
                        return entity[logicalName];
                    }
                    return null;
                }
                if (isMultiOptionSet) {
                    return entity[logicalName].toString().split(',').map(function (item) { return parseInt(item, 10); });
                }
                return entity[logicalName];
            };
            var setValue = function (value) {
                if (isMultiOptionSet) value = value.join(',');
                if (entityLogicalCollectionName !== undefined && entityLogicalCollectionName.length > 0) {
                    value = value.replace('{', EMPTY_STRING).replace('}', EMPTY_STRING);
                    upsertEntity[schemaName + '@odata.bind'] = '/' + entityLogicalCollectionName + '(' + value + ')';
                } else {
                    upsertEntity[logicalName] = value;
                }
                entity[logicalName] = value;
            };
            Object.defineProperty(property, 'FormattedValue', {
                get: getFormattedValue
            });
            if (readOnly) {
                Object.defineProperty(property, 'Value', {
                    get: getValue
                });
            }
            else {
                Object.defineProperty(property, 'Value', {
                    get: getValue,
                    set: setValue
                });
            }
            return property;
        }
		var msdyn_timeentry = {
			CreatedBy: { b: 'createdby', a: '_createdby_value', c: 'systemusers', d: 'systemuser', r: true },
			CreatedOn_UtcDateAndTime: { a: 'createdon', r: true },
			CreatedOnBehalfBy: { b: 'createdonbehalfby', a: '_createdonbehalfby_value', c: 'systemusers', d: 'systemuser', r: true },
			ImportSequenceNumber: { a: 'importsequencenumber' },
			ModifiedBy: { b: 'modifiedby', a: '_modifiedby_value', c: 'systemusers', d: 'systemuser', r: true },
			ModifiedOn_UtcDateAndTime: { a: 'modifiedon', r: true },
			ModifiedOnBehalfBy: { b: 'modifiedonbehalfby', a: '_modifiedonbehalfby_value', c: 'systemusers', d: 'systemuser', r: true },
			msdyn_bookableresource: { b: 'msdyn_bookableresource', a: '_msdyn_bookableresource_value', c: 'bookableresources', d: 'bookableresource' },
			msdyn_date_UtcDateOnly: { a: 'msdyn_date' },
			msdyn_description: { a: 'msdyn_description' },
			msdyn_duration: { a: 'msdyn_duration' },
			msdyn_entryStatus: { a: 'msdyn_entrystatus' },
			msdyn_externalDescription: { a: 'msdyn_externaldescription' },
			msdyn_manager: { b: 'msdyn_manager', a: '_msdyn_manager_value', c: 'systemusers', d: 'systemuser' },
			msdyn_project: { b: 'msdyn_project', a: '_msdyn_project_value', c: 'msdyn_projects', d: 'msdyn_project' },
			msdyn_projectTask: { b: 'msdyn_projectTask', a: '_msdyn_projecttask_value', c: 'msdyn_projecttasks', d: 'msdyn_projecttask' },
			msdyn_relatedItemId: { a: 'msdyn_relateditemid' },
			msdyn_relatedItemType: { a: 'msdyn_relateditemtype' },
			msdyn_resourceCategory: { b: 'msdyn_resourceCategory', a: '_msdyn_resourcecategory_value', c: 'bookableresourcecategories', d: 'bookableresourcecategory' },
			msdyn_ResourceOrganizationalUnitId: { b: 'msdyn_ResourceOrganizationalUnitId', a: '_msdyn_resourceorganizationalunitid_value', c: 'msdyn_organizationalunits', d: 'msdyn_organizationalunit' },
			msdyn_targetEntryStatus: { a: 'msdyn_targetentrystatus' },
			msdyn_timeentryId: { a: 'msdyn_timeentryid' },
			msdyn_transactioncategory: { b: 'msdyn_transactioncategory', a: '_msdyn_transactioncategory_value', c: 'msdyn_transactioncategories', d: 'msdyn_transactioncategory' },
			msdyn_type: { a: 'msdyn_type' },
			OverriddenCreatedOn_UtcDateOnly: { a: 'overriddencreatedon' },
			OwnerId_systemuser: { b: 'ownerid', a: '_ownerid_value', c: 'systemusers', d: 'systemuser' },
			OwnerId_team: { b: 'ownerid', a: '_ownerid_value', c: 'teams', d: 'team' },
			OwningBusinessUnit: { b: 'owningbusinessunit', a: '_owningbusinessunit_value', c: 'businessunits', d: 'businessunit', r: true },
			OwningTeam: { b: 'owningteam', a: '_owningteam_value', c: 'teams', d: 'team', r: true },
			OwningUser: { b: 'owninguser', a: '_owninguser_value', c: 'systemusers', d: 'systemuser', r: true },
			processid: { a: 'processid' },
			stageid: { a: 'stageid' },
			statecode: { a: 'statecode' },
			statuscode: { a: 'statuscode' },
			TimeZoneRuleVersionNumber: { a: 'timezoneruleversionnumber' },
			traversedpath: { a: 'traversedpath' },
			UTCConversionTimeZoneCode: { a: 'utcconversiontimezonecode' },
			VersionNumber: { a: 'versionnumber', r: true }
		};
		if (e === undefined) e = {};
		var u = {};
		for (var field in msdyn_timeentry) {
			var a = msdyn_timeentry[field].a;
			var b = msdyn_timeentry[field].b;
			var c = msdyn_timeentry[field].c;
			var d = msdyn_timeentry[field].d;
			var g = msdyn_timeentry[field].g;
			var r = msdyn_timeentry[field].r;
			msdyn_timeentry[field] = webApiField(e, a, b, c, d, r, u, g);
		}
		msdyn_timeentry.Entity = u;
		msdyn_timeentry.EntityName = 'msdyn_timeentry';
		msdyn_timeentry.EntityCollectionName = 'msdyn_timeentries';
		msdyn_timeentry['@odata.etag'] = e['@odata.etag'];
		msdyn_timeentry.getAliasedValue = function (alias, isMultiOptionSet) {
			if (e[alias] === undefined || e[alias] === null) {
				return null;
			}
			if (isMultiOptionSet) {
				return e[alias].toString().split(',').map(function (item) { return parseInt(item, 10); });
			}
			return e[alias];
		}
		msdyn_timeentry.getAliasedFormattedValue = function (alias, isMultiOptionSet) {
			if (e[alias + f] === undefined || e[alias + f] === null) {
				return EMPTY_STRING;
			}
			if (isMultiOptionSet) {
				return e[alias + f].toString().split(';').map(function (item) { return item.trim(); });
			}
			return e[alias + f];
		}
		return msdyn_timeentry;
	};
})(LuckyMokey || (LuckyMokey = {}));
/** @namespace OptionSet */
var OptionSet;
(function (OptionSet) {
	OptionSet.msdyn_timeentry = {
		msdyn_entryStatus : {
			Draft: 192350000,
			Returned: 192350001,
			Approved: 192350002,
			Submitted: 192350003,
			Recall_Requested: 192350004
		},
		msdyn_relatedItemType : {
			None: 192350000,
			Resource_Booking: 192350001,
			Resource_Assignment: 192350002,
			Exchange_Appointments: 192350100
		},
		msdyn_targetEntryStatus : {
			Draft: 192350000,
			Returned: 192350001,
			Approved: 192350002,
			Submitted: 192350003,
			Recall_Requested: 192350004
		},
		msdyn_type : {
			Work: 192350000,
			Absence: 192350001,
			Vacation: 192350002
		},
		statecode : {
			Active: 0,
			Inactive: 1
		},
		statuscode : {
			Active: 1,
			Inactive: 2
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