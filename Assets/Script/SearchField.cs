using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchField : MonoBehaviour
{
    Scene scene;
    Player player;
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
      
    }

    // Update is called once per frame
    void Update()
    {
        SceneTransition();
    }

    // ÉVÅ[Éìä÷åW
    private void SceneTransition()
    {

        if (SceneManager.GetActiveScene().name == "Search01" && nextScene) 
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Search02);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search02"&&nextScene)
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Search03);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search03" && nextScene) 
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Search04);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search04" && nextScene) 
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Search05);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search05" && nextScene) 
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Search06);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search06" && nextScene) 
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Search07);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search07" && nextScene) 
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Search08);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search08" && nextScene) 
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Search09);
            nextScene = false;
        }
        if (SceneManager.GetActiveScene().name == "Search09" && nextScene) 
        {
            player = gameObject.AddComponent<Player>();
            player.ResetHit_Enemy();
            scene.ChangeScene((int)Scene.SceneName.Battle);
            nextScene = false;
        }
    }
}
