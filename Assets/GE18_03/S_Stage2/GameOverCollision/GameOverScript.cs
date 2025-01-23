using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public Transform startPlace;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = startPlace.position;
        }
    }
}
