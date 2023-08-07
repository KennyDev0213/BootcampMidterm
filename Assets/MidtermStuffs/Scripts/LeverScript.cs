using UnityEngine;
using UnityEngine.Events;

public class LeverScript : MonoBehaviour, IInteractible
{
    [SerializeField] UnityEvent leverEvent;

    public void Interact()
    {
        GetComponent<Animator>().SetBool("Activated", true);
        leverEvent?.Invoke();
    }

}
