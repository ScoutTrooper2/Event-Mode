using Exiled.API.Features;
using Exiled.CustomItems.API.Features;
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

namespace EVENT_MODE
{
    public class EventMode : Plugin<Config>
    {
        public static EventMode Plugin;

        private EventHandlers _eventHandlers;
        public override string Name => "EventMode";
        public override string Author => "ScoutTrooper";

        public override void OnEnabled()
        {
            Plugin = this;
            _eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Scp914.Activating += _eventHandlers.interact914;
            Exiled.Events.Handlers.Player.TriggeringTesla += _eventHandlers.TeslaInteract;
            Exiled.Events.Handlers.Server.RespawningTeam += _eventHandlers.Respawnteam;
            Exiled.Events.Handlers.Player.Escaping += _eventHandlers.Escapes;
            Exiled.Events.Handlers.Player.ActivatingGenerator += _eventHandlers.Generators;
            Exiled.Events.Handlers.Scp330.InteractingScp330 += _eventHandlers.Scp330;
            Exiled.Events.Handlers.Player.PickingUpItem += _eventHandlers.Pickups;
            Exiled.Events.Handlers.Scp2536.FindingPosition += _eventHandlers.Scp2536;
            Exiled.Events.Handlers.Scp559.Spawning += _eventHandlers.Scp559;
            Exiled.Events.Handlers.Player.Died += _eventHandlers.OverwatchAll;
            Exiled.Events.Handlers.Server.RoundStarted -= _eventHandlers.OnRoundStarted;
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp914.Activating -= _eventHandlers.interact914;
            Exiled.Events.Handlers.Player.TriggeringTesla -= _eventHandlers.TeslaInteract;
            Exiled.Events.Handlers.Server.RespawningTeam -= _eventHandlers.Respawnteam;
            Exiled.Events.Handlers.Player.Escaping -= _eventHandlers.Escapes;
            Exiled.Events.Handlers.Player.ActivatingGenerator -= _eventHandlers.Generators;
            Exiled.Events.Handlers.Scp330.InteractingScp330 -= _eventHandlers.Scp330;
            Exiled.Events.Handlers.Player.PickingUpItem -= _eventHandlers.Pickups;
            Exiled.Events.Handlers.Scp2536.FindingPosition -= _eventHandlers.Scp2536;
            Exiled.Events.Handlers.Scp559.Spawning -= _eventHandlers.Scp559;
            Exiled.Events.Handlers.Player.Died -= _eventHandlers.OverwatchAll;
            Exiled.Events.Handlers.Server.RoundStarted -= _eventHandlers.OnRoundStarted;
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;
            base.OnDisabled();
        }
        private void OnRoundStarted()
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