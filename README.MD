# State Machine for Unity (C#)

*A flexible finite state machine implementation for Unity game development*

## 📦 Installation

### Via Unity Package Manager
1. Open `Window > Package Manager`
2. Click `+ > Add package from git URL`
3. Paste:  
   `https://github.com/Trellcko/StateMachine.git`

## Usage

To use the State Machine in your own scripts, you must reference its assembly definition.

1. In your project, create an `.asmdef` file (if you don't already have one).
2. In the Inspector, add a reference to the `Trellcko.StateMachine` assembly.
3. You can now use the package's namespaces in your code:

## 🛠️ How To Use
#### Creating States

```csharp
public class BootstrapState : BaseStateWithoutPayload
{
   private readonly IInitService _initService;

   public BootstrapState(StateMachine stateMachine, IInitService initService) : base(stateMachine)
   {
      _initService = initService;
      GoToState<EmptyState>(()=> _initService.IsInited, 0);  
   }

   public overide void Enter()
   {
      _initService.Init();
   }
}
```

#### Implementing the State Machine

```csharp
public class ExampleBehaviour : MonoBehaviour
{
   private readonly IStateMachine _stateMachine = new StateMachine();
   private readonly IInitService _initService = new();

   private void Awake()
   {
      _stateMachine.AddStates(new EmptyState(_stateMachine),
      new BootstrapState(_stateMachine, _initService));

      _stateMachine.SetState<BootstrapState>();
   }

   private void Update()
   {
      _stateMachine.Update();
   }
}
```
