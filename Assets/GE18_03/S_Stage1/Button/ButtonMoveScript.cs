using System.Security.Cryptography;
using UnityEngine;

public class ButtonMoveScript : MonoBehaviour
{
    public Material green = default;
    private Material initM = default;
    private Vector3 initPos, targetPos;
    public float zAmount = 0;
    void Start()
    {
        initM = GetComponent<MeshRenderer>().material;
        initPos = transform.position;
        targetPos = new Vector3(initPos.x, initPos.y, initPos.z + zAmount);
    }
    public void ChangeAppear()
    {
        GetComponent<MeshRenderer>().material = green;
        transform.position = targetPos;
        Invoke("RevertAppear", 0.7f);
    }

    private void RevertAppear()
    {
        GetComponent<MeshRenderer>().material = initM;
        transform.position = initPos;
    }

}
