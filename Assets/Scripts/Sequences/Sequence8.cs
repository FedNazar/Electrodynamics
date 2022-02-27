using UnityEngine;
using UnityEngine.SceneManagement;

public class Sequence8 : MonoBehaviour
{
    float timeValue = 0f;

    public StringControl sc;
    public Transform sCamPos;
    public CameraRotator cr;
    public GameObject graphiteGO;
    public Rigidbody graphite;
    public MeshRenderer stringMR;

    bool a1 = false, a2 = false, a3 = false, a4 = false;

    void Update()
    {
        timeValue += 2 * Time.deltaTime;
        if (timeValue >= 15 && !a1)
        {
            a1 = true;
            stringMR.enabled = true;
            cr.enabled = false;
            gameObject.transform.position = sCamPos.position;
            gameObject.transform.rotation = sCamPos.rotation;
        }
        if (timeValue >= 17 && !a2)
        {
            a2 = true;
            sc.MoveString(3f, -1);
        }
        if (timeValue >= 22f && !a3)
        {
            a3 = true;
            graphiteGO.transform.parent = null;
            graphite.isKinematic = false;
        }
        if (timeValue >= 26 && !a4)
        {
            a4 = true;
            SceneManager.LoadScene(9);
        }
    }
}

