using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    [SerializeField]
    FillHandler fillHandler;
    [SerializeField]
    public int current = 1;
    [SerializeField]
    int max = 1;
    [SerializeField]
    UnityEngine.Events.UnityEvent<String> onvalueChange;
    private void Awake()
    {
        Trigger();
    }
    internal void Fill()
    {
        current = max;

        Trigger();
    }
    public void Empty()
    {
        current = 0;

        Trigger();
    }

    // Start is called before the first frame update
    private void Trigger()
    {
        onvalueChange.Invoke(current.ToString());
    }
    // Update is called once per frame
    void Update()
    {
        var current = Math.Max(0, Math.Min(max, this.current));
        if (current != this.current)
        {
            this.current = current;
            Trigger();
        }
        fillHandler.fill = (float)current / max;

    }

    public void distribute(Collider c)
    {
        var c2 = c.GetComponent<Container>();
        if (c2)
        {
            var avalable_space = c2.max - c2.current;
            var movedAmmount = Math.Min(current, avalable_space);
            current -= movedAmmount;
            c2.current += movedAmmount;
            Trigger();
            c2.Trigger();

        }   
    }
}
