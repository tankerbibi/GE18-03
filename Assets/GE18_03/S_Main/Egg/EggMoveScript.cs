using UnityEngine;

public class EggMoveScript : MonoBehaviour
{
    private float defY = 0;
    public float initY;
    public float amount = 1;
    public float rate = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        defY = Mathf.Sin(Time.time * rate) * amount;
    }

    // Update is called once per frame
    void Update()
    {
        defY = Mathf.Sin(Time.time * rate) * amount;
        transform.position = new Vector3(transform.position.x, transform.position.y + defY, transform.position.z);
    }
}
