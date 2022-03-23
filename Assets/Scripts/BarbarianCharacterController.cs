using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianCharacterController : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Walk", true);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("Run", true);
        }
    }
}
