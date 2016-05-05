using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour
{

    // Attributes

    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes Axes = RotationAxes.MouseXAndY;

    public float SensitivityX = 10F;
    public float SensitivityY = 10F;

    public float MinimumX = -360F;
    public float MaximumX = 360F;

    public float MinimumY = -60F;
    public float MaximumY = 60F;

    float RotationY = 0F;

    Transform CameraTransform;

    public GameObject Player;
    Vector3 Offset;

    void Start()
    {
        Offset = transform.position - Player.transform.position;

        CameraTransform = transform;

        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
    }

    void Update()
    {
        transform.position = Player.transform.position + Offset;
        MouseHandling();
    }

    void MouseHandling()
    {
        //Look direction
        if (Axes == RotationAxes.MouseXAndY)
        {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * SensitivityX;

            RotationY += Input.GetAxis("Mouse Y") * SensitivityY;
            RotationY = Mathf.Clamp(RotationY, MinimumY, MaximumY);

            CameraTransform.localEulerAngles = new Vector3(-RotationY, rotationX, 0);
        }

        else if (Axes == RotationAxes.MouseX)
        {
            CameraTransform.Rotate(0, Input.GetAxis("Mouse X") * SensitivityX, 0);
        }

        else
        {
            RotationY += Input.GetAxis("Mouse Y") * SensitivityY;
            RotationY = Mathf.Clamp(RotationY, MinimumY, MaximumY);

            CameraTransform.localEulerAngles = new Vector3(-RotationY, transform.localEulerAngles.y, 0);
        }
    }
}
