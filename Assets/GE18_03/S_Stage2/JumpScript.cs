using UnityEngine;
using UnityEngine.InputSystem;

public class JumpScript : MonoBehaviour
{
    private bool isSky = false;
    private Rigidbody rb;
    public float jumpPower = 850;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isSky = false;
        }
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started && !isSky)
        {
            rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
            isSky = true;
        }
    }
}
