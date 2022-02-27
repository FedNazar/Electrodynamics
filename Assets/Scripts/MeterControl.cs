using UnityEngine;

public class MeterControl : MonoBehaviour
{
    public float speed = 5f;
    float pointerOffset = 0f;
    float currentOffset = 0f;
    bool isMoving;
    int moveDir = 1;

    public void MovePointer(float offset, int dir)
    {
        isMoving = true;
        pointerOffset = offset;
        moveDir = dir * -1;
    }

    private void Update()
    {
        if (isMoving)
        {
            if (currentOffset < pointerOffset)
            {
                gameObject.transform.Translate(Vector3.up * speed * moveDir * Time.deltaTime);
                currentOffset += speed * Time.deltaTime;
            }
            else
            {
                isMoving = false;
                currentOffset = 0f;
                pointerOffset = 0f;
            }
        }
    }
}
