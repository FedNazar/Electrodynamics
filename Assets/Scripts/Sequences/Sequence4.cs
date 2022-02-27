using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence4 : MonoBehaviour
{
    float timeValue = 0f;

    public SwitchControl sc;
    public MeterControl mc;
    public Transform sCamPos;
    public CameraRotator cr;

    bool a1 = false, a2 = false, a3 = false, a4 = false;

    void Update()
    {
        timeValue += 2 * Time.deltaTime;
        if (timeValue >= 5 && !a1)
        {
            a1 = true;
            sc.SwitchOn();
        }
        if (timeValue >= 7 && !a2)
        {
            a2 = true;
            gameObject.transform.position = sCamPos.position;
            gameObject.transform.rotation = sCamPos.rotation;
            cr.enabled = false;
        }
        if (timeValue >= 9 && !a3)
        {
            a3 = true;
            mc.MovePointer(0.16f, 1);
        }
        if (timeValue >= 12 && !a4)
        {
            a4 = true;
            SceneManager.LoadScene(5);
        }
    }
}