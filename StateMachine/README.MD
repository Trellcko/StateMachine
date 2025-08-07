# State Machine for Unity (C#)

*A flexible finite state machine implementation for Unity game development*

## 📦 Installation

### Via Unity Package Manager
1. Open `Window > Package Manager`
2. Click `+ > Add package from git URL`
3. Paste:  
   `https://github.com/Trellcko/StateMachine.git`

#### How to create Own State

```csharp
public class BootstrapState : BaseStateWithoutPayload
{
   private readonly IInitService _initService;

   public BootstrapState(StateMachine stateMachine, IInitService initService) : base(stateMachine)
   {
      _initService = initService;
      GoToState<EmptyState>(()=> _initService.IsInited);  
   }

   public overide void Enter()
   {
      _initService.Init();
   }
}
```

#### How to Init StateMachine

```csharp
public class ExampleBehaviour : MonoBehaviour
{
   private readonly StateMachine _stateMachine = new();
   private readonly IInitService _initService = new();

   private void Awake()
   {
      _stateMachine.AddStates(new EmptyState(_stateMachine),
      new BootstrapState(_stateMachine, _initService));
   }

   private void Update()
   {
      _stateMachine.Update();
   }
}
```
