using UnityEngine;

public class SwitchMoveScript : MonoBehaviour
{
    [System.NonSerialized] public bool flg = false;
    private Vector3 initPos, targetPos;
    public Material green = default;
    public float yAmount = 0;
    private AudioSource audioSorce;
    [SerializeField] AudioClip sound;

    void Start()
    {
        audioSorce = GetComponent<AudioSource>();
        initPos = transform.position;
        targetPos = new Vector3(initPos.x, initPos.y + yAmount, initPos.z);
    }

    public void ChangeAppear()
    {
        audioSorce.PlayOneShot(sound);
        transform.position = targetPos;
        this.GetComponent<MeshRenderer>().material = green;
    }
}
