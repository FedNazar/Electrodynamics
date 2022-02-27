using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence10 : MonoBehaviour
{
    float timeValue = 0f;

    public LampControl lc1, lc2;
    public SwitchControl sc;

    bool a1 = false, a2 = false, a3 = false;
    bool a4 = false, a5 = false, a6 = false, a7 = false;

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
            lc1.TurnLampOn();
        }
        if (timeValue >= 7.5f && !a3)
        {
            a3 = true;
            lc2.TurnLampOn();
        }
        if (timeValue >= 15 && !a4)
        {
            a4 = true;
            sc.SwitchOff();
        }
        if (timeValue >= 17 && !a5)
        {
            a5 = true;
            lc1.SetIntensity(4);
            lc2.SetIntensity(4);
        }
        if (timeValue >= 17.4f && !a6)
        {
            a6 = true;
            lc1.TurnLampOff();
            lc2.TurnLampOff();
        }
        if (timeValue >= 21f && !a7)
        {
            a7 = true;
            Application.Quit();
        }
    }
}

