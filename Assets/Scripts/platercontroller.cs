                     using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platercontroller : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    public float speed=200f;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movemet();
    }

    void Movemet()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float facedircetion = Input.GetAxisRaw("Horizontal");
        float verticalmove = Input.GetAxis("Vertical");
        //»ÀŒÔ“∆∂Ø
        if (horizontalmove != 0 )
        {
            rb.velocity = new Vector2(horizontalmove * Time.fixedDeltaTime * speed , rb.velocity.y);
            anim.SetFloat("running", Mathf.Abs(horizontalmove));
        }
        if (verticalmove != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x , verticalmove * Time.fixedDeltaTime * speed);
            anim.SetFloat("running", Mathf.Abs(verticalmove));
        }
        if (facedircetion != 0)
        {
            transform.localScale = new Vector3(facedircetion,1,1);
        }
    }
}
