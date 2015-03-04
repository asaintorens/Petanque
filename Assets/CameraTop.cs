using UnityEngine;
using System.Collections;

public class CameraTop : MonoBehaviour
{

    public UnityEngine.Camera cameraMain;
    public UnityEngine.Camera cameraTop;
    void Start()
    {
        cameraTop.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChangeCamera()
    {
        if (!this.cameraTop.enabled)
        {
            this.cameraTop.enabled = true;
            this.cameraMain.enabled = false;
        }
        else
        {
            this.cameraTop.enabled = false;
            this.cameraMain.enabled = true;
        }
    }
}
