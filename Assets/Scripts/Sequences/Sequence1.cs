using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence1 : MonoBehaviour
{
    float timeValue = 0f;

    public LampControl lc;
    public SwitchControl sc;

    bool a1 = false, a2 = false, a3 = false;

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
            lc.TurnLampOn();
        }
        if (timeValue >= 11 && !a3)
        {
            a3 = true;
            SceneManager.LoadScene(2);
        }
    }
}
