using System;
using Leopotam.EcsLite;

namespace Gameplay.Session
{
    [Serializable]
    public abstract class InjectModuleInSession
    {
        public abstract void Init(EcsSystems systems);
    }
}