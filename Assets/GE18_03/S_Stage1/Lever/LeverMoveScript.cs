using UnityEngine;
using UnityEngine.Audio;

public class LeverMoveScript : MonoBehaviour
{
    public enum Select
    {
        Up,
        Center,
        Down,
        max
    }
    public Select select = Select.Up;
    [SerializeField] private float rotateAmount = 50.0f;
    [SerializeField] private PlayerCheckScript playerCheckScript;
    private AudioSource audioSource;
    private bool Upping = false;
    private int cnt;
    [SerializeField] private AudioClip sound;
    private void Start()
    {
        transform.Rotate(0.0f, 0.0f, rotateAmount);
        audioSource = GetComponent<AudioSource>();
    }

    public void LeverMove()
    {
        if (playerCheckScript.flg)
        {
            audioSource.PlayOneShot(sound);
            cnt++;
            if (Upping)
            {
                transform.Rotate(0.0f, 0.0f, +rotateAmount);
                select--;
            }
            else
            {
                transform.Rotate(0.0f, 0.0f, -rotateAmount);
                select++;
            }
            if(cnt >= (int)Select.max - 1)
            {
                cnt = 0;
                Upping = !Upping;
            }
            //if (Upping)
            //{
            //    transform.Rotate(0.0f, 0.0f, -rotateAmount);
            //    select--;
            //    switch (select)
            //    {
            //        case Select.Up:
            //            transform.Rotate(0.0f, 0.0f, -rotateAmount);
            //            select = Select.Center;
            //            break;
            //        case Select.Center:
            //            transform.Rotate(0.0f, 0.0f, -rotateAmount);
            //            select = Select.Down;
            //            break;
            //        case Select.Down:
            //            transform.Rotate(0.0f, 0.0f, 2 * rotateAmount);
            //            select = Select.Up;
            //            break;
            //    }
            
            //}
        }
    }
}
