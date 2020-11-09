using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float input_x = 0;
    public float input_y = 0;
    public float speed = 2.5f;
    bool isWalking = false;
    //public Animator anim;
    public JoystickMovement joystmove;
    // Start is called before the first frame update
    void Start()
    {
        isWalking = false;
        GameObject Joystick = GameObject.FindGameObjectWithTag("Joystick");
        joystmove = Joystick.GetComponent<JoystickMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        input_x = joystmove.HorizontalInput();
        input_y = joystmove.VerticalInput();
        isWalking = (input_x != 0 || input_y != 0);
        if (isWalking)
        {
            var move = new Vector3(input_x, input_y, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
        }
        print("x" + input_x);
        print("y"+input_y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
            print("teste");
    }
}
