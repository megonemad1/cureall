using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filler : MonoBehaviour
{
    public void Fill(Collider collider)
    {
        collider.GetComponent<Container>()?.Fill();
    }
    public void Empty(Collider collider)
    {
        collider.GetComponent<Container>()?.Empty();
    }
}
