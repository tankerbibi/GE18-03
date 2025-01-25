using UnityEngine;

public class SwitchMoveScript : MonoBehaviour
{
    [System.NonSerialized] public bool flg = false;
    private Vector3 initPos, targetPos;
    public Material green = default;
    public float yAmount = 0;

    void Start()
    {
        initPos = transform.position;
        targetPos = new Vector3(initPos.x, initPos.y + yAmount, initPos.z);
    }

    public void ChangeAppear()
    {
        transform.position = targetPos;
        this.GetComponent<MeshRenderer>().material = green;
    }
}
