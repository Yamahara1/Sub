using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �Q�[���J�n����̃V�[���ǂݍ��ݑO�ɌĂ΂��悤�ɂ��鑮�����w��
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    private static void InitializeBeforeSceneLoad()
    {
        // Resources����GameManager�v���n�u��ǂݍ���
        var gameManagerPrefab = Resources.Load<GameManager>("GameManager");

        // �Q�[�����ɏ�ɑ��݂���I�u�W�F�N�g�𐶐�
        var gameManager = Instantiate(gameManagerPrefab);
        // �V�[���ύX���ɂ��j������Ȃ��悤�ɂ���
        DontDestroyOnLoad(gameManager);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { Application.Quit(); }
    }
}
