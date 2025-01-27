﻿'use strict';
/** @namespace DevKit */
var DevKit;
(function (DevKit) {
	'use strict';
	DevKit.DuplicateRuleApi = function (e) {
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
		var duplicaterule = {
			BaseEntityMatchCodeTable: { a: 'baseentitymatchcodetable', r: true },
			BaseEntityName: { a: 'baseentityname' },
			BaseEntityTypeCode: { a: 'baseentitytypecode', r: true },
			CreatedBy: { b: 'createdby', a: '_createdby_value', c: 'systemusers', d: 'systemuser', r: true },
			CreatedOn_UtcDateAndTime: { a: 'createdon', r: true },
			CreatedOnBehalfBy: { b: 'createdonbehalfby', a: '_createdonbehalfby_value', c: 'systemusers', d: 'systemuser', r: true },
			Description: { a: 'description' },
			DuplicateRuleId: { a: 'duplicateruleid' },
			ExcludeInactiveRecords: { a: 'excludeinactiverecords' },
			IsCaseSensitive: { a: 'iscasesensitive' },
			MatchingEntityMatchCodeTable: { a: 'matchingentitymatchcodetable', r: true },
			MatchingEntityName: { a: 'matchingentityname' },
			MatchingEntityTypeCode: { a: 'matchingentitytypecode', r: true },
			ModifiedBy: { b: 'modifiedby', a: '_modifiedby_value', c: 'systemusers', d: 'systemuser', r: true },
			ModifiedOn_UtcDateAndTime: { a: 'modifiedon', r: true },
			ModifiedOnBehalfBy: { b: 'modifiedonbehalfby', a: '_modifiedonbehalfby_value', c: 'systemusers', d: 'systemuser', r: true },
			Name: { a: 'name' },
			OwnerId_systemuser: { b: 'ownerid', a: '_ownerid_value', c: 'systemusers', d: 'systemuser' },
			OwnerId_team: { b: 'ownerid', a: '_ownerid_value', c: 'teams', d: 'team' },
			OwningBusinessUnit: { b: 'owningbusinessunit', a: '_owningbusinessunit_value', c: 'businessunits', d: 'businessunit', r: true },
			OwningTeam: { b: 'owningteam', a: '_owningteam_value', c: 'teams', d: 'team', r: true },
			OwningUser: { b: 'owninguser', a: '_owninguser_value', c: 'systemusers', d: 'systemuser', r: true },
			StateCode: { a: 'statecode', r: true },
			StatusCode: { a: 'statuscode' },
			TimeZoneRuleVersionNumber: { a: 'timezoneruleversionnumber' },
			UTCConversionTimeZoneCode: { a: 'utcconversiontimezonecode' }
		};
		if (e === undefined) e = {};
		var u = {};
		for (var field in duplicaterule) {
			var a = duplicaterule[field].a;
			var b = duplicaterule[field].b;
			var c = duplicaterule[field].c;
			var d = duplicaterule[field].d;
			var g = duplicaterule[field].g;
			var r = duplicaterule[field].r;
			duplicaterule[field] = webApiField(e, a, b, c, d, r, u, g);
		}
		duplicaterule.Entity = u;
		duplicaterule.EntityName = 'duplicaterule';
		duplicaterule.EntityCollectionName = 'duplicaterules';
		duplicaterule['@odata.etag'] = e['@odata.etag'];
		duplicaterule.getAliasedValue = function (alias, isMultiOptionSet) {
			if (e[alias] === undefined || e[alias] === null) {
				return null;
			}
			if (isMultiOptionSet) {
				return e[alias].toString().split(',').map(function (item) { return parseInt(item, 10); });
			}
			return e[alias];
		}
		duplicaterule.getAliasedFormattedValue = function (alias, isMultiOptionSet) {
			if (e[alias + f] === undefined || e[alias + f] === null) {
				return EMPTY_STRING;
			}
			if (isMultiOptionSet) {
				return e[alias + f].toString().split(';').map(function (item) { return item.trim(); });
			}
			return e[alias + f];
		}
		return duplicaterule;
	};
})(DevKit || (DevKit = {}));
/** @namespace OptionSet */
var OptionSet;
(function (OptionSet) {
	OptionSet.DuplicateRule = {
		BaseEntityTypeCode : {
			Account: 1,
			ACIViewMapper: 8040,
			Action_Card: 9962,
			Action_Card_Type: 9983,
			Action_Card_User_Settings: 9973,
			ActionCardUserState: 9968,
			Activity: 4200,
			Activity_File_Attachment: 10049,
			Activity_Party: 135,
			Address: 1071,
			Advanced_Similarity_Rule: 9949,
			AI_Builder_Dataset: 10079,
			AI_Builder_Dataset_File: 10080,
			AI_Builder_Dataset_Record: 10081,
			AI_Builder_Datasets_Container: 10082,
			AI_Builder_File: 10083,
			AI_Builder_File_Attached_Data: 10084,
			AI_Configuration: 402,
			AI_Form_Processing_Document: 10085,
			AI_Model: 401,
			AI_Object_Detection_Bounding_Box: 10088,
			AI_Object_Detection_Image: 10086,
			AI_Object_Detection_Image_Mapping: 10089,
			AI_Object_Detection_Label: 10087,
			AI_Template: 400,
			Announcement: 132,
			Annual_Fiscal_Calendar: 2000,
			App_Config_Master: 9011,
			App_Configuration: 9012,
			App_Configuration_Instance: 9013,
			App_Module_Component: 9007,
			App_Module_Roles: 9009,
			Application_File: 4707,
			Application_Ribbons: 1120,
			ApplicationUser: 10021,
			AppModule_Metadata: 8700,
			AppModule_Metadata_Async_Operation: 8702,
			AppModule_Metadata_Dependency: 8701,
			Appointment: 4201,
			Article: 127,
			Article_Comment: 1082,
			Article_Template: 1016,
			Attachment_1001: 1001,
			Attachment_1002: 1002,
			Attribute: 9808,
			Attribute_Map: 4601,
			Auditing: 4567,
			Authorization_Server: 1094,
			Azure_Service_Connection: 9936,
			BotContent: 10039,
			BPF_Account: 10115,
			Bulk_Delete_Failure: 4425,
			Bulk_Delete_Operation: 4424,
			Business_Data_Localized_Label: 4232,
			Business_Process_Flow_Instance: 4725,
			Business_Unit: 10,
			Business_Unit_Map: 6,
			Calendar: 4003,
			Calendar_Rule: 4004,
			Callback_Registration: 301,
			Canvas_App: 300,
			CanvasApp_Extended_Metadata: 10031,
			CascadeGrantRevokeAccessRecordsTracker: 10018,
			CascadeGrantRevokeAccessVersionTracker: 10019,
			Catalog: 10065,
			Catalog_Assignment: 10066,
			Category: 9959,
			Channel_Access_Profile: 3005,
			Channel_Access_Profile_Rule: 9400,
			Channel_Access_Profile_Rule_Item: 9401,
			Channel_Property: 1236,
			Channel_Property_Group: 1234,
			Chatbot: 10041,
			Chatbot_subcomponent: 10042,
			Client_update: 36,
			Column_Mapping: 4417,
			Comment: 8005,
			Component_Layer: 10005,
			Component_Layer_Data_Source: 10006,
			Connection: 3234,
			Connection_Reference: 10037,
			Connection_Role: 3231,
			Connection_Role_Object_Type_Code: 3233,
			Connector: 372,
			Contact: 2,
			ConversationTranscript: 10040,
			Currency: 9105,
			Custom_API: 10068,
			Custom_API_Request_Parameter: 10069,
			Custom_API_Response_Property: 10070,
			Custom_Control: 9753,
			Custom_Control_Default_Config: 9755,
			Custom_Control_Resource: 9754,
			Customer_Relationship: 4502,
			Data_Import: 4410,
			Data_Lake_Folder: 10014,
			Data_Lake_Folder_Permission: 10015,
			Data_Lake_Workspace: 10016,
			Data_Lake_Workspace_Permission: 10017,
			Data_Map: 4411,
			Data_Performance_Dashboard: 4450,
			Data_Source: 10164,
			Data_Source_2: 10167,
			Data_Source_3: 10168,
			Dataflow: 418,
			DelveActionHub: 9961,
			Dependency: 7105,
			Dependency_Feature: 7108,
			Dependency_Node: 7106,
			Display_String: 4102,
			Display_String_Map: 4101,
			Document_Location: 9508,
			Document_Suggestions: 1189,
			Document_Template: 9940,
			Duplicate_Detection_Rule: 4414,
			Duplicate_Record: 4415,
			Duplicate_Rule_Condition: 4416,
			Email: 4202,
			Email_Hash: 4023,
			Email_Search: 4299,
			Email_Server_Profile: 9605,
			Email_Signature: 9997,
			Email_Template: 2010,
			Entity: 9800,
			Entity_Analytics_Config: 430,
			Entity_Image_Configuration: 432,
			Entity_Key: 9810,
			Entity_Map: 4600,
			Entity_Relationship: 9811,
			Environment_Variable_Definition: 380,
			Environment_Variable_Value: 381,
			Exchange_Sync_Id_Mapping: 4120,
			Expander_Event: 4711,
			Expired_Process: 955,
			ExportSolutionUpload: 10010,
			External_Party: 3008,
			External_Party_Item: 9987,
			Fax: 4204,
			FeatureControlSetting: 10165,
			Feedback: 9958,
			Field_Permission: 1201,
			Field_Security_Profile: 1200,
			Field_Sharing: 44,
			FileAttachment: 55,
			Filter_Template: 30,
			Fixed_Monthly_Fiscal_Calendar: 2004,
			Flow_Machine: 10033,
			Flow_Machine_Group: 10034,
			Flow_Session: 4720,
			Follow: 8003,
			Global_Search_Configuration: 54,
			Goal: 9600,
			Goal_Metric: 9603,
			Help_Page: 10116,
			Hierarchy_Rule: 8840,
			Hierarchy_Security_Configuration: 9919,
			HolidayWrapper: 9996,
			Image_Attribute_Configuration: 431,
			Image_Descriptor: 1007,
			Import_Data: 4413,
			Import_Entity_Mapping: 4428,
			Import_Job: 9107,
			Import_Log: 4423,
			Import_Source_File: 4412,
			Indexed_Article: 126,
			Integration_Status: 3000,
			Inter_Process_Lock: 4011,
			Interaction_for_Email: 9986,
			Internal_Address: 1003,
			Internal_Catalog_Assignment: 10067,
			Invalid_Dependency: 7107,
			ISV_Config: 4705,
			KeyVaultReference: 10063,
			Knowledge_Article: 9953,
			Knowledge_Article_Category: 9960,
			Knowledge_Article_Image: 10055,
			Knowledge_article_language_setting: 10058,
			Knowledge_Article_Template: 10060,
			Knowledge_Article_Views: 9955,
			Knowledge_Base_Record: 9930,
			Knowledge_Federated_Article: 10052,
			Knowledge_FederatedArticle_Incident: 10053,
			Knowledge_Interaction_Insight: 10056,
			Knowledge_personalization: 10059,
			Knowledge_search_filter: 10062,
			Knowledge_Search_Insight: 10057,
			Knowledge_Search_Model: 9947,
			Knowledge_search_personal_filter_config: 10061,
			Language: 9957,
			Language_Provisioning_State: 9875,
			Letter: 4207,
			License: 2027,
			Like: 8006,
			List_Value_Mapping: 4418,
			LocalConfigStore: 9201,
			Lookup_Mapping: 4419,
			Mail_Merge_Template: 9106,
			Mailbox: 9606,
			Mailbox_Auto_Tracking_Folder: 9608,
			Mailbox_Statistics: 9607,
			Mailbox_Tracking_Category: 9609,
			Managed_Property: 9812,
			ManagedIdentity: 10064,
			Metadata_Difference: 4231,
			Mobile_Offline_Profile: 9866,
			Mobile_Offline_Profile_Item: 9867,
			Mobile_Offline_Profile_Item_Association: 9868,
			Model_driven_App: 9006,
			Model_Driven_App_Component_Node: 10026,
			Model_Driven_App_Component_Nodes_Edge: 10025,
			Model_Driven_App_Element: 10024,
			Model_Driven_App_Setting: 10027,
			Model_Driven_App_User_Setting: 10028,
			Monthly_Fiscal_Calendar: 2003,
			Multi_Select_Option_Value: 9912,
			MultiEntitySearch: 9910,
			Navigation_Setting: 9900,
			New_Process: 950,
			NonRelational_Data_Source: 10077,
			Note: 5,
			Notification_10075: 10075,
			Notification_4110: 4110,
			OData_v4_Data_Source: 10032,
			Office_Document: 4490,
			Office_Graph_Document: 9950,
			Offline_Command_Definition: 9870,
			OptionSet: 9809,
			Organization: 1019,
			Organization_Insights_Metric: 9699,
			Organization_Insights_Notification: 9690,
			Organization_Setting: 10029,
			Organization_Statistic: 4708,
			Organization_UI: 1021,
			OrganizationDataSyncSubscription: 10073,
			OrganizationDataSyncSubscriptionEntity: 10074,
			Owner: 7,
			Owner_Mapping: 4420,
			Package: 10007,
			Partner_Application: 1095,
			PDF_Setting: 10048,
			Personal_Document_Template: 9941,
			Phone_Call: 4210,
			Plug_in_Assembly: 4605,
			Plug_in_Trace_Log: 4619,
			Plug_in_Type: 4602,
			Plug_in_Type_Statistic: 4603,
			Plugin_Package: 10166,
			PM_Inferred_Task: 10091,
			PM_Recording: 10092,
			Position: 50,
			Post: 8000,
			Post_Regarding: 8002,
			Post_Role: 8001,
			Principal_Sync_Attribute_Map: 1404,
			Privilege: 1023,
			Privilege_Object_Type_Code: 31,
			Process: 4703,
			Process_Configuration: 9650,
			Process_Dependency: 4704,
			Process_Log: 4706,
			Process_Session: 4710,
			Process_Stage: 4724,
			Process_Trigger: 4712,
			ProcessStageParameter: 10035,
			ProvisionLanguageForUser: 10013,
			Publisher: 7101,
			Publisher_Address: 7102,
			Quarterly_Fiscal_Calendar: 2002,
			Queue: 2020,
			Queue_Item: 2029,
			QueueItemCount: 2023,
			QueueMemberCount: 2024,
			Record_Creation_and_Update_Rule: 9300,
			Record_Creation_and_Update_Rule_Item: 9301,
			Recurrence_Rule: 4250,
			Recurring_Appointment: 4251,
			Relationship_Attribute: 9814,
			Relationship_Entity: 9813,
			Relationship_Role: 4500,
			Relationship_Role_Map: 4501,
			Replication_Backlog: 1140,
			Report: 9100,
			Report_Link: 9104,
			Report_Related_Category: 9102,
			Report_Related_Entity: 9101,
			Report_Visibility: 9103,
			RevokeInheritedAccessRecordsTracker: 90001,
			Ribbon_Client_Metadata: 4579,
			Ribbon_Command: 1116,
			Ribbon_Context_Group: 1115,
			Ribbon_Difference: 1130,
			Ribbon_Metadata_To_Process: 9880,
			Ribbon_Rule: 1117,
			Ribbon_Tab_To_Command_Mapping: 1113,
			Rich_Text_Attachment: 10076,
			Role_Template: 1037,
			Rollup_Field: 9604,
			Rollup_Job: 9511,
			Rollup_Properties: 9510,
			Rollup_Query: 9602,
			Routing_Rule_Set: 8181,
			Rule_Item: 8199,
			RuntimeDependency: 7200,
			Saved_Organization_Insights_Configuration: 1309,
			Saved_View: 4230,
			Sdk_Message: 4606,
			Sdk_Message_Filter: 4607,
			Sdk_Message_Pair: 4613,
			Sdk_Message_Processing_Step: 4608,
			Sdk_Message_Processing_Step_Image: 4615,
			Sdk_Message_Processing_Step_Secure_Configuration: 4616,
			Sdk_Message_Request: 4609,
			Sdk_Message_Request_Field: 4614,
			Sdk_Message_Response: 4610,
			Sdk_Message_Response_Field: 4611,
			Search_provider: 10054,
			Search_Telemetry: 10078,
			Security_Role: 1036,
			Semiannual_Fiscal_Calendar: 2001,
			Service_Configuration: 10050,
			Service_Endpoint: 4618,
			Service_Plan: 101,
			Service_Plan_Mapping: 10170,
			Setting_Definition: 10030,
			SharePoint_Data: 9509,
			Sharepoint_Document: 9507,
			SharePoint_Site: 9502,
			Similarity_Rule: 9951,
			Site_Map: 4709,
			SLA: 9750,
			SLA_Item: 9751,
			SLA_KPI: 10051,
			SLA_KPI_Instance: 9752,
			Social_Activity: 4216,
			Social_Profile: 99,
			SocialInsightsConfiguration: 1300,
			Solution: 7100,
			Solution_Component: 7103,
			Solution_Component_Attribute_Configuration: 10000,
			Solution_Component_Batch_Configuration: 10169,
			Solution_Component_Configuration: 10001,
			Solution_Component_Data_Source: 10012,
			Solution_Component_Definition: 7104,
			Solution_Component_Relationship_Configuration: 10002,
			Solution_Component_Summary: 10011,
			Solution_History: 10003,
			Solution_History_Data_Source: 10004,
			SolutionHistoryData: 9890,
			StageSolutionUpload: 10009,
			Status_Map: 1075,
			String_Map: 1043,
			Subject: 129,
			Subscription: 29,
			Subscription_Clients: 1072,
			Subscription_Manually_Tracked_Object: 37,
			Subscription_Statistic_Offline: 45,
			Subscription_Statistic_Outlook: 46,
			Subscription_Sync_Entry_Offline: 47,
			Subscription_Sync_Entry_Outlook: 48,
			Subscription_Synchronization_Information: 33,
			SuggestionCardTemplate: 1190,
			Sync_Attribute_Mapping: 1401,
			Sync_Attribute_Mapping_Profile: 1400,
			Sync_Error: 9869,
			System_Application_Metadata: 7000,
			System_Chart: 1111,
			System_Form: 1030,
			System_Job: 4700,
			System_User_Manager_Map: 51,
			System_User_Principal: 14,
			SystemUser_BusinessUnit_Entity_Map: 42,
			SystemUserAuthorizationChangeTracker: 60,
			Task: 4212,
			Team: 9,
			Team_Profiles: 1203,
			Team_Sync_Attribute_Mapping_Profiles: 1403,
			Team_template: 92,
			TeamMobileOfflineProfileMembership: 10071,
			Territory: 2013,
			Text_Analytics_Entity_Mapping: 9945,
			Theme: 2015,
			Time_Stamp_Date_Mapping: 9932,
			Time_Zone_Definition: 4810,
			Time_Zone_Localized_Name: 4812,
			Time_Zone_Rule: 4811,
			Tour: 10117,
			Trace: 8050,
			Trace_Association: 8051,
			Trace_Regarding: 8052,
			Tracking_information_for_deleted_entities: 35,
			Transformation_Mapping: 4426,
			Transformation_Parameter_Mapping: 4427,
			Translation_Process: 951,
			Unresolved_Address: 2012,
			UntrackedEmail: 4220,
			User: 8,
			User_Application_Metadata: 7001,
			User_Chart: 1112,
			User_Dashboard: 1031,
			User_Entity_Instance_Data: 2501,
			User_Entity_UI_Settings: 2500,
			User_Fiscal_Calendar: 1086,
			User_Mapping: 2016,
			User_Search_Facet: 52,
			User_Settings: 150,
			UserMobileOfflineProfileMembership: 10072,
			View: 1039,
			Virtual_Entity_Data_Provider: 78,
			Virtual_Entity_Data_Source: 85,
			Virtual_Entity_Metadata: 10118,
			Web_Resource: 9333,
			Web_Wizard: 4800,
			Web_Wizard_Access_Privilege: 4803,
			Wizard_Page: 4802,
			Workflow_Binary: 10036,
			Workflow_Wait_Subscription: 4702
		},
		MatchingEntityTypeCode : {
			Account: 1,
			ACIViewMapper: 8040,
			Action_Card: 9962,
			Action_Card_Type: 9983,
			Action_Card_User_Settings: 9973,
			ActionCardUserState: 9968,
			Activity: 4200,
			Activity_File_Attachment: 10049,
			Activity_Party: 135,
			Address: 1071,
			Advanced_Similarity_Rule: 9949,
			AI_Builder_Dataset: 10079,
			AI_Builder_Dataset_File: 10080,
			AI_Builder_Dataset_Record: 10081,
			AI_Builder_Datasets_Container: 10082,
			AI_Builder_File: 10083,
			AI_Builder_File_Attached_Data: 10084,
			AI_Configuration: 402,
			AI_Form_Processing_Document: 10085,
			AI_Model: 401,
			AI_Object_Detection_Bounding_Box: 10088,
			AI_Object_Detection_Image: 10086,
			AI_Object_Detection_Image_Mapping: 10089,
			AI_Object_Detection_Label: 10087,
			AI_Template: 400,
			Announcement: 132,
			Annual_Fiscal_Calendar: 2000,
			App_Config_Master: 9011,
			App_Configuration: 9012,
			App_Configuration_Instance: 9013,
			App_Module_Component: 9007,
			App_Module_Roles: 9009,
			Application_File: 4707,
			Application_Ribbons: 1120,
			ApplicationUser: 10021,
			AppModule_Metadata: 8700,
			AppModule_Metadata_Async_Operation: 8702,
			AppModule_Metadata_Dependency: 8701,
			Appointment: 4201,
			Article: 127,
			Article_Comment: 1082,
			Article_Template: 1016,
			Attachment_1001: 1001,
			Attachment_1002: 1002,
			Attribute: 9808,
			Attribute_Map: 4601,
			Auditing: 4567,
			Authorization_Server: 1094,
			Azure_Service_Connection: 9936,
			BotContent: 10039,
			BPF_Account: 10115,
			Bulk_Delete_Failure: 4425,
			Bulk_Delete_Operation: 4424,
			Business_Data_Localized_Label: 4232,
			Business_Process_Flow_Instance: 4725,
			Business_Unit: 10,
			Business_Unit_Map: 6,
			Calendar: 4003,
			Calendar_Rule: 4004,
			Callback_Registration: 301,
			Canvas_App: 300,
			CanvasApp_Extended_Metadata: 10031,
			CascadeGrantRevokeAccessRecordsTracker: 10018,
			CascadeGrantRevokeAccessVersionTracker: 10019,
			Catalog: 10065,
			Catalog_Assignment: 10066,
			Category: 9959,
			Channel_Access_Profile: 3005,
			Channel_Access_Profile_Rule: 9400,
			Channel_Access_Profile_Rule_Item: 9401,
			Channel_Property: 1236,
			Channel_Property_Group: 1234,
			Chatbot: 10041,
			Chatbot_subcomponent: 10042,
			Client_update: 36,
			Column_Mapping: 4417,
			Comment: 8005,
			Component_Layer: 10005,
			Component_Layer_Data_Source: 10006,
			Connection: 3234,
			Connection_Reference: 10037,
			Connection_Role: 3231,
			Connection_Role_Object_Type_Code: 3233,
			Connector: 372,
			Contact: 2,
			ConversationTranscript: 10040,
			Currency: 9105,
			Custom_API: 10068,
			Custom_API_Request_Parameter: 10069,
			Custom_API_Response_Property: 10070,
			Custom_Control: 9753,
			Custom_Control_Default_Config: 9755,
			Custom_Control_Resource: 9754,
			Customer_Relationship: 4502,
			Data_Import: 4410,
			Data_Lake_Folder: 10014,
			Data_Lake_Folder_Permission: 10015,
			Data_Lake_Workspace: 10016,
			Data_Lake_Workspace_Permission: 10017,
			Data_Map: 4411,
			Data_Performance_Dashboard: 4450,
			Data_Source: 10164,
			Data_Source_2: 10167,
			Data_Source_3: 10168,
			Dataflow: 418,
			DelveActionHub: 9961,
			Dependency: 7105,
			Dependency_Feature: 7108,
			Dependency_Node: 7106,
			Display_String: 4102,
			Display_String_Map: 4101,
			Document_Location: 9508,
			Document_Suggestions: 1189,
			Document_Template: 9940,
			Duplicate_Detection_Rule: 4414,
			Duplicate_Record: 4415,
			Duplicate_Rule_Condition: 4416,
			Email: 4202,
			Email_Hash: 4023,
			Email_Search: 4299,
			Email_Server_Profile: 9605,
			Email_Signature: 9997,
			Email_Template: 2010,
			Entity: 9800,
			Entity_Analytics_Config: 430,
			Entity_Image_Configuration: 432,
			Entity_Key: 9810,
			Entity_Map: 4600,
			Entity_Relationship: 9811,
			Environment_Variable_Definition: 380,
			Environment_Variable_Value: 381,
			Exchange_Sync_Id_Mapping: 4120,
			Expander_Event: 4711,
			Expired_Process: 955,
			ExportSolutionUpload: 10010,
			External_Party: 3008,
			External_Party_Item: 9987,
			Fax: 4204,
			FeatureControlSetting: 10165,
			Feedback: 9958,
			Field_Permission: 1201,
			Field_Security_Profile: 1200,
			Field_Sharing: 44,
			FileAttachment: 55,
			Filter_Template: 30,
			Fixed_Monthly_Fiscal_Calendar: 2004,
			Flow_Machine: 10033,
			Flow_Machine_Group: 10034,
			Flow_Session: 4720,
			Follow: 8003,
			Global_Search_Configuration: 54,
			Goal: 9600,
			Goal_Metric: 9603,
			Help_Page: 10116,
			Hierarchy_Rule: 8840,
			Hierarchy_Security_Configuration: 9919,
			HolidayWrapper: 9996,
			Image_Attribute_Configuration: 431,
			Image_Descriptor: 1007,
			Import_Data: 4413,
			Import_Entity_Mapping: 4428,
			Import_Job: 9107,
			Import_Log: 4423,
			Import_Source_File: 4412,
			Indexed_Article: 126,
			Integration_Status: 3000,
			Inter_Process_Lock: 4011,
			Interaction_for_Email: 9986,
			Internal_Address: 1003,
			Internal_Catalog_Assignment: 10067,
			Invalid_Dependency: 7107,
			ISV_Config: 4705,
			KeyVaultReference: 10063,
			Knowledge_Article: 9953,
			Knowledge_Article_Category: 9960,
			Knowledge_Article_Image: 10055,
			Knowledge_article_language_setting: 10058,
			Knowledge_Article_Template: 10060,
			Knowledge_Article_Views: 9955,
			Knowledge_Base_Record: 9930,
			Knowledge_Federated_Article: 10052,
			Knowledge_FederatedArticle_Incident: 10053,
			Knowledge_Interaction_Insight: 10056,
			Knowledge_personalization: 10059,
			Knowledge_search_filter: 10062,
			Knowledge_Search_Insight: 10057,
			Knowledge_Search_Model: 9947,
			Knowledge_search_personal_filter_config: 10061,
			Language: 9957,
			Language_Provisioning_State: 9875,
			Letter: 4207,
			License: 2027,
			Like: 8006,
			List_Value_Mapping: 4418,
			LocalConfigStore: 9201,
			Lookup_Mapping: 4419,
			Mail_Merge_Template: 9106,
			Mailbox: 9606,
			Mailbox_Auto_Tracking_Folder: 9608,
			Mailbox_Statistics: 9607,
			Mailbox_Tracking_Category: 9609,
			Managed_Property: 9812,
			ManagedIdentity: 10064,
			Metadata_Difference: 4231,
			Mobile_Offline_Profile: 9866,
			Mobile_Offline_Profile_Item: 9867,
			Mobile_Offline_Profile_Item_Association: 9868,
			Model_driven_App: 9006,
			Model_Driven_App_Component_Node: 10026,
			Model_Driven_App_Component_Nodes_Edge: 10025,
			Model_Driven_App_Element: 10024,
			Model_Driven_App_Setting: 10027,
			Model_Driven_App_User_Setting: 10028,
			Monthly_Fiscal_Calendar: 2003,
			Multi_Select_Option_Value: 9912,
			MultiEntitySearch: 9910,
			Navigation_Setting: 9900,
			New_Process: 950,
			NonRelational_Data_Source: 10077,
			Note: 5,
			Notification_10075: 10075,
			Notification_4110: 4110,
			OData_v4_Data_Source: 10032,
			Office_Document: 4490,
			Office_Graph_Document: 9950,
			Offline_Command_Definition: 9870,
			OptionSet: 9809,
			Organization: 1019,
			Organization_Insights_Metric: 9699,
			Organization_Insights_Notification: 9690,
			Organization_Setting: 10029,
			Organization_Statistic: 4708,
			Organization_UI: 1021,
			OrganizationDataSyncSubscription: 10073,
			OrganizationDataSyncSubscriptionEntity: 10074,
			Owner: 7,
			Owner_Mapping: 4420,
			Package: 10007,
			Partner_Application: 1095,
			PDF_Setting: 10048,
			Personal_Document_Template: 9941,
			Phone_Call: 4210,
			Plug_in_Assembly: 4605,
			Plug_in_Trace_Log: 4619,
			Plug_in_Type: 4602,
			Plug_in_Type_Statistic: 4603,
			Plugin_Package: 10166,
			PM_Inferred_Task: 10091,
			PM_Recording: 10092,
			Position: 50,
			Post: 8000,
			Post_Regarding: 8002,
			Post_Role: 8001,
			Principal_Sync_Attribute_Map: 1404,
			Privilege: 1023,
			Privilege_Object_Type_Code: 31,
			Process: 4703,
			Process_Configuration: 9650,
			Process_Dependency: 4704,
			Process_Log: 4706,
			Process_Session: 4710,
			Process_Stage: 4724,
			Process_Trigger: 4712,
			ProcessStageParameter: 10035,
			ProvisionLanguageForUser: 10013,
			Publisher: 7101,
			Publisher_Address: 7102,
			Quarterly_Fiscal_Calendar: 2002,
			Queue: 2020,
			Queue_Item: 2029,
			QueueItemCount: 2023,
			QueueMemberCount: 2024,
			Record_Creation_and_Update_Rule: 9300,
			Record_Creation_and_Update_Rule_Item: 9301,
			Recurrence_Rule: 4250,
			Recurring_Appointment: 4251,
			Relationship_Attribute: 9814,
			Relationship_Entity: 9813,
			Relationship_Role: 4500,
			Relationship_Role_Map: 4501,
			Replication_Backlog: 1140,
			Report: 9100,
			Report_Link: 9104,
			Report_Related_Category: 9102,
			Report_Related_Entity: 9101,
			Report_Visibility: 9103,
			RevokeInheritedAccessRecordsTracker: 90001,
			Ribbon_Client_Metadata: 4579,
			Ribbon_Command: 1116,
			Ribbon_Context_Group: 1115,
			Ribbon_Difference: 1130,
			Ribbon_Metadata_To_Process: 9880,
			Ribbon_Rule: 1117,
			Ribbon_Tab_To_Command_Mapping: 1113,
			Rich_Text_Attachment: 10076,
			Role_Template: 1037,
			Rollup_Field: 9604,
			Rollup_Job: 9511,
			Rollup_Properties: 9510,
			Rollup_Query: 9602,
			Routing_Rule_Set: 8181,
			Rule_Item: 8199,
			RuntimeDependency: 7200,
			Saved_Organization_Insights_Configuration: 1309,
			Saved_View: 4230,
			Sdk_Message: 4606,
			Sdk_Message_Filter: 4607,
			Sdk_Message_Pair: 4613,
			Sdk_Message_Processing_Step: 4608,
			Sdk_Message_Processing_Step_Image: 4615,
			Sdk_Message_Processing_Step_Secure_Configuration: 4616,
			Sdk_Message_Request: 4609,
			Sdk_Message_Request_Field: 4614,
			Sdk_Message_Response: 4610,
			Sdk_Message_Response_Field: 4611,
			Search_provider: 10054,
			Search_Telemetry: 10078,
			Security_Role: 1036,
			Semiannual_Fiscal_Calendar: 2001,
			Service_Configuration: 10050,
			Service_Endpoint: 4618,
			Service_Plan: 101,
			Service_Plan_Mapping: 10170,
			Setting_Definition: 10030,
			SharePoint_Data: 9509,
			Sharepoint_Document: 9507,
			SharePoint_Site: 9502,
			Similarity_Rule: 9951,
			Site_Map: 4709,
			SLA: 9750,
			SLA_Item: 9751,
			SLA_KPI: 10051,
			SLA_KPI_Instance: 9752,
			Social_Activity: 4216,
			Social_Profile: 99,
			SocialInsightsConfiguration: 1300,
			Solution: 7100,
			Solution_Component: 7103,
			Solution_Component_Attribute_Configuration: 10000,
			Solution_Component_Batch_Configuration: 10169,
			Solution_Component_Configuration: 10001,
			Solution_Component_Data_Source: 10012,
			Solution_Component_Definition: 7104,
			Solution_Component_Relationship_Configuration: 10002,
			Solution_Component_Summary: 10011,
			Solution_History: 10003,
			Solution_History_Data_Source: 10004,
			SolutionHistoryData: 9890,
			StageSolutionUpload: 10009,
			Status_Map: 1075,
			String_Map: 1043,
			Subject: 129,
			Subscription: 29,
			Subscription_Clients: 1072,
			Subscription_Manually_Tracked_Object: 37,
			Subscription_Statistic_Offline: 45,
			Subscription_Statistic_Outlook: 46,
			Subscription_Sync_Entry_Offline: 47,
			Subscription_Sync_Entry_Outlook: 48,
			Subscription_Synchronization_Information: 33,
			SuggestionCardTemplate: 1190,
			Sync_Attribute_Mapping: 1401,
			Sync_Attribute_Mapping_Profile: 1400,
			Sync_Error: 9869,
			System_Application_Metadata: 7000,
			System_Chart: 1111,
			System_Form: 1030,
			System_Job: 4700,
			System_User_Manager_Map: 51,
			System_User_Principal: 14,
			SystemUser_BusinessUnit_Entity_Map: 42,
			SystemUserAuthorizationChangeTracker: 60,
			Task: 4212,
			Team: 9,
			Team_Profiles: 1203,
			Team_Sync_Attribute_Mapping_Profiles: 1403,
			Team_template: 92,
			TeamMobileOfflineProfileMembership: 10071,
			Territory: 2013,
			Text_Analytics_Entity_Mapping: 9945,
			Theme: 2015,
			Time_Stamp_Date_Mapping: 9932,
			Time_Zone_Definition: 4810,
			Time_Zone_Localized_Name: 4812,
			Time_Zone_Rule: 4811,
			Tour: 10117,
			Trace: 8050,
			Trace_Association: 8051,
			Trace_Regarding: 8052,
			Tracking_information_for_deleted_entities: 35,
			Transformation_Mapping: 4426,
			Transformation_Parameter_Mapping: 4427,
			Translation_Process: 951,
			Unresolved_Address: 2012,
			UntrackedEmail: 4220,
			User: 8,
			User_Application_Metadata: 7001,
			User_Chart: 1112,
			User_Dashboard: 1031,
			User_Entity_Instance_Data: 2501,
			User_Entity_UI_Settings: 2500,
			User_Fiscal_Calendar: 1086,
			User_Mapping: 2016,
			User_Search_Facet: 52,
			User_Settings: 150,
			UserMobileOfflineProfileMembership: 10072,
			View: 1039,
			Virtual_Entity_Data_Provider: 78,
			Virtual_Entity_Data_Source: 85,
			Virtual_Entity_Metadata: 10118,
			Web_Resource: 9333,
			Web_Wizard: 4800,
			Web_Wizard_Access_Privilege: 4803,
			Wizard_Page: 4802,
			Workflow_Binary: 10036,
			Workflow_Wait_Subscription: 4702
		},
		StateCode : {
			Active: 1,
			Inactive: 0
		},
		StatusCode : {
			Published: 2,
			Publishing: 1,
			Unpublished: 0
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