using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenDelay : MonoBehaviour
{
    float timeValue = 0f;
    bool a = false;

    void Update()
    {
        timeValue += 2 * Time.deltaTime;
        if (timeValue >= 5 && !a)
        {
            a = true;
            SceneManager.LoadScene(1);
        }
    }
}
