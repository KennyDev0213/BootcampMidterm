using UnityEngine;
public class BotIdle : BotState
{
    public BotIdle(BotController bot){
        botController = bot;
    }

    public override void OnStateEnter()
    {
        
    }

    public override void OnStateExit()
    {
        
    }

    public override void OnStateUpdate()
    {
        int layer = 1 << LayerMask.NameToLayer("Entity");
        if(!Physics.Linecast(botController.eyes.position, botController.player.position, ~layer))
        {
            botController.ChangeState(new BotAgressive(botController));
        }
    }
}
