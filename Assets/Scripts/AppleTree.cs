using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    [Header("Set in Inspector")]
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirection =0.1f;

    public float secondsBetweenAppleDrop = 1f;
       
    void Start () {

    }             
    void Update () {
        Vector3 pos = transform.position;
        pos.x += speed + Time.deltaTime;
        pos.x += 1.0f * .01f;
        pos.x += .01f;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        else if (Random.value < chanceToChangeDirection)
        {
            speed *=-1;
        }
    }
}
