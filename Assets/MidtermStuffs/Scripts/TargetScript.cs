using UnityEngine;
using UnityEngine.Events;

public class TargetScript : MonoBehaviour, IDestroyable
{
    [SerializeField] UnityEvent targetEvent;

    public void OnCollided()
    {
        targetEvent?.Invoke();
    }
}
