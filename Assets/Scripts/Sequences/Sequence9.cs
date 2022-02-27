using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence9 : MonoBehaviour
{
    float timeValue = 0f;

    public Transform sCamPos;
    public CameraRotator cr;
    public MeshRenderer cuStrMR, clStrMR;

    bool a1 = false, a2 = false;

    void Update()
    {
        timeValue += 2 * Time.deltaTime;
        if (timeValue >= 7 && !a1)
        {
            a1 = true;
            cuStrMR.enabled = true;
            clStrMR.enabled = true;
            cr.enabled = false;
            gameObject.transform.position = sCamPos.position;
            gameObject.transform.rotation = sCamPos.rotation;
        }
        if (timeValue >= 16 && !a2)
        {
            a2 = true;
            SceneManager.LoadScene(10);
        }
    }
}


