using UnityEngine;

public class LampControl : MonoBehaviour
{
    public Light lLight;
    public Material lOff, lOn;
    MeshRenderer mr;

    private void Start()
    {
        mr = gameObject.GetComponent<MeshRenderer>();
    }

    public void TurnLampOn()
    {
        lLight.enabled = true;
        mr.material = lOn;
    }

    public void TurnLampOff()
    {
        lLight.enabled = false;
        mr.material = lOff;
    }

    public void SetIntensity(float intensity)
    {
        lLight.intensity = intensity;
    }
}
