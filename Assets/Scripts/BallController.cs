using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public int force;
    Rigidbody2D rigid;
    private int count;
    public Text countText;
    GameObject panelLanjutLevel2;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Vector2 arah = new Vector2(2, 4).normalized;
        rigid.AddForce(arah * force);
        count = 0;
        SetCountText();

        panelLanjutLevel2 = GameObject.Find("PanelMenang");
        panelLanjutLevel2.SetActive(false);
    }

    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Box"))
        {
            Destroy(other.gameObject);
            count = count + 5;
            SetCountText();
        }
        if(other.gameObject.name == "Paddle")
        {
            float sudut = (transform.position.x - other.transform.position.x) * 5f;
            Vector2 arah = new Vector2(sudut, rigid.velocity.y).normalized;
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(arah * force * 2);
        }
        if(other.gameObject.name == "tepiBawah")
        {
            ResetPositionBall();
        }
        if(count == 100)
        {
            panelLanjutLevel2.SetActive(true);
            Destroy(gameObject);
            return;
        }
    }

    void SetCountText()
    {
        countText.text = " " + count.ToString();
    }

    void ResetPositionBall()
    {
        transform.localPosition = new Vector2(0, -2.65f);
        Vector2 arah = new Vector2(2, 4).normalized;
    }
}
