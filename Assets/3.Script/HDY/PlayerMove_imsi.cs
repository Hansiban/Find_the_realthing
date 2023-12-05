using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_imsi : MonoBehaviour
{
    private Rigidbody rd;
    public float speed = 10f;
    public float jumpHeight = 3f;
    public float dash = 5f;
    public float rotSpeed = 3f;

    private Vector3 dir = Vector3.zero;
    public LayerMask layer;
    public bool ground = false;

    private bool hurt = false;

    private void Start()
    {
        rd = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        dir.Normalize();

    }
    private void FixedUpdate()
    {
        if (dir != Vector3.zero)
        {
            bool complete = Mathf.Sign(transform.forward.x) != Mathf.Sign(dir.x) || Mathf.Sign(transform.forward.z) != Mathf.Sign(dir.z);

            //캐릭터가 향하는 쪽으로 시선이 돌아간다.
            if (complete)
            {
                transform.Rotate(0, 1, 0);
            }
            
            transform.forward = Vector3.Lerp(transform.forward, dir, rotSpeed * Time.deltaTime);
        }

        rd.MovePosition(this.gameObject.transform.position + dir * speed * Time.deltaTime);
    }
}


