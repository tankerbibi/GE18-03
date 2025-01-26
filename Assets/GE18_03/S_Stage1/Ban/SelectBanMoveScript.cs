using UnityEngine;

public class SelectBanMoveScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Push(Vector3 targetPos)
    {
        transform.position = new Vector3(targetPos.x, targetPos.y,transform.position.z);
    }
}
