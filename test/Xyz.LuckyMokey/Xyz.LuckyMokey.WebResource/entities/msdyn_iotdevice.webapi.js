﻿'use strict';
/** @namespace LuckyMokey */
var LuckyMokey;
(function (LuckyMokey) {
	'use strict';
	LuckyMokey.msdyn_iotdeviceApi = function (e) {
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
		var msdyn_iotdevice = {
			CreatedBy: { b: 'createdby', a: '_createdby_value', c: 'systemusers', d: 'systemuser', r: true },
			CreatedOn_UtcDateAndTime: { a: 'createdon', r: true },
			CreatedOnBehalfBy: { b: 'createdonbehalfby', a: '_createdonbehalfby_value', c: 'systemusers', d: 'systemuser', r: true },
			ImportSequenceNumber: { a: 'importsequencenumber' },
			ModifiedBy: { b: 'modifiedby', a: '_modifiedby_value', c: 'systemusers', d: 'systemuser', r: true },
			ModifiedOn_UtcDateAndTime: { a: 'modifiedon', r: true },
			ModifiedOnBehalfBy: { b: 'modifiedonbehalfby', a: '_modifiedonbehalfby_value', c: 'systemusers', d: 'systemuser', r: true },
			msdyn_Account: { b: 'msdyn_Account', a: '_msdyn_account_value', c: 'accounts', d: 'account' },
			msdyn_Category: { b: 'msdyn_Category', a: '_msdyn_category_value', c: 'msdyn_iotdevicecategories', d: 'msdyn_iotdevicecategory' },
			msdyn_ConnectionState: { a: 'msdyn_connectionstate' },
			msdyn_DeviceId: { a: 'msdyn_deviceid' },
			msdyn_DeviceReportedProperties: { a: 'msdyn_devicereportedproperties' },
			msdyn_DeviceSettings: { a: 'msdyn_devicesettings' },
			msdyn_iotdeviceId: { a: 'msdyn_iotdeviceid' },
			msdyn_IoTProviderInstance: { b: 'msdyn_IoTProviderInstance', a: '_msdyn_iotproviderinstance_value', c: 'msdyn_iotproviderinstances', d: 'msdyn_iotproviderinstance' },
			msdyn_IsSimulated: { a: 'msdyn_issimulated' },
			msdyn_LastActivityTime_UtcDateAndTime: { a: 'msdyn_lastactivitytime' },
			msdyn_LastCommandSent: { b: 'msdyn_LastCommandSent', a: '_msdyn_lastcommandsent_value', c: 'msdyn_iotdevicecommands', d: 'msdyn_iotdevicecommand' },
			msdyn_LastCommandSentTime_UtcDateAndTime: { a: 'msdyn_lastcommandsenttime' },
			msdyn_name: { a: 'msdyn_name' },
			msdyn_RegistrationMessage: { a: 'msdyn_registrationmessage' },
			msdyn_RegistrationStatus: { a: 'msdyn_registrationstatus' },
			msdyn_Tags: { a: 'msdyn_tags' },
			msdyn_Timezone: { a: 'msdyn_timezone' },
			OverriddenCreatedOn_UtcDateOnly: { a: 'overriddencreatedon' },
			OwnerId_systemuser: { b: 'ownerid', a: '_ownerid_value', c: 'systemusers', d: 'systemuser' },
			OwnerId_team: { b: 'ownerid', a: '_ownerid_value', c: 'teams', d: 'team' },
			OwningBusinessUnit: { b: 'owningbusinessunit', a: '_owningbusinessunit_value', c: 'businessunits', d: 'businessunit', r: true },
			OwningTeam: { b: 'owningteam', a: '_owningteam_value', c: 'teams', d: 'team', r: true },
			OwningUser: { b: 'owninguser', a: '_owninguser_value', c: 'systemusers', d: 'systemuser', r: true },
			statecode: { a: 'statecode' },
			statuscode: { a: 'statuscode' },
			TimeZoneRuleVersionNumber: { a: 'timezoneruleversionnumber' },
			UTCConversionTimeZoneCode: { a: 'utcconversiontimezonecode' },
			VersionNumber: { a: 'versionnumber', r: true }
		};
		if (e === undefined) e = {};
		var u = {};
		for (var field in msdyn_iotdevice) {
			var a = msdyn_iotdevice[field].a;
			var b = msdyn_iotdevice[field].b;
			var c = msdyn_iotdevice[field].c;
			var d = msdyn_iotdevice[field].d;
			var g = msdyn_iotdevice[field].g;
			var r = msdyn_iotdevice[field].r;
			msdyn_iotdevice[field] = webApiField(e, a, b, c, d, r, u, g);
		}
		msdyn_iotdevice.Entity = u;
		msdyn_iotdevice.EntityName = 'msdyn_iotdevice';
		msdyn_iotdevice.EntityCollectionName = 'msdyn_iotdevices';
		msdyn_iotdevice['@odata.etag'] = e['@odata.etag'];
		msdyn_iotdevice.getAliasedValue = function (alias, isMultiOptionSet) {
			if (e[alias] === undefined || e[alias] === null) {
				return null;
			}
			if (isMultiOptionSet) {
				return e[alias].toString().split(',').map(function (item) { return parseInt(item, 10); });
			}
			return e[alias];
		}
		msdyn_iotdevice.getAliasedFormattedValue = function (alias, isMultiOptionSet) {
			if (e[alias + f] === undefined || e[alias + f] === null) {
				return EMPTY_STRING;
			}
			if (isMultiOptionSet) {
				return e[alias + f].toString().split(';').map(function (item) { return item.trim(); });
			}
			return e[alias + f];
		}
		return msdyn_iotdevice;
	};
})(LuckyMokey || (LuckyMokey = {}));
/** @namespace OptionSet */
var OptionSet;
(function (OptionSet) {
	OptionSet.msdyn_iotdevice = {
		msdyn_IsSimulated : {
			Yes: 192350000,
			No: 192350001
		},
		msdyn_RegistrationStatus : {
			Unknown: 192350000,
			Unregistered: 192350001,
			In_Progress: 192350002,
			Registered: 192350003,
			Error: 192350004
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