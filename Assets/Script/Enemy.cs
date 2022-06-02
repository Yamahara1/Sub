using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private static int currentHP;
    public Slider slider;
    Scene scene;

    private bool trg;


    public int GetSetEnemyHP
    {
        get { return currentHP; }
        set { currentHP = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
        // Sliderを満タン
        slider.value = currentHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Battle")
        {
            EnemyBattle();
        }
    }

    public void EnemyBattle()
    {
        if (Input.GetKeyDown(KeyCode.Return) && trg)
        {
            // ダメージランダム
            int damage = 1;

            // HPからダメージを引く
            currentHP -= damage;

            trg = false;
        }
        slider.value = currentHP;
        trg = true;
    }
}
