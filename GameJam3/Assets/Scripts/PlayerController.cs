using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speedTimeout = 10F;
    public bool _speedActive = false;
    public float speed;
    public float maxspeed;
    

    private Rigidbody rb;
    private float _speedTimeRemaining;

    void Start()
    {
        _speedTimeRemaining = speedTimeout;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (_speedActive && _speedTimeRemaining > 0)
        {
            _speedTimeRemaining -= Time.deltaTime;
            speed = maxspeed;

        }
        else
        {
            _speedTimeRemaining = speedTimeout;
            _speedActive = false;
            speed = 5;
        }
        Debug.Log(_speedTimeRemaining);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        //Debug.Log(speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
           _speedActive = true;
            other.gameObject.SetActive(false);
        }
    }

}