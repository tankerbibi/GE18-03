using UnityEngine;
using UnityEngine.InputSystem;

public class StaminaScript : MonoBehaviour
{
    public float decreaseRate = 13.0f;
    public float decrease = 1.0f;
    private float runGauge = 0;
    private MoveScript MS;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MS = GetComponent<MoveScript>();
    }



    // Update is called once per frame
    void Update()
    {
        MS.walkSpeed += runGauge;
    }
}
