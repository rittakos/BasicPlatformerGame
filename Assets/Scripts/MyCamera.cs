using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public Transform player;

    public float time = 0.1f;
    private Vector3 v = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            float x = Mathf.SmoothDamp(transform.position.x, player.position.x, ref v.x, time);
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
    }
}
