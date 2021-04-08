using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class vJoyButtonHandler : XRBaseInteractable
{
    private vJoyController JoystickController;
    public int ButtonId;

    public Material SensorOnMaterial;
    public Material SensorOffMaterial;

    private MeshRenderer sensorLight;

    public void Start()
    {
        JoystickController = FindObjectOfType<vJoyController>();
        sensorLight = GetComponent<MeshRenderer>();
        sensorLight.material = SensorOffMaterial;
    }

    public void OnHoverEnterEvent(XRBaseInteractor interactor)
    {
        sensorLight.material = SensorOnMaterial;
        JoystickController.SetButton(ButtonId, true);
    }

    public void OnHoverExitEvent(XRBaseInteractor interactor)
    {
        JoystickController.SetButton(ButtonId, false);
        sensorLight.material = SensorOffMaterial;
    }
}
