using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class followTrain : MonoBehaviour
{
    public GameObject obj;
    public float x;
    public float y;
    public float z;

    public Camera cameraObj;

    public float speedx = 5.0f;
    public float speedy = 5.0f;

    public Vector3 offset;

    private float yOffset = 12.0f;
    private float zOffset = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(obj.transform.position.x, obj.transform.position.y + yOffset, obj.transform.position.z + zOffset);
        offset = new Vector3(0, 10, -12);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = new Vector3(obj.transform.position.x + x, obj.transform.position.y + y, obj.transform.position.z +z);
        //transform.position = obj.transform.position + new Vector3(x, y, z);
        if (Input.GetMouseButton(0))
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * speedx, Vector3.up) * offset;
            

        }
        if (Input.GetMouseButton(1))
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * speedx, Vector3.forward) * offset;
            offset = new Vector3(offset.x, Mathf.Clamp(offset.y, 10, 180), offset.y);


        }
        transform.position = obj.transform.position + offset;
        transform.LookAt(obj.transform.position);

    }

}
