using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{

    private float speedMod = 0.0f;//a speed modifier
    private Vector3 point = new Vector3(0,0,0);//the coord to the point where the camera looks at

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(point);//makes the camera look to it
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(point, new Vector3(0.0f, 0.0f, 0.0f), 20 * Time.deltaTime * speedMod);
    }
}
