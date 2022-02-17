using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apps : MonoBehaviour
{
    [Header("Set in Inspector")]
    public static float bottomY = 1f;
    void Update()
    {
     if (transform.position.y < bottomY){
        Destroy (this.gameObject, 0.4f);
     }
    }

}
