using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animations : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rig;
    public AudioSource over;
    public AudioSource down;
    public AudioSource losing;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = 0, y = 0;
        rig = GetComponent<Rigidbody2D>();
        if (Input.GetKey("left"))
        {
            x = -40;
            transform.localScale = new Vector3(-2, 2, 1);
        }
        else if (Input.GetKey("right"))
        {
            x = 40;
            transform.localScale = new Vector3(2, 2, 1);
        }
        else if (Input.GetKey("up"))
        {
            y = 20;
        }
        else if (Input.GetKey("down"))
        {
            y = -20;
        }
        rig.AddForce(new Vector2(x, y));

    }

    private void OnCollisionEnter2D(Collision2D obj)
    {
        if(obj.gameObject.tag=="Coin")
        {
            Destroy(obj.gameObject);
            Coin.scorevale += 10;
            over.Play();
        }
        if (obj.gameObject.tag == "Bird")
        {
            Destroy(obj.gameObject);
            Coin.scorevale -= 10;
            down.Play();
        }
        if (obj.gameObject.tag == "Enemy")
        {
            losing.Play();
            Destroy(player);
            Coin.scorevale = 0;
            TimeLeft.Timer = 15;
            SceneManager.LoadScene("Animations"); 
        }
        if (Coin.scorevale >= 70|| obj.gameObject.tag == "End")
        {
            losing.Play();
            SceneManager.LoadScene("Animations2");
        }
        if (obj.gameObject.tag == "Time++")
        {
            Destroy(obj.gameObject);
            TimeLeft.Timer += 15;
        }
    }
}
