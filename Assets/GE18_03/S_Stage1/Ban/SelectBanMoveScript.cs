using Unity.VisualScripting;
using UnityEngine;

public class SelectBanMoveScript : MonoBehaviour
{
    [SerializeField] private LeverMoveScript leverMoveScripttate;
    [SerializeField] private LeverMoveScript leverMoveScriptyoko;
    private Vector3 initPos;
    [SerializeField] private float moveAmount = 5.0f;
    [SerializeField] private float pushAmount = 5.0f;
    private bool pushFlg = false;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float pushPower = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initPos = transform.position;
    }

    private void FixedUpdate()
    {
        LeverMoveScript.Select tateSelect = leverMoveScripttate.select;
        LeverMoveScript.Select yokoSelect = leverMoveScriptyoko.select;
        if (!pushFlg) 
        {
            switch (tateSelect)
            {
                case LeverMoveScript.Select.Up:
                    transform.position = new Vector3(transform.position.x, initPos.y, initPos.z);
                    break;
                case LeverMoveScript.Select.Center:
                    transform.position = new Vector3(transform.position.x, initPos.y - moveAmount, initPos.z);
                    break;
                case LeverMoveScript.Select.Down:
                    transform.position = new Vector3(transform.position.x, initPos.y - moveAmount * 2, initPos.z);
                    break;

            }
            switch (yokoSelect)
            {
                case LeverMoveScript.Select.Up:
                    transform.position = new Vector3(initPos.x, transform.position.y, initPos.z);
                    break;
                case LeverMoveScript.Select.Center:
                    transform.position = new Vector3(initPos.x + moveAmount, transform.position.y, initPos.z);
                    break;
                case LeverMoveScript.Select.Down:
                    transform.position = new Vector3(initPos.x + moveAmount * 2, transform.position.y, initPos.z);
                    break;
            }
        }
        else
        {
            Vector3 targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + pushAmount);
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        }
    }

    public void Push()
    {
        pushFlg = true;
        Invoke("Flgfalse", 1f);
    }
    private void Flgfalse()
    {
        pushFlg = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Egg")
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.AddForce(other.transform.up * pushPower, ForceMode.Impulse);
        }
    }

}
