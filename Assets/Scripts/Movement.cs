using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*   To be clear, this is player movement.
*/

public class Movement : MonoBehaviour
{
    public enum eMode{
        idle, spin
    }

    [Header("Set in Inspector")]
    public float speed = 5;
    public float spinDuration = 0.25f;
    public float spinDelay = 0.5f;

    [Header("Set Dynamically")]
    public eMode mode = eMode.idle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
