using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
<<<<<<< HEAD
    private GameObject hpGauge;

    public float playTime = 10;
    private float delta;
    public Text txtTime;
    public bool isGameOver;
    public Text txtScore;
    public Text txtHp;
    private int totalScore;
=======
    GameObject hpGauge;
>>>>>>> 8ad34f4c9d2ab63a143c419943ea04d5bf9450e8

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
<<<<<<< HEAD
        this.txtScore.text = string.Format("{0}¡°", this.totalScore);

        var player = GameObject.FindObjectOfType<PlayerController>();
        this.txtHp.text = string.Format("{0}/{1}", player.hp, player.maxHp);
=======
>>>>>>> 8ad34f4c9d2ab63a143c419943ea04d5bf9450e8
    }

    void Update()
    {
<<<<<<< HEAD
        if (this.isGameOver) return;

        this.delta += Time.deltaTime;

        if (this.delta > 1)
        {
            this.delta = 0;
            this.playTime -= 1;
            this.txtTime.text = string.Format("{0}√  ", (int)this.playTime);
            if (this.playTime <= 0)
            {
                if (this.isGameOver == false)
                {
                    this.GameOver();
                }
            }
        }
    }

    public void IncreaseScore(int score)
    {
        this.totalScore += score;
        this.txtScore.text = string.Format("{0}¡°", this.totalScore);
    }

    public GameObject gameoverGo;
    public void GameOver()
    {
        this.gameoverGo.SetActive(true);
        this.isGameOver = true;
        Debug.Log("GAME OVER");
=======
>>>>>>> 8ad34f4c9d2ab63a143c419943ea04d5bf9450e8
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
<<<<<<< HEAD

    public void UpdateHpGauge(float hp, float maxHp)
    {
        this.txtHp.text = string.Format("{0}/{1}", hp, maxHp);
        var per = hp / maxHp;
        this.hpGauge.GetComponent<Image>().fillAmount = per;
        if (per <= 0)
        {
            if (this.isGameOver == false)
            {
                this.GameOver();
            }
        }
    }
=======
>>>>>>> 8ad34f4c9d2ab63a143c419943ea04d5bf9450e8
}
