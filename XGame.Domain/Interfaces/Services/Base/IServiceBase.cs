﻿using prmToolkit.NotificationPattern;
using System;

namespace XGame.Domain.Interfaces.Services.Base
{
    public interface IServiceBase : INotifiable, IDisposable
    {
        // Estou usando o "Notifications" no ControllerBase, por isso preciso do INotifiable aqui.
    }
}
