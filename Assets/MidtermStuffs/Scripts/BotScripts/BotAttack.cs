using UnityEngine;

public class BotAttack : BotState{

    BotWeapon weapon;
    
    float attackTime = 1, attackCooldown = 0;

    public BotAttack(BotController bot)
    {
        botController = bot;
    }

    public override void OnStateEnter()
    {
        weapon = new BotWeapon(botController.player.GetComponent<Health>());
    }

    public override void OnStateExit()
    {
        botController.attackIndicator.enabled = false;
    }

    public override void OnStateUpdate()
    {
        if(attackCooldown > 0)
        {
            attackCooldown -= Time.deltaTime;
        }
        else
        {
            botController.attackAudio.Play();
            weapon.Use();
            attackCooldown = attackTime;

            botController.Zap();
        }

        if(Vector3.Distance(botController.transform.position, botController.player.position) > botController.attackRange)
        {
            botController.ChangeState(new BotAgressive(botController));
        }
    }
}