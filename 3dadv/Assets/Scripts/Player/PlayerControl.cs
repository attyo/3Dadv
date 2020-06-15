using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    float speed=0.1f;
    Rigidbody rigid;
    Vector3 forward_camera;
    Vector3 right_camera;
    
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        forward_camera = transform.GetChild(0).transform.forward;//カメラのフォワードをとる
        forward_camera.y = 0;
        right_camera = transform.GetChild(0).transform.right;


        if (Input.GetKey(KeyCode.W))
        {
            rigid.MovePosition(transform.position + forward_camera * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigid.MovePosition(transform.position - right_camera  * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigid.MovePosition(transform.position - forward_camera * speed/2.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.MovePosition(transform.position + right_camera * speed);
        }
    }
}
