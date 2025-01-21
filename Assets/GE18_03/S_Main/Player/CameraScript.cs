using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float cameraSpeed;

    void LateUpdate()
    {
        //Vector3 myPosition = player.position + offset;
        ////myPosition.z = this.transform.position.z;
        //transform.position = myPosition;
    }
}
