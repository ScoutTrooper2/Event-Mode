using CommandSystem;
using Exiled.API.Features;
using Exiled.Permissions.Extensions;
using System;
using UnityEngine;

namespace EVENT_MODE
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class EvModeCommand : ICommand
    {
        public string Command { get; } = "evmode";
        public string[] Aliases { get; } = new string[2]
        {
      "evm",
      "eventmode"
        };
        public string Description { get; } = "Managment of Event Mode.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = string.Empty;

            if (!(sender is CommandSender commandSender))
            {
                response = "You don't have permission to use this command.";
                return false;
            }

            if (arguments.Count < 2)
            {
                response = "Usage: evmode <on/off> <feature>";
                return false;
            }

            string mode = arguments.At(0).ToLower();
            string feature = arguments.At(1).ToLower();

            switch (feature)
            {
                case "914":
                    HandleFeature(mode, "SCP-914", out response);
                    break;
                case "escape":
                    HandleFeature(mode, "Escapeability", out response);
                    break;
                case "tesla":
                    HandleFeature(mode, "Teslasgates", out response);
                    break;
                case "respawn":
                    HandleFeature(mode, "Respawns", out response);
                    break;
                case "generators":
                    HandleFeature(mode, "Generators", out response);
                    break;
                case "330":
                    HandleFeature(mode, "Scp330", out response);
                    break;
                case "pickup":
                    HandleFeature(mode, "Pickup", out response);
                    break;
                case "unmute":
                    HandleFeature(mode, "unmute", out response);
                    break;
                case "overwatch":
                    HandleFeature(mode, "overwatch", out response);
                    break;
                case "2536":
                    HandleFeature(mode, "2536mode", out response);
                    break;
                case "auto":
                    HandleFeature(mode, "Automat", out response);
                    break;
                case "559":
                    HandleFeature(mode, "559mode", out response);
                    break;
                case "joinmessage":
                    HandleFeature(mode, "joinmes", out response);
                    break;
                // Add cases for other features here
                default:
                    response = EventMode.Plugin.Config.InfoText;
                    return false;
            }

            return true;
        }

        private void HandleFeature(string mode, string featureName, out string response)
        {
            if (mode == "on")
            {
                if (featureName == "SCP-914")
                {
                    EventHandlers.evmode914 = false;
                }
                if (featureName == "joinmes")
                {
                    EventHandlers.joinmessage = false;
                }
                if (featureName == "Escapeability")
                {
                    EventHandlers.evmodeescape = false;
                }
                if (featureName == "Teslasgates")
                {
                    EventHandlers.evmodetesla = false;
                }
                if (featureName == "Respawns")
                {
                    EventHandlers.evmoderespawn = false;
                }
                if (featureName == "Generators")
                {
                    EventHandlers.evmodegenerators = false;
                }
                if (featureName == "Scp330")
                {
                    EventHandlers.evmode330 = false;
                }
                if (featureName == "Pickup")
                {
                    EventHandlers.evmodepick = false;
                }
                if (featureName == "unmute")
                {
                    EventHandlers.unmute = true;
                }
                if (featureName == "overwatch")
                {
                    EventHandlers.evmodeoverwatch = true;
                }
                if (featureName == "2536mode")
                {
                    EventHandlers.evmode2536 = false;
                }
                if (featureName == "559mode")
                {
                    EventHandlers.evmode559 = false;
                }
                if (featureName == "Automat")
                {
                    EventHandlers.evmode2536 = true;
                    EventHandlers.evmode330 = true;
                    EventHandlers.evmode559 = true;
                    EventHandlers.evmode914 = true;
                    EventHandlers.evmodeescape = true;
                    EventHandlers.evmodegenerators = true;
                    EventHandlers.evmoderespawn = true;
                    EventHandlers.evmodetesla = true;
                    Map.Broadcast(10, EventMode.Plugin.Config.EventStart);
                    EventHandlers.joinmessage = true;
                }
                response = $"{featureName} has been enabled.";
            }
            else if (mode == "off")
            {
                if (featureName == "SCP-914")
                {
                    EventHandlers.evmode914 = true;
                }
                if (featureName == "joinmes")
                {
                    EventHandlers.joinmessage = true;
                }
                if (featureName == "Escapeability")
                {
                    EventHandlers.evmodeescape = true;
                }
                if (featureName == "Teslasgates")
                {
                    EventHandlers.evmodetesla = true;
                }
                if (featureName == "Respawns")
                {
                    EventHandlers.evmoderespawn = true;
                }
                if (featureName == "Generators")
                {
                    EventHandlers.evmodegenerators = true;
                }
                if (featureName == "Scp330")
                {
                    EventHandlers.evmode330 = true;
                }
                if (featureName == "Pickup")
                {
                    EventHandlers.evmodepick = true;
                }
                if (featureName == "Mute")
                {
                    EventHandlers.unmute = false;
                }
                if (featureName == "Overw")
                {
                    EventHandlers.evmodeoverwatch = false;
                }
                if (featureName == "2536mode")
                {
                    EventHandlers.evmode2536 = true;
                }
                if (featureName == "559mode")
                {
                    EventHandlers.evmode559 = true;
                }
                if (featureName == "Automat")
                {
                    EventHandlers.evmode2536 = false;
                    EventHandlers.evmode330 = false;
                    EventHandlers.evmode559 = false;
                    EventHandlers.evmode914 = false;
                    EventHandlers.evmodeescape = false;
                    EventHandlers.evmodegenerators = false;
                    EventHandlers.evmodeoverwatch = false;
                    EventHandlers.evmoderespawn = false;
                    EventHandlers.evmodetesla = false;
                    EventHandlers.joinmessage = false;
                    Map.Broadcast(10, EventMode.Plugin.Config.Eventended);
                }
                response = $"{featureName} has been disabled.";
            }
            else
            {
                response = "Invalid mode. Use 'on' or 'off'.";
            }
        }
    }
}