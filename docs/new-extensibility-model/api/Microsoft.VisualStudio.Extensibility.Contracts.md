<a name='assembly'></a>
# Microsoft.VisualStudio.Extensibility.Contracts

## Contents

- [ActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint')
  - [And(constraints)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-And-Microsoft-VisualStudio-Extensibility-ActivationConstraint[]- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.And(Microsoft.VisualStudio.Extensibility.ActivationConstraint[])')
  - [ClientContext(key,regexPattern)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ClientContext-Microsoft-VisualStudio-Extensibility-ClientContextKey,System-String- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.ClientContext(Microsoft.VisualStudio.Extensibility.ClientContextKey,System.String)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.Equals(Microsoft.VisualStudio.Extensibility.ActivationConstraint)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-GetHashCode 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.GetHashCode')
  - [Not(constraint)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-Not-Microsoft-VisualStudio-Extensibility-ActivationConstraint- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.Not(Microsoft.VisualStudio.Extensibility.ActivationConstraint)')
  - [Or(constraints)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-Or-Microsoft-VisualStudio-Extensibility-ActivationConstraint[]- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.Or(Microsoft.VisualStudio.Extensibility.ActivationConstraint[])')
  - [ProjectAddedItem(regexPattern)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ProjectAddedItem-System-String- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.ProjectAddedItem(System.String)')
  - [SolutionHasProjectBuildProperty(property,regexPattern)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionHasProjectBuildProperty-System-String,System-String- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.SolutionHasProjectBuildProperty(System.String,System.String)')
  - [SolutionHasProjectCapability(capability)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionHasProjectCapability-Microsoft-VisualStudio-Extensibility-ProjectCapability- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.SolutionHasProjectCapability(Microsoft.VisualStudio.Extensibility.ProjectCapability)')
  - [SolutionHasProjectFlavor(flavor)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionHasProjectFlavor-System-Guid- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.SolutionHasProjectFlavor(System.Guid)')
  - [SolutionState(state)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionState-Microsoft-VisualStudio-Extensibility-SolutionState- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.SolutionState(Microsoft.VisualStudio.Extensibility.SolutionState)')
  - [op_BitwiseAnd(a,b)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-op_BitwiseAnd-Microsoft-VisualStudio-Extensibility-ActivationConstraint,Microsoft-VisualStudio-Extensibility-ActivationConstraint- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.op_BitwiseAnd(Microsoft.VisualStudio.Extensibility.ActivationConstraint,Microsoft.VisualStudio.Extensibility.ActivationConstraint)')
  - [op_BitwiseOr(a,b)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-op_BitwiseOr-Microsoft-VisualStudio-Extensibility-ActivationConstraint,Microsoft-VisualStudio-Extensibility-ActivationConstraint- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.op_BitwiseOr(Microsoft.VisualStudio.Extensibility.ActivationConstraint,Microsoft.VisualStudio.Extensibility.ActivationConstraint)')
  - [op_LogicalNot(a)](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-op_LogicalNot-Microsoft-VisualStudio-Extensibility-ActivationConstraint- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.op_LogicalNot(Microsoft.VisualStudio.Extensibility.ActivationConstraint)')
- [ActivationConstraintExpression](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.ActivationConstraintExpression')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.ActivationConstraintExpression.Equals(Microsoft.VisualStudio.Extensibility.ActivationConstraint.ActivationConstraintExpression)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.ActivationConstraintExpression.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression-GetHashCode 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.ActivationConstraintExpression.GetHashCode')
- [AllowNullAttribute](#T-System-Diagnostics-CodeAnalysis-AllowNullAttribute 'System.Diagnostics.CodeAnalysis.AllowNullAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-AllowNullAttribute-#ctor 'System.Diagnostics.CodeAnalysis.AllowNullAttribute.#ctor')
- [AndActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.AndActivationConstraint')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.AndActivationConstraint.Equals(Microsoft.VisualStudio.Extensibility.ActivationConstraint.AndActivationConstraint)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.AndActivationConstraint.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint-GetHashCode 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.AndActivationConstraint.GetHashCode')
- [BaseCommandConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration')
  - [#ctor(displayName)](#M-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration.#ctor(System.String)')
  - [ClientContexts](#P-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-ClientContexts 'Microsoft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration.ClientContexts')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration.GetHashCode')
- [BaseControlConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration')
  - [#ctor(displayName)](#M-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration.#ctor(System.String)')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration.DisplayName')
  - [Placements](#P-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-Placements 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration.Placements')
  - [Priority](#P-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-Priority 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration.Priority')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration.GetHashCode')
- [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey')
  - [Custom(value)](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-Custom-System-String- 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Custom(System.String)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-Equals-Microsoft-VisualStudio-Extensibility-ClientContextKey- 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Equals(Microsoft.VisualStudio.Extensibility.ClientContextKey)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-GetHashCode 'Microsoft.VisualStudio.Extensibility.ClientContextKey.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-ToString 'Microsoft.VisualStudio.Extensibility.ClientContextKey.ToString')
  - [op_Equality(a,b)](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-op_Equality-Microsoft-VisualStudio-Extensibility-ClientContextKey,Microsoft-VisualStudio-Extensibility-ClientContextKey- 'Microsoft.VisualStudio.Extensibility.ClientContextKey.op_Equality(Microsoft.VisualStudio.Extensibility.ClientContextKey,Microsoft.VisualStudio.Extensibility.ClientContextKey)')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey.op_Implicit(System.String)~Microsoft.VisualStudio.Extensibility.ClientContextKey')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-op_Implicit-Microsoft-VisualStudio-Extensibility-ClientContextKey-~System-String 'Microsoft.VisualStudio.Extensibility.ClientContextKey.op_Implicit(Microsoft.VisualStudio.Extensibility.ClientContextKey)~System.String')
  - [op_Inequality(a,b)](#M-Microsoft-VisualStudio-Extensibility-ClientContextKey-op_Inequality-Microsoft-VisualStudio-Extensibility-ClientContextKey,Microsoft-VisualStudio-Extensibility-ClientContextKey- 'Microsoft.VisualStudio.Extensibility.ClientContextKey.op_Inequality(Microsoft.VisualStudio.Extensibility.ClientContextKey,Microsoft.VisualStudio.Extensibility.ClientContextKey)')
- [CommandConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration')
  - [#ctor(displayName)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.#ctor(System.String)')
  - [EnabledWhen](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-EnabledWhen 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.EnabledWhen')
  - [Flags](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Flags 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.Flags')
  - [Icon](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Icon 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.Icon')
  - [Shortcuts](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Shortcuts 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.Shortcuts')
  - [TooltipText](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-TooltipText 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.TooltipText')
  - [VisibleWhen](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-VisibleWhen 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.VisibleWhen')
  - [VsctCommandMapping](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-VsctCommandMapping 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.VsctCommandMapping')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration.GetHashCode')
- [CommandFlags](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandFlags 'Microsoft.VisualStudio.Extensibility.Commands.CommandFlags')
  - [CanSelect](#F-Microsoft-VisualStudio-Extensibility-Commands-CommandFlags-CanSelect 'Microsoft.VisualStudio.Extensibility.Commands.CommandFlags.CanSelect')
  - [CanToggle](#F-Microsoft-VisualStudio-Extensibility-Commands-CommandFlags-CanToggle 'Microsoft.VisualStudio.Extensibility.Commands.CommandFlags.CanToggle')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-CommandFlags-None 'Microsoft.VisualStudio.Extensibility.Commands.CommandFlags.None')
- [CommandGroupConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration')
  - [#ctor(placement)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement- 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement)')
  - [#ctor(placement,priority)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement,System-UInt32- 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement,System.UInt32)')
  - [#ctor()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-#ctor 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.#ctor')
  - [Children](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Children 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.Children')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Id 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.Id')
  - [Placement](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Placement 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.Placement')
  - [Priority](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Priority 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.Priority')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration.GetHashCode')
- [CommandIconConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration')
  - [#ctor(iconName,iconSettings)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-ImageMoniker,Microsoft-VisualStudio-Extensibility-Commands-IconSettings- 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.ImageMoniker,Microsoft.VisualStudio.Extensibility.Commands.IconSettings)')
  - [IconName](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-IconName 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration.IconName')
  - [IconSettings](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-IconSettings 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration.IconSettings')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration.GetHashCode')
- [CommandPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement')
  - [#ctor(parent)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-#ctor-Microsoft-VisualStudio-Extensibility-Commands-VsctId- 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.#ctor(Microsoft.VisualStudio.Extensibility.Commands.VsctId)')
  - [VsctParentId](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-VsctParentId 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.VsctParentId')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement- 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.Equals(Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.Equals(System.Object)')
  - [FromVsctParent(guid,id)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-FromVsctParent-System-Guid,System-UInt32- 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.FromVsctParent(System.Guid,System.UInt32)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.GetHashCode')
- [CommandShortcutConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration')
  - [#ctor(mod1,key1)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key- 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.Commands.ModifierKey,Microsoft.VisualStudio.Extensibility.Commands.Key)')
  - [#ctor(mod1,key1,activationConstraint)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key,System-Guid- 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.Commands.ModifierKey,Microsoft.VisualStudio.Extensibility.Commands.Key,System.Guid)')
  - [#ctor(mod1,key1,mod2,key2)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key,Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key- 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.Commands.ModifierKey,Microsoft.VisualStudio.Extensibility.Commands.Key,Microsoft.VisualStudio.Extensibility.Commands.ModifierKey,Microsoft.VisualStudio.Extensibility.Commands.Key)')
  - [#ctor(mod1,key1,mod2,key2,activationConstraint)](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key,Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key,System-Guid- 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.Commands.ModifierKey,Microsoft.VisualStudio.Extensibility.Commands.Key,Microsoft.VisualStudio.Extensibility.Commands.ModifierKey,Microsoft.VisualStudio.Extensibility.Commands.Key,System.Guid)')
  - [ActivationConstraint](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.ActivationConstraint')
  - [Key1](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Key1 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.Key1')
  - [Key2](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Key2 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.Key2')
  - [Mod1](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Mod1 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.Mod1')
  - [Mod2](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Mod2 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.Mod2')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration.GetHashCode')
- [CompileTimeEvaluationAttribute](#T-Microsoft-VisualStudio-Extensibility-CompileTimeEvaluationAttribute 'Microsoft.VisualStudio.Extensibility.CompileTimeEvaluationAttribute')
- [ContainerChild](#T-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild')
  - [#ctor(childIdentifier)](#M-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild.#ctor(System.String)')
  - [#ctor(group)](#M-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-#ctor-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild.#ctor(Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration)')
  - [ChildIdentifier](#P-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-ChildIdentifier 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild.ChildIdentifier')
  - [CommandGroupConfiguration](#P-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-CommandGroupConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild.CommandGroupConfiguration')
  - [IsSeparator](#P-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-IsSeparator 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild.IsSeparator')
  - [GetSeparatorId(owningFullClassName)](#M-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-GetSeparatorId-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild.GetSeparatorId(System.String)')
- [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement')
  - [Custom(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-Custom-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.Custom(System.String)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-Equals-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement- 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.Equals(Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-ToString 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.ToString')
  - [op_Equality(a,b)](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement,Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement- 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement,Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement)')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.op_Implicit(System.String)~Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-~System-String 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement)~System.String')
  - [op_Inequality(a,b)](#M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement,Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement- 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement,Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement)')
- [ControlContainerConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration')
  - [#ctor(displayName)](#M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.#ctor(System.String)')
  - [DisplayName](#P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-DisplayName 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.DisplayName')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Id 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.Id')
  - [Placements](#P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Placements 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.Placements')
  - [Priority](#P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Priority 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.Priority')
  - [TooltipText](#P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-TooltipText 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.TooltipText')
  - [Type](#P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Type 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.Type')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration.GetHashCode')
- [ControlContainerConfiguration\`1](#T-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration`1')
  - [#ctor(displayName)](#M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration`1.#ctor(System.String)')
  - [Children](#P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-Children 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration`1.Children')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-Equals-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration{`0}- 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration`1.Equals(Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration{`0})')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration`1.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration`1.GetHashCode')
- [ControlContainerType](#T-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerType 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerType')
  - [Menu](#F-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerType-Menu 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerType.Menu')
  - [Toolbar](#F-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerType-Toolbar 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerType.Toolbar')
- [DebuggerVisualizerProviderConfiguration](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration')
  - [#ctor(visualizerDisplayName,targetType)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-#ctor-System-String,System-Type- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration.#ctor(System.String,System.Type)')
  - [#ctor(visualizerDisplayName,targetType)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-#ctor-System-String,System-String- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration.#ctor(System.String,System.String)')
  - [#ctor(targets)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType[]- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType[])')
  - [Targets](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-Targets 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration.Targets')
  - [VisualizerObjectSourceType](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-VisualizerObjectSourceType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration.VisualizerObjectSourceType')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-Equals-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration.Equals(Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration.GetHashCode')
- [DisallowNullAttribute](#T-System-Diagnostics-CodeAnalysis-DisallowNullAttribute 'System.Diagnostics.CodeAnalysis.DisallowNullAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-DisallowNullAttribute-#ctor 'System.Diagnostics.CodeAnalysis.DisallowNullAttribute.#ctor')
- [Dock](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock')
  - [Bottom](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Bottom 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Bottom')
  - [Left](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Left 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Left')
  - [None](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-None 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.None')
  - [Right](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Right 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Right')
  - [Top](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Top 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Top')
- [DocumentFilter](#T-Microsoft-VisualStudio-Extensibility-DocumentFilter 'Microsoft.VisualStudio.Extensibility.DocumentFilter')
  - [DocumentType](#P-Microsoft-VisualStudio-Extensibility-DocumentFilter-DocumentType 'Microsoft.VisualStudio.Extensibility.DocumentFilter.DocumentType')
  - [Pattern](#P-Microsoft-VisualStudio-Extensibility-DocumentFilter-Pattern 'Microsoft.VisualStudio.Extensibility.DocumentFilter.Pattern')
  - [RelativePath](#P-Microsoft-VisualStudio-Extensibility-DocumentFilter-RelativePath 'Microsoft.VisualStudio.Extensibility.DocumentFilter.RelativePath')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-DocumentFilter-Equals-Microsoft-VisualStudio-Extensibility-DocumentFilter- 'Microsoft.VisualStudio.Extensibility.DocumentFilter.Equals(Microsoft.VisualStudio.Extensibility.DocumentFilter)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-DocumentFilter-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.DocumentFilter.Equals(System.Object)')
  - [FromDocumentType(documentType)](#M-Microsoft-VisualStudio-Extensibility-DocumentFilter-FromDocumentType-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration- 'Microsoft.VisualStudio.Extensibility.DocumentFilter.FromDocumentType(Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration)')
  - [FromDocumentType(documentType)](#M-Microsoft-VisualStudio-Extensibility-DocumentFilter-FromDocumentType-Microsoft-VisualStudio-Extensibility-Editor-DocumentType- 'Microsoft.VisualStudio.Extensibility.DocumentFilter.FromDocumentType(Microsoft.VisualStudio.Extensibility.Editor.DocumentType)')
  - [FromGlobPattern(pattern,relativePath)](#M-Microsoft-VisualStudio-Extensibility-DocumentFilter-FromGlobPattern-System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.DocumentFilter.FromGlobPattern(System.String,System.Boolean)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-DocumentFilter-GetHashCode 'Microsoft.VisualStudio.Extensibility.DocumentFilter.GetHashCode')
- [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType')
  - [Custom(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-Custom-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.Custom(System.String)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-Equals-Microsoft-VisualStudio-Extensibility-Editor-DocumentType- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.Equals(Microsoft.VisualStudio.Extensibility.Editor.DocumentType)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-ToString 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.ToString')
  - [op_Equality(a,b)](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-DocumentType,Microsoft-VisualStudio-Extensibility-Editor-DocumentType- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.DocumentType,Microsoft.VisualStudio.Extensibility.Editor.DocumentType)')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.op_Implicit(System.String)~Microsoft.VisualStudio.Extensibility.Editor.DocumentType')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-~System-String 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.DocumentType)~System.String')
  - [op_Inequality(a,b)](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-DocumentType,Microsoft-VisualStudio-Extensibility-Editor-DocumentType- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.DocumentType,Microsoft.VisualStudio.Extensibility.Editor.DocumentType)')
- [DocumentTypeConfiguration](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration')
  - [#ctor(name)](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration.#ctor(System.String)')
  - [BaseDocumentType](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-BaseDocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration.BaseDocumentType')
  - [FileExtensions](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-FileExtensions 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration.FileExtensions')
  - [Name](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-Name 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration.Name')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration.GetHashCode')
- [DoesNotReturnAttribute](#T-System-Diagnostics-CodeAnalysis-DoesNotReturnAttribute 'System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-DoesNotReturnAttribute-#ctor 'System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute.#ctor')
- [DoesNotReturnIfAttribute](#T-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute')
  - [#ctor(parameterValue)](#M-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute-#ctor-System-Boolean- 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.#ctor(System.Boolean)')
  - [ParameterValue](#P-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute-ParameterValue 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute.ParameterValue')
- [DynamicCommandAnchorConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchorConfiguration')
  - [#ctor(displayName)](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchorConfiguration.#ctor(System.String)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchorConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchorConfiguration)')
- [EqualityUtilities](#T-Microsoft-VisualStudio-Extensibility-EqualityUtilities 'Microsoft.VisualStudio.Extensibility.EqualityUtilities')
  - [ArrayEquals\`\`1(array1,array2)](#M-Microsoft-VisualStudio-Extensibility-EqualityUtilities-ArrayEquals``1-``0[],``0[]- 'Microsoft.VisualStudio.Extensibility.EqualityUtilities.ArrayEquals``1(``0[],``0[])')
  - [GetEnumerableHash\`\`1(enumerable)](#M-Microsoft-VisualStudio-Extensibility-EqualityUtilities-GetEnumerableHash``1-System-Collections-Generic-IEnumerable{``0}- 'Microsoft.VisualStudio.Extensibility.EqualityUtilities.GetEnumerableHash``1(System.Collections.Generic.IEnumerable{``0})')
- [ExtensionConfiguration](#T-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration 'Microsoft.VisualStudio.Extensibility.ExtensionConfiguration')
  - [LoadedWhen](#P-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-LoadedWhen 'Microsoft.VisualStudio.Extensibility.ExtensionConfiguration.LoadedWhen')
  - [RequiresInProcessHosting](#P-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-RequiresInProcessHosting 'Microsoft.VisualStudio.Extensibility.ExtensionConfiguration.RequiresInProcessHosting')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-Equals-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration- 'Microsoft.VisualStudio.Extensibility.ExtensionConfiguration.Equals(Microsoft.VisualStudio.Extensibility.ExtensionConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ExtensionConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.ExtensionConfiguration.GetHashCode')
- [ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute')
  - [#ctor(rpcContractType,wrapperObjectType)](#M-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-#ctor-System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.#ctor(System.Type,System.Type)')
  - [RpcContractType](#P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-RpcContractType 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.RpcContractType')
  - [WrapperObjectType](#P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-WrapperObjectType 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute.WrapperObjectType')
- [ExtensionPartAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute')
  - [#ctor(interfaceType,configurationProperties)](#M-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-#ctor-System-Type,System-String[]- 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute.#ctor(System.Type,System.String[])')
  - [ConfigurationProperties](#P-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-ConfigurationProperties 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute.ConfigurationProperties')
  - [InterfaceType](#P-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-InterfaceType 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute.InterfaceType')
- [GroupChild](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupChild 'Microsoft.VisualStudio.Extensibility.Commands.GroupChild')
  - [ChildIdentifier](#P-Microsoft-VisualStudio-Extensibility-Commands-GroupChild-ChildIdentifier 'Microsoft.VisualStudio.Extensibility.Commands.GroupChild.ChildIdentifier')
  - [Anchor\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupChild-Anchor``1 'Microsoft.VisualStudio.Extensibility.Commands.GroupChild.Anchor``1')
  - [Command\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupChild-Command``1 'Microsoft.VisualStudio.Extensibility.Commands.GroupChild.Command``1')
  - [Menu(childControl)](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupChild-Menu-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.GroupChild.Menu(Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration)')
- [GroupPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement')
  - [#ctor(parent)](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-#ctor-Microsoft-VisualStudio-Extensibility-Commands-VsctId- 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.#ctor(Microsoft.VisualStudio.Extensibility.Commands.VsctId)')
  - [#ctor(parent,relativeDisplayOrder)](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-#ctor-System-String,System-UInt32- 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.#ctor(System.String,System.UInt32)')
  - [ParentIdentifier](#P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-ParentIdentifier 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.ParentIdentifier')
  - [RelativeDisplayOrder](#P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-RelativeDisplayOrder 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.RelativeDisplayOrder')
  - [VsctParentId](#P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-VsctParentId 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.VsctParentId')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-Equals-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement- 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.Equals(Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.GetHashCode')
  - [Menu(configuration,relativeDisplayOrder)](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-Menu-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration,System-UInt32- 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.Menu(Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration,System.UInt32)')
  - [Toolbar(configuration,relativeDisplayOrder)](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-Toolbar-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration,System-UInt32- 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.Toolbar(Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration,System.UInt32)')
  - [VsctParent(guid,id)](#M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-VsctParent-System-Guid,System-UInt32- 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.VsctParent(System.Guid,System.UInt32)')
- [ITextViewMarginProviderBase](#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProviderBase 'Microsoft.VisualStudio.Extensibility.Editor.ITextViewMarginProviderBase')
- [IVisualStudioContributionClass](#T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionClass 'Microsoft.VisualStudio.Extensibility.IVisualStudioContributionClass')
- [IVisualStudioContributionProperty](#T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionProperty 'Microsoft.VisualStudio.Extensibility.IVisualStudioContributionProperty')
- [IconSettings](#T-Microsoft-VisualStudio-Extensibility-Commands-IconSettings 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings')
  - [IconAndText](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconAndText 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.IconAndText')
  - [IconOnly](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconOnly 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.IconOnly')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-None 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings.None')
- [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker')
  - [Custom(value)](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-Custom-System-String- 'Microsoft.VisualStudio.Extensibility.ImageMoniker.Custom(System.String)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ImageMoniker.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-Equals-Microsoft-VisualStudio-Extensibility-ImageMoniker- 'Microsoft.VisualStudio.Extensibility.ImageMoniker.Equals(Microsoft.VisualStudio.Extensibility.ImageMoniker)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-GetHashCode 'Microsoft.VisualStudio.Extensibility.ImageMoniker.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-ToString 'Microsoft.VisualStudio.Extensibility.ImageMoniker.ToString')
  - [op_Equality(a,b)](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-op_Equality-Microsoft-VisualStudio-Extensibility-ImageMoniker,Microsoft-VisualStudio-Extensibility-ImageMoniker- 'Microsoft.VisualStudio.Extensibility.ImageMoniker.op_Equality(Microsoft.VisualStudio.Extensibility.ImageMoniker,Microsoft.VisualStudio.Extensibility.ImageMoniker)')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker.op_Implicit(System.String)~Microsoft.VisualStudio.Extensibility.ImageMoniker')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-op_Implicit-Microsoft-VisualStudio-Extensibility-ImageMoniker-~System-String 'Microsoft.VisualStudio.Extensibility.ImageMoniker.op_Implicit(Microsoft.VisualStudio.Extensibility.ImageMoniker)~System.String')
  - [op_Inequality(a,b)](#M-Microsoft-VisualStudio-Extensibility-ImageMoniker-op_Inequality-Microsoft-VisualStudio-Extensibility-ImageMoniker,Microsoft-VisualStudio-Extensibility-ImageMoniker- 'Microsoft.VisualStudio.Extensibility.ImageMoniker.op_Inequality(Microsoft.VisualStudio.Extensibility.ImageMoniker,Microsoft.VisualStudio.Extensibility.ImageMoniker)')
- [IsExternalInit](#T-System-Runtime-CompilerServices-IsExternalInit 'System.Runtime.CompilerServices.IsExternalInit')
- [Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key')
  - [None](#P-Microsoft-VisualStudio-Extensibility-Commands-Key-None 'Microsoft.VisualStudio.Extensibility.Commands.Key.None')
  - [VK_LBUTTON](#P-Microsoft-VisualStudio-Extensibility-Commands-Key-VK_LBUTTON 'Microsoft.VisualStudio.Extensibility.Commands.Key.VK_LBUTTON')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-Key-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.Key.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-Key-Equals-Microsoft-VisualStudio-Extensibility-Commands-Key- 'Microsoft.VisualStudio.Extensibility.Commands.Key.Equals(Microsoft.VisualStudio.Extensibility.Commands.Key)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-Key-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.Key.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-Extensibility-Commands-Key-ToString 'Microsoft.VisualStudio.Extensibility.Commands.Key.ToString')
  - [op_Equality(a,b)](#M-Microsoft-VisualStudio-Extensibility-Commands-Key-op_Equality-Microsoft-VisualStudio-Extensibility-Commands-Key,Microsoft-VisualStudio-Extensibility-Commands-Key- 'Microsoft.VisualStudio.Extensibility.Commands.Key.op_Equality(Microsoft.VisualStudio.Extensibility.Commands.Key,Microsoft.VisualStudio.Extensibility.Commands.Key)')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-Commands-Key-op_Implicit-Microsoft-VisualStudio-Extensibility-Commands-Key-~System-String 'Microsoft.VisualStudio.Extensibility.Commands.Key.op_Implicit(Microsoft.VisualStudio.Extensibility.Commands.Key)~System.String')
  - [op_Inequality(a,b)](#M-Microsoft-VisualStudio-Extensibility-Commands-Key-op_Inequality-Microsoft-VisualStudio-Extensibility-Commands-Key,Microsoft-VisualStudio-Extensibility-Commands-Key- 'Microsoft.VisualStudio.Extensibility.Commands.Key.op_Inequality(Microsoft.VisualStudio.Extensibility.Commands.Key,Microsoft.VisualStudio.Extensibility.Commands.Key)')
- [KnownPlacements](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-KnownPlacements 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.KnownPlacements')
- [KnownPlacements](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-KnownPlacements 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.KnownPlacements')
  - [ExtensionsMenu](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-KnownPlacements-ExtensionsMenu 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.KnownPlacements.ExtensionsMenu')
  - [ToolsMenu](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-KnownPlacements-ToolsMenu 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.KnownPlacements.ToolsMenu')
  - [ViewOtherWindowsMenu](#P-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-KnownPlacements-ViewOtherWindowsMenu 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement.KnownPlacements.ViewOtherWindowsMenu')
  - [ExtensionsMenu](#P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-KnownPlacements-ExtensionsMenu 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.KnownPlacements.ExtensionsMenu')
  - [ToolsMenu](#P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-KnownPlacements-ToolsMenu 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.KnownPlacements.ToolsMenu')
  - [ViewOtherWindowsMenu](#P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-KnownPlacements-ViewOtherWindowsMenu 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement.KnownPlacements.ViewOtherWindowsMenu')
- [KnownValues](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues')
- [KnownValues](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.KnownValues')
- [KnownValues](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues')
- [KnownValues](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker-KnownValues 'Microsoft.VisualStudio.Extensibility.ImageMoniker.KnownValues')
  - [Bottom](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Bottom 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.Bottom')
  - [BottomControl](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-BottomControl 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.BottomControl')
  - [BottomRightCorner](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-BottomRightCorner 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.BottomRightCorner')
  - [HorizontalScrollBarContainer](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-HorizontalScrollBarContainer 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.HorizontalScrollBarContainer')
  - [Left](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Left 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.Left')
  - [LeftSelection](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-LeftSelection 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.LeftSelection')
  - [Right](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Right 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.Right')
  - [RightControl](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-RightControl 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.RightControl')
  - [Top](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Top 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.Top')
  - [VerticalScrollBar](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-VerticalScrollBar 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.VerticalScrollBar')
  - [VerticalScrollBarContainer](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-VerticalScrollBarContainer 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.VerticalScrollBarContainer')
  - [Code](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues-Code 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.KnownValues.Code')
  - [PlainText](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues-PlainText 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.KnownValues.PlainText')
  - [Text](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues-Text 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.KnownValues.Text')
  - [ChrMargin](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-ChrMargin 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.ChrMargin')
  - [ColMargin](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-ColMargin 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.ColMargin')
  - [FileHealthIndicator](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-FileHealthIndicator 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.FileHealthIndicator')
  - [Glyph](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-Glyph 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.Glyph')
  - [HorizontalScrollBar](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-HorizontalScrollBar 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.HorizontalScrollBar')
  - [IndentationCharacterMargin](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-IndentationCharacterMargin 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.IndentationCharacterMargin')
  - [InsertModeMargin](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-InsertModeMargin 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.InsertModeMargin')
  - [LineEndingMargin](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-LineEndingMargin 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.LineEndingMargin')
  - [LineNumber](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-LineNumber 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.LineNumber')
  - [Outlining](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-Outlining 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.Outlining')
  - [OverviewChangeTracking](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-OverviewChangeTracking 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.OverviewChangeTracking')
  - [OverviewError](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-OverviewError 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.OverviewError')
  - [OverviewMark](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-OverviewMark 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.OverviewMark')
  - [OverviewSourceImage](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-OverviewSourceImage 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.OverviewSourceImage')
  - [RowMargin](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-RowMargin 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.RowMargin')
  - [SelectionStateMargin](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-SelectionStateMargin 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.SelectionStateMargin')
  - [Spacer](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-Spacer 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.Spacer')
  - [Suggestion](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-Suggestion 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.Suggestion')
  - [VerticalScrollBar](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-VerticalScrollBar 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.VerticalScrollBar')
  - [ZoomControl](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-ZoomControl 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.ZoomControl')
- [LocalizableStringAttribute](#T-Microsoft-VisualStudio-Extensibility-LocalizableStringAttribute 'Microsoft.VisualStudio.Extensibility.LocalizableStringAttribute')
- [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement')
  - [Custom(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-Custom-System-String- 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.Custom(System.String)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-Equals-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement- 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.Equals(Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement)')
  - [FromTextViewMarginProvider\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-FromTextViewMarginProvider``1 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.FromTextViewMarginProvider``1')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-ToString 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.ToString')
  - [op_Equality(a,b)](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement,Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement- 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.op_Equality(Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement,Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement)')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.op_Implicit(System.String)~Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-~System-String 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.op_Implicit(Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement)~System.String')
  - [op_Inequality(a,b)](#M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement,Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement- 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.op_Inequality(Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement,Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement)')
- [MaybeNullAttribute](#T-System-Diagnostics-CodeAnalysis-MaybeNullAttribute 'System.Diagnostics.CodeAnalysis.MaybeNullAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-MaybeNullAttribute-#ctor 'System.Diagnostics.CodeAnalysis.MaybeNullAttribute.#ctor')
- [MaybeNullWhenAttribute](#T-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute')
  - [#ctor(returnValue)](#M-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute-#ctor-System-Boolean- 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.#ctor(System.Boolean)')
  - [ReturnValue](#P-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute-ReturnValue 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue')
- [MemberNotNullAttribute](#T-System-Diagnostics-CodeAnalysis-MemberNotNullAttribute 'System.Diagnostics.CodeAnalysis.MemberNotNullAttribute')
  - [#ctor(member)](#M-System-Diagnostics-CodeAnalysis-MemberNotNullAttribute-#ctor-System-String- 'System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.#ctor(System.String)')
  - [#ctor(members)](#M-System-Diagnostics-CodeAnalysis-MemberNotNullAttribute-#ctor-System-String[]- 'System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.#ctor(System.String[])')
  - [Members](#P-System-Diagnostics-CodeAnalysis-MemberNotNullAttribute-Members 'System.Diagnostics.CodeAnalysis.MemberNotNullAttribute.Members')
- [MemberNotNullWhenAttribute](#T-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute')
  - [#ctor(returnValue,member)](#M-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-#ctor-System-Boolean,System-String- 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.#ctor(System.Boolean,System.String)')
  - [#ctor(returnValue,members)](#M-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-#ctor-System-Boolean,System-String[]- 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.#ctor(System.Boolean,System.String[])')
  - [Members](#P-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-Members 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.Members')
  - [ReturnValue](#P-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-ReturnValue 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.ReturnValue')
- [MenuChild](#T-Microsoft-VisualStudio-Extensibility-Commands-MenuChild 'Microsoft.VisualStudio.Extensibility.Commands.MenuChild')
  - [Separator](#P-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Separator 'Microsoft.VisualStudio.Extensibility.Commands.MenuChild.Separator')
  - [Anchor\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Anchor``1 'Microsoft.VisualStudio.Extensibility.Commands.MenuChild.Anchor``1')
  - [Command\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Command``1 'Microsoft.VisualStudio.Extensibility.Commands.MenuChild.Command``1')
  - [Group(commandGroupConfiguration)](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Group-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.MenuChild.Group(Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration)')
  - [Group(groupChildren)](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Group-Microsoft-VisualStudio-Extensibility-Commands-GroupChild[]- 'Microsoft.VisualStudio.Extensibility.Commands.MenuChild.Group(Microsoft.VisualStudio.Extensibility.Commands.GroupChild[])')
  - [Menu(menuConfiguration)](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Menu-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.MenuChild.Menu(Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration)')
- [MenuConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration')
  - [#ctor(displayName)](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration.#ctor(System.String)')
  - [Type](#P-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-Type 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration.Type')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration.GetHashCode')
- [ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey')
  - [Control](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-Control 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.Control')
  - [ControlShift](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-ControlShift 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.ControlShift')
  - [ControlShiftLeftAlt](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-ControlShiftLeftAlt 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.ControlShiftLeftAlt')
  - [LeftAlt](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-LeftAlt 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.LeftAlt')
  - [None](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-None 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.None')
  - [Shift](#F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-Shift 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey.Shift')
- [NotActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.NotActivationConstraint')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.NotActivationConstraint.Equals(Microsoft.VisualStudio.Extensibility.ActivationConstraint.NotActivationConstraint)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.NotActivationConstraint.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint-GetHashCode 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.NotActivationConstraint.GetHashCode')
- [NotNullAttribute](#T-System-Diagnostics-CodeAnalysis-NotNullAttribute 'System.Diagnostics.CodeAnalysis.NotNullAttribute')
  - [#ctor()](#M-System-Diagnostics-CodeAnalysis-NotNullAttribute-#ctor 'System.Diagnostics.CodeAnalysis.NotNullAttribute.#ctor')
- [NotNullIfNotNullAttribute](#T-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute')
  - [#ctor(parameterName)](#M-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute-#ctor-System-String- 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.#ctor(System.String)')
  - [ParameterName](#P-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute-ParameterName 'System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute.ParameterName')
- [NotNullWhenAttribute](#T-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute')
  - [#ctor(returnValue)](#M-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute-#ctor-System-Boolean- 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.#ctor(System.Boolean)')
  - [ReturnValue](#P-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute-ReturnValue 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue')
- [OrActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.OrActivationConstraint')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.OrActivationConstraint.Equals(Microsoft.VisualStudio.Extensibility.ActivationConstraint.OrActivationConstraint)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.OrActivationConstraint.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint-GetHashCode 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.OrActivationConstraint.GetHashCode')
- [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability')
  - [AppDesigner](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-AppDesigner 'Microsoft.VisualStudio.Extensibility.ProjectCapability.AppDesigner')
  - [AssemblyReferences](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-AssemblyReferences 'Microsoft.VisualStudio.Extensibility.ProjectCapability.AssemblyReferences')
  - [COMReferences](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-COMReferences 'Microsoft.VisualStudio.Extensibility.ProjectCapability.COMReferences')
  - [CPS](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-CPS 'Microsoft.VisualStudio.Extensibility.ProjectCapability.CPS')
  - [CSharp](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-CSharp 'Microsoft.VisualStudio.Extensibility.ProjectCapability.CSharp')
  - [Cordova](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-Cordova 'Microsoft.VisualStudio.Extensibility.ProjectCapability.Cordova')
  - [DeclaredSourceItems](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-DeclaredSourceItems 'Microsoft.VisualStudio.Extensibility.ProjectCapability.DeclaredSourceItems')
  - [DependenciesTree](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-DependenciesTree 'Microsoft.VisualStudio.Extensibility.ProjectCapability.DependenciesTree')
  - [DeploymentProject](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-DeploymentProject 'Microsoft.VisualStudio.Extensibility.ProjectCapability.DeploymentProject')
  - [EditAndContinue](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-EditAndContinue 'Microsoft.VisualStudio.Extensibility.ProjectCapability.EditAndContinue')
  - [FabricApplication](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-FabricApplication 'Microsoft.VisualStudio.Extensibility.ProjectCapability.FabricApplication')
  - [FileSystemBasedCordovaProject](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-FileSystemBasedCordovaProject 'Microsoft.VisualStudio.Extensibility.ProjectCapability.FileSystemBasedCordovaProject')
  - [FolderPublish](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-FolderPublish 'Microsoft.VisualStudio.Extensibility.ProjectCapability.FolderPublish')
  - [HandlesOwnReload](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-HandlesOwnReload 'Microsoft.VisualStudio.Extensibility.ProjectCapability.HandlesOwnReload')
  - [JavaScript](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScript 'Microsoft.VisualStudio.Extensibility.ProjectCapability.JavaScript')
  - [JavaScriptProject](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptProject 'Microsoft.VisualStudio.Extensibility.ProjectCapability.JavaScriptProject')
  - [JavaScriptUAPProject](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptUAPProject 'Microsoft.VisualStudio.Extensibility.ProjectCapability.JavaScriptUAPProject')
  - [JavaScriptWJProject](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptWJProject 'Microsoft.VisualStudio.Extensibility.ProjectCapability.JavaScriptWJProject')
  - [JavaScriptWindowsAppContainerProject](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptWindowsAppContainerProject 'Microsoft.VisualStudio.Extensibility.ProjectCapability.JavaScriptWindowsAppContainerProject')
  - [JavaScriptWindowsPhoneProject](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptWindowsPhoneProject 'Microsoft.VisualStudio.Extensibility.ProjectCapability.JavaScriptWindowsPhoneProject')
  - [LSJavaScript_v45](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-LSJavaScript_v45 'Microsoft.VisualStudio.Extensibility.ProjectCapability.LSJavaScript_v45')
  - [LaunchProfiles](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-LaunchProfiles 'Microsoft.VisualStudio.Extensibility.ProjectCapability.LaunchProfiles')
  - [MultiTarget](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-MultiTarget 'Microsoft.VisualStudio.Extensibility.ProjectCapability.MultiTarget')
  - [NoGeneralDependentFileIcon](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-NoGeneralDependentFileIcon 'Microsoft.VisualStudio.Extensibility.ProjectCapability.NoGeneralDependentFileIcon')
  - [OpenProjectFile](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-OpenProjectFile 'Microsoft.VisualStudio.Extensibility.ProjectCapability.OpenProjectFile')
  - [PackageReferences](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-PackageReferences 'Microsoft.VisualStudio.Extensibility.ProjectCapability.PackageReferences')
  - [PerPlatformCompilation](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-PerPlatformCompilation 'Microsoft.VisualStudio.Extensibility.ProjectCapability.PerPlatformCompilation')
  - [ProjectReferences](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ProjectReferences 'Microsoft.VisualStudio.Extensibility.ProjectCapability.ProjectReferences')
  - [ReferenceManagerAssemblies](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerAssemblies 'Microsoft.VisualStudio.Extensibility.ProjectCapability.ReferenceManagerAssemblies')
  - [ReferenceManagerBrowse](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerBrowse 'Microsoft.VisualStudio.Extensibility.ProjectCapability.ReferenceManagerBrowse')
  - [ReferenceManagerCOM](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerCOM 'Microsoft.VisualStudio.Extensibility.ProjectCapability.ReferenceManagerCOM')
  - [ReferenceManagerProjects](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerProjects 'Microsoft.VisualStudio.Extensibility.ProjectCapability.ReferenceManagerProjects')
  - [ReferenceManagerSharedProjects](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerSharedProjects 'Microsoft.VisualStudio.Extensibility.ProjectCapability.ReferenceManagerSharedProjects')
  - [ReferenceManagerWinRT](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerWinRT 'Microsoft.VisualStudio.Extensibility.ProjectCapability.ReferenceManagerWinRT')
  - [SDKReferences](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-SDKReferences 'Microsoft.VisualStudio.Extensibility.ProjectCapability.SDKReferences')
  - [SharedProjectReferences](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-SharedProjectReferences 'Microsoft.VisualStudio.Extensibility.ProjectCapability.SharedProjectReferences')
  - [TestContainer](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-TestContainer 'Microsoft.VisualStudio.Extensibility.ProjectCapability.TestContainer')
  - [TypeScript](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-TypeScript 'Microsoft.VisualStudio.Extensibility.ProjectCapability.TypeScript')
  - [UseFileGlobs](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-UseFileGlobs 'Microsoft.VisualStudio.Extensibility.ProjectCapability.UseFileGlobs')
  - [UserSourceItems](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-UserSourceItems 'Microsoft.VisualStudio.Extensibility.ProjectCapability.UserSourceItems')
  - [VB](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-VB 'Microsoft.VisualStudio.Extensibility.ProjectCapability.VB')
  - [VisualC](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-VisualC 'Microsoft.VisualStudio.Extensibility.ProjectCapability.VisualC')
  - [WinRTReferences](#P-Microsoft-VisualStudio-Extensibility-ProjectCapability-WinRTReferences 'Microsoft.VisualStudio.Extensibility.ProjectCapability.WinRTReferences')
  - [Custom(value)](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-Custom-System-String- 'Microsoft.VisualStudio.Extensibility.ProjectCapability.Custom(System.String)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ProjectCapability.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-Equals-Microsoft-VisualStudio-Extensibility-ProjectCapability- 'Microsoft.VisualStudio.Extensibility.ProjectCapability.Equals(Microsoft.VisualStudio.Extensibility.ProjectCapability)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-GetHashCode 'Microsoft.VisualStudio.Extensibility.ProjectCapability.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-ToString 'Microsoft.VisualStudio.Extensibility.ProjectCapability.ToString')
  - [op_Equality(a,b)](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-op_Equality-Microsoft-VisualStudio-Extensibility-ProjectCapability,Microsoft-VisualStudio-Extensibility-ProjectCapability- 'Microsoft.VisualStudio.Extensibility.ProjectCapability.op_Equality(Microsoft.VisualStudio.Extensibility.ProjectCapability,Microsoft.VisualStudio.Extensibility.ProjectCapability)')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability.op_Implicit(System.String)~Microsoft.VisualStudio.Extensibility.ProjectCapability')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-op_Implicit-Microsoft-VisualStudio-Extensibility-ProjectCapability-~System-String 'Microsoft.VisualStudio.Extensibility.ProjectCapability.op_Implicit(Microsoft.VisualStudio.Extensibility.ProjectCapability)~System.String')
  - [op_Inequality(a,b)](#M-Microsoft-VisualStudio-Extensibility-ProjectCapability-op_Inequality-Microsoft-VisualStudio-Extensibility-ProjectCapability,Microsoft-VisualStudio-Extensibility-ProjectCapability- 'Microsoft.VisualStudio.Extensibility.ProjectCapability.op_Inequality(Microsoft.VisualStudio.Extensibility.ProjectCapability,Microsoft.VisualStudio.Extensibility.ProjectCapability)')
- [Resources](#T-Microsoft-VisualStudio-Extensibility-Contracts-Resources 'Microsoft.VisualStudio.Extensibility.Contracts.Resources')
  - [CommandIdAlreadyRegistered](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-CommandIdAlreadyRegistered 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.CommandIdAlreadyRegistered')
  - [ContainerChildArgumentException](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ContainerChildArgumentException 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ContainerChildArgumentException')
  - [Culture](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-Culture 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.Culture')
  - [ErrorCanOnlyBeInvokedAtCompileTime](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorCanOnlyBeInvokedAtCompileTime 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorCanOnlyBeInvokedAtCompileTime')
  - [ErrorDebuggerVisualizersOnlySupportConcreteTypes](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDebuggerVisualizersOnlySupportConcreteTypes 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorDebuggerVisualizersOnlySupportConcreteTypes')
  - [ErrorDebuggerVisualizersOnlySupportUnboundGenerics](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDebuggerVisualizersOnlySupportUnboundGenerics 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorDebuggerVisualizersOnlySupportUnboundGenerics')
  - [ErrorDocumentTypeAlreadyDefined](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDocumentTypeAlreadyDefined 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorDocumentTypeAlreadyDefined')
  - [ErrorDuplicatedBaseDocumentType](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDuplicatedBaseDocumentType 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorDuplicatedBaseDocumentType')
  - [ErrorDuplicatedExtension](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDuplicatedExtension 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorDuplicatedExtension')
  - [ErrorFileExtensionCannotBeNullOrEmpty](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorFileExtensionCannotBeNullOrEmpty 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorFileExtensionCannotBeNullOrEmpty')
  - [ErrorFileExtensionsMustStartWithADot](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorFileExtensionsMustStartWithADot 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorFileExtensionsMustStartWithADot')
  - [ErrorMessageDocumentTypeAlreadyDefined](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMessageDocumentTypeAlreadyDefined 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorMessageDocumentTypeAlreadyDefined')
  - [ErrorMessageMissingExtensionClass](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMessageMissingExtensionClass 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorMessageMissingExtensionClass')
  - [ErrorMessageMultipleExtensionClasses](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMessageMultipleExtensionClasses 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorMessageMultipleExtensionClasses')
  - [ErrorMissingExtensionClass](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMissingExtensionClass 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorMissingExtensionClass')
  - [ErrorMultipleExtensionClasses](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMultipleExtensionClasses 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorMultipleExtensionClasses')
  - [ErrorMustImplementITextViewMarginProvider](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMustImplementITextViewMarginProvider 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ErrorMustImplementITextViewMarginProvider')
  - [InvalidVersionString](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-InvalidVersionString 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.InvalidVersionString')
  - [PriorityIsOnlyForVsctPlacements](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-PriorityIsOnlyForVsctPlacements 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.PriorityIsOnlyForVsctPlacements')
  - [ResourceManager](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ResourceManager 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.ResourceManager')
  - [TypeDoesNotExtendOtherType](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-TypeDoesNotExtendOtherType 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.TypeDoesNotExtendOtherType')
  - [UnsupportedDocumentMoniker](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-UnsupportedDocumentMoniker 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.UnsupportedDocumentMoniker')
  - [WarningCouldntFindImageAssetDirectory](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-WarningCouldntFindImageAssetDirectory 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.WarningCouldntFindImageAssetDirectory')
  - [WarningMessageCouldntFindImageAssetDirectory](#P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-WarningMessageCouldntFindImageAssetDirectory 'Microsoft.VisualStudio.Extensibility.Contracts.Resources.WarningMessageCouldntFindImageAssetDirectory')
- [ServiceFactoryRegistrationAttribute](#T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute')
  - [#ctor(serviceName,serviceVersion,factoryType,instanceType,interfaceType)](#M-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-#ctor-System-String,System-String,System-Type,System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.#ctor(System.String,System.String,System.Type,System.Type,System.Type)')
  - [FactoryType](#P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-FactoryType 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.FactoryType')
  - [InstanceType](#P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-InstanceType 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.InstanceType')
  - [InterfaceType](#P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-InterfaceType 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.InterfaceType')
  - [Moniker](#P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-Moniker 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute.Moniker')
- [ServiceHubServiceMoniker](#T-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker 'Microsoft.VisualStudio.Extensibility.ServiceHubServiceMoniker')
  - [#ctor(name,version)](#M-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker-#ctor-System-String,System-String- 'Microsoft.VisualStudio.Extensibility.ServiceHubServiceMoniker.#ctor(System.String,System.String)')
  - [Name](#P-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker-Name 'Microsoft.VisualStudio.Extensibility.ServiceHubServiceMoniker.Name')
  - [Version](#P-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker-Version 'Microsoft.VisualStudio.Extensibility.ServiceHubServiceMoniker.Version')
- [Shell](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Shell')
  - [ActiveEditorContentType](#P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveEditorContentType 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Shell.ActiveEditorContentType')
  - [ActiveEditorFileName](#P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveEditorFileName 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Shell.ActiveEditorFileName')
  - [ActiveSelectionFileName](#P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveSelectionFileName 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Shell.ActiveSelectionFileName')
  - [ActiveSelectionPath](#P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveSelectionPath 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Shell.ActiveSelectionPath')
  - [ActiveSelectionUri](#P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveSelectionUri 'Microsoft.VisualStudio.Extensibility.ClientContextKey.Shell.ActiveSelectionUri')
- [SolutionState](#T-Microsoft-VisualStudio-Extensibility-SolutionState 'Microsoft.VisualStudio.Extensibility.SolutionState')
  - [Building](#F-Microsoft-VisualStudio-Extensibility-SolutionState-Building 'Microsoft.VisualStudio.Extensibility.SolutionState.Building')
  - [Empty](#F-Microsoft-VisualStudio-Extensibility-SolutionState-Empty 'Microsoft.VisualStudio.Extensibility.SolutionState.Empty')
  - [Exists](#F-Microsoft-VisualStudio-Extensibility-SolutionState-Exists 'Microsoft.VisualStudio.Extensibility.SolutionState.Exists')
  - [FullyLoaded](#F-Microsoft-VisualStudio-Extensibility-SolutionState-FullyLoaded 'Microsoft.VisualStudio.Extensibility.SolutionState.FullyLoaded')
  - [MultipleProject](#F-Microsoft-VisualStudio-Extensibility-SolutionState-MultipleProject 'Microsoft.VisualStudio.Extensibility.SolutionState.MultipleProject')
  - [NoSolution](#F-Microsoft-VisualStudio-Extensibility-SolutionState-NoSolution 'Microsoft.VisualStudio.Extensibility.SolutionState.NoSolution')
  - [SingleProject](#F-Microsoft-VisualStudio-Extensibility-SolutionState-SingleProject 'Microsoft.VisualStudio.Extensibility.SolutionState.SingleProject')
- [StringBasedEnumAttribute](#T-Microsoft-VisualStudio-Extensibility-Internal-StringBasedEnumAttribute 'Microsoft.VisualStudio.Extensibility.Internal.StringBasedEnumAttribute')
  - [#ctor(defaultValue,allowsConversionFromString)](#M-Microsoft-VisualStudio-Extensibility-Internal-StringBasedEnumAttribute-#ctor-System-String,System-Boolean- 'Microsoft.VisualStudio.Extensibility.Internal.StringBasedEnumAttribute.#ctor(System.String,System.Boolean)')
- [TextViewExtensionConfiguration](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.TextViewExtensionConfiguration')
  - [AppliesTo](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-AppliesTo 'Microsoft.VisualStudio.Extensibility.Editor.TextViewExtensionConfiguration.AppliesTo')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration- 'Microsoft.VisualStudio.Extensibility.Editor.TextViewExtensionConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Editor.TextViewExtensionConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.TextViewExtensionConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.TextViewExtensionConfiguration.GetHashCode')
- [TextViewMarginGridUnitType](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginGridUnitType')
  - [Auto](#F-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType-Auto 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginGridUnitType.Auto')
  - [Pixel](#F-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType-Pixel 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginGridUnitType.Pixel')
  - [Star](#F-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType-Star 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginGridUnitType.Star')
- [TextViewMarginProviderConfiguration](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration')
  - [#ctor(marginContainer)](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement- 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.#ctor(Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement)')
  - [After](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-After 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.After')
  - [Before](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-Before 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.Before')
  - [GridCellLength](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-GridCellLength 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.GridCellLength')
  - [GridUnitType](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-GridUnitType 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.GridUnitType')
  - [MarginContainer](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-MarginContainer 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.MarginContainer')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration- 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.GetHashCode')
- [ToolWindowConfiguration](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration')
  - [AllowAutoCreation](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-AllowAutoCreation 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.AllowAutoCreation')
  - [DockDirection](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-DockDirection 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.DockDirection')
  - [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Placement')
  - [VisibleWhen](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-VisibleWhen 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.VisibleWhen')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Equals-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Equals(Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.GetHashCode')
- [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement')
  - [DocumentWell](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DocumentWell 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.DocumentWell')
  - [Floating](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Floating 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.Floating')
  - [DockedTo(value)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DockedTo-System-Guid- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.DockedTo(System.Guid)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.Equals(System.Object)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Equals-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.Equals(Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-GetHashCode 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.GetHashCode')
  - [ToString()](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-ToString 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.ToString')
  - [op_Equality(a,b)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-op_Equality-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement,Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.op_Equality(Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement,Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement)')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-op_Implicit-System-Guid-~Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.op_Implicit(System.Guid)~Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement')
  - [op_Implicit(value)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-op_Implicit-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-~System-String 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.op_Implicit(Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement)~System.String')
  - [op_Inequality(a,b)](#M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-op_Inequality-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement,Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement- 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.op_Inequality(Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement,Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement)')
- [ToolbarChild](#T-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarChild')
  - [Separator](#P-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Separator 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarChild.Separator')
  - [Anchor\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Anchor``1 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarChild.Anchor``1')
  - [Command\`\`1()](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Command``1 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarChild.Command``1')
  - [Group(commandGroupConfiguration)](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Group-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarChild.Group(Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration)')
  - [Group(groupChildren)](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Group-Microsoft-VisualStudio-Extensibility-Commands-GroupChild[]- 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarChild.Group(Microsoft.VisualStudio.Extensibility.Commands.GroupChild[])')
  - [Toolbar(menuConfiguration)](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Toolbar-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarChild.Toolbar(Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration)')
- [ToolbarConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration')
  - [#ctor(displayName)](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration.#ctor(System.String)')
  - [Type](#P-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-Type 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration.Type')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration- 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration.Equals(Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration)')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-Equals-System-Object- 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration.Equals(System.Object)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration.GetHashCode')
- [UserDefinedTypeUtilities](#T-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities 'Microsoft.VisualStudio.Extensibility.UserDefinedTypeUtilities')
  - [AreEquivalent(first,second)](#M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-AreEquivalent-System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.UserDefinedTypeUtilities.AreEquivalent(System.Type,System.Type)')
  - [ImplementsInterface(implementer,interfaceTypeName)](#M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-ImplementsInterface-System-Type,System-String- 'Microsoft.VisualStudio.Extensibility.UserDefinedTypeUtilities.ImplementsInterface(System.Type,System.String)')
  - [IsAssignableTo(assignee,target)](#M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-IsAssignableTo-System-Type,System-Type- 'Microsoft.VisualStudio.Extensibility.UserDefinedTypeUtilities.IsAssignableTo(System.Type,System.Type)')
  - [IsOrExtends(extender,baseTypeName)](#M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-IsOrExtends-System-Type,System-String- 'Microsoft.VisualStudio.Extensibility.UserDefinedTypeUtilities.IsOrExtends(System.Type,System.String)')
  - [ValidateTypeRepresentsAnchor(t)](#M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-ValidateTypeRepresentsAnchor-System-Type- 'Microsoft.VisualStudio.Extensibility.UserDefinedTypeUtilities.ValidateTypeRepresentsAnchor(System.Type)')
  - [ValidateTypeRepresentsCommand(t)](#M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-ValidateTypeRepresentsCommand-System-Type- 'Microsoft.VisualStudio.Extensibility.UserDefinedTypeUtilities.ValidateTypeRepresentsCommand(System.Type)')
- [VisualStudioContributionAttribute](#T-Microsoft-VisualStudio-Extensibility-VisualStudioContributionAttribute 'Microsoft.VisualStudio.Extensibility.VisualStudioContributionAttribute')
- [VisualizerObjectSourceType](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceType')
  - [#ctor(type)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType-#ctor-System-Type- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceType.#ctor(System.Type)')
  - [#ctor(type)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType-#ctor-System-String- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceType.#ctor(System.String)')
  - [Type](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType-Type 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceType.Type')
- [VisualizerTargetType](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType')
  - [#ctor(visualizerDisplayName,targetType)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType-#ctor-System-String,System-Type- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType.#ctor(System.String,System.Type)')
  - [#ctor(visualizerDisplayName,targetType)](#M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType-#ctor-System-String,System-String- 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType.#ctor(System.String,System.String)')
  - [TargetType](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType-TargetType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType.TargetType')
  - [VisualizerDisplayName](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType-VisualizerDisplayName 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType.VisualizerDisplayName')
- [VsctCommandConstants](#T-Microsoft-VisualStudio-Extensibility-Commands-VsctCommandConstants 'Microsoft.VisualStudio.Extensibility.Commands.VsctCommandConstants')
  - [IDM_VS_CSCD_WINDOWS](#F-Microsoft-VisualStudio-Extensibility-Commands-VsctCommandConstants-IDM_VS_CSCD_WINDOWS 'Microsoft.VisualStudio.Extensibility.Commands.VsctCommandConstants.IDM_VS_CSCD_WINDOWS')
  - [IDM_VS_MENU_EXTENSIONS](#F-Microsoft-VisualStudio-Extensibility-Commands-VsctCommandConstants-IDM_VS_MENU_EXTENSIONS 'Microsoft.VisualStudio.Extensibility.Commands.VsctCommandConstants.IDM_VS_MENU_EXTENSIONS')
  - [IDM_VS_MENU_TOOLS](#F-Microsoft-VisualStudio-Extensibility-Commands-VsctCommandConstants-IDM_VS_MENU_TOOLS 'Microsoft.VisualStudio.Extensibility.Commands.VsctCommandConstants.IDM_VS_MENU_TOOLS')
- [VsctGroupConstants](#T-Microsoft-VisualStudio-Extensibility-Commands-VsctGroupConstants 'Microsoft.VisualStudio.Extensibility.Commands.VsctGroupConstants')
  - [IDG_VS_EXTENSIONS](#F-Microsoft-VisualStudio-Extensibility-Commands-VsctGroupConstants-IDG_VS_EXTENSIONS 'Microsoft.VisualStudio.Extensibility.Commands.VsctGroupConstants.IDG_VS_EXTENSIONS')
  - [IDG_VS_TOOLS_EXT_TOOLS](#F-Microsoft-VisualStudio-Extensibility-Commands-VsctGroupConstants-IDG_VS_TOOLS_EXT_TOOLS 'Microsoft.VisualStudio.Extensibility.Commands.VsctGroupConstants.IDG_VS_TOOLS_EXT_TOOLS')
  - [IDG_VS_WNDO_OTRWNDWS1](#F-Microsoft-VisualStudio-Extensibility-Commands-VsctGroupConstants-IDG_VS_WNDO_OTRWNDWS1 'Microsoft.VisualStudio.Extensibility.Commands.VsctGroupConstants.IDG_VS_WNDO_OTRWNDWS1')
- [VsctGuidConstants](#T-Microsoft-VisualStudio-Extensibility-Commands-VsctGuidConstants 'Microsoft.VisualStudio.Extensibility.Commands.VsctGuidConstants')
  - [guidSHLMainMenu](#F-Microsoft-VisualStudio-Extensibility-Commands-VsctGuidConstants-guidSHLMainMenu 'Microsoft.VisualStudio.Extensibility.Commands.VsctGuidConstants.guidSHLMainMenu')
- [VsctId](#T-Microsoft-VisualStudio-Extensibility-Commands-VsctId 'Microsoft.VisualStudio.Extensibility.Commands.VsctId')
  - [#ctor(guid,id)](#M-Microsoft-VisualStudio-Extensibility-Commands-VsctId-#ctor-System-Guid,System-UInt32- 'Microsoft.VisualStudio.Extensibility.Commands.VsctId.#ctor(System.Guid,System.UInt32)')
  - [Guid](#P-Microsoft-VisualStudio-Extensibility-Commands-VsctId-Guid 'Microsoft.VisualStudio.Extensibility.Commands.VsctId.Guid')
  - [Id](#P-Microsoft-VisualStudio-Extensibility-Commands-VsctId-Id 'Microsoft.VisualStudio.Extensibility.Commands.VsctId.Id')
  - [Equals()](#M-Microsoft-VisualStudio-Extensibility-Commands-VsctId-Equals-Microsoft-VisualStudio-Extensibility-Commands-VsctId- 'Microsoft.VisualStudio.Extensibility.Commands.VsctId.Equals(Microsoft.VisualStudio.Extensibility.Commands.VsctId)')
  - [GetHashCode()](#M-Microsoft-VisualStudio-Extensibility-Commands-VsctId-GetHashCode 'Microsoft.VisualStudio.Extensibility.Commands.VsctId.GetHashCode')

<a name='T-Microsoft-VisualStudio-Extensibility-ActivationConstraint'></a>
## ActivationConstraint `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Describes a context-based activation rule.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-And-Microsoft-VisualStudio-Extensibility-ActivationConstraint[]-'></a>
### And(constraints) `method`

##### Summary

Creates an activation constraint that is `true` when all `constraints` are
`true`.

##### Returns

A constraint that is `true` when all `constraints` are
`true`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| constraints | [Microsoft.VisualStudio.Extensibility.ActivationConstraint[]](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint[] 'Microsoft.VisualStudio.Extensibility.ActivationConstraint[]') | The operands of the logical AND operation. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ClientContext-Microsoft-VisualStudio-Extensibility-ClientContextKey,System-String-'></a>
### ClientContext(key,regexPattern) `method`

##### Summary

Creates an activation constraint that is `true` when the provided client context key matches the
regex pattern provided.

##### Returns

A constraint that is `true` when the provided client context key matches the regex
pattern provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [Microsoft.VisualStudio.Extensibility.ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') | The client context key. |
| regexPattern | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The regex pattern to match. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-Not-Microsoft-VisualStudio-Extensibility-ActivationConstraint-'></a>
### Not(constraint) `method`

##### Summary

Creates an activation constraint that is `true` when `constraint` is
`false` and vice versa.

##### Returns

A constraint that is `true` when when `constraint` is
`false` and vice versa.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| constraint | [Microsoft.VisualStudio.Extensibility.ActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint') | The operand of the NOT operation. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-Or-Microsoft-VisualStudio-Extensibility-ActivationConstraint[]-'></a>
### Or(constraints) `method`

##### Summary

Creates an activation constraint that is `true` when at least one of
`constraints` is `true`.

##### Returns

A constraint that is `true` when at least one of `constraints` is
`true`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| constraints | [Microsoft.VisualStudio.Extensibility.ActivationConstraint[]](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint[] 'Microsoft.VisualStudio.Extensibility.ActivationConstraint[]') | The operands of the logical OR operation. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ProjectAddedItem-System-String-'></a>
### ProjectAddedItem(regexPattern) `method`

##### Summary

Creates an activation constraint that is `true` when a file matching the regex pattern
provided is added to a project in the solution that is opened.

##### Returns

A constraint that is `true` when a file matching the regex pattern provided is
added to a project in the solution that is opened.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| regexPattern | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The regex pattern to match. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionHasProjectBuildProperty-System-String,System-String-'></a>
### SolutionHasProjectBuildProperty(property,regexPattern) `method`

##### Summary

Creates an activation constraint that is `true` when the solution has a loaded project with the
specified build property and the property value matches the regex pattern provided.

##### Returns

A constraint that is `true` when the solution has a loaded project with the
specified build property and the property value matches the regex pattern provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The solution build property. |
| regexPattern | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The regex pattern to match. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionHasProjectCapability-Microsoft-VisualStudio-Extensibility-ProjectCapability-'></a>
### SolutionHasProjectCapability(capability) `method`

##### Summary

Creates an activation constraint that is `true` when the solution has a project with the
matching capability.

##### Returns

A constraint that is `true` when the solution has a project with the matching
capability.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| capability | [Microsoft.VisualStudio.Extensibility.ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') | The solution build property. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionHasProjectFlavor-System-Guid-'></a>
### SolutionHasProjectFlavor(flavor) `method`

##### Summary

Creates an activation constraint that is `true` when the solution has a project that has a flavor matching `flavor`.

##### Returns

A constraint that is `true` when the solution has a project with the matching
capability.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| flavor | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | The project flavor GUID. |

##### Remarks

This method is deprecated, use [SolutionHasProjectCapability](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionHasProjectCapability-Microsoft-VisualStudio-Extensibility-ProjectCapability- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.SolutionHasProjectCapability(Microsoft.VisualStudio.Extensibility.ProjectCapability)') instead.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionState-Microsoft-VisualStudio-Extensibility-SolutionState-'></a>
### SolutionState(state) `method`

##### Summary

Creates an activation constraint that is `true` when the solution state matches `state`.

##### Returns

A constraint that is `true` when the solution state matches `state`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| state | [Microsoft.VisualStudio.Extensibility.SolutionState](#T-Microsoft-VisualStudio-Extensibility-SolutionState 'Microsoft.VisualStudio.Extensibility.SolutionState') | The solution state. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-op_BitwiseAnd-Microsoft-VisualStudio-Extensibility-ActivationConstraint,Microsoft-VisualStudio-Extensibility-ActivationConstraint-'></a>
### op_BitwiseAnd(a,b) `method`

##### Summary

Creates an activation constraint that is `true` when both `a` and
`b` are `true`.

##### Returns

A constraint that is `true` when when both `a` and
`b` are `true`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint') | The first operand of the logical AND operation. |
| b | [Microsoft.VisualStudio.Extensibility.ActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint') | The second operand of the logical AND operation. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-op_BitwiseOr-Microsoft-VisualStudio-Extensibility-ActivationConstraint,Microsoft-VisualStudio-Extensibility-ActivationConstraint-'></a>
### op_BitwiseOr(a,b) `method`

##### Summary

Creates an activation constraint that is `true` when at least one of `a` or
`b` is `true`.

##### Returns

A constraint that is `true` when at least one of `a` or
`b` is `true`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint') | The first operand of the logical OR operation. |
| b | [Microsoft.VisualStudio.Extensibility.ActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint') | The second operand of the logical OR operation. |

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-op_LogicalNot-Microsoft-VisualStudio-Extensibility-ActivationConstraint-'></a>
### op_LogicalNot(a) `method`

##### Summary

Creates an activation constraint that is `true` when `a` is
`false` and vice versa.

##### Returns

A constraint that is `true` when when `a` is
`false` and vice versa.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint') | The operand of the NOT operation. |

<a name='T-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression'></a>
## ActivationConstraintExpression `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ActivationConstraint

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ActivationConstraintExpression-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-AllowNullAttribute'></a>
## AllowNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that `null` is allowed as an input even if the
    corresponding type disallows it.

<a name='M-System-Diagnostics-CodeAnalysis-AllowNullAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [AllowNullAttribute](https://learn.microsoft.com/dotnet/api/System.Diagnostics.CodeAnalysis.AllowNullAttribute 'System.Diagnostics.CodeAnalysis.AllowNullAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint'></a>
## AndActivationConstraint `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ActivationConstraint

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-AndActivationConstraint-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration'></a>
## BaseCommandConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Base configuration of a VisualStudio.Extensibility Command.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-#ctor-System-String-'></a>
### #ctor(displayName) `constructor`

##### Summary

Initializes a new instance of the [BaseCommandConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.BaseCommandConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The initial display name for the command. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-ClientContexts'></a>
### ClientContexts `property`

##### Summary

Gets or sets the client context categories requested by the command.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-BaseCommandConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration'></a>
## BaseControlConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Base configuration of a VisualStudio.Extensibility Command.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-#ctor-System-String-'></a>
### #ctor(displayName) `constructor`

##### Summary

Initializes a new instance of the [BaseControlConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.BaseControlConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The initial display name for the command. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-DisplayName'></a>
### DisplayName `property`

##### Summary

Gets the initial command display name.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-Placements'></a>
### Placements `property`

##### Summary

Gets or sets where the command should be placed in the IDE.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-Priority'></a>
### Priority `property`

##### Summary

Gets or sets the placement of this command relative to other commands in the same VSCT defined group.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-BaseControlConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ClientContextKey'></a>
## ClientContextKey `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Client context keys to be used in [ClientContext](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-ClientContext-Microsoft-VisualStudio-Extensibility-ClientContextKey,System-String- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.ClientContext(Microsoft.VisualStudio.Extensibility.ClientContextKey,System.String)').

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-Custom-System-String-'></a>
### Custom(value) `method`

##### Summary

Initializes a [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') value.

##### Returns

The [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey'). |

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-Equals-Microsoft-VisualStudio-Extensibility-ClientContextKey-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-ToString'></a>
### ToString() `method`

##### Summary

Returns the string value of [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey').

##### Returns

The string value of [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-op_Equality-Microsoft-VisualStudio-Extensibility-ClientContextKey,Microsoft-VisualStudio-Extensibility-ClientContextKey-'></a>
### op_Equality(a,b) `method`

##### Summary

Compares two [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') values returning whether they are equal.

##### Returns

Whether the two values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') | The first value to compare. |
| b | [Microsoft.VisualStudio.Extensibility.ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') | The second value to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-ClientContextKey'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a `string` to a [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey'). |

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-op_Implicit-Microsoft-VisualStudio-Extensibility-ClientContextKey-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') to a `string`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Microsoft.VisualStudio.Extensibility.ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey-~System-String 'Microsoft.VisualStudio.Extensibility.ClientContextKey') | The [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') to be converted. |

<a name='M-Microsoft-VisualStudio-Extensibility-ClientContextKey-op_Inequality-Microsoft-VisualStudio-Extensibility-ClientContextKey,Microsoft-VisualStudio-Extensibility-ClientContextKey-'></a>
### op_Inequality(a,b) `method`

##### Summary

Compares two [ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') values returning whether they are different.

##### Returns

Whether the two values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') | The first instance to compare. |
| b | [Microsoft.VisualStudio.Extensibility.ClientContextKey](#T-Microsoft-VisualStudio-Extensibility-ClientContextKey 'Microsoft.VisualStudio.Extensibility.ClientContextKey') | The second instance to compare. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration'></a>
## CommandConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Configuration of a VisualStudio.Extensibility Command.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-#ctor-System-String-'></a>
### #ctor(displayName) `constructor`

##### Summary

Initializes a new instance of the [CommandConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The initial display name for the command. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-EnabledWhen'></a>
### EnabledWhen `property`

##### Summary

Gets or sets the configuration for when the command is enabled.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Flags'></a>
### Flags `property`

##### Summary

Gets or sets the flags associated with the command.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Icon'></a>
### Icon `property`

##### Summary

Gets or sets the command icon configuration.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Shortcuts'></a>
### Shortcuts `property`

##### Summary

Gets or sets the command shortcut configuration.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-TooltipText'></a>
### TooltipText `property`

##### Summary

Gets or sets the initial command tooltip text. If left `null` defaults to displayName only when
the command is a button or toolbar button.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-VisibleWhen'></a>
### VisibleWhen `property`

##### Summary

Gets or sets the configuration for when the command is visible.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-VsctCommandMapping'></a>
### VsctCommandMapping `property`

##### Summary

Gets or sets the Guid/Id pair of a VSCT defined command that this command is replacing.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandFlags'></a>
## CommandFlags `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Boolean flags for commands.

##### Remarks

This is equivalent to Microsoft.VisualStudio.RpcContracts.Commands.CommandFlags.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-CommandFlags-CanSelect'></a>
### CanSelect `constants`

##### Summary

Indicates that the command can be selected.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-CommandFlags-CanToggle'></a>
### CanToggle `constants`

##### Summary

Indicates that the command can be toggled.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-CommandFlags-None'></a>
### None `constants`

##### Summary

Indicates that no command flags are set.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration'></a>
## CommandGroupConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Configuration of a VisualStudio.Extensibility Group.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-'></a>
### #ctor(placement) `constructor`

##### Summary

Initializes a new instance of the [CommandGroupConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| placement | [Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement') | The control container that this group should be parented to. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement,System-UInt32-'></a>
### #ctor(placement,priority) `constructor`

##### Summary

Initializes a new instance of the [CommandGroupConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| placement | [Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement') | The control container that this group should be parented to. |
| priority | [System.UInt32](https://learn.microsoft.com/dotnet/api/System.UInt32 'System.UInt32') | The display order of the group relative to other groups parented to the same control. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [CommandGroupConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration') class.

##### Parameters

This constructor has no parameters.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Children'></a>
### Children `property`

##### Summary

Gets the set of children that should be parented to this group.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Id'></a>
### Id `property`

##### Summary

Gets an optional identifier used to reference the group from elsewhere.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Placement'></a>
### Placement `property`

##### Summary

Gets where the group should be placed in the IDE.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Priority'></a>
### Priority `property`

##### Summary

Gets the placement of this group relative to other controls in the same container if parented to a VSCT defined control.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration'></a>
## CommandIconConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Configuration of the icon to be displayed for a VisualStudio.Extensibility Command.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-ImageMoniker,Microsoft-VisualStudio-Extensibility-Commands-IconSettings-'></a>
### #ctor(iconName,iconSettings) `constructor`

##### Summary

Initializes a new instance of the [CommandIconConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandIconConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iconName | [Microsoft.VisualStudio.Extensibility.ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') | The [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') to be used as the icon for a command. |
| iconSettings | [Microsoft.VisualStudio.Extensibility.Commands.IconSettings](#T-Microsoft-VisualStudio-Extensibility-Commands-IconSettings 'Microsoft.VisualStudio.Extensibility.Commands.IconSettings') | The settings for how to display the icon. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-IconName'></a>
### IconName `property`

##### Summary

Gets the name of the icon.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-IconSettings'></a>
### IconSettings `property`

##### Summary

Gets the settings related to how the command should be displayed.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandIconConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement'></a>
## CommandPlacement `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Defined where a command is placed.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-#ctor-Microsoft-VisualStudio-Extensibility-Commands-VsctId-'></a>
### #ctor(parent) `constructor`

##### Summary

Initializes a new instance of the [CommandPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parent | [Microsoft.VisualStudio.Extensibility.Commands.VsctId](#T-Microsoft-VisualStudio-Extensibility-Commands-VsctId 'Microsoft.VisualStudio.Extensibility.Commands.VsctId') | VSCT id of the control's parent. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-VsctParentId'></a>
### VsctParentId `property`

##### Summary

Gets the VSCT parent identifier.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-FromVsctParent-System-Guid,System-UInt32-'></a>
### FromVsctParent(guid,id) `method`

##### Summary

Create a placement configuration using the Guid/Id pair of a group defined via VSCT.

##### Returns

A [CommandPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement 'Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | The guid of the group. |
| id | [System.UInt32](https://learn.microsoft.com/dotnet/api/System.UInt32 'System.UInt32') | The id of the group. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration'></a>
## CommandShortcutConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An attribute used on Command classes to specify the command shortcut.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key-'></a>
### #ctor(mod1,key1) `constructor`

##### Summary

Initializes a new instance of the [CommandShortcutConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod1 | [Microsoft.VisualStudio.Extensibility.Commands.ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey') | First modifier key. |
| key1 | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | First key. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key,System-Guid-'></a>
### #ctor(mod1,key1,activationConstraint) `constructor`

##### Summary

Initializes a new instance of the [CommandShortcutConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod1 | [Microsoft.VisualStudio.Extensibility.Commands.ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey') | First modifier key. |
| key1 | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | First key. |
| activationConstraint | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | Optional UI context for the shortcut. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key,Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key-'></a>
### #ctor(mod1,key1,mod2,key2) `constructor`

##### Summary

Initializes a new instance of the [CommandShortcutConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod1 | [Microsoft.VisualStudio.Extensibility.Commands.ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey') | First modifier key. |
| key1 | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | First key. |
| mod2 | [Microsoft.VisualStudio.Extensibility.Commands.ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey') | Second modifier key. |
| key2 | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | Second key. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key,Microsoft-VisualStudio-Extensibility-Commands-ModifierKey,Microsoft-VisualStudio-Extensibility-Commands-Key,System-Guid-'></a>
### #ctor(mod1,key1,mod2,key2,activationConstraint) `constructor`

##### Summary

Initializes a new instance of the [CommandShortcutConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandShortcutConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mod1 | [Microsoft.VisualStudio.Extensibility.Commands.ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey') | First modifier key. |
| key1 | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | First key. |
| mod2 | [Microsoft.VisualStudio.Extensibility.Commands.ModifierKey](#T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey 'Microsoft.VisualStudio.Extensibility.Commands.ModifierKey') | Second modifier key. |
| key2 | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | Second key. |
| activationConstraint | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | Optional UI context for the shortcut. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-ActivationConstraint'></a>
### ActivationConstraint `property`

##### Summary

Gets the optional UI Context GUID used to scope the shortcut.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Key1'></a>
### Key1 `property`

##### Summary

Gets the first key for this shortcut.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Key2'></a>
### Key2 `property`

##### Summary

Gets the optional second key for this shortcut.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Mod1'></a>
### Mod1 `property`

##### Summary

Gets the first modifier key for this shortcut.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Mod2'></a>
### Mod2 `property`

##### Summary

Gets the optional second modifier key for this shortcut.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-CommandShortcutConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-CompileTimeEvaluationAttribute'></a>
## CompileTimeEvaluationAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

An attribute used to mark that a property is evaluated at compile time and reprensents the configuration of an
[IVisualStudioContributionClass](#T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionClass 'Microsoft.VisualStudio.Extensibility.IVisualStudioContributionClass').
Alternatively it is used on types that implement [IVisualStudioContributionProperty](#T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionProperty 'Microsoft.VisualStudio.Extensibility.IVisualStudioContributionProperty') and are used to
define static properties marked with [VisualStudioContributionAttribute](#T-Microsoft-VisualStudio-Extensibility-VisualStudioContributionAttribute 'Microsoft.VisualStudio.Extensibility.VisualStudioContributionAttribute'), which are also evaluated at
compile time.
This is used by the VisualStudio.Extensibility libraries for documentation purposes and it's not meant to be used
directly by extenders.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild'></a>
## ContainerChild `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An instance of a control on a control container.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-#ctor-System-String-'></a>
### #ctor(childIdentifier) `constructor`

##### Summary

Initializes a new instance of the [ContainerChild](#T-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| childIdentifier | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The identifier of the item to be parented to the container. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-#ctor-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-'></a>
### #ctor(group) `constructor`

##### Summary

Initializes a new instance of the [ContainerChild](#T-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild 'Microsoft.VisualStudio.Extensibility.Commands.ContainerChild') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| group | [Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration') | The group that is being parented to the container. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-ChildIdentifier'></a>
### ChildIdentifier `property`

##### Summary

Gets the identifier of the child item.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-CommandGroupConfiguration'></a>
### CommandGroupConfiguration `property`

##### Summary

Gets the group that represents the child item.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-IsSeparator'></a>
### IsSeparator `property`

##### Summary

Gets or sets a value indicating whether gets whether or not this child item is a separator between two groups.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ContainerChild-GetSeparatorId-System-String-'></a>
### GetSeparatorId(owningFullClassName) `method`

##### Summary

Gets the id of the separator.

##### Returns

The separator id.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owningFullClassName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The full class name of the class owning the separator. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement'></a>
## ContainerMarginPlacement `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Identifies a text view margin that contains other margins.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-Custom-System-String-'></a>
### Custom(value) `method`

##### Summary

Initializes a [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') value.

##### Returns

The [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-Equals-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-ToString'></a>
### ToString() `method`

##### Summary

Returns the string value of [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement').

##### Returns

The string value of [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement,Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-'></a>
### op_Equality(a,b) `method`

##### Summary

Compares two [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') values returning whether they are equal.

##### Returns

Whether the two values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') | The first value to compare. |
| b | [Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') | The second value to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a `string` to a [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String) 'System.String') | The string value of [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') to a `string`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') | The [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') to be converted. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement,Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-'></a>
### op_Inequality(a,b) `method`

##### Summary

Compares two [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') values returning whether they are different.

##### Returns

Whether the two values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') | The first instance to compare. |
| b | [Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') | The second instance to compare. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration'></a>
## ControlContainerConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Configuration of a VisualStudio.Extensibility ControlContainer.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-#ctor-System-String-'></a>
### #ctor(displayName) `constructor`

##### Summary

Initializes a new instance of the [ControlContainerConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The initial display name for the container. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-DisplayName'></a>
### DisplayName `property`

##### Summary

Gets the initial container's display name.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Id'></a>
### Id `property`

##### Summary

Gets an optional identifier used to reference the group from elsewhere.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Placements'></a>
### Placements `property`

##### Summary

Gets where the container should be placed in the IDE.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Priority'></a>
### Priority `property`

##### Summary

Gets the placement of this container relative to other controls in the same group defined via VSCT.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-TooltipText'></a>
### TooltipText `property`

##### Summary

Gets the container's tooltip text. If left `null` defaults to displayName.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Type'></a>
### Type `property`

##### Summary

Gets the type of the control container.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1'></a>
## ControlContainerConfiguration\`1 `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Configuration of a VisualStudio.Extensibility ControlContainer.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of control container's children. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-#ctor-System-String-'></a>
### #ctor(displayName) `constructor`

##### Summary

Initializes a new instance of the [ControlContainerConfiguration\`1](#T-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1 'Microsoft.VisualStudio.Extensibility.Commands.ControlContainerConfiguration`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The initial display name for the container. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-Children'></a>
### Children `property`

##### Summary

Gets the set of children that should be parented to this container.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-Equals-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration{`0}-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerConfiguration`1-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerType'></a>
## ControlContainerType `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Indicates what type of container a control container is.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerType-Menu'></a>
### Menu `constants`

##### Summary

Indicates that a control container is a menu.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ControlContainerType-Toolbar'></a>
### Toolbar `constants`

##### Summary

Indicates that a control container is a toolbar.

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration'></a>
## DebuggerVisualizerProviderConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

Configuration of a DebuggerVisualizerProvider class.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-#ctor-System-String,System-Type-'></a>
### #ctor(visualizerDisplayName,targetType) `constructor`

##### Summary

Initializes a new instance of the [DebuggerVisualizerProviderConfiguration](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visualizerDisplayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The display name of the debugger visualizer. |
| targetType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') that is supported by this debugger visualizer.

`targetType` must be a concrete type. The debugger visualizer will only
support objects of type `targetType`, not objects of types extending `targetType`.

If `targetType` is a generic type, it must be unbound.

Trailing compoments of the [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') can be omitted. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-#ctor-System-String,System-String-'></a>
### #ctor(visualizerDisplayName,targetType) `constructor`

##### Summary

Initializes a new instance of the [DebuggerVisualizerProviderConfiguration](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visualizerDisplayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The display name of the debugger visualizer. |
| targetType | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') of the type that is supported by this
debugger visualizer.

`targetType` must be a concrete type. The debugger visualizer will only
support objects of type `targetType`, not objects of types extending `targetType`.

If `targetType` is a generic type, it must be unbound.

Trailing compoments of the [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') can be omitted. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType[]-'></a>
### #ctor(targets) `constructor`

##### Summary

Initializes a new instance of the [DebuggerVisualizerProviderConfiguration](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.DebuggerVisualizerProviderConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targets | [Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType[]](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType[]') | Types that a debugger visualizer will target and the corresponding display names for the
visualizer. |

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-Targets'></a>
### Targets `property`

##### Summary

Gets types that a debugger visualizer will target and the corresponding display names for the visualizer.

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-VisualizerObjectSourceType'></a>
### VisualizerObjectSourceType `property`

##### Summary

Gets the type of the visualizer object source loaded in the debug target process to access the object to be
visualized. When `null`, the default visualizer object source, which performs
serialization using Newtonsoft.Json, will be used.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-Equals-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProviderConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-DisallowNullAttribute'></a>
## DisallowNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that `null` is disallowed as an input even if the
    corresponding type allows it.

<a name='M-System-Diagnostics-CodeAnalysis-DisallowNullAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DisallowNullAttribute](https://learn.microsoft.com/dotnet/api/System.Diagnostics.CodeAnalysis.DisallowNullAttribute 'System.Diagnostics.CodeAnalysis.DisallowNullAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock'></a>
## Dock `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

Dock direction that can be used to control how a tool window is docked when it's first shown.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Bottom'></a>
### Bottom `constants`

##### Summary

Docks the tool window below its placement target.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Left'></a>
### Left `constants`

##### Summary

Docks the tool window to the left of its placement target.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-None'></a>
### None `constants`

##### Summary

Docks the tool window alongside its placement target.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Right'></a>
### Right `constants`

##### Summary

Docks the tool window to the right of its placement target.

<a name='F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Top'></a>
### Top `constants`

##### Summary

Docks the tool window above its placement target.

<a name='T-Microsoft-VisualStudio-Extensibility-DocumentFilter'></a>
## DocumentFilter `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Describes an applicability condition based on the type or path of a document.

<a name='P-Microsoft-VisualStudio-Extensibility-DocumentFilter-DocumentType'></a>
### DocumentType `property`

##### Summary

Gets the document type of an object. Document type is frequently used to target specific languages.

<a name='P-Microsoft-VisualStudio-Extensibility-DocumentFilter-Pattern'></a>
### Pattern `property`

##### Summary

Gets the glob pattern to match document file path.
 Glob patterns can have the following syntax:

 * to match one or more characters in a path segment
 ? to match on one character in a path segment
 ** to match any number of path segments, including none
 {} to group conditions (e.g. **/*.{ts,js} matches all TypeScript and JavaScript files)
 [] to declare a range of characters to match in a path segment (e.g., example.[0-9]
 to match on example.0, example.1, …)
 [!...] to negate a range of characters to match in a path segment (e.g., example.[!0-9]
 to match on example.a, example.b, but not example.0)
 Note: a backslash (\) is not valid within a glob pattern. If you have an existing file path to match against,
 consider to use the relative pattern support that takes care of converting any backslash into slash.
 Otherwise, make sure to convert any backslash to slash when creating the glob pattern.

<a name='P-Microsoft-VisualStudio-Extensibility-DocumentFilter-RelativePath'></a>
### RelativePath `property`

##### Summary

Gets a value indicating whether the pattern should be applied to the absolute path of a file or to a path
relative to the solution folder.

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentFilter-Equals-Microsoft-VisualStudio-Extensibility-DocumentFilter-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentFilter-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentFilter-FromDocumentType-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-'></a>
### FromDocumentType(documentType) `method`

##### Summary

Creates a [DocumentFilter](#T-Microsoft-VisualStudio-Extensibility-DocumentFilter 'Microsoft.VisualStudio.Extensibility.DocumentFilter') from a document type.

##### Returns

The [DocumentFilter](#T-Microsoft-VisualStudio-Extensibility-DocumentFilter 'Microsoft.VisualStudio.Extensibility.DocumentFilter').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentType | [Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration') | The type of a document. Document type is frequently used to target specific
languages. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentFilter-FromDocumentType-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-'></a>
### FromDocumentType(documentType) `method`

##### Summary

Creates a [DocumentFilter](#T-Microsoft-VisualStudio-Extensibility-DocumentFilter 'Microsoft.VisualStudio.Extensibility.DocumentFilter') from a document type.

##### Returns

The [DocumentFilter](#T-Microsoft-VisualStudio-Extensibility-DocumentFilter 'Microsoft.VisualStudio.Extensibility.DocumentFilter').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| documentType | [Microsoft.VisualStudio.Extensibility.Editor.DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') | The type of a document. Document type is frequently used to target specific
languages. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentFilter-FromGlobPattern-System-String,System-Boolean-'></a>
### FromGlobPattern(pattern,relativePath) `method`

##### Summary

Creates a [DocumentFilter](#T-Microsoft-VisualStudio-Extensibility-DocumentFilter 'Microsoft.VisualStudio.Extensibility.DocumentFilter') from a glob pattern matching the document file path.

##### Returns

The [DocumentFilter](#T-Microsoft-VisualStudio-Extensibility-DocumentFilter 'Microsoft.VisualStudio.Extensibility.DocumentFilter').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pattern | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The glob pattern to match document file path. Glob patterns can have the following syntax:
<br/><br/>
- * to match one or more characters in a path segment
- ? to match on one character in a path segment
- ** to match any number of path segments, including none
- {} to group conditions (e.g. **/*.{ts,js} matches all TypeScript and JavaScript files)
- [] to declare a range of characters to match in a path segment (e.g., example.[0-9] to match on example.0, example.1, …)
 [!...] to negate a range of characters to match in a path segment (e.g., example.[!0-9] to match on example.a, example.b, but not example.0)
 <br/><br/>
 Note: a backslash (\) is not valid within a glob pattern. If you have an existing file path to match against,
 consider to use the relative pattern support that takes care of converting any backslash into slash.
 Otherwise, make sure to convert any backslash to slash when creating the glob pattern. |
| relativePath | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | Defines whether the pattern should be applied to the absolute path of a file or to a path
 relative to the solution folder. |

<a name='M-Microsoft-VisualStudio-Extensibility-DocumentFilter-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType'></a>
## DocumentType `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

A document type identifies document content as belonging to a specific
category, such as of some programming language or more generally just as code
or as text. Visual Studio enables various features based on current document type,
while extensions use document type to define their activation criteria.
An extension can define a new document type and map it to file extensions
using [DocumentTypeConfiguration](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration').

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-Custom-System-String-'></a>
### Custom(value) `method`

##### Summary

Initializes a [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') value.

##### Returns

The [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-Equals-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-ToString'></a>
### ToString() `method`

##### Summary

Returns the string value of [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType').

##### Returns

The string value of [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-DocumentType,Microsoft-VisualStudio-Extensibility-Editor-DocumentType-'></a>
### op_Equality(a,b) `method`

##### Summary

Compares two [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') values returning whether they are equal.

##### Returns

Whether the two values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.Editor.DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') | The first value to compare. |
| b | [Microsoft.VisualStudio.Extensibility.Editor.DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') | The second value to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-Editor-DocumentType'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a `string` to a [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String) 'System.String') | The string value of [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') to a `string`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Microsoft.VisualStudio.Extensibility.Editor.DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') | The [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') to be converted. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-DocumentType,Microsoft-VisualStudio-Extensibility-Editor-DocumentType-'></a>
### op_Inequality(a,b) `method`

##### Summary

Compares two [DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') values returning whether they are different.

##### Returns

Whether the two values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.Editor.DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') | The first instance to compare. |
| b | [Microsoft.VisualStudio.Extensibility.Editor.DocumentType](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType') | The second instance to compare. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration'></a>
## DocumentTypeConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Allows declaring a new document type.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Initializes a new instance of the [DocumentTypeConfiguration](#T-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.DocumentTypeConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The document type name. Document type names are case-insensitive. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-BaseDocumentType'></a>
### BaseDocumentType `property`

##### Summary

Gets or sets base this document type inherits from.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-FileExtensions'></a>
### FileExtensions `property`

##### Summary

Gets or sets file name extensions associated with the document type. File extensions must start with a '.' character.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-Name'></a>
### Name `property`

##### Summary

Gets the document type name. Document type names are case-insensitive.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-DocumentTypeConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-DoesNotReturnAttribute'></a>
## DoesNotReturnAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that a method that will never return under any circumstance.

<a name='M-System-Diagnostics-CodeAnalysis-DoesNotReturnAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DoesNotReturnAttribute](https://learn.microsoft.com/dotnet/api/System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute 'System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute'></a>
## DoesNotReturnIfAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that the method will not return if the associated [Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean')
    parameter is passed the specified value.

<a name='M-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute-#ctor-System-Boolean-'></a>
### #ctor(parameterValue) `constructor`

##### Summary

Initializes a new instance of the [DoesNotReturnIfAttribute](https://learn.microsoft.com/dotnet/api/System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute 'System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute')
    class with the specified parameter value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameterValue | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | The condition parameter value.
    Code after the method is considered unreachable by diagnostics if the argument
    to the associated parameter matches this value. |

<a name='P-System-Diagnostics-CodeAnalysis-DoesNotReturnIfAttribute-ParameterValue'></a>
### ParameterValue `property`

##### Summary

Gets the condition parameter value.
    Code after the method is considered unreachable by diagnostics if the argument
    to the associated parameter matches this value.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration'></a>
## DynamicCommandAnchorConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Base configuration of a VisualStudio.Extensibility Command.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration-#ctor-System-String-'></a>
### #ctor(displayName) `constructor`

##### Summary

Initializes a new instance of the [DynamicCommandAnchorConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.DynamicCommandAnchorConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The initial display name for the command. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-DynamicCommandAnchorConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-EqualityUtilities'></a>
## EqualityUtilities `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Utility methods for implementing IEquatable.

<a name='M-Microsoft-VisualStudio-Extensibility-EqualityUtilities-ArrayEquals``1-``0[],``0[]-'></a>
### ArrayEquals\`\`1(array1,array2) `method`

##### Summary

An implementation of SequenceEquals that allows null arrays.

##### Returns

Whether the two arrays contains equal elements or are both null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array1 | [\`\`0[]](#T-``0[] '``0[]') | The first array to compare, or null. |
| array2 | [\`\`0[]](#T-``0[] '``0[]') | The second array to compare, or null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The element type of the arrays. |

<a name='M-Microsoft-VisualStudio-Extensibility-EqualityUtilities-GetEnumerableHash``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### GetEnumerableHash\`\`1(enumerable) `method`

##### Summary

Calculate the hash of an enumerable allowing a null array.

##### Returns

The hash.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumerable | [System.Collections.Generic.IEnumerable<T>](https://learn.microsoft.com/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable<T>') | The enumerable to calculate the hash for, or null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The element type of the enumerable. |

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration'></a>
## ExtensionConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

The configuration of an Extension class.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-LoadedWhen'></a>
### LoadedWhen `property`

##### Summary

Gets or sets the configuration for when the extension is loaded.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-RequiresInProcessHosting'></a>
### RequiresInProcessHosting `property`

##### Summary

Gets or sets a value indicating whether the extension requires to be hosted in process.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-Equals-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute'></a>
## ExtensionContractAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Contains additional information about an extension part contract, specifically around wrapping type.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-#ctor-System-Type,System-Type-'></a>
### #ctor(rpcContractType,wrapperObjectType) `constructor`

##### Summary

Initializes a new instance of the [ExtensionContractAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionContractAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rpcContractType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | Type of the rpc contract interface. |
| wrapperObjectType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | Type of the wrapper object. |

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-RpcContractType'></a>
### RpcContractType `property`

##### Summary

Gets the RPC contract type this interface is intended for.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionContractAttribute-WrapperObjectType'></a>
### WrapperObjectType `property`

##### Summary

Gets the wrapper object type.

<a name='T-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute'></a>
## ExtensionPartAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

An attribute used to mark an interface or a class extending ExtensionPart.

<a name='M-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-#ctor-System-Type,System-String[]-'></a>
### #ctor(interfaceType,configurationProperties) `constructor`

##### Summary

Initializes a new instance of the [ExtensionPartAttribute](#T-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute 'Microsoft.VisualStudio.Extensibility.ExtensionPartAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| interfaceType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The contract interface [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') for the extension part. |
| configurationProperties | [System.String[]](https://learn.microsoft.com/dotnet/api/System.String 'System.String[]') | The name of the properties containing the configuration of the type this
attribute is applied to. |

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-ConfigurationProperties'></a>
### ConfigurationProperties `property`

##### Summary

Gets the name of the properties containing the configuration of the type this attribute is applied to.

<a name='P-Microsoft-VisualStudio-Extensibility-ExtensionPartAttribute-InterfaceType'></a>
### InterfaceType `property`

##### Summary

Gets the contract interface [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') for the extension part.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-GroupChild'></a>
## GroupChild `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An instance of a control on a group.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-GroupChild-ChildIdentifier'></a>
### ChildIdentifier `property`

##### Summary

Gets the identifier of the child item.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupChild-Anchor``1'></a>
### Anchor\`\`1() `method`

##### Summary

Create an instance of group child placement for a dynamic command anchor.

##### Returns

The group child placement for a dynamic command anchor.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the dynamic command anchor to be parented to the group. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupChild-Command``1'></a>
### Command\`\`1() `method`

##### Summary

Create an instance of group child placement for a command.

##### Returns

The group child placement for a command.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the command to be parented to the group. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupChild-Menu-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-'></a>
### Menu(childControl) `method`

##### Summary

Create an instance of group child placement.

##### Returns

The group child placement.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| childControl | [Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration') | The configuration of the menu to be parented to the group. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement'></a>
## GroupPlacement `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Defined where a group is placed.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-#ctor-Microsoft-VisualStudio-Extensibility-Commands-VsctId-'></a>
### #ctor(parent) `constructor`

##### Summary

Initializes a new instance of the [GroupPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parent | [Microsoft.VisualStudio.Extensibility.Commands.VsctId](#T-Microsoft-VisualStudio-Extensibility-Commands-VsctId 'Microsoft.VisualStudio.Extensibility.Commands.VsctId') | VSCT id of the group's parent. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-#ctor-System-String,System-UInt32-'></a>
### #ctor(parent,relativeDisplayOrder) `constructor`

##### Summary

Initializes a new instance of the [GroupPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parent | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Unique identifier of the group's parent. |
| relativeDisplayOrder | [System.UInt32](https://learn.microsoft.com/dotnet/api/System.UInt32 'System.UInt32') | The display order of the group relative to other groups parented to the same control. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-ParentIdentifier'></a>
### ParentIdentifier `property`

##### Summary

Gets the identifier of the parent.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-RelativeDisplayOrder'></a>
### RelativeDisplayOrder `property`

##### Summary

Gets the display order of the group relative to other groups parented to the same control.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-VsctParentId'></a>
### VsctParentId `property`

##### Summary

Gets the legacy parent identifier.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-Equals-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-Menu-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration,System-UInt32-'></a>
### Menu(configuration,relativeDisplayOrder) `method`

##### Summary

Create a placement configuration using the configuration for a menu.

##### Returns

A [GroupPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration') | The menu configuration. |
| relativeDisplayOrder | [System.UInt32](https://learn.microsoft.com/dotnet/api/System.UInt32 'System.UInt32') | The display order of the group relative to other groups inside of the menu. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-Toolbar-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration,System-UInt32-'></a>
### Toolbar(configuration,relativeDisplayOrder) `method`

##### Summary

Create a placement configuration using the configuration for a toolbar.

##### Returns

A [GroupPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration') | The toolbar configuration. |
| relativeDisplayOrder | [System.UInt32](https://learn.microsoft.com/dotnet/api/System.UInt32 'System.UInt32') | The display order of the group relative to other groups inside of the toolbar. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-VsctParent-System-Guid,System-UInt32-'></a>
### VsctParent(guid,id) `method`

##### Summary

Create a placement configuration using the Guid/Id pair of a menu or toolbar defined via VSCT.

##### Returns

A [GroupPlacement](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement 'Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | The guid of the menu/toolbar. |
| id | [System.UInt32](https://learn.microsoft.com/dotnet/api/System.UInt32 'System.UInt32') | The id of the menu/toolbar. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProviderBase'></a>
## ITextViewMarginProviderBase `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

This interface is for internal use, implement ITextViewMarginProvider instead.

<a name='T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionClass'></a>
## IVisualStudioContributionClass `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Extenders can extend types implementing [IVisualStudioContributionClass](#T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionClass 'Microsoft.VisualStudio.Extensibility.IVisualStudioContributionClass') and mark their class with
[VisualStudioContributionAttribute](#T-Microsoft-VisualStudio-Extensibility-VisualStudioContributionAttribute 'Microsoft.VisualStudio.Extensibility.VisualStudioContributionAttribute') to allow it to be consumed by Visual Studio. This interface is
meant to be implemented by abstract classes provided by the VisualStudio.Extensibility libraries, extenders
shouldn't implement this interace directly.

<a name='T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionProperty'></a>
## IVisualStudioContributionProperty `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Types implementing [IVisualStudioContributionProperty](#T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionProperty 'Microsoft.VisualStudio.Extensibility.IVisualStudioContributionProperty') can be used to create static properties marked with
[VisualStudioContributionAttribute](#T-Microsoft-VisualStudio-Extensibility-VisualStudioContributionAttribute 'Microsoft.VisualStudio.Extensibility.VisualStudioContributionAttribute') which allows them to define metadata for the extension that is consumed
by Visual Studio. This interface is meant to be implemented by types provided by the VisualStudio.Extensibility
libraries, extenders shouldn't implement this interace directly.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-IconSettings'></a>
## IconSettings `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Settings for command icons.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconAndText'></a>
### IconAndText `constants`

##### Summary

In a toolbar, an icon and the display name of the command should be shown to represent in the command.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-IconOnly'></a>
### IconOnly `constants`

##### Summary

In a toolbar, only the icon should be shown to represent the command. In a menu, only the text will be shown.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-IconSettings-None'></a>
### None `constants`

##### Summary

None.

<a name='T-Microsoft-VisualStudio-Extensibility-ImageMoniker'></a>
## ImageMoniker `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Image monikers for images supplied by the extension or by the Visual Studio image catalog.

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-Custom-System-String-'></a>
### Custom(value) `method`

##### Summary

Initializes a [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') value.

##### Returns

The [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker'). |

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-Equals-Microsoft-VisualStudio-Extensibility-ImageMoniker-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-ToString'></a>
### ToString() `method`

##### Summary

Returns the string value of [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker').

##### Returns

The string value of [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-op_Equality-Microsoft-VisualStudio-Extensibility-ImageMoniker,Microsoft-VisualStudio-Extensibility-ImageMoniker-'></a>
### op_Equality(a,b) `method`

##### Summary

Compares two [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') values returning whether they are equal.

##### Returns

Whether the two values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') | The first value to compare. |
| b | [Microsoft.VisualStudio.Extensibility.ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') | The second value to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-ImageMoniker'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a `string` to a [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String) 'System.String') | The string value of [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker'). |

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-op_Implicit-Microsoft-VisualStudio-Extensibility-ImageMoniker-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') to a `string`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Microsoft.VisualStudio.Extensibility.ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') | The [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') to be converted. |

<a name='M-Microsoft-VisualStudio-Extensibility-ImageMoniker-op_Inequality-Microsoft-VisualStudio-Extensibility-ImageMoniker,Microsoft-VisualStudio-Extensibility-ImageMoniker-'></a>
### op_Inequality(a,b) `method`

##### Summary

Compares two [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') values returning whether they are different.

##### Returns

Whether the two values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') | The first instance to compare. |
| b | [Microsoft.VisualStudio.Extensibility.ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') | The second instance to compare. |

<a name='T-System-Runtime-CompilerServices-IsExternalInit'></a>
## IsExternalInit `type`

##### Namespace

System.Runtime.CompilerServices

##### Summary

Used by C# 9 for property `init` accessors.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-Key'></a>
## Key `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Key that can be used as a command's shortcut key.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-Key-None'></a>
### None `property`

##### Summary

Empty key.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-Key-VK_LBUTTON'></a>
### VK_LBUTTON `property`

##### Summary

Virtual key codes that are supported as key bindings.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Key-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Key-Equals-Microsoft-VisualStudio-Extensibility-Commands-Key-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Key-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Key-ToString'></a>
### ToString() `method`

##### Summary

Returns the string value of [Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key').

##### Returns

The string value of [Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Key-op_Equality-Microsoft-VisualStudio-Extensibility-Commands-Key,Microsoft-VisualStudio-Extensibility-Commands-Key-'></a>
### op_Equality(a,b) `method`

##### Summary

Compares two [Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') values returning whether they are equal.

##### Returns

Whether the two values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | The first value to compare. |
| b | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | The second value to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Key-op_Implicit-Microsoft-VisualStudio-Extensibility-Commands-Key-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') to a `string`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | The [Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') to be converted. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-Key-op_Inequality-Microsoft-VisualStudio-Extensibility-Commands-Key,Microsoft-VisualStudio-Extensibility-Commands-Key-'></a>
### op_Inequality(a,b) `method`

##### Summary

Compares two [Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') values returning whether they are different.

##### Returns

Whether the two values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | The first instance to compare. |
| b | [Microsoft.VisualStudio.Extensibility.Commands.Key](#T-Microsoft-VisualStudio-Extensibility-Commands-Key 'Microsoft.VisualStudio.Extensibility.Commands.Key') | The second instance to compare. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-KnownPlacements'></a>
## KnownPlacements `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands.CommandPlacement

##### Summary

Known locations that a command can be parented to.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-KnownPlacements'></a>
## KnownPlacements `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands.GroupPlacement

##### Summary

Known locations that a command can be parented to.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-KnownPlacements-ExtensionsMenu'></a>
### ExtensionsMenu `property`

##### Summary

Gets a group inside of the Extensions top level menu.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-KnownPlacements-ToolsMenu'></a>
### ToolsMenu `property`

##### Summary

Gets a group inside of the Tools top level menu.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-CommandPlacement-KnownPlacements-ViewOtherWindowsMenu'></a>
### ViewOtherWindowsMenu `property`

##### Summary

Gets a group inside of the View -> Other Windows menu.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-KnownPlacements-ExtensionsMenu'></a>
### ExtensionsMenu `property`

##### Summary

Gets the Extensions top level menu.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-KnownPlacements-ToolsMenu'></a>
### ToolsMenu `property`

##### Summary

Gets the Tools top level menu.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-GroupPlacement-KnownPlacements-ViewOtherWindowsMenu'></a>
### ViewOtherWindowsMenu `property`

##### Summary

Gets the View -> Other Windows menu.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues'></a>
## KnownValues `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement

##### Summary

Well-known [ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') values for container margins supplied by Visual Studio.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues'></a>
## KnownValues `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.DocumentType

##### Summary

Known document types extensions can target or derive their custom
document types from.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues'></a>
## KnownValues `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement

##### Summary

Well-known [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') values for margins supplied by Visual Studio.

<a name='T-Microsoft-VisualStudio-Extensibility-ImageMoniker-KnownValues'></a>
## KnownValues `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ImageMoniker

##### Summary

Well-known [ImageMoniker](#T-Microsoft-VisualStudio-Extensibility-ImageMoniker 'Microsoft.VisualStudio.Extensibility.ImageMoniker') values for images supplied with the Visual Studio image catalog.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Bottom'></a>
### Bottom `property`

##### Summary

The container margin below the text view.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-BottomControl'></a>
### BottomControl `property`

##### Summary

A horizontal margin container in the [Bottom](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Bottom 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.Bottom') margin that contains the [HorizontalScrollBarContainer](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-HorizontalScrollBarContainer 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.HorizontalScrollBarContainer').

##### Remarks

Margins that wish to appear to the left or right of the horizontal scrollbar and all its siblings should be added to
this container margin.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-BottomRightCorner'></a>
### BottomRightCorner `property`

##### Summary

The container margin to the right of the "Bottom" margin and below the "Right" margin.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-HorizontalScrollBarContainer'></a>
### HorizontalScrollBarContainer `property`

##### Summary

The container margin that contains the [HorizontalScrollBar](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-HorizontalScrollBar 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.HorizontalScrollBar') by default.

##### Remarks

Other margins can be placed to the left or right of the [HorizontalScrollBar](#P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-HorizontalScrollBar 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement.KnownValues.HorizontalScrollBar') depending on their order attribute.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Left'></a>
### Left `property`

##### Summary

The container margin to the left of the text view.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-LeftSelection'></a>
### LeftSelection `property`

##### Summary

The container margin to the left of the text view that implements mouse handlers for line selection.
This behavior is inherited by margins contained in the left selection margin.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Right'></a>
### Right `property`

##### Summary

The container margin to the right of the text view.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-RightControl'></a>
### RightControl `property`

##### Summary

A vertical margin container in the [Right](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Right 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.Right') margin that contains the [VerticalScrollBarContainer](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-VerticalScrollBarContainer 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.VerticalScrollBarContainer').

##### Remarks

Margins that wish to appear on top or bottom of the vertical scrollbar and all its siblings should be added
to this container margin.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-Top'></a>
### Top `property`

##### Summary

The container margin above the text view.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-VerticalScrollBar'></a>
### VerticalScrollBar `property`

##### Summary

The standard vertical scrollbar.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-VerticalScrollBarContainer'></a>
### VerticalScrollBarContainer `property`

##### Summary

The container margin that contains the [VerticalScrollBar](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-VerticalScrollBar 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.VerticalScrollBar') by default.

##### Remarks

Other margins can be placed above or below the [VerticalScrollBar](#P-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-KnownValues-VerticalScrollBar 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement.KnownValues.VerticalScrollBar') depending on their order attribute.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues-Code'></a>
### Code `property`

##### Summary

Gets base document type of any document containing code. Derives from [Text](#P-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues-Text 'Microsoft.VisualStudio.Extensibility.Editor.DocumentType.KnownValues.Text').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues-PlainText'></a>
### PlainText `property`

##### Summary

Gets base document type of plain text files.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-DocumentType-KnownValues-Text'></a>
### Text `property`

##### Summary

Gets base document type of any text based document.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-ChrMargin'></a>
### ChrMargin `property`

##### Summary

The margin to the right of the horizontal scrollbar containing the current character index of the caret on it's given line.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-ColMargin'></a>
### ColMargin `property`

##### Summary

The margin to the right of the horizontal scrollbar containing the current column location of the caret on it's given line.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-FileHealthIndicator'></a>
### FileHealthIndicator `property`

##### Summary

The margin to the left of the horizontal scroll bar that hosts a file health indicator.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-Glyph'></a>
### Glyph `property`

##### Summary

The margin to the left of the text view that shows breakpoint and other glyphs.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-HorizontalScrollBar'></a>
### HorizontalScrollBar `property`

##### Summary

The standard horizontal scrollbar.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-IndentationCharacterMargin'></a>
### IndentationCharacterMargin `property`

##### Summary

The margin to the right of the horizontal scrollbar describing what character gets inserted when you press tab.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-InsertModeMargin'></a>
### InsertModeMargin `property`

##### Summary

The margin to the right of the horizontal scrollbar containing the state of Insert/Overwrite mode.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-LineEndingMargin'></a>
### LineEndingMargin `property`

##### Summary

The margin to the right of the horizontal scrollbar containing the state of newlines in the view.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-LineNumber'></a>
### LineNumber `property`

##### Summary

The margin to the left of the text view that shows line numbers.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-Outlining'></a>
### Outlining `property`

##### Summary

The margin to the left of the text view that allows collapsing and expansion of outlining regions.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-OverviewChangeTracking'></a>
### OverviewChangeTracking `property`

##### Summary

Name of the margin that shows changes in the entire file.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-OverviewError'></a>
### OverviewError `property`

##### Summary

Name of the margin that shows errors in the entire file.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-OverviewMark'></a>
### OverviewMark `property`

##### Summary

Name of the margin that shows marks in the entire file.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-OverviewSourceImage'></a>
### OverviewSourceImage `property`

##### Summary

Name of the margin that shows a zoomed-out image of the entire file.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-RowMargin'></a>
### RowMargin `property`

##### Summary

The margin to the right of the horizontal scrollbar containing the current caret line number.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-SelectionStateMargin'></a>
### SelectionStateMargin `property`

##### Summary

The margin to the right of the horizontal scrollbar containing the state of selections in the view.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-Spacer'></a>
### Spacer `property`

##### Summary

The margin that appears between the line number and outlining margins and shows which text
has changed in the current session.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-Suggestion'></a>
### Suggestion `property`

##### Summary

The margin to the left of the text view that shows suggestion glyphs such as the Light Bulb.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-VerticalScrollBar'></a>
### VerticalScrollBar `property`

##### Summary

The standard vertical scrollbar.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-KnownValues-ZoomControl'></a>
### ZoomControl `property`

##### Summary

The margin to the left of the horizontal scroll bar that hosts a zoom control for zooming the view.

<a name='T-Microsoft-VisualStudio-Extensibility-LocalizableStringAttribute'></a>
## LocalizableStringAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

An attribute used to mark that a property or parameter should be localized by referencing a string defined in the
string-resources.json file.
This is used by the VisualStudio.Extensibility libraries for documentation purposes and it's not meant to be used
directly by extenders.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement'></a>
## MarginPlacement `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Identifies a text view margin placement.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-Custom-System-String-'></a>
### Custom(value) `method`

##### Summary

Initializes a [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') value.

##### Returns

The [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-Equals-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-FromTextViewMarginProvider``1'></a>
### FromTextViewMarginProvider\`\`1() `method`

##### Summary

Creates the [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') corresponding to an extension part implementing ITextViewMarginProvider.

##### Returns

The [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement').

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') of an extension part which implements ITextViewMarginProvider. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-ToString'></a>
### ToString() `method`

##### Summary

Returns the string value of [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement').

##### Returns

The string value of [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-op_Equality-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement,Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-'></a>
### op_Equality(a,b) `method`

##### Summary

Compares two [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') values returning whether they are equal.

##### Returns

Whether the two values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') | The first value to compare. |
| b | [Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') | The second value to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a `string` to a [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement'). |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-op_Implicit-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') to a `string`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') | The [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') to be converted. |

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-op_Inequality-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement,Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement-'></a>
### op_Inequality(a,b) `method`

##### Summary

Compares two [MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') values returning whether they are different.

##### Returns

Whether the two values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') | The first instance to compare. |
| b | [Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-MarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.MarginPlacement') | The second instance to compare. |

<a name='T-System-Diagnostics-CodeAnalysis-MaybeNullAttribute'></a>
## MaybeNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that an output may be `null` even if the
    corresponding type disallows it.

<a name='M-System-Diagnostics-CodeAnalysis-MaybeNullAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [MaybeNullAttribute](https://learn.microsoft.com/dotnet/api/System.Diagnostics.CodeAnalysis.MaybeNullAttribute 'System.Diagnostics.CodeAnalysis.MaybeNullAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute'></a>
## MaybeNullWhenAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that when a method returns [ReturnValue](https://learn.microsoft.com/dotnet/api/System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue'), 
    the parameter may be `null` even if the corresponding type disallows it.

<a name='M-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute-#ctor-System-Boolean-'></a>
### #ctor(returnValue) `constructor`

##### Summary

Initializes the attribute with the specified return value condition.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnValue | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | The return value condition.
    If the method returns this value, the associated parameter may be `null`. |

<a name='P-System-Diagnostics-CodeAnalysis-MaybeNullWhenAttribute-ReturnValue'></a>
### ReturnValue `property`

##### Summary

Gets the return value condition.
    If the method returns this value, the associated parameter may be `null`.

<a name='T-System-Diagnostics-CodeAnalysis-MemberNotNullAttribute'></a>
## MemberNotNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that the method or property will ensure that the listed field and property members have
    not-`null` values.

<a name='M-System-Diagnostics-CodeAnalysis-MemberNotNullAttribute-#ctor-System-String-'></a>
### #ctor(member) `constructor`

##### Summary

Initializes the attribute with a field or property member.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| member | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The field or property member that is promised to be not-null. |

<a name='M-System-Diagnostics-CodeAnalysis-MemberNotNullAttribute-#ctor-System-String[]-'></a>
### #ctor(members) `constructor`

##### Summary

Initializes the attribute with the list of field and property members.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| members | [System.String[]](https://learn.microsoft.com/dotnet/api/System.String 'System.String[]') | The list of field and property members that are promised to be not-null. |

<a name='P-System-Diagnostics-CodeAnalysis-MemberNotNullAttribute-Members'></a>
### Members `property`

##### Summary

Gets field or property member names.

<a name='T-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute'></a>
## MemberNotNullWhenAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that the method or property will ensure that the listed field and property members have
    non-`null` values when returning with the specified return value condition.

<a name='M-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-#ctor-System-Boolean,System-String-'></a>
### #ctor(returnValue,member) `constructor`

##### Summary

Initializes the attribute with the specified return value condition and a field or property member.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnValue | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | The return value condition. If the method returns this value,
    the associated parameter will not be `null`. |
| member | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The field or property member that is promised to be not-`null`. |

<a name='M-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-#ctor-System-Boolean,System-String[]-'></a>
### #ctor(returnValue,members) `constructor`

##### Summary

Initializes the attribute with the specified return value condition and list
    of field and property members.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnValue | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | The return value condition. If the method returns this value,
    the associated parameter will not be `null`. |
| members | [System.String[]](https://learn.microsoft.com/dotnet/api/System.String 'System.String[]') | The list of field and property members that are promised to be not-null. |

<a name='P-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-Members'></a>
### Members `property`

##### Summary

Gets field or property member names.

<a name='P-System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-ReturnValue'></a>
### ReturnValue `property`

##### Summary

Gets the return value condition.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-MenuChild'></a>
## MenuChild `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An instance of a control on a menu.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Separator'></a>
### Separator `property`

##### Summary

Gets a visual separator between two groups in a menu.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Anchor``1'></a>
### Anchor\`\`1() `method`

##### Summary

Create an instance of menu child placement for a dynamic command anchor.

##### Returns

The menu child placement for a dynamic command anchor.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the dynamic command anchor to be parented to the menu. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Command``1'></a>
### Command\`\`1() `method`

##### Summary

Create an instance of menu child placement for a command.

##### Returns

The menu child placement for a command.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the command to be parented to the menu. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Group-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-'></a>
### Group(commandGroupConfiguration) `method`

##### Summary

Create an instance of menu child placement for a group.

##### Returns

The menu child placement for a group.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandGroupConfiguration | [Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration') | The group being parented to the menu. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Group-Microsoft-VisualStudio-Extensibility-Commands-GroupChild[]-'></a>
### Group(groupChildren) `method`

##### Summary

Create an instance of menu child placement for a group.

##### Returns

The menu child placement for a group.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| groupChildren | [Microsoft.VisualStudio.Extensibility.Commands.GroupChild[]](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupChild 'Microsoft.VisualStudio.Extensibility.Commands.GroupChild[]') | The set of children to be parented to the group. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuChild-Menu-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-'></a>
### Menu(menuConfiguration) `method`

##### Summary

Create an instance of menu child placement.

##### Returns

The menu child placement.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| menuConfiguration | [Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration') | The configuration of the menu to be parented to the menu. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration'></a>
## MenuConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Configuration of a VisualStudio.Extensibility Menu.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-#ctor-System-String-'></a>
### #ctor(displayName) `constructor`

##### Summary

Initializes a new instance of the [MenuConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The initial display name for the container. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-Type'></a>
### Type `property`

##### Summary

Gets the type of the control container.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey'></a>
## ModifierKey `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Enum containing the modifier keys for shortcuts.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-Control'></a>
### Control `constants`

##### Summary

Control key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-ControlShift'></a>
### ControlShift `constants`

##### Summary

Control key and shift key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-ControlShiftLeftAlt'></a>
### ControlShiftLeftAlt `constants`

##### Summary

Control key, shift key and left alt key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-LeftAlt'></a>
### LeftAlt `constants`

##### Summary

Left alt key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-None'></a>
### None `constants`

##### Summary

Empty modifier key.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-ModifierKey-Shift'></a>
### Shift `constants`

##### Summary

Shift key.

<a name='T-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint'></a>
## NotActivationConstraint `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ActivationConstraint

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-NotActivationConstraint-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-NotNullAttribute'></a>
## NotNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that an output is not `null` even if the
    corresponding type allows it.

<a name='M-System-Diagnostics-CodeAnalysis-NotNullAttribute-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [NotNullAttribute](https://learn.microsoft.com/dotnet/api/System.Diagnostics.CodeAnalysis.NotNullAttribute 'System.Diagnostics.CodeAnalysis.NotNullAttribute') class.

##### Parameters

This constructor has no parameters.

<a name='T-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute'></a>
## NotNullIfNotNullAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that the output will be non-`null` if the
    named parameter is non-`null`.

<a name='M-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute-#ctor-System-String-'></a>
### #ctor(parameterName) `constructor`

##### Summary

Initializes the attribute with the associated parameter name.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameterName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The associated parameter name.
    The output will be non-`null` if the argument to the
    parameter specified is non-`null`. |

<a name='P-System-Diagnostics-CodeAnalysis-NotNullIfNotNullAttribute-ParameterName'></a>
### ParameterName `property`

##### Summary

Gets the associated parameter name.
    The output will be non-`null` if the argument to the
    parameter specified is non-`null`.

<a name='T-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute'></a>
## NotNullWhenAttribute `type`

##### Namespace

System.Diagnostics.CodeAnalysis

##### Summary

Specifies that when a method returns [ReturnValue](https://learn.microsoft.com/dotnet/api/System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue'),
    the parameter will not be `null` even if the corresponding type allows it.

<a name='M-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute-#ctor-System-Boolean-'></a>
### #ctor(returnValue) `constructor`

##### Summary

Initializes the attribute with the specified return value condition.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnValue | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | The return value condition.
    If the method returns this value, the associated parameter will not be `null`. |

<a name='P-System-Diagnostics-CodeAnalysis-NotNullWhenAttribute-ReturnValue'></a>
### ReturnValue `property`

##### Summary

Gets the return value condition.
    If the method returns this value, the associated parameter will not be `null`.

<a name='T-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint'></a>
## OrActivationConstraint `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ActivationConstraint

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint-Equals-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-OrActivationConstraint-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ProjectCapability'></a>
## ProjectCapability `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Project capability to be used in [SolutionHasProjectCapability](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionHasProjectCapability-Microsoft-VisualStudio-Extensibility-ProjectCapability- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.SolutionHasProjectCapability(Microsoft.VisualStudio.Extensibility.ProjectCapability)').

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-AppDesigner'></a>
### AppDesigner `property`

##### Summary

Indicates that the project uses the app designer for managing project properties.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-AssemblyReferences'></a>
### AssemblyReferences `property`

##### Summary

Indicates that the project supports assembly references.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-COMReferences'></a>
### COMReferences `property`

##### Summary

Indicates that the project supports COM references.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-CPS'></a>
### CPS `property`

##### Summary

Project is based on the Project System Extensibility SDK.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-CSharp'></a>
### CSharp `property`

##### Summary

Project may contain or compile C# source files.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-Cordova'></a>
### Cordova `property`

##### Summary

The project integrates with and depends on Apache Cordova.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-DeclaredSourceItems'></a>
### DeclaredSourceItems `property`

##### Summary

Indicates that the project is a typical MSBuild project (not DNX) in that it declares source items in the project itself (rather than a project.json file that assumes all files in the directory are part of a compilation).

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-DependenciesTree'></a>
### DependenciesTree `property`

##### Summary

Indicates that the project supports the dependencies node in Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-DeploymentProject'></a>
### DeploymentProject `property`

##### Summary

Indicates a project that is capable of provisioning Azure resources using Azure Resource Manager that will create an environment for an application.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-EditAndContinue'></a>
### EditAndContinue `property`

##### Summary

Indicates that the project supports the edit and continue debugging feature.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-FabricApplication'></a>
### FabricApplication `property`

##### Summary

Indicates a project that represents a Service Fabric application.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-FileSystemBasedCordovaProject'></a>
### FileSystemBasedCordovaProject `property`

##### Summary

Indicates that the Cordova project looks to the file system to determine the project content. This is the defining capability for the project system in Visual Studio Tools for Apache Cordova.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-FolderPublish'></a>
### FolderPublish `property`

##### Summary

Indicates a project that is capable of publishing the deployment artifacts to a folder.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-HandlesOwnReload'></a>
### HandlesOwnReload `property`

##### Summary

Indicates that the project can handle a reload by itself (potentially smartly) without the solution doing a full reload of the project when the project file changes on disk.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScript'></a>
### JavaScript `property`

##### Summary

Project contains and handles JavaScript source files.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptProject'></a>
### JavaScriptProject `property`

##### Summary

Indicates that the project supports JavaScript development. This capability also means that the project can manage JavaScript related project items.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptUAPProject'></a>
### JavaScriptUAPProject `property`

##### Summary

The JavaScript project targets the Universal Windows Platform of Windows 10.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptWJProject'></a>
### JavaScriptWJProject `property`

##### Summary

The JavaScript project targets Windows 8.1 desktop platform.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptWindowsAppContainerProject'></a>
### JavaScriptWindowsAppContainerProject `property`

##### Summary

Indicates that the project is both "JavaScript" and "WindowsAppContainer", so all JavaScript projects that emit *.AppX bundles will declare this capability.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-JavaScriptWindowsPhoneProject'></a>
### JavaScriptWindowsPhoneProject `property`

##### Summary

The JavaScript project targets Windows Phone 8.1 platform.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-LSJavaScript_v45'></a>
### LSJavaScript_v45 `property`

##### Summary

Indicates a project that represents a LightSwitch JavaScript V4.5 project.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-LaunchProfiles'></a>
### LaunchProfiles `property`

##### Summary

Indicates that the project supports multiple profiles for debugging.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-MultiTarget'></a>
### MultiTarget `property`

##### Summary

Indicates that items in this project may be applied to multiple platforms.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-NoGeneralDependentFileIcon'></a>
### NoGeneralDependentFileIcon `property`

##### Summary

Indicates that dependent files should have their own corresponding icons instead of generic one.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-OpenProjectFile'></a>
### OpenProjectFile `property`

##### Summary

Indicates that the project is capable of handling the project file being edited live in an IDE while the project is already loaded.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-PackageReferences'></a>
### PackageReferences `property`

##### Summary

Indicates that the project supports package references. For eg: C# projects use PackageReference items for NuGet package references.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-PerPlatformCompilation'></a>
### PerPlatformCompilation `property`

##### Summary

(aka. #ifdef capability) Indicates that items in this project are compiled individually for every target platform.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ProjectReferences'></a>
### ProjectReferences `property`

##### Summary

Indicates that the project supports project references.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerAssemblies'></a>
### ReferenceManagerAssemblies `property`

##### Summary

Indicates that the project will show the Assemblies tab in the Reference manager dialog in Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerBrowse'></a>
### ReferenceManagerBrowse `property`

##### Summary

Indicates that the project will show the Browse button in the Reference manager dialog in Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerCOM'></a>
### ReferenceManagerCOM `property`

##### Summary

Indicates that the project will show the COM tab in the Reference manager dialog in Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerProjects'></a>
### ReferenceManagerProjects `property`

##### Summary

Indicates that the project will show the Projects tab in the Reference manager dialog in Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerSharedProjects'></a>
### ReferenceManagerSharedProjects `property`

##### Summary

Indicates that the project will show the Shared Projects tab in the Reference manager dialog in Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-ReferenceManagerWinRT'></a>
### ReferenceManagerWinRT `property`

##### Summary

Indicates that the project will show the WinRT tab in the Reference manager dialog in Visual Studio.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-SDKReferences'></a>
### SDKReferences `property`

##### Summary

Indicates that the project supports SDK references.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-SharedProjectReferences'></a>
### SharedProjectReferences `property`

##### Summary

Indicates that the project supports references to Shared Projects.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-TestContainer'></a>
### TestContainer `property`

##### Summary

The project may contain unit tests.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-TypeScript'></a>
### TypeScript `property`

##### Summary

Indicates that the TypeScript build targets are imported into the project and the project is capable of compiling TypeScript source files into JavaScript.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-UseFileGlobs'></a>
### UseFileGlobs `property`

##### Summary

Indicates that the project file can include files using MSBuild file globbing patterns.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-UserSourceItems'></a>
### UserSourceItems `property`

##### Summary

Indicates that the user is allowed to add arbitrary files to their project.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-VB'></a>
### VB `property`

##### Summary

Project may contain or compile VB source files.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-VisualC'></a>
### VisualC `property`

##### Summary

Project may contain or compile C++ source files.

<a name='P-Microsoft-VisualStudio-Extensibility-ProjectCapability-WinRTReferences'></a>
### WinRTReferences `property`

##### Summary

Indicates that the project references WinRT libraries.

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-Custom-System-String-'></a>
### Custom(value) `method`

##### Summary

Initializes a [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') value.

##### Returns

The [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability'). |

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-Equals-Microsoft-VisualStudio-Extensibility-ProjectCapability-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-ToString'></a>
### ToString() `method`

##### Summary

Returns the string value of [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability').

##### Returns

The string value of [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-op_Equality-Microsoft-VisualStudio-Extensibility-ProjectCapability,Microsoft-VisualStudio-Extensibility-ProjectCapability-'></a>
### op_Equality(a,b) `method`

##### Summary

Compares two [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') values returning whether they are equal.

##### Returns

Whether the two values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') | The first value to compare. |
| b | [Microsoft.VisualStudio.Extensibility.ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') | The second value to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-op_Implicit-System-String-~Microsoft-VisualStudio-Extensibility-ProjectCapability'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a `string` to a [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The string value of [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability'). |

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-op_Implicit-Microsoft-VisualStudio-Extensibility-ProjectCapability-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') to a `string`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Microsoft.VisualStudio.Extensibility.ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') | The [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') to be converted. |

<a name='M-Microsoft-VisualStudio-Extensibility-ProjectCapability-op_Inequality-Microsoft-VisualStudio-Extensibility-ProjectCapability,Microsoft-VisualStudio-Extensibility-ProjectCapability-'></a>
### op_Inequality(a,b) `method`

##### Summary

Compares two [ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') values returning whether they are different.

##### Returns

Whether the two values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') | The first instance to compare. |
| b | [Microsoft.VisualStudio.Extensibility.ProjectCapability](#T-Microsoft-VisualStudio-Extensibility-ProjectCapability 'Microsoft.VisualStudio.Extensibility.ProjectCapability') | The second instance to compare. |

<a name='T-Microsoft-VisualStudio-Extensibility-Contracts-Resources'></a>
## Resources `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Contracts

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-CommandIdAlreadyRegistered'></a>
### CommandIdAlreadyRegistered `property`

##### Summary

Looks up a localized string similar to Command ID is already registered..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ContainerChildArgumentException'></a>
### ContainerChildArgumentException `property`

##### Summary

Looks up a localized string similar to "'{0}' must implement {1}".

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorCanOnlyBeInvokedAtCompileTime'></a>
### ErrorCanOnlyBeInvokedAtCompileTime `property`

##### Summary

Looks up a localized string similar to This method can only be invoked at compile-time during the evaluation of a compile-time constant property. Compile-time constants are consumed when bulding the extension to generate the extension metadata, they are not meant to be referenced at runtime..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDebuggerVisualizersOnlySupportConcreteTypes'></a>
### ErrorDebuggerVisualizersOnlySupportConcreteTypes `property`

##### Summary

Looks up a localized string similar to Only concrete types are supported by debugger visualizers.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDebuggerVisualizersOnlySupportUnboundGenerics'></a>
### ErrorDebuggerVisualizersOnlySupportUnboundGenerics `property`

##### Summary

Looks up a localized string similar to Only generic types that are unbound are supported by debugger visualizers.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDocumentTypeAlreadyDefined'></a>
### ErrorDocumentTypeAlreadyDefined `property`

##### Summary

Looks up a localized string similar to The document type is already defined in this assembly.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDuplicatedBaseDocumentType'></a>
### ErrorDuplicatedBaseDocumentType `property`

##### Summary

Looks up a localized string similar to Duplicated base document type..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorDuplicatedExtension'></a>
### ErrorDuplicatedExtension `property`

##### Summary

Looks up a localized string similar to Duplicated extension..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorFileExtensionCannotBeNullOrEmpty'></a>
### ErrorFileExtensionCannotBeNullOrEmpty `property`

##### Summary

Looks up a localized string similar to File extension cannot be null or empty..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorFileExtensionsMustStartWithADot'></a>
### ErrorFileExtensionsMustStartWithADot `property`

##### Summary

Looks up a localized string similar to File extension must start with a '.' character..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMessageDocumentTypeAlreadyDefined'></a>
### ErrorMessageDocumentTypeAlreadyDefined `property`

##### Summary

Looks up a localized string similar to The document type '{0}' is already defined in this assembly.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMessageMissingExtensionClass'></a>
### ErrorMessageMissingExtensionClass `property`

##### Summary

Looks up a localized string similar to VisualStudio.Extensibility projects must contribute one class extending Microsoft.VisualStudio.Extensibility.Extension.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMessageMultipleExtensionClasses'></a>
### ErrorMessageMultipleExtensionClasses `property`

##### Summary

Looks up a localized string similar to VisualStudio.Extensibility projects must contribute a single class extending Microsoft.VisualStudio.Extensibility.Extension.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMissingExtensionClass'></a>
### ErrorMissingExtensionClass `property`

##### Summary

Looks up a localized string similar to Missing Extension class.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMultipleExtensionClasses'></a>
### ErrorMultipleExtensionClasses `property`

##### Summary

Looks up a localized string similar to Only one Extension class is supported.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ErrorMustImplementITextViewMarginProvider'></a>
### ErrorMustImplementITextViewMarginProvider `property`

##### Summary

Looks up a localized string similar to The type parameter must implement ITextViewMarginProvider..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-InvalidVersionString'></a>
### InvalidVersionString `property`

##### Summary

Looks up a localized string similar to Invalid version identifier..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-PriorityIsOnlyForVsctPlacements'></a>
### PriorityIsOnlyForVsctPlacements `property`

##### Summary

Looks up a localized string similar to {0} can only be used when parenting to a control defined through VSCT..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-TypeDoesNotExtendOtherType'></a>
### TypeDoesNotExtendOtherType `property`

##### Summary

Looks up a localized string similar to The type '{0}' does not extend '{1}'.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-UnsupportedDocumentMoniker'></a>
### UnsupportedDocumentMoniker `property`

##### Summary

Looks up a localized string similar to Unsupported document moniker..

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-WarningCouldntFindImageAssetDirectory'></a>
### WarningCouldntFindImageAssetDirectory `property`

##### Summary

Looks up a localized string similar to Couldn't find image asset directory.

<a name='P-Microsoft-VisualStudio-Extensibility-Contracts-Resources-WarningMessageCouldntFindImageAssetDirectory'></a>
### WarningMessageCouldntFindImageAssetDirectory `property`

##### Summary

Looks up a localized string similar to Couldn't find image asset directory {0}.

<a name='T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute'></a>
## ServiceFactoryRegistrationAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Describes a mapping from service moniker to internal service factory type and extension part instance type.

<a name='M-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-#ctor-System-String,System-String,System-Type,System-Type,System-Type-'></a>
### #ctor(serviceName,serviceVersion,factoryType,instanceType,interfaceType) `constructor`

##### Summary

Initializes a new instance of the [ServiceFactoryRegistrationAttribute](#T-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute 'Microsoft.VisualStudio.Extensibility.ServiceFactoryRegistrationAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Name of the service. |
| serviceVersion | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Version of the service. |
| factoryType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | Factory class type. |
| instanceType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | Optional service object instance class type, if specified the type info will be passed to the factory. |
| interfaceType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | Optional interface type, if specified the type info will be passed to factory to determine the wrapper type. |

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-FactoryType'></a>
### FactoryType `property`

##### Summary

Gets the service factory type.

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-InstanceType'></a>
### InstanceType `property`

##### Summary

Gets the service object instance type.

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-InterfaceType'></a>
### InterfaceType `property`

##### Summary

Gets the target interface type for this service moniker, should be specified if instance type is implementing multiple interfaces.

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceFactoryRegistrationAttribute-Moniker'></a>
### Moniker `property`

##### Summary

Gets the service moniker.

<a name='T-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker'></a>
## ServiceHubServiceMoniker `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

A record for a brokered service moniker.

<a name='M-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker-#ctor-System-String,System-String-'></a>
### #ctor(name,version) `constructor`

##### Summary

Initializes a new instance of the [ServiceHubServiceMoniker](#T-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker 'Microsoft.VisualStudio.Extensibility.ServiceHubServiceMoniker') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Service name. |
| version | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | Service version. |

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker-Name'></a>
### Name `property`

##### Summary

Gets the service identifier.

<a name='P-Microsoft-VisualStudio-Extensibility-ServiceHubServiceMoniker-Version'></a>
### Version `property`

##### Summary

Gets the service version.

<a name='T-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell'></a>
## Shell `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ClientContextKey

##### Summary

Shell client context keys.

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveEditorContentType'></a>
### ActiveEditorContentType `property`

##### Summary

Content type of the active editor view.

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveEditorFileName'></a>
### ActiveEditorFileName `property`

##### Summary

File name for the document that belongs to active editor view.

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveSelectionFileName'></a>
### ActiveSelectionFileName `property`

##### Summary

File name of the selected item in solution explorer.

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveSelectionPath'></a>
### ActiveSelectionPath `property`

##### Summary

Full path for the selected item in solution explorer.

<a name='P-Microsoft-VisualStudio-Extensibility-ClientContextKey-Shell-ActiveSelectionUri'></a>
### ActiveSelectionUri `property`

##### Summary

Full URI for the selected item in solution explorer.

<a name='T-Microsoft-VisualStudio-Extensibility-SolutionState'></a>
## SolutionState `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Solution state values to be used in [SolutionState](#M-Microsoft-VisualStudio-Extensibility-ActivationConstraint-SolutionState-Microsoft-VisualStudio-Extensibility-SolutionState- 'Microsoft.VisualStudio.Extensibility.ActivationConstraint.SolutionState(Microsoft.VisualStudio.Extensibility.SolutionState)').

<a name='F-Microsoft-VisualStudio-Extensibility-SolutionState-Building'></a>
### Building `constants`

##### Summary

Solution is building.

<a name='F-Microsoft-VisualStudio-Extensibility-SolutionState-Empty'></a>
### Empty `constants`

##### Summary

Solution contains no projects but may contain solution items.

<a name='F-Microsoft-VisualStudio-Extensibility-SolutionState-Exists'></a>
### Exists `constants`

##### Summary

A solution is opened but may be in loaded or loading state.

<a name='F-Microsoft-VisualStudio-Extensibility-SolutionState-FullyLoaded'></a>
### FullyLoaded `constants`

##### Summary

A solution is opened and fully loaded.

<a name='F-Microsoft-VisualStudio-Extensibility-SolutionState-MultipleProject'></a>
### MultipleProject `constants`

##### Summary

Solution contains multiple projects.

<a name='F-Microsoft-VisualStudio-Extensibility-SolutionState-NoSolution'></a>
### NoSolution `constants`

##### Summary

No solution loaded.

<a name='F-Microsoft-VisualStudio-Extensibility-SolutionState-SingleProject'></a>
### SingleProject `constants`

##### Summary

Solution contains a single project.

<a name='T-Microsoft-VisualStudio-Extensibility-Internal-StringBasedEnumAttribute'></a>
## StringBasedEnumAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Internal

##### Summary

An attribute used to enable string-based enumeration code generation.

<a name='M-Microsoft-VisualStudio-Extensibility-Internal-StringBasedEnumAttribute-#ctor-System-String,System-Boolean-'></a>
### #ctor(defaultValue,allowsConversionFromString) `constructor`

##### Summary

Initializes a new instance of the [StringBasedEnumAttribute](#T-Microsoft-VisualStudio-Extensibility-Internal-StringBasedEnumAttribute 'Microsoft.VisualStudio.Extensibility.Internal.StringBasedEnumAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| defaultValue | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The default value of the uninitialized enumeration struct. |
| allowsConversionFromString | [System.Boolean](https://learn.microsoft.com/dotnet/api/System.Boolean 'System.Boolean') | Whether a Custom(string) method and an implicit convesion are generated
allowing the extender to create enumeration values from an arbitrary string. |

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration'></a>
## TextViewExtensionConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Configuration for an ITextViewListener extension part.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-AppliesTo'></a>
### AppliesTo `property`

##### Summary

Gets or sets the conditions under which the ITextViewListener should be activated.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewExtensionConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType'></a>
## TextViewMarginGridUnitType `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Describes the kind of value that [GridCellLength](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-GridCellLength 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.GridCellLength') object is holding.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType-Auto'></a>
### Auto `constants`

##### Summary

The size is determined by the size properties of the content object.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType-Pixel'></a>
### Pixel `constants`

##### Summary

The value is expressed as a pixel.

<a name='F-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType-Star'></a>
### Star `constants`

##### Summary

The value is expressed as a weighted proportion of available space.

<a name='T-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration'></a>
## TextViewMarginProviderConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Editor

##### Summary

Configuration for an ITextViewMarginProvider extension part.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-#ctor-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement-'></a>
### #ctor(marginContainer) `constructor`

##### Summary

Initializes a new instance of the [TextViewMarginProviderConfiguration](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration') class.

##### Returns

The [TextViewMarginProviderConfiguration](#T-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| marginContainer | [Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement](#T-Microsoft-VisualStudio-Extensibility-Editor-ContainerMarginPlacement 'Microsoft.VisualStudio.Extensibility.Editor.ContainerMarginPlacement') | The margin that contains this margin. |

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-After'></a>
### After `property`

##### Summary

Gets or sets the optional margin after which this margin should be placed.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-Before'></a>
### Before `property`

##### Summary

Gets or sets the optional margin before which this margin should be placed.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-GridCellLength'></a>
### GridCellLength `property`

##### Summary

Gets or sets the size of the grid cell in which the margin should be placed.
Defaults to 1.0.

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-GridUnitType'></a>
### GridUnitType `property`

##### Summary

Gets or sets the grid unit type to be used for drawing of this element in the container margin's grid.
Describes the kind of value that a [GridCellLength](#P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-GridCellLength 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginProviderConfiguration.GridCellLength') object is holding.
Defaults to [Auto](#F-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginGridUnitType-Auto 'Microsoft.VisualStudio.Extensibility.Editor.TextViewMarginGridUnitType.Auto').

<a name='P-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-MarginContainer'></a>
### MarginContainer `property`

##### Summary

Gets the name of the margin that contains this margin.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Editor-TextViewMarginProviderConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration'></a>
## ToolWindowConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

Configuration for a tool window.

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-AllowAutoCreation'></a>
### AllowAutoCreation `property`

##### Summary

Gets or sets a value indicating whether the tool window can be created automatically.

##### Remarks

When true, the tool window will be created if it should be visible in the current window layout or when any
relevant visibility contexts activate. When false the tool window will not be created as part of loading any
window layout or due to visibility contexts, and the only way to trigger the creation is to manually show it.

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-DockDirection'></a>
### DockDirection `property`

##### Summary

Gets or sets the dock direction where the tool window should be placed relative to the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Placement') value.

##### Remarks

If the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Placement') has the value [Floating](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Floating 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.Floating') this value is ignored. If
the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Placement') has the value [DocumentWell](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DocumentWell 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.DocumentWell') this value will dock
the tool window to the corresponding side of the main window's document well. If the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Placement') is
any other value the tool window will be docked relative to the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Placement') based on the value of the
"Insert new tabs to the right" setting with the exception of [Left](#F-Microsoft-VisualStudio-Extensibility-ToolWindows-Dock-Left 'Microsoft.VisualStudio.Extensibility.ToolWindows.Dock.Left') which will always dock to
the left of the [Placement](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Placement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowConfiguration.Placement').

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Placement'></a>
### Placement `property`

##### Summary

Gets or sets the default placement location for the tool window. This can be a well-known value, or the
identifier of another tool window.

##### Remarks

If the value is [Floating](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Floating 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.Floating') the tool window will be created in its own floating
window. If the value is [DocumentWell](#P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DocumentWell 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement.DocumentWell') the tool window will be docked in
relation to the main window's document well. Any other value will attempt to find the referenced location and
dock the tool window relative to that location, but if that location cannot be found, the tool window will
fallback to opening in a floating window.

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-VisibleWhen'></a>
### VisibleWhen `property`

##### Summary

Gets or sets the optional [ActivationConstraint](#T-Microsoft-VisualStudio-Extensibility-ActivationConstraint 'Microsoft.VisualStudio.Extensibility.ActivationConstraint') describing when the tool window is visible.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Equals-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement'></a>
## ToolWindowPlacement `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.ToolWindows

##### Summary

Tool window placement.

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DocumentWell'></a>
### DocumentWell `property`

##### Summary

Places the tool window in the active document well by default.

<a name='P-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Floating'></a>
### Floating `property`

##### Summary

Places the tool window in a standalone floating window by default.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-DockedTo-System-Guid-'></a>
### DockedTo(value) `method`

##### Summary

Initializes a new instance of the [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') struct.

##### Returns

The [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | The [Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') of the tool window to dock to. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-Equals-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-ToString'></a>
### ToString() `method`

##### Summary

Returns the string value of [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement').

##### Returns

The string value of [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement').

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-op_Equality-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement,Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-'></a>
### op_Equality(a,b) `method`

##### Summary

Compares two [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') values returning whether they are equal.

##### Returns

Whether the two values are equal.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') | The first value to compare. |
| b | [Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') | The second value to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-op_Implicit-System-Guid-~Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') to a [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | The modifier key name. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-op_Implicit-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-~System-String'></a>
### op_Implicit(value) `method`

##### Summary

Implicitly converts a [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') to a `string`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') | The [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') to be converted. |

<a name='M-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-op_Inequality-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement,Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement-'></a>
### op_Inequality(a,b) `method`

##### Summary

Compares two [ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') values returning whether they are different.

##### Returns

Whether the two values are different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') | The first instance to compare. |
| b | [Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement](#T-Microsoft-VisualStudio-Extensibility-ToolWindows-ToolWindowPlacement 'Microsoft.VisualStudio.Extensibility.ToolWindows.ToolWindowPlacement') | The second instance to compare. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild'></a>
## ToolbarChild `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

An instance of a control on a toolbar.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Separator'></a>
### Separator `property`

##### Summary

Gets a visual separator between two groups in a toolbar.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Anchor``1'></a>
### Anchor\`\`1() `method`

##### Summary

Create an instance of toolbar child placement for a dynamic command anchor.

##### Returns

The toolbar child placement for a dynamic command anchor.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the dynamic command anchor to be parented to the toolbar. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Command``1'></a>
### Command\`\`1() `method`

##### Summary

Create an instance of toolbar child placement for a command.

##### Returns

The toolbar child placement for a command.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the command to be parented to the toolbar. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Group-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration-'></a>
### Group(commandGroupConfiguration) `method`

##### Summary

Create an instance of toolbar child placement for a group.

##### Returns

The toolbar child placement for a group.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandGroupConfiguration | [Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-CommandGroupConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.CommandGroupConfiguration') | The group being parented to the toolbar. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Group-Microsoft-VisualStudio-Extensibility-Commands-GroupChild[]-'></a>
### Group(groupChildren) `method`

##### Summary

Create an instance of menu child placement for a group.

##### Returns

The menu child placement for a group.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| groupChildren | [Microsoft.VisualStudio.Extensibility.Commands.GroupChild[]](#T-Microsoft-VisualStudio-Extensibility-Commands-GroupChild 'Microsoft.VisualStudio.Extensibility.Commands.GroupChild[]') | The set of children to be parented to the group. |

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarChild-Toolbar-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration-'></a>
### Toolbar(menuConfiguration) `method`

##### Summary

Create an instance of toolbar child placement.

##### Returns

The toolbar child placement.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| menuConfiguration | [Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-MenuConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.MenuConfiguration') | The configuration of the menu to be parented to the toolbar. |

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration'></a>
## ToolbarConfiguration `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Configuration of a VisualStudio.Extensibility Toolbar.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-#ctor-System-String-'></a>
### #ctor(displayName) `constructor`

##### Summary

Initializes a new instance of the [ToolbarConfiguration](#T-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration 'Microsoft.VisualStudio.Extensibility.Commands.ToolbarConfiguration') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The initial display name for the container. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-Type'></a>
### Type `property`

##### Summary

Gets the type of the control container.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-Equals-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-Equals-System-Object-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-ToolbarConfiguration-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities'></a>
## UserDefinedTypeUtilities `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

Utility methods for interacting with [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') instances that may be a UserDefinedType.

<a name='M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-AreEquivalent-System-Type,System-Type-'></a>
### AreEquivalent(first,second) `method`

##### Summary

Checks if `first` and `second` represent the same type.

##### Returns

Whether `first` and `second` represent the same type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The first type to compare. |
| second | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The second type to compare. |

<a name='M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-ImplementsInterface-System-Type,System-String-'></a>
### ImplementsInterface(implementer,interfaceTypeName) `method`

##### Summary

Checks  if the type `implementer` implements `interfaceTypeName`.

##### Returns

Whether `implementer` implements `interfaceTypeName`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| implementer | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type to be checked. |
| interfaceTypeName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The type name of the interface as provided by [ToString](https://learn.microsoft.com/dotnet/api/System.Type.ToString 'System.Type.ToString'). |

<a name='M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-IsAssignableTo-System-Type,System-Type-'></a>
### IsAssignableTo(assignee,target) `method`

##### Summary

Checks if `assignee` can be assigned to a variable of type `target`.

##### Returns

Whether `assignee` can be assigned to `target`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| assignee | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type of the object to be assigned. |
| target | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type of the variable being assigned to. |

<a name='M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-IsOrExtends-System-Type,System-String-'></a>
### IsOrExtends(extender,baseTypeName) `method`

##### Summary

Checks if the type `extender` is or extends `baseTypeName`.

##### Returns

Whether `extender` is or extends `baseTypeName`.
`baseTypeName` cannot be an interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| extender | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type to be checked. |
| baseTypeName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The type name of the base class as provided by [ToString](https://learn.microsoft.com/dotnet/api/System.Type.ToString 'System.Type.ToString'). |

<a name='M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-ValidateTypeRepresentsAnchor-System-Type-'></a>
### ValidateTypeRepresentsAnchor(t) `method`

##### Summary

Validates that the provided [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') extends the DynamicCommandAnchor class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type to validate. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](https://learn.microsoft.com/dotnet/api/System.ArgumentException 'System.ArgumentException') | Thrown if the provided type does not extend the DynamicCommandAnchor class. |

<a name='M-Microsoft-VisualStudio-Extensibility-UserDefinedTypeUtilities-ValidateTypeRepresentsCommand-System-Type-'></a>
### ValidateTypeRepresentsCommand(t) `method`

##### Summary

Validates that the provided [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') extends the Command class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| t | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The type to validate. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](https://learn.microsoft.com/dotnet/api/System.ArgumentException 'System.ArgumentException') | Thrown if the provided type does not extend the Command class. |

<a name='T-Microsoft-VisualStudio-Extensibility-VisualStudioContributionAttribute'></a>
## VisualStudioContributionAttribute `type`

##### Namespace

Microsoft.VisualStudio.Extensibility

##### Summary

An attribute used to contribute VisualStudio.Extensibility components from the extension and allow Visual Studio to
consume them. This attribute can be applied to types that extend an abstract class which implements
[IVisualStudioContributionClass](#T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionClass 'Microsoft.VisualStudio.Extensibility.IVisualStudioContributionClass') or on properties of a type that implements
[IVisualStudioContributionProperty](#T-Microsoft-VisualStudio-Extensibility-IVisualStudioContributionProperty 'Microsoft.VisualStudio.Extensibility.IVisualStudioContributionProperty').

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType'></a>
## VisualizerObjectSourceType `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

The [Type](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType-Type 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceType.Type') of the visualizer object source loaded in the debug target process to access the object to be visualized.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType-#ctor-System-Type-'></a>
### #ctor(type) `constructor`

##### Summary

Initializes a new instance of the [VisualizerObjectSourceType](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceType') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') of the type of the visualizer object source loaded in the debug
target process to access the object to be visualized. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType-#ctor-System-String-'></a>
### #ctor(type) `constructor`

##### Summary

Initializes a new instance of the [VisualizerObjectSourceType](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceType') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The [Type](#P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType-Type 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerObjectSourceType.Type') of the visualizer object source loaded in the debug target process to
access the object to be visualized. |

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerObjectSourceType-Type'></a>
### Type `property`

##### Summary

Gets the [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') of the type of the visualizer object source loaded in the debug
target process to access the object to be visualized.

<a name='T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType'></a>
## VisualizerTargetType `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.DebuggerVisualizers

##### Summary

The [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') that a debugger visualizer will target and the corresponding display name for the visualizer.

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType-#ctor-System-String,System-Type-'></a>
### #ctor(visualizerDisplayName,targetType) `constructor`

##### Summary

Initializes a new instance of the [VisualizerTargetType](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visualizerDisplayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The display name of the debugger visualizer. |
| targetType | [System.Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') | The [Type](https://learn.microsoft.com/dotnet/api/System.Type 'System.Type') that is supported by this debugger visualizer.

`targetType` must be a concrete type. The debugger visualizer will only
support objects of type `targetType`, not objects of types extending `targetType`.

If `targetType` is a generic type, it must be unbound.

Trailing compoments of the [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') can be omitted. |

<a name='M-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType-#ctor-System-String,System-String-'></a>
### #ctor(visualizerDisplayName,targetType) `constructor`

##### Summary

Initializes a new instance of the [VisualizerTargetType](#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType 'Microsoft.VisualStudio.Extensibility.DebuggerVisualizers.VisualizerTargetType') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visualizerDisplayName | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The display name of the debugger visualizer. |
| targetType | [System.String](https://learn.microsoft.com/dotnet/api/System.String 'System.String') | The [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') of the type that is supported by this
debugger visualizer.

`targetType` must be a concrete type. The debugger visualizer will only
support objects of type `targetType`, not objects of types extending `targetType`.

If `targetType` is a generic type, it must be unbound.

Trailing compoments of the [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') can be omitted. |

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType-TargetType'></a>
### TargetType `property`

##### Summary

Gets the [AssemblyQualifiedName](https://learn.microsoft.com/dotnet/api/System.Type.AssemblyQualifiedName 'System.Type.AssemblyQualifiedName') of the type that is supported by this debugger visualizer.

<a name='P-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-VisualizerTargetType-VisualizerDisplayName'></a>
### VisualizerDisplayName `property`

##### Summary

Gets display name of the debugger visualizer.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-VsctCommandConstants'></a>
## VsctCommandConstants `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Constants related to legacy command definitions.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-VsctCommandConstants-IDM_VS_CSCD_WINDOWS'></a>
### IDM_VS_CSCD_WINDOWS `constants`

##### Summary

The id for the "View -> Other Windows" menu inside of Visual Studio.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-VsctCommandConstants-IDM_VS_MENU_EXTENSIONS'></a>
### IDM_VS_MENU_EXTENSIONS `constants`

##### Summary

The id for the Extensions top-level menu in Visual Studio.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-VsctCommandConstants-IDM_VS_MENU_TOOLS'></a>
### IDM_VS_MENU_TOOLS `constants`

##### Summary

The id for the the Tools top-level menu in Visual Studio.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-VsctGroupConstants'></a>
## VsctGroupConstants `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Constants related to legacy group definitions.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-VsctGroupConstants-IDG_VS_EXTENSIONS'></a>
### IDG_VS_EXTENSIONS `constants`

##### Summary

The id for the Extensions group inside of the Extensions top-level menu in Visual Studio.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-VsctGroupConstants-IDG_VS_TOOLS_EXT_TOOLS'></a>
### IDG_VS_TOOLS_EXT_TOOLS `constants`

##### Summary

The id for the External Tools group inside of the Tools top-level menu in Visual Studio.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-VsctGroupConstants-IDG_VS_WNDO_OTRWNDWS1'></a>
### IDG_VS_WNDO_OTRWNDWS1 `constants`

##### Summary

The id for a group inside of the  "View -> Other Windows" menu inside of Visual Studio.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-VsctGuidConstants'></a>
## VsctGuidConstants `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

Constants related to legacy group definitions.

<a name='F-Microsoft-VisualStudio-Extensibility-Commands-VsctGuidConstants-guidSHLMainMenu'></a>
### guidSHLMainMenu `constants`

##### Summary

The Guid for the main menu in Visual Studio.

<a name='T-Microsoft-VisualStudio-Extensibility-Commands-VsctId'></a>
## VsctId `type`

##### Namespace

Microsoft.VisualStudio.Extensibility.Commands

##### Summary

A record for the id of a VSCT defined component.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-VsctId-#ctor-System-Guid,System-UInt32-'></a>
### #ctor(guid,id) `constructor`

##### Summary

Initializes a new instance of the [VsctId](#T-Microsoft-VisualStudio-Extensibility-Commands-VsctId 'Microsoft.VisualStudio.Extensibility.Commands.VsctId') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.Guid](https://learn.microsoft.com/dotnet/api/System.Guid 'System.Guid') | Identifying guid. |
| id | [System.UInt32](https://learn.microsoft.com/dotnet/api/System.UInt32 'System.UInt32') | Identifying id. |

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-VsctId-Guid'></a>
### Guid `property`

##### Summary

Gets the guid of the VSCT defined component.

<a name='P-Microsoft-VisualStudio-Extensibility-Commands-VsctId-Id'></a>
### Id `property`

##### Summary

Gets the id of the VSCT defined component.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-VsctId-Equals-Microsoft-VisualStudio-Extensibility-Commands-VsctId-'></a>
### Equals() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Microsoft-VisualStudio-Extensibility-Commands-VsctId-GetHashCode'></a>
### GetHashCode() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
