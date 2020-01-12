using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pers;
    public float smooth;
    Vector3 pers_pos;
    Camera cam;
    void Start()
    {
        pers_pos = Vector3.zero;
        pers_pos.z = -10;
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraFollow();
    }

    void CameraFollow()
    {
        pers_pos = pers.transform.position;
        pers_pos.z = -10;
        cam.transform.position = pers_pos * smooth;
    }
    void CameraPositionTransform(Vector3 new_pos)
    {
        new_pos.z = -10;
        cam.transform.position = new_pos;
    }
}
