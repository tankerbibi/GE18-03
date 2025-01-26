using UnityEngine;

public class CagoUpScript : MonoBehaviour
{
    [System.NonSerialized]public bool flg = false;
    public float yAmount = 0;
    private Vector3 targetPos;
    private float speed = 5.0f;
    void Start()
    {
        Vector3 initPos = transform.position;
        targetPos = new Vector3(initPos.x, initPos.y + yAmount, initPos.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (flg)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        }
    }
}
