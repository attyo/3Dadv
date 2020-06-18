using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    [SerializeField]
    GameObject camera;
    [SerializeField]
    float cam_speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateCamera();
    }
    private void rotateCamera()
    {
        //Vector3でX,Y方向の回転の度合いを定義
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * cam_speed, Input.GetAxis("Mouse Y") * cam_speed, 0);

        if (camera.transform.forward.y > 0.7f && angle.y > 0)
        {
            angle.y = 0;
        }
        else
        if (camera.transform.forward.y < -0.7f && angle.y < 0)
        {
            angle.y = 0;
        }
        else
            camera.transform.RotateAround(camera.transform.position, -camera.transform.right, angle.y);
        camera.transform.RotateAround(camera.transform.position, Vector3.up, angle.x);

    }
}
