using UnityEngine;
public class BotAgressive : BotState
{
    public BotAgressive(BotController bot){
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
        
        if(Vector3.Distance(botController.transform.position, botController.player.position) < botController.attackRange)
        {
            Debug.Log(Vector3.Distance(botController.transform.position, botController.player.position));
            botController.ChangeState(new BotAttack(botController));
        }
        else
        {
            botController.agent.destination = botController.player.position;
        }
    }
}
