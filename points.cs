using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {   
        if(other.gameObject.tag != "Hit")
        {

        hits++;
        Debug.Log("You'hv bumped into a thing this many times:" + hits);
        
        }
    }
}
