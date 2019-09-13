using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movements : MonoBehaviour
{
    public Rigidbody obj;
    public float speed;
    public float trans;
    public Canvas pass;
    public Canvas fail;
    public float inc;
    public int endpoint;
    public Text txt;
    public movements mov;
    public float start;


    void Start()
    {
        pass.enabled = false;
        fail.enabled = false;


    }

    void Update()
    {
        obj.AddForce(0, 0, speed * Time.deltaTime);

        txt.text = (transform.position.z + start).ToString("0");
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            obj.AddForce(-trans * Time.deltaTime, 0, 0);
            speed += inc-(0.5f*inc);
            trans += inc;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            obj.AddForce(trans * Time.deltaTime, 0, 0);
            speed += inc - (0.5f * inc);
            trans += inc;
        }



        if (transform.position.z >= endpoint)
        {
            txt.text ="";
            pass.enabled = true;
            mov.enabled = false;
        }

    }





    
}
