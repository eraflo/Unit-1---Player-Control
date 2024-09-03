using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Vehicle Parameters")]
    public float Speed = 5.0f;

    [Range(1, 50)]
    public float TurningSpeed = 25.0f;

    private float _horizontalInput;
    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        // Move vehicle forward
        transform.Rotate(Vector3.up, Time.deltaTime * TurningSpeed * _horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * _verticalInput);
    }
}
