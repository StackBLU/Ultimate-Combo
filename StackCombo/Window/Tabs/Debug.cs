﻿using Dalamud.Game.ClientState.Objects.SubKinds;
using Dalamud.Game.ClientState.Objects.Types;
using ImGuiNET;
using StackCombo.ComboHelper.Functions;
using StackCombo.Combos;
using StackCombo.CustomCombo;
using StackCombo.Data;
using StackCombo.Services;
using System;
using System.Linq;
using System.Numerics;
using Status = Dalamud.Game.ClientState.Statuses.Status;

namespace StackCombo.Window.Tabs
{

	internal class Debug : ConfigWindow
	{

		internal class DebugCombo : CustomComboClass
		{
			protected internal override CustomComboPreset Preset { get; }

			protected override uint Invoke(uint actionID, uint lastComboActionID, float comboTime, byte level)
			{
				return actionID;
			}
		}

		public static int debugNum = 0;
		internal static new unsafe void Draw()
		{
			IPlayerCharacter? LocalPlayer = Service.ClientState.LocalPlayer;
			DebugCombo? comboClass = new();

			if (LocalPlayer != null)
			{
				if (Service.ClientState.LocalPlayer.TargetObject is IBattleChara chara)
				{
					foreach (Status? status in chara.StatusList)
					{
						ImGui.TextUnformatted($"TARGET STATUS CHECK: {chara.Name} -> {ActionWatching.GetStatusName(status.StatusId)}: {status.StatusId} {Math.Round(status.RemainingTime, 1)}");
					}
				}

				foreach (Status? status in Service.ClientState.LocalPlayer.StatusList)
				{
					ImGui.TextUnformatted($"Self Status Check: {Service.ClientState.LocalPlayer.Name} -> {ActionWatching.GetStatusName(status.StatusId)}: {status.StatusId} {Math.Round(status.RemainingTime, 1)}");
				}

				ImGui.TextUnformatted($"Territory: {Service.ClientState.TerritoryType}");
				ImGui.TextUnformatted($"Target Object Kind: {Service.ClientState.LocalPlayer.TargetObject?.ObjectKind}");
				ImGui.TextUnformatted($"Target is Battle Char: {Service.ClientState.LocalPlayer.TargetObject is IBattleChara}");
				ImGui.TextUnformatted($"In Combat: {CustomComboFunctions.InCombat()}");
				ImGui.TextUnformatted($"# of GCDs used: {ActionWatching.NumberOfGcdsUsed}");
				ImGui.TextUnformatted($"In Melee Range: {CustomComboFunctions.InMeleeRange()}");
				ImGui.TextUnformatted($"Distance from Target: {CustomComboFunctions.GetTargetDistance()}");
				ImGui.TextUnformatted($"Target HP Value: {CustomComboFunctions.EnemyHealthCurrentHp()}");
				ImGui.TextUnformatted($"Last Action: {ActionWatching.GetActionName(ActionWatching.LastAction)} (ID:{ActionWatching.LastAction})");
				ImGui.TextUnformatted($"Last Action Cost: {CustomComboFunctions.GetResourceCost(ActionWatching.LastAction)}");
				ImGui.TextUnformatted($"Last Action Type: {ActionWatching.GetAttackType(ActionWatching.LastAction)}");
				ImGui.TextUnformatted($"Last Weaponskill: {ActionWatching.GetActionName(ActionWatching.LastWeaponskill)}");
				ImGui.TextUnformatted($"Last Spell: {ActionWatching.GetActionName(ActionWatching.LastSpell)}");
				ImGui.TextUnformatted($"Last Ability: {ActionWatching.GetActionName(ActionWatching.LastAbility)}");
				ImGui.TextUnformatted($"Zone: {Service.ClientState.TerritoryType}");
				_ = ImGui.BeginChild("BLUSPELLS", new Vector2(250, 500), true);
				ImGui.TextUnformatted($"Selected BLU Spells:\n{string.Join("\n", Service.Configuration.ActiveBLUSpells.Select(ActionWatching.GetActionName).OrderBy(x => x))}");
				ImGui.EndChild();
			}

			else
			{
				ImGui.TextUnformatted("Please log in to use this tab.");
			}
		}
	}
}