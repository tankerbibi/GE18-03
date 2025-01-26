using UnityEngine;

public class LeverMoveScript : MonoBehaviour
{
    public enum Select
    {
        Up,
        Center,
        Down,
    }
    private Select select = Select.Up;
    [SerializeField] private float rotateAmount = 50.0f;
    [SerializeField] private PlayerCheckScript playerCheckScript;
    public bool tate = true;
    private void Start()
    {
        transform.Rotate(0.0f, 0.0f, rotateAmount);
    }

    public void LeverMove()
    {
        if (playerCheckScript.flg)
        {
            switch (select)
            {
                case Select.Up:
                    transform.Rotate(0.0f, 0.0f, -rotateAmount);
                    select = Select.Center;
                    break;
                case Select.Center:
                    transform.Rotate(0.0f, 0.0f, -rotateAmount);
                    select = Select.Down;
                    break;
                case Select.Down:
                    transform.Rotate(0.0f, 0.0f, 2 * rotateAmount);
                    select = Select.Up;
                    break;
            }
        }
    }
}
