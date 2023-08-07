using UnityEngine;
using UnityEngine.Events;
public class Button : MonoBehaviour, IInteractible
{
    public AudioSource click;
    [SerializeField] UnityEvent buttonEvent;

    public void Interact()
    {
        click?.Play();
        buttonEvent?.Invoke();
    }
}
