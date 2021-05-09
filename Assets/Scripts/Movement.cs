using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Controller controller;
    public Animator animator;
    public float speed;

    private float x = 0.0f;
    private bool jump = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

        if (Input.GetKey("r"))
            controller.reset();


        x = Input.GetAxisRaw("Horizontal") * speed;

        animator.SetFloat("speed", Mathf.Abs(x));


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
    }

    void FixedUpdate()
    {
        controller.move(x * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
