using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawTime;// thoi gian tao ra qua bong tieo theo
    float m_spawTime;// luu tru gia tri spawtime
   
    public GameObject ball;
    void Start()
    {
        m_spawTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_spawTime -= Time.deltaTime;
        if (m_spawTime <= 0)
        {
            spawball();
            m_spawTime = spawTime;
        }
    }
    public void spawball()
    {
        Vector2 spawball = new Vector2(Random.Range(-10.04f, 4.93f), 7.138425f);
        if (ball)
        {
            Instantiate(ball, spawball, Quaternion.identity);
        }
    }

}
