using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnter : MonoBehaviour
{
    [SerializeField]
    private bool active;
    [SerializeField]
    UnityEngine.Events.UnityEvent<Collider> onEnter;

    public bool Active { get => active; set => active = value; }

    private void OnTriggerEnter(Collider other)
    {
        if (active)
            onEnter.Invoke(other);
    }
}
