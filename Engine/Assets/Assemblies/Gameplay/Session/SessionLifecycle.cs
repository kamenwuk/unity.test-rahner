using Leopotam.EcsLite.Di;
using Leopotam.EcsLite;
using UnityEngine;

namespace Gameplay.Session
{
    internal sealed class SessionLifecycle : MonoBehaviour
    {
        [SerializeReference]
        private InjectModuleInSession[] _injectModules;

        private EcsSystems _systems = null;
        private EcsWorld _world = null;

        private void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);
            foreach (var module in _injectModules)
                module.Init(_systems);
            _systems.Inject()
                .Init();
        }
        private void Update()
        {
            _systems.Run();
        }
    }
}