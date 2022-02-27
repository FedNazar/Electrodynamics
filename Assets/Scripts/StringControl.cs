using UnityEngine;

public class StringControl : MonoBehaviour
{
    public float speed = 5f, rotateSpeed = 1f;
    private float sPath = 0, currentSPath = 0;
    private float sMPath = 0, currentSMPath = 0;
    bool isMoving = false, isRotating = false;
    int moveDir = 1, rotateDir = 1;

    public void MoveString(float path, int dir)
    {
        sPath = path;
        moveDir = dir;
        isMoving = true;
    }

    public void RotateString(float path, int dir)
    {
        sMPath = path;
        rotateDir = dir;
        isRotating = true;
    }

    private void Update()
    {
        if (isMoving)
        {
            if (currentSPath < sPath)
            {
                gameObject.transform.Translate(gameObject.transform.forward * speed * moveDir * Time.deltaTime);
                currentSPath += speed * Time.deltaTime;
            }
            else
            {
                isMoving = false;
                currentSPath = 0;
            }
        }
        if (isRotating)
        {
            if (currentSMPath < sMPath)
            {
                gameObject.transform.Rotate(gameObject.transform.up * rotateSpeed * rotateDir * Time.deltaTime);
                currentSMPath += (rotateSpeed / 1000) * Time.deltaTime;
            }
            else
            {
                isRotating = false;
                currentSMPath = 0;
            }
        }
    }
}
