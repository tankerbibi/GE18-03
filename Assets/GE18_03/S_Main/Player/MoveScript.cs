using UnityEngine;
using UnityEngine.InputSystem;

public class MoveScript : MonoBehaviour
{   
    public float rotationSpeed = 1;
    private float initSpeed;
    public float walkSpeed = 1;
    public float runSpeed = 2;
    private float posNeg;
    private Vector3 velocity;
    private Rigidbody rb;
    private Animator anim;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        anim = this.GetComponent<Animator>();
        initSpeed = walkSpeed;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        var axis = context.ReadValue<Vector2>();
        velocity = new Vector3(axis.x, 0, axis.y);
        if (context.started)
        {
            anim.SetBool("Moving", true);
        }
        if (context.canceled)
        {
            anim.SetBool("Moving", false);
        }
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        var axis = context.ReadValue<float>();
        posNeg = axis * rotationSpeed;
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            walkSpeed = runSpeed;
            anim.SetBool("ShiftPressed", true);
        }
        if (context.canceled)
        {
            walkSpeed = initSpeed;
            anim.SetBool("ShiftPressed", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = this.transform.rotation * new Vector3(velocity.x * walkSpeed, rb.linearVelocity.y, velocity.z * walkSpeed);
        this.transform.Rotate(0.0f,posNeg,0.0f);
    }
}
