using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkWin : MonoBehaviour
{
    [SerializeField]
    int winnumber = 1;
    [SerializeField]
    UnityEngine.Events.UnityEvent onWin;
    public void isWin(Collider c)
    {
        var container = c.GetComponent<Container>();
        if (container != null && container.current == winnumber)
            onWin.Invoke();
    }
}
