using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{

    public float Speed;
    public float RotationSpeed;

    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * Time.deltaTime * _verticalInput * RotationSpeed);

        Dash();
    }

    private void Dash()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Speed *= 2;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Speed /= 2;
        }
    }
}
