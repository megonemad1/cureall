using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    [SerializeField]
    UnityEngine.Events.UnityEvent<Transform> onMouseDown, onMouseUp;
    private void OnMouseDown()
    {
        onMouseDown.Invoke(transform);
    }
    private void OnMouseUp()
    {
        onMouseUp.Invoke(transform);
    }
}
