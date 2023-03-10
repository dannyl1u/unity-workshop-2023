using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10;
    private Rigidbody2D _rigidbody2D;
    private float _horizontalMovement;
    private float _verticalMovement;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = Input.GetAxis("Horizontal");
        _verticalMovement = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_horizontalMovement * Speed, _verticalMovement * Speed);
    }
}