using UnityEngine;

public class EndTriggerScript : MonoBehaviour
{
    private bool flg = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Egg")
        {
            flg = true;
        }
        if(other.tag == "Player")
        {
            if(flg)
            {

            }
        }
    }
}
