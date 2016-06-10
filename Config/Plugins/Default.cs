using System.Collections.Generic;

namespace ezEvade.Config.Plugins
{
    [ConfigPlugin(Author = "By Ka", Name = "Default", Version = "2.0.1.6", RecomendedChampions = new[] { "All" },
        Description = "The default config for ezEvade.")]
    public class Default : ConfigPreset
    {
        public override void LoadConfig()
        {
            SetValue(ConfigValue.ExtraDetectionRange, 550);
            SetValue(ConfigValue.ExtraLineWidth, 1);
            SetValue(ConfigValue.ExtraSpellRadius, 40); //ExtraAvoidDistance
            SetValue(ConfigValue.ExtraPingBuffer, 60);
            SetValue(ConfigValue.ExtraCpaDistance, 40);
            SetValue(ConfigValue.RejectMinDistance, 10);
            SetValue(ConfigValue.MinimumComfortZone, 50);
            SetValue(ConfigValue.ExtraEvadeDistance, 40);
            SetValue(ConfigValue.EvadeMode, EvadeMode.Smooth);
            SetValue(ConfigValue.FastEvadeActivationTime, 0);
            SetValue(ConfigValue.SpellActivationTime, 10);
            SetValue(ConfigValue.TickLimiter, 100);
            SetValue(ConfigValue.SpellDetectionTime, 10);

            //Booleans
            SetValue(ConfigValue.DodgeSkillShots, true);
            SetValue(ConfigValue.DrawSkillShots, true);
            SetValue(ConfigValue.PreventDodgingNearEnemy, false);
            SetValue(ConfigValue.CalculateWindupDelay, true);
            SetValue(ConfigValue.HighPrecision, true);
            SetValue(ConfigValue.PreventDodgingUnderTower, false);
            SetValue(ConfigValue.ClickOnlyOnce, true);
            SetValue(ConfigValue.OnlyDodgeDangerous, false);
            SetValue(ConfigValue.DodgeDangerousKeysEnabled, false);
            SetValue(ConfigValue.DodgeFowSpells, false);
            SetValue(ConfigValue.DodgeCircularSpells, false);
            SetValue(ConfigValue.ActivateEvadeSpells, true);
            SetValue(ConfigValue.DodgeDangerousKey1, false);
            SetValue(ConfigValue.DodgeDangerousKey2, false);
            SetValue(ConfigValue.RecalculatePath, true);
            SetValue(ConfigValue.ContinueMovement, false);
            SetValue(ConfigValue.CheckSpellCollision, false);
            SetValue(ConfigValue.AdvancedSpellDetection, false);
            SetValue(ConfigValue.FastMovementBlock, true);
            SetValue(ConfigValue.EnableEvadeDistance, false);
            SetValue(ConfigValue.ShowDebugInfo, false);
            SetValue(ConfigValue.EnableSpellTester, false);
            SetValue(ConfigValue.DrawEvadeStatus, true);
            SetValue(ConfigValue.DrawSpellPosition, false);
            SetValue(ConfigValue.DrawEvadePosition, false);
            SetValue(ConfigValue.AutoSetPing, false);
        }
    }
}