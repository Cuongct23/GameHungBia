using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeImage : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] sprites = new Sprite[5];
    SpriteRenderer renderer;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.score == 200)
        {
            renderer.sprite = sprites[0];
        }else if (controller.score == 400)
        {
            renderer.sprite = sprites[1];
        }
        else if (controller.score == 600)
        {
            renderer.sprite = sprites[2];
        }
        else if (controller.score == 800)
        {
            renderer.sprite = sprites[3];
        }
    }
}
