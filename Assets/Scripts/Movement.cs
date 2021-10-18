using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    NewInput controls;

    Vector2 inputMovement;

    [SerializeField] Stats stats;

    void Awake()
    {
        controls = new NewInput();

        //the events that read the input
        controls.Combat.Move.performed += ctx => inputMovement = ctx.ReadValue<Vector2>();
        controls.Combat.Move.canceled += ctx => inputMovement = Vector2.zero;
    }

    void OnEnable()
    {
        controls.Combat.Enable();
    }

    void OnDisable()
    {
        controls.Combat.Disable();
    }

    void Update()
    {
        //The vector3 in charge of moving the object.
        Vector3 movement = new Vector3(inputMovement.x, 0, inputMovement.y) * stats.speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
