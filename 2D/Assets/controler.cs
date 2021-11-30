using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    public GameObject player;
    private Animator ani;
    //private bool active = true;
    void Start()
    {
        ani = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAni1()
    {
        ani.SetBool("An1", true);
        ani.SetBool("An2", false);
        ani.SetBool("An3", false);
        ani.SetBool("An4", false);

        StartCoroutine(Resetar());
    }

    public void playAni2()
    {
        ani.SetBool("An2", true);
        ani.SetBool("An1", false);
        ani.SetBool("An3", false);
        ani.SetBool("An4", false);

        StartCoroutine(Resetar());
    }

    public void playAni3()
    {
        ani.SetBool("An3", true);
        ani.SetBool("An1", false);
        ani.SetBool("An2", false);
        ani.SetBool("An4", false);

        StartCoroutine(Resetar());
    }

    public void playAni4()
    {
        ani.SetBool("An1", false);
        ani.SetBool("An2", false);
        ani.SetBool("An3", false);
        ani.SetBool("An4", true);

        StartCoroutine(Resetar());
    }

    IEnumerator Resetar()
    {
        yield return new WaitForSeconds(0.5f);

        ani.SetBool("An1", false);
        ani.SetBool("An2", false);
        ani.SetBool("An3", false);
        ani.SetBool("An4", false);
    }
}