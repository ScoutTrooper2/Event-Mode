using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Policy;
using Exiled.API.Enums;
using Exiled.API.Interfaces;
using Scp914;

namespace EVENT_MODE
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Is the debug enabled?")]
        public bool Debug { get; set; } = false;

        [Description("Info Text")]
        public string InfoText { get; set; } = "Usage Guide - \n\n There are two modes:\non - enables\noff - disables\n\nlist of available arguments -\n 914 - Interaction with 914\nEscape - Escape system\nTesla - Interaction with Tesla Gates\nrespawn - Spawn Squad System ( MTF / CI )\ngenerators - Interaction with generators\n330 - Interaction with Scp-330\npickup - Picking up items\nunmute - Removes mutation from the player when he leaves the server\noverwatch - turns the player into a supervisor at his death\n2536 - Christmas tree\n559 - Cake\n";
        [Description("Join Message")]
        public string EventStart { get; set; } = "<b><size=25>Start event!<b>";
        [Description("Event ended Message")]
        public string Eventended { get; set; } = "<b><size=25>Event end | Event-Maker disable system<b>";
        [Description("THIS ONLY FOR RUS TRANSLATE -")]
        public string RUSINFO { get; set; } = "Руководство по использованию - \n\nЕсть два режима:\nOn - включает\nOff - выключает\n\nСписок доступных аргументов -\n914 - Взаимодействие с 914\nEscape - Система побега\nTesla - Взаимодействие с Тесла-Вратами\nrespawn - Система спавна отрядов ( MTF / CI )\ngenerators - Взаимодействие с генераторами\n330 - Взаимодействие с Scp-330\npickup - Подбирание предметов\nunmute - Снимает мут у игрока когда он покидает сервер\noverwatch - переводит игрока в надзирателя при его смерти\n2536 - Новогодняя елка\n559 - Торт\n";
        [Description("Join Message")]
        public string RUSSTART { get; set; } = "<b><size=25>На сервере начался ивент!<b>";
        [Description("Event ended Message")]
        public string RUSSEND { get; set; } = "<b><size=25>На сервере закончился ивент | Проводящий выключил Авто-систему<b>";
    }
}

