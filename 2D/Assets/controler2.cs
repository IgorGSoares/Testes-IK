using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler2 : MonoBehaviour
{
    public Animator ani;
    //private bool active = true;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ani.SetBool("An1", true);

            ani.SetBool("An2", false);
            ani.SetBool("An3", false);
            ani.SetBool("An4", false);

            //active = false;
            //StartCoroutine(recharge());
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ani.SetBool("An2", true);

            ani.SetBool("An1", false);
            ani.SetBool("An3", false);
            ani.SetBool("An4", false);

            //active = false;
            //StartCoroutine(recharge());
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ani.SetBool("An3", true);

            ani.SetBool("An1", false);
            ani.SetBool("An2", false);
            ani.SetBool("An4", false);

            //active = false;
            //StartCoroutine(recharge());
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ani.SetBool("An4", true);
        }
        else
        {
            ani.SetBool("An1", false);
            ani.SetBool("An2", false);
            ani.SetBool("An3", false);
            ani.SetBool("An4", false);

            //if (active == true)
            //{
            //    StartCoroutine(idle());
            //    Debug.Log("entrou");
            //    active = false;
            //}

        }
    }
}
