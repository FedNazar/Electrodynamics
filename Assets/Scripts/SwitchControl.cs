using UnityEngine;

public class SwitchControl : MonoBehaviour
{
    public float speed = 10;
    public float sPath = 60f;
    float currentSPath = 0f;
    bool isSwitching = false;
    int switchDir = 1;

    public void SwitchOn()
    {
        switchDir = 1;
        isSwitching = true;
    }

    public void SwitchOff()
    {
        switchDir = -1;
        isSwitching = true;
    }

    private void Update()
    {
        if (isSwitching)
        {
            if (currentSPath <= sPath)
            {
                transform.Rotate(transform.forward * speed * Time.deltaTime * switchDir);
                currentSPath += speed * Time.deltaTime;
            }
            else
            {
                isSwitching = false;
                currentSPath = 0f;
            }
        }
    }
}
