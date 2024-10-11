using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyNerd : MonoBehaviour
{
    public float _jumpHeight = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0) * Time.deltaTime;

        if(Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpHeight);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Renderer>().enabled = false;
        Time.timeScale = 0;
    }
}
