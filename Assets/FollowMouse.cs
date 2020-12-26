using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField]
    Camera c;
    [SerializeField]
    float dist = 5;
    // Start is called before the first frame update
    public void Attach(Transform t)
    {
        transform.DetachChildren();
        t.SetParent(transform);

    }
    public void Dettach(Transform t)
    {
        t.SetParent(null);
    }
    private void Update()
    {
        transform.position = c.ScreenToWorldPoint( Input.mousePosition+c.transform.forward*dist);
    }
}
