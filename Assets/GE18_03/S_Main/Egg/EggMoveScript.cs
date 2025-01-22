using UnityEngine;

public class EggMoveScript : MonoBehaviour
{
    private float y = 0;
    public float initY;
    public float amount = 1;
    public float rate = 1;
    public EggSplineScript eggSplineScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        y = Mathf.Sin(Time.time * rate) * amount;
    }

    // Update is called once per frame
    void Update()
    {
        y = Mathf.Sin(Time.time * rate) * amount;
        transform.position = new Vector3(transform.position.x, initY + y, transform.position.z);
    }
}
