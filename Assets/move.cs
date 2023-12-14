using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5f;
    public Animator anim;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("kiri", true);

            Vector3 Movement = new Vector3(-speed, 0f, 0f) * Time.deltaTime;

            transform.Translate(Movement);
        }

        else
        {
            anim.SetBool("kiri", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("kanan", true);
            
            Vector3 Movement = new Vector3(speed, 0f, 0f) * Time.deltaTime;

            transform.Translate(Movement);
        } 

        else 
        {
            anim.SetBool("kanan", false);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("throw", true);
        }

        else
        {
            anim.SetBool("throw", false);
        }
    }
}
