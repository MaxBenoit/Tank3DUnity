using UnityEngine;
using System.Collections;

public class TankMove : MonoBehaviour
{
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    int frontBackMove;
    int sideMove;

    void Update()
    {
        KeyboardHandling();
        if (frontBackMove != 0 && sideMove != 0)
        {
            float translation = frontBackMove * speed;
            float rotation = sideMove * rotationSpeed;
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;
            GetComponent<Transform>().Translate(0, 0, translation);
            GetComponent<Transform>().Rotate(0, rotation, 0);
        }
        // Mouse
        foreach (Mesh m in GetComponentsInChildren<Mesh>())
        {
            Debug.LogFormat(m.name);
        }
    }
    void KeyboardHandling()
    {
        frontBackMove = KeyHandling(KeyCode.S) - KeyHandling(KeyCode.W);
        sideMove = KeyHandling(KeyCode.D) - KeyHandling(KeyCode.A);
    }
    int KeyHandling(KeyCode key)
    {
        return Input.GetKey(key) ? 1 : 0;
    }
}