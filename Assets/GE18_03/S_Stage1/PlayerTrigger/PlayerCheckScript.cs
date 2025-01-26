using UnityEngine;

public class PlayerCheckScript : MonoBehaviour
{
    [System.NonSerialized] public bool flg;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            flg = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            flg = false;
        }
    }
}
