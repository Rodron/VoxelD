using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroManager : MonoBehaviour
{    
    /*
    #region Instance
    private static GyroManager instance;
    public static GyroManager Instance{
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GyroManager>();
                if (instance == null){
                    instance = new GameObject("Spawned Gyromanager", typeof(GyroManager)).GetComponent<GyroManager>();
                }
            }

            return instance;
        }
        set
        {
            instance = value;
        }
    }
    #endregion
    */
    [Header ("Logic")]
    private Gyroscope gyro;
    private Quaternion rotation;
    private bool gyroActive;
    public GameObject debugText;
    Text daDebugText;

    public void EnableGyro()
    {
        if(gyroActive)
            return;

        if(SystemInfo.supportsGyroscope){
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroActive = gyro.enabled;
        }
        else
            Debug.Log("Gyro is not supported on this device");
    }

    public Quaternion GetGyroRotation()
    {
        return rotation;
    }

    private void Start()
    {
        daDebugText = debugText.GetComponent<Text>();
    }
    private void Update()
    {
        if(SystemInfo.supportsGyroscope){
            rotation = gyro.attitude;
            daDebugText.text = "Rotation: " + rotation;
        }
    }
}
