using UnityEngine;
interface IPickupObject : IInteractible
{
    public void PickUp(Transform position);

    public void Drop();
}