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
   }

   public void Enter()
   {
      initService.Init();
      GoToState<EmptyState>();
   }
}
```
