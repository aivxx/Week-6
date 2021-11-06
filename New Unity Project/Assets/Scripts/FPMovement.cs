using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPMovement : MonoBehaviour
{
    // Player's movement parameters
    public Vector3 direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    // OnPlayerMove event handler
    public void OnPlayerMove(InputValue value)
    {

        // A vector with x and y components corresponding to the player's WASD and Arrow inputs
        // both components are in the range [-1, 1]
        Vector2 inputVector = value.Get<Vector2>();
       
        // move in the XZ-plane
        direction.x = inputVector.x;
        direction.z = inputVector.y;
    }
}
