using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private float speed = 10f;
    [SerializeField] private PlayerController controller;

    private bool jump;
    private float horizontalMovement;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");

        if (Input.GetButton("Jump"))
        {
            jump = true;
        } else
        {
            jump = false;
        }

        controller.Move(horizontalMovement * speed * Time.deltaTime, jump);

    }
}
