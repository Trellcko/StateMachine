using Constants;
using Trell.TwoDTestTask.Infrastructure;
using Trell.TwoDTestTask.Infrastructure.Service.Infrastructure;
using Trell.TwoDTestTask.Infrastructure.Service.Infrastructure.States;
using Trell.TwoDTestTask.Infrastructure.States;

namespace Trell.TwoDTestTask.Service.Infrastructure
{
    public class BootstrapSceneLoadState : BaseStateWithoutPayload
    {
        private readonly ISceneService _sceneService;

        public BootstrapSceneLoadState(StateMachine machine, ISceneService sceneService) : base(machine)
        {
            _sceneService = sceneService;
        }

        public override void Enter()
        {
            _sceneService.Load(SceneName.BootstrapScene, GoToState<MainMenuState>);
        }
    }
}