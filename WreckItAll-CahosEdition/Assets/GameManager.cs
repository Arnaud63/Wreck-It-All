using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.modele;
using Zenject;

public class GameManager : MonoBehaviour{
    public GameObject playerPrefab;
    private GameObject playerInstance;

    [Inject]
    private EBall Ball1;


    // Start is called before the first frame update
    void Start(){
        if(playerPrefab!=null){
            playerInstance=Instantiate(playerPrefab,Vector3.up,Quaternion.identity);
        }
        Debug.Log(Ball1);
    }

    public void GameOver(){
        Debug.Log("GameOver");
        Invoke("ReloadLevel",1);
    }


    private void ReloadLevel(){
        Destroy(playerInstance);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        playerInstance=Instantiate(playerPrefab,Vector3.up,Quaternion.identity);
    }
}
