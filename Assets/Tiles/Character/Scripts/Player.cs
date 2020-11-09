using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;
    public float speed;

 //Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.magnitude);

        transform.position = transform.position + movement * speed * Time.deltaTime;

    }
}
//{
  //  public Animator playerAnimator;
   // float Horizontal = 0;
   // float Vertical = 0;
   // public float speed = 2.5f;
   // bool isWalking = false;
    // Start is called before the first frame update
   // void Start()
   // {
    //    isWalking = false;
   // }

    // Update is called once per frame
   // void Update()
    //{
      //  Horizontal = Input.GetAxisRaw("Horizontal");
       // Vertical = Input.GetAxisRaw("Vertical");
       // isWalking = (Horizontal != 0 || Vertical != 0);

       // if (isWalking)
       // {
         //   var move = new Vector3(Horizontal, Vertical, 0).normalized;
          //  transform.position += move * speed * Time.deltaTime;
       // }
   // }
//}