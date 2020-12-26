using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillHandler : MonoBehaviour
{
    [Range(0, 1), SerializeField]
    public float fill;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1, Mathf.Lerp(transform.localScale.y, fill, Time.deltaTime), 1);
        transform.localPosition = Mathf.Lerp(transform.localPosition.y, (fill / 2) - .5f, Time.deltaTime) * Vector3.up+Vector3.back*.2f;
    }
}
