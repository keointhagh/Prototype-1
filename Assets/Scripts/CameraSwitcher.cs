using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Changed the toggle key to KeyCode.V
    public KeyCode switchKey = KeyCode.V;

    private Camera mainCamera;
    private Camera driverCamera;
    private bool isMainCameraActive = true;

    void Start()
    {
        // Find the GameObject by tag, then grab its Camera component
        GameObject mainCamObj = GameObject.FindWithTag("MainCamera");
        GameObject driverCamObj = GameObject.FindWithTag("DriverCamera");

        // Safety check to ensure the objects actually exist in the scene
        if (mainCamObj != null) mainCamera = mainCamObj.GetComponent<Camera>();
        if (driverCamObj != null) driverCamera = driverCamObj.GetComponent<Camera>();

        // Set the initial camera state
        SetCameraState();
    }

    void Update()
    {
        // Listen for the single keypress event (V Key)
        if (Input.GetKeyDown(switchKey))
        {
            // Toggle the boolean flag (true becomes false, false becomes true)
            isMainCameraActive = !isMainCameraActive;
            SetCameraState();
        }
    }

    void SetCameraState()
    {
        if (mainCamera != null && driverCamera != null)
        {
            // Enable one, disable the other based on our boolean state
            mainCamera.enabled = isMainCameraActive;
            driverCamera.enabled = !isMainCameraActive;
        }
    }
}
