using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    Scene scene;
    RectTransform rect;
    SearchField search;
    public NodeMove node;
    public Slider slider;
    public Rigidbody2D rigidBody;

    private static int currentHP = 10;
    private static int playerMoveY = 100;
    private static int playerMoveX = 100;

    private bool StageTrg = true;

    //敵の種類のフラグ　これでバトル時の敵の種類を決定する
    public static bool Enemy_Metro = false;
    public static bool Enemy_Cobra = false;
    public static bool Enemy_Penguin = false;
    public static bool Enemy_Slime = false;

    //今どのシーンかを判定する
    public static bool Search01 = false;
    public static bool Search02 = false;
    public static bool Search03 = false;
    public static bool Search04 = false;
    public static bool Search05 = false;
    public static bool Search06 = false;
    public static bool Search07 = false;
    public static bool Search08 = false;
    public static bool Search09 = false;
     
    //フィールドの敵(２体)
    public GameObject flid_enemy1;
    public GameObject flid_enemy2;

    //どちらの敵に当たったか
    public static bool hit_enemy1 = false;
    public static bool hit_enemy2 = false;

    Vector3 currentPos;
    Vector3 pos;

    public int GetSetPlayerHP
    {
        get { return currentHP; }
        set { currentHP = value; }
    }


    public bool GetEnemy(int num)
    {
        switch(num)
        {
            case 0: 
                return Enemy_Metro;
           
            case 1:
                return Enemy_Cobra;

            case 2:
                return Enemy_Penguin;

            case 3:
                return Enemy_Slime;
        }
        return false;
    }

    public void SetEnemy(int num)
    {
        switch (num)
        {
            case 0:
                Enemy_Metro=true;
                Enemy_Cobra = false;
                Enemy_Penguin = false;
                Enemy_Slime = false;
                break;

            case 1:
                Enemy_Metro = false;
                Enemy_Cobra = true;
                Enemy_Penguin = false;
                Enemy_Slime = false;
                break;

            case 2:
                Enemy_Metro = false;
                Enemy_Cobra = false;
                Enemy_Penguin = true;
                Enemy_Slime = false;
                break;

            case 3:
                Enemy_Metro = false;
                Enemy_Cobra = false;
                Enemy_Penguin = false;
                Enemy_Slime = true;
                break;

        }
    }

    public bool GetSearch(int num)
    {
        switch (num)
        {
            case 1:
                return Search01;
            case 2:
                return Search02;
            case 3:
                return Search03;
            case 4:
                return Search04;
            case 5:
                return Search05;
            case 6:
                return Search06;
            case 7:
                return Search07;
            case 8:
                return Search08;
            case 9:
                return Search09;
        }
        return false;
    }

    public void SetSearch()
    {
        if (SceneManager.GetActiveScene().name == "Search01")
        {
            Search01 = true;
        }

        if (SceneManager.GetActiveScene().name == "Search02")
        {
            Search01 = false;
            Search02 = true;
        }

        if (SceneManager.GetActiveScene().name == "Search03")
        {
            Search02 = false;
            Search03 = true;
        }

        if (SceneManager.GetActiveScene().name == "Search04")
        {
            Search03 = false;
            Search04 = true;
        }

        if (SceneManager.GetActiveScene().name == "Search05")
        {
            Search04 = false;
            Search05 = true;
        }

        if (SceneManager.GetActiveScene().name == "Search06")
        {
            Search05 = false;
            Search06 = true;
        }

        if (SceneManager.GetActiveScene().name == "Search07")
        {
            Search06 = false;
            Search07 = true;
        }
        if (SceneManager.GetActiveScene().name == "Search08")
        {
            Search07 = false;
            Search08 = true;
        }
        if (SceneManager.GetActiveScene().name == "Search09")
        {
            Search08 = false;
            Search09 = true;
        }

    }

    public bool GetHit_Enemy(int num)
    {
        if(num==1)
        {
            return hit_enemy1;
        }

        if(num==2)
        {
            return hit_enemy2;
        }

        return false;
    }

    public void SetHit_Enemy(int num)
    {
        if(num==1)
        {
            hit_enemy1 = true;
        }
        if(num==2)
        {
            hit_enemy2 = true;
        }
    }

    public void ResetHit_Enemy()
    {
        hit_enemy1 = false;
        hit_enemy2 = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
        node = gameObject.GetComponent<NodeMove>();
        search = gameObject.AddComponent<SearchField>();
        rect = gameObject.GetComponent<RectTransform>();
        rigidBody = gameObject.GetComponent<Rigidbody2D>();

        // Sliderを満タン
        slider.value = currentHP;

        if (hit_enemy1 && GetSearch(1))
        {
          flid_enemy1.SetActive(false);
            pos.x = 500.0f;
            pos.y = -200.0f;
            pos.z = 0.0f;
          rect.localPosition = pos;
        }

        if (hit_enemy1 && GetSearch(2))
        {
            flid_enemy1.SetActive(false);
            pos.x = 400.0f;
            pos.y = -100.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;          
        }

        if (hit_enemy2 && GetSearch(2))
        {
            flid_enemy2.SetActive(false);
            pos.x = -200.0f;
            pos.y = 0.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy1 && GetSearch(3))
        {
            flid_enemy1.SetActive(false);
            pos.x = 400.0f;
            pos.y = 200.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy2 && GetSearch(3))
        {
            flid_enemy2.SetActive(false);
            pos.x = -500.0f;
            pos.y = -100.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy1 && GetSearch(4))
        {
            flid_enemy1.SetActive(false);
            pos.x = -200.0f;
            pos.y = 0.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy2 && GetSearch(4))
        {
            flid_enemy2.SetActive(false);
            pos.x = 400.0f;
            pos.y = 100.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy1 && GetSearch(5))
        {
            flid_enemy1.SetActive(false);
            pos.x = -200.0f;
            pos.y = 0.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy2 && GetSearch(5))
        {
            flid_enemy2.SetActive(false);
            pos.x = 200.0f;
            pos.y = -200.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy1 && GetSearch(6))
        {
            flid_enemy1.SetActive(false);
            pos.x = -300.0f;
            pos.y = 100.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy2 && GetSearch(6))
        {
            flid_enemy2.SetActive(false);
            pos.x = 200.0f;
            pos.y = -100.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy1 && GetSearch(7))
        {
            flid_enemy1.SetActive(false);
            pos.x = 100.0f;
            pos.y = 200.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy2 && GetSearch(7))
        {
            flid_enemy2.SetActive(false);
            pos.x = -400.0f;
            pos.y = -200.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy1 && GetSearch(8))
        {
            flid_enemy1.SetActive(false);
            pos.x = -300.0f;
            pos.y = 0.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

        if (hit_enemy2 && GetSearch(8))
        {
            flid_enemy2.SetActive(false);
            pos.x = 200.0f;
            pos.y = -100.0f;
            pos.z = 0.0f;
            rect.localPosition = pos;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Battle" &&
            node.GetSetDamageflgP)
        {
            PlayerBattle();
        }
        if (StageTrg)
        {
            PlayerMove();
        }
        if (!StageTrg) 
        {
            rect.position = currentPos;
        }

  
    }

    private void PlayerBattle()
    {
        // ダメージランダム
        int damage = 1;

        // HPからダメージを引く
        currentHP -= damage;

        slider.value = currentHP;

        node.GetSetDamageflgP = false;
    }

    private void PlayerMove()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rect.localPosition += new Vector3(-playerMoveX, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rect.localPosition += new Vector3(0, playerMoveY, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rect.localPosition += new Vector3(0, -playerMoveY, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rect.localPosition += new Vector3(playerMoveX, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Stairs"))
        {
            search.GetSetNextFlg = true;
        }
        if (other.gameObject.CompareTag("Stage"))
        {
            StageTrg = true;
            currentPos = rect.position;
        }
        if (other.gameObject.CompareTag("Tile"))
        {
            StageTrg = false;
        }

        if(other.gameObject.CompareTag("Enemy_Metro")|| other.gameObject.CompareTag("Enemy_Cobra")||
            other.gameObject.CompareTag("Enemy_Penguin")|| other.gameObject.CompareTag("Enemy_Slime")||
           other.gameObject.CompareTag("Enemy_Metro2") || other.gameObject.CompareTag("Enemy_Cobra2") ||
           other.gameObject.CompareTag("Enemy_Penguin2") || other.gameObject.CompareTag("Enemy_Slime2"))
        {
            SetSearch();
        }

        if (other.gameObject.CompareTag("Enemy_Metro"))
        {
            SetEnemy(0);
            SetHit_Enemy(1);
            scene.ChangeScene((int)Scene.SceneName.Battle);
            return;
            
        }
        if (other.gameObject.CompareTag("Enemy_Metro2"))
        {
            SetEnemy(0);
            SetHit_Enemy(2);
            scene.ChangeScene((int)Scene.SceneName.Battle);
            return;
        }

        if (other.gameObject.CompareTag("Enemy_Cobra"))
        {
            SetEnemy(1);
            SetHit_Enemy(1);
            scene.ChangeScene((int)Scene.SceneName.Battle);
            return;
        }
        if (other.gameObject.CompareTag("Enemy_Cobra2"))
        {
            SetEnemy(1);
            SetHit_Enemy(2);
            scene.ChangeScene((int)Scene.SceneName.Battle);
            return;
        }

        if (other.gameObject.CompareTag("Enemy_Penguin"))
        {
            SetEnemy(2);
            SetHit_Enemy(1);
            scene.ChangeScene((int)Scene.SceneName.Battle);
            return;
        }
        if (other.gameObject.CompareTag("Enemy_Penguin2"))
        {
            SetEnemy(2);
            SetHit_Enemy(2);
            scene.ChangeScene((int)Scene.SceneName.Battle);
            return;
        }

        if (other.gameObject.CompareTag("Enemy_Slime"))
        {
            SetEnemy(3);
            SetHit_Enemy(1);
            scene.ChangeScene((int)Scene.SceneName.Battle);
            return;
        }
        if (other.gameObject.CompareTag("Enemy_Slime2"))
        {
            SetEnemy(3);
            SetHit_Enemy(2);
            scene.ChangeScene((int)Scene.SceneName.Battle);
            return;
        }


    }
}
