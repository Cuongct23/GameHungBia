using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class beerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject heart1, heart2, heart3;
    int mang = 0;
    public GameObject gameOver;
    Text txt;

    void Start()
    {
        gameOver.SetActive(false);
        txt = GameObject.Find("Score").GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("beer"))
        {
            mang += 1;
            if (mang == 1)
            {
                if (controller.score < 0)
                {
                    txt.text = "Score:" + 0;
                }
                else if (controller.score > 0)
                {
                    controller.score -= 200;
                    txt.text = "Score:" + controller.score;
                }
                Destroy(heart3);
            }
            else if (mang == 2)
            {
                if (controller.score < 0)
                {
                    txt.text = "Score:" + 0;
                }
                else if (controller.score > 0)
                {
                    controller.score -= 200;
                    txt.text = "Score:" + controller.score;
                }
                Destroy(heart2);
            }
            else if (mang == 3)
            {
                if (controller.score < 0)
                {
                    txt.text = "Score:" + 0;
                }
                else if (controller.score > 0)
                {
                    controller.score -= 200;
                    txt.text = "Score:" + controller.score;
                }
                Destroy(heart1);
                Time.timeScale = 0f;

                //if (audioSource && audioLose)
                gameOver.SetActive(true);
                //UnityEditor.EditorApplication.isPlaying = false;
            }
            Destroy(collision.gameObject);
            Debug.Log("va cham" + collision.gameObject.name);
        }
    }
}
