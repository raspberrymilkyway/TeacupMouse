using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*   To be clear, this is player movement.
*   (We... didn't get to adding spin.)
*/

public class Movement : MonoBehaviour
{
    public enum eMode{
        idle, spin
    }

    [SerializeField] private float _speed = 20;
    [SerializeField] private Rigidbody _rigid;

    [Header("Set in Inspector")]
    public float speed = 5;
    public float spinDuration = 0.25f;
    public float spinDelay = 0.5f;

    [Header("Set Dynamically")]
    public eMode mode = eMode.idle;

    // Update is called once per frame
    void Update()
    {
        var vel = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal")) * _speed;
        vel.y = _rigid.velocity.y;
        _rigid.velocity = vel;
    }
}
