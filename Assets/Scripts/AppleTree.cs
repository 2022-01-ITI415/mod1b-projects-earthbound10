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
 
    }
}