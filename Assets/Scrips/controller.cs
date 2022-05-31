using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D mBody;
    public float speed;
    public static int score = 0;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public GameObject heart1, heart2, heart3;



    void Start()
    {
        mBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        if (transform.position.x <= -9.42 && move < 0 || transform.position.x >= 4.28 && move > 0)
        {
            return;
        }
        else if (move != 0)
        {
            transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("beer"))
        {
            if (audioSource && audioClip)
            {
                audioSource.PlayOneShot(audioClip);
                Text txt = GameObject.Find("Score").GetComponent<Text>();
                score += 200;
                txt.text = "Score:" + score;
                Debug.Log("Va cham" + collision.gameObject.name);
                Destroy(collision.gameObject);


            }
            else
            {
                audioSource.Play();
            }

        }

    }
    public void Reload()
    {
        SceneManager.LoadScene("lab6");
        Time.timeScale = 1f;

    }
}
