using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Control : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed; // speed of our moves
    Vector3 change; // changes per click
    Rigidbody2D pers;
    Animator anim;
    void Start()
    {
        change = new Vector3(0, 0, 0);
        pers = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change.x = Input.GetAxisRaw("Horizontal"); // read of "A" - "D" and "Left" - "Right" buttons
        change.y = Input.GetAxisRaw("Vertical"); // read of "W" - "S" and "Up" - "Down" buttons

        if (change != Vector3.zero) // transform position
        {
            MoveCharacter();
            AnimationCharacter(change.x, change.y);
        }
        else
        {
            anim.SetBool("move", false);
        }
    }

    void MoveCharacter()
    {
        //pers.MovePosition(transform.position + change * speed * Time.deltaTime);
        transform.position += change * speed;
    }
    void AnimationCharacter(float x, float y)
    {
        anim.SetFloat("x", x);
        anim.SetFloat("y", y);
        anim.SetBool("move", true);


    }
}
