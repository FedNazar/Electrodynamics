using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence7 : MonoBehaviour
{
    float timeValue = 0f;

    public StringControl sc;
    public Transform sCamPos;
    public CameraRotator cr;

    bool a1 = false, a2 = false, a3 = false, a4 = false;

    void Update()
    {
        timeValue += 2 * Time.deltaTime;
        if (timeValue >= 9 && !a1)
        {
            a1 = true;
            cr.enabled = false;
            gameObject.transform.position = sCamPos.position;
            gameObject.transform.rotation = sCamPos.rotation;
        }
        if (timeValue >= 11 && !a2)
        {
            a2 = true;
            sc.MoveString(1.7f, -1);
        }
        if (timeValue >= 14f && !a3)
        {
            a3 = true;
            sc.RotateString(100f, -1);
        }
        if (timeValue >= 24 && !a4)
        {
            a4 = true;
            SceneManager.LoadScene(8);
        }
    }
}

