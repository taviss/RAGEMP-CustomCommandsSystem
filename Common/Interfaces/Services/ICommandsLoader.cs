﻿using CustomCommandSystem.Common.Models;
using System.Reflection;

namespace CustomCommandSystem.Common.Interfaces.Services
{
    internal interface ICommandsLoader
    {
        void LoadCommands(Assembly assembly);
        void UnloadCommands(Assembly assembly);
        void ReloadCommands(Assembly assembly);
        internal CommandData? GetCommandData(string cmd);
    }
}