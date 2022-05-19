using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchField : MonoBehaviour
{
    Scene scene;
    Enemy enemy;
    private bool nextScene = false;

    public bool GetSetNextFlg
    {
        get { return nextScene; }
        set { nextScene = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        scene = gameObject.AddComponent<Scene>();
        enemy = gameObject.AddComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        SceneTransition();
    }

    // �V�[���֌W
    private void SceneTransition()
    {
        if (SceneManager.GetActiveScene().name == "Search01" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.Search02);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search02"&&nextScene)
        {
            scene.ChangeScene((int)Scene.SceneName.Search03);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search03" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.Search04);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search04" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.Search05);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search05" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.Search06);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search06" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.Search07);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search07" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.Search08);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search08" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.Search09);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search09" && nextScene) 
        {
            scene.ChangeScene((int)Scene.SceneName.GameClear);
            nextScene = false;
        }

        //if (scene.GetSetSceneFlg == 1 || scene.GetSetSceneFlg == 2 || scene.GetSetSceneFlg == 3 ||
        //    scene.GetSetSceneFlg == 4 || scene.GetSetSceneFlg == 5 || scene.GetSetSceneFlg == 6 ||
        //    scene.GetSetSceneFlg == 7 || scene.GetSetSceneFlg == 8 || scene.GetSetSceneFlg == 9 && enemy.GetSetEnemyBattleFlg) 
        //{
        //    scene.ChangeScene((int)Scene.SceneName.Battle);
        //    enemy.GetSetEnemyBattleFlg = false;
        //}
    }
}
