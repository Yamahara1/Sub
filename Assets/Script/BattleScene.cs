using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScene : MonoBehaviour
{
    Scene scene;
    Player player;
    Enemy enemy;

    //エネミーは一定時間で攻撃(のちに実行)

    public GameObject Enemy_Metro;
    public GameObject Enemy_Cobra;
    public GameObject Enemy_Penguin;
    public GameObject Enemy_Slime;

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
        player = gameObject.AddComponent<Player>();
        enemy = gameObject.AddComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetEnemy(0))
        {
            Enemy_Metro.SetActive(true);
        }
        if (player.GetEnemy(1))
        {
            Enemy_Cobra.SetActive(true);
        }
        if (player.GetEnemy(2))
        {
            Enemy_Penguin.SetActive(true);
        }
        if (player.GetEnemy(3))
        {
            Enemy_Slime.SetActive(true);
        }

        if (player.GetSetPlayerHP <= 0)
        {
            scene.ChangeScene((int)Scene.SceneName.GameOver);
        }
        if (enemy.GetSetEnemyHP <= 0)
        {
            scene.ChangeScene((int)Scene.SceneName.GameClear);
        }

        if (Input.GetMouseButton(0))
        {
            if(player.GetSearch(1))
            {
                scene.ChangeScene((int)Scene.SceneName.Search01);
            }

            if (player.GetSearch(2))
            {
                scene.ChangeScene((int)Scene.SceneName.Search02);
            }

            if (player.GetSearch(3))
            {
                scene.ChangeScene((int)Scene.SceneName.Search03);
            }

            if (player.GetSearch(4))
            {
                scene.ChangeScene((int)Scene.SceneName.Search04);
            }

            if (player.GetSearch(5))
            {
                scene.ChangeScene((int)Scene.SceneName.Search05);
            }

            if (player.GetSearch(6))
            {
                scene.ChangeScene((int)Scene.SceneName.Search06);
            }

            if (player.GetSearch(7))
            {
                scene.ChangeScene((int)Scene.SceneName.Search07);
            }
            if (player.GetSearch(8))
            {
                scene.ChangeScene((int)Scene.SceneName.Search08);
            }
            if (player.GetSearch(9))
            {
                scene.ChangeScene((int)Scene.SceneName.Search09);
            }
        }

    }
}
