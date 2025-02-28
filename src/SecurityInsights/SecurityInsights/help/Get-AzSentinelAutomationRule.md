---
external help file:
Module Name: Az.SecurityInsights
online version: https://learn.microsoft.com/powershell/module/az.securityinsights/get-azsentinelautomationrule
schema: 2.0.0
---

# Get-AzSentinelAutomationRule

## SYNOPSIS
Gets the automation rule.

## SYNTAX

### List (Default)
```
Get-AzSentinelAutomationRule -ResourceGroupName <String> -WorkspaceName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzSentinelAutomationRule -Id <String> -ResourceGroupName <String> -WorkspaceName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzSentinelAutomationRule -InputObject <ISecurityInsightsIdentity> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Gets the automation rule.

## EXAMPLES

### Example 1: List all Automation Rules
```powershell
 Get-AzSentinelAutomationRule -ResourceGroupName "myResourceGroupName" -workspaceName "myWorkspaceName"
```

```output
DisplayName                 : VIP automation rule
CreatedByEmail              : luke@contoso.com
CreatedByUserPrincipalName  : luke@contoso.com
TriggeringLogicIsEnabled    : True
TriggeringLogicTriggersOn   : Incidents
TriggeringLogicTriggersWhen : Created
Name                       	: 2f32af32-ad13-4fbb-9fbc-e19e0e7ff767

```

This command lists all Automation Rules under a Microsoft Sentinel workspace.

### Example 2: Get an Automation Rule
```powershell
 Get-AzSentinelAutomationRule -ResourceGroupName "myResourceGroupName" -workspaceName "myWorkspaceName" -Id "2f32af32-ad13-4fbb-9fbc-e19e0e7ff767"
```

```output
DisplayName                 : VIP automation rule
CreatedByEmail              : luke@contoso.com
CreatedByUserPrincipalName  : luke@contoso.com
TriggeringLogicIsEnabled    : True
TriggeringLogicTriggersOn   : Incidents
TriggeringLogicTriggersWhen : Created
Name                       	: 2f32af32-ad13-4fbb-9fbc-e19e0e7ff767
```

This command gets an Automation Rule.

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Automation rule ID

```yaml
Type: System.String
Parameter Sets: Get
Aliases: AutomationRuleId

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.ISecurityInsightsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: Get, List
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -WorkspaceName
The name of the workspace.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.ISecurityInsightsIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IAutomationRule

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <ISecurityInsightsIdentity>`: Identity Parameter
  - `[ActionId <String>]`: Action ID
  - `[AlertRuleTemplateId <String>]`: Alert rule template ID
  - `[AutomationRuleId <String>]`: Automation rule ID
  - `[BookmarkId <String>]`: Bookmark ID
  - `[ConsentId <String>]`: consent ID
  - `[DataConnectorId <String>]`: Connector ID
  - `[EntityId <String>]`: entity ID
  - `[EntityQueryId <String>]`: entity query ID
  - `[EntityQueryTemplateId <String>]`: entity query template ID
  - `[Id <String>]`: Resource identity path
  - `[IncidentCommentId <String>]`: Incident comment ID
  - `[IncidentId <String>]`: Incident ID
  - `[MetadataName <String>]`: The Metadata name.
  - `[Name <String>]`: Threat intelligence indicator name field.
  - `[RelationName <String>]`: Relation Name
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[RuleId <String>]`: Alert rule ID
  - `[SentinelOnboardingStateName <String>]`: The Sentinel onboarding state name. Supports - default
  - `[SettingsName <String>]`: The setting name. Supports - Anomalies, EyesOn, EntityAnalytics, Ueba
  - `[SourceControlId <String>]`: Source control Id
  - `[SubscriptionId <String>]`: The ID of the target subscription.
  - `[WorkspaceName <String>]`: The name of the workspace.

## RELATED LINKS

