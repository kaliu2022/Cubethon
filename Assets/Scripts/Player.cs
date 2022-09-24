using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float Force = 750;
    bool alive = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            //move left right
            float hSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
            transform.Translate(hSpeed, 0, 0);
            //move forward
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * Force * Time.deltaTime);
        }

    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void FixedUpdate()
    {
        if (transform.position.y < -100)
        {
            Reset();
        }

    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag != "Floor")
        {
            alive = false;
            Invoke("Reset", 5.0f); //reload scene in 5 seconds
        }
    }

    public void Stop()
    {
        alive = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        Invoke("Reset", 5.0f); //reset the game in 5 seconds
    }

}
