using UnityEngine;
using UnityEngine.AI;

public class BotController : MonoBehaviour {

    public Transform player;
    public NavMeshAgent agent;
    public Transform eyes;

    public float attackRange = 4;
    public AudioSource attackAudio;

    public LineRenderer attackIndicator;

    BotState currentState;
    private void Start() {
        currentState = new BotIdle(this);
        currentState.OnStateEnter();

        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;

            if (player == null){
                Debug.LogError($"{name} 'player' transform was null and could not find the player gameobject. make sure the player gameobject has the 'player' tag or manually attack the player transform to the BotController script");
            }
        }

        attackIndicator = GetComponent<LineRenderer>();
        attackIndicator.enabled = false;
    }

    public void Zap()
    {
        attackIndicator.enabled = true;
        attackIndicator.SetPosition(0, transform.position);
        attackIndicator.SetPosition(1, player.transform.position);
    }

    private void Update() {
        currentState.OnStateUpdate();

        if(attackIndicator.enabled == true)
        {
            attackIndicator.enabled = false;
        }
    }

    public void ChangeState(BotState state) {
        currentState.OnStateExit();
        currentState = state;
        currentState.OnStateEnter();
    }
}