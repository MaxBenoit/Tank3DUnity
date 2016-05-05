using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour
{
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    void Update()
    {
        float translation = -Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        GetComponent<Transform>().Translate(0, 0, translation);
        GetComponent<Transform>().Rotate(0, rotation, 0);
    }
}