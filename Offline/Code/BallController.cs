using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BallController : MonoBehaviour
{
    public Rigidbody2D rg;
    public float speed;
    public float x, y;
    public TextMeshProUGUI Player1, Player2, Score;
    private int plus, plus2;
    public Transform spawn;
    public bool pos, audio;
    public Manager manager;

    void Start()
    {
        BallControllers();
    }
    public void Update()
    {
        if (pos)
        {
            transform.position = spawn.position;
            manager.source.PlayOneShot(manager.SFX[1]);
            pos = false;
        }
        if (audio)
        {
            manager.source.PlayOneShot(manager.SFX[0]);
            audio = false;
        }
        var i = plus == 3;
        var ii = plus2 == 3;
        if (i)
        {
            manager.PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if (ii)
        {
            manager.PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void FixedUpdate()
    {
        Score.text = "_";
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            audio = true;
        }
        if (collision.gameObject.CompareTag("Wall 3"))
        {
            plus++;
            Player2.text = "" + plus;
            pos = true;
        }
        if (collision.gameObject.CompareTag("Wall 4"))
        {
            plus2++;
            Player1.text = "" + plus2;
            pos = true;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            audio = true;
        }
    }
    void BallControllers()
    {
        x = Random.Range(0.1f, 2f) == 0 ? -1 : 1;
        y = Random.Range(0.1f, 2f) == 0 ? -1 : 1;
        rg.velocity = new Vector2(x * speed, y * speed);
    }
}
