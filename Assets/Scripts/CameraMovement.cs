using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{
    Transform transform;
    public GameObject target;

	// Use this for initialization
	void Start () 
    {
        transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.mousePosition.x > Screen.width / 2 + Screen.width / 8)
        {
            GetComponent<Transform>().Rotate(target.transform.up, 0.5f);
        }
        else if (Input.mousePosition.x < Screen.width / 2 - Screen.width / 8)
        {
            GetComponent<Transform>().Rotate(target.transform.up, -0.5f);
        }

        if (Input.mousePosition.y > Screen.height / 2 + Screen.height / 8)
        {
            GetComponent<Transform>().Rotate(transform.right, 0.5f);
        }
        else if (Input.mousePosition.y < Screen.height / 2 - Screen.height / 8)
        {
            GetComponent<Transform>().Rotate(transform.right, -0.5f);
        }
	
	}
}
