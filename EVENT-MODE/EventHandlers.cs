using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API;
using Exiled.Events.Features;
using Exiled.Events.EventArgs.Scp914;
using Exiled.Events.EventArgs.Server;

namespace EVENT_MODE
{
    public class EventHandlers

    {
        internal static bool evmode914 = false;
        internal static bool evmodetesla = false;
        internal static bool evmoderespawn = false;
        internal static bool evmodeescape = false;
        internal static bool evmodegenerators = false;
        internal static bool evmode330 = false;
        internal static bool evmodepick = false;
        internal static bool evmode2536 = false;
        internal static bool evmode559 = false;
        internal static bool unmute = false;
        internal static bool evmodeoverwatch = false;
        internal static bool joinmessage = false;

        public void interact914(Exiled.Events.EventArgs.Scp914.ActivatingEventArgs ev)
        {
            if (evmode914 == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void TeslaInteract(TriggeringTeslaEventArgs ev)
        {
            if (evmodetesla == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void Respawnteam(RespawningTeamEventArgs ev)
        {
            if (evmoderespawn == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void Escapes(EscapingEventArgs ev)
        {
            if (evmodeescape == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void Generators(ActivatingGeneratorEventArgs ev)
        {
            if (evmodegenerators == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void Scp330(Exiled.Events.EventArgs.Scp330.InteractingScp330EventArgs ev)
        {
            if (evmode330 == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void Pickups(PickingUpItemEventArgs ev)
        {
            if (evmodepick == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void Scp2536(Exiled.Events.EventArgs.Scp2536.FindingPositionEventArgs ev)
        {
            if (evmode2536 == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void Scp559(Exiled.Events.EventArgs.Scp559.SpawningEventArgs ev)
        {
            if (evmode559 == true)
            {
                ev.IsAllowed = false;
            }
        }
        public void UnMuteAll(LeftEventArgs ev)
        {
            if (unmute == true)
            {
                ev.Player.UnMute();
            }
        }
        public void OverwatchAll(DiedEventArgs ev)
        {
            if (evmodeoverwatch == true)
            {
                ev.Player.Role.Set(RoleTypeId.Overwatch);
            }
        }
        public void RestartAndDisable(EndingRoundEventArgs ev)
        {
            if (ev.IsRoundEnded == true)
            {
                Timing.CallDelayed(1f, () =>
                {
                    EventHandlers.evmode2536 = false;
                    EventHandlers.evmode330 = false;
                    EventHandlers.evmode559 = false;
                    EventHandlers.evmode914 = false;
                    EventHandlers.evmodeescape = false;
                    EventHandlers.evmodegenerators = false;
                    EventHandlers.evmodeoverwatch = false;
                    EventHandlers.evmodepick = false;
                    EventHandlers.evmoderespawn = false;
                    EventHandlers.evmodetesla = false;
                    EventHandlers.joinmessage = false;
                });
            }

        }

        public void OnRoundStarted()
        {
            EventHandlers.evmode2536 = false;
            EventHandlers.evmode330 = false;
            EventHandlers.evmode559 = false;
            EventHandlers.evmode914 = false;
            EventHandlers.evmodeescape = false;
            EventHandlers.evmodegenerators = false;
            EventHandlers.evmodeoverwatch = false;
            EventHandlers.evmodepick = false;
            EventHandlers.evmoderespawn = false;
            EventHandlers.evmodetesla = false;
            EventHandlers.joinmessage = false;
        }    
    }
}
