using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
    public GameObject playerPrefab;
    private GameObject playerInstance;
    // Start is called before the first frame update
    void Start(){
        if(playerPrefab!=null){
            playerInstance=Instantiate(playerPrefab,Vector3.up,Quaternion.identity);
        }
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
