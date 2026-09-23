using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator anim;

    void Awake()
    {
        // DontDestroyOnLoad(gameObject); // Prevent this object from being destroyed when loading a new scene        
    }

    void Update()
    {        
        if(Input.GetKeyDown(KeyCode.Space)){            
            anim.SetTrigger("FadeOut"); // Trigger the fade-out animation
            Invoke("LoadNextScene", 2f);
        }
    }
    // This method can be called from a UI button to start the game
    public void StartGame(){
        anim.SetTrigger("FadeOut"); // Trigger the fade-out animation
        Invoke("LoadNextScene", 2f);
    }
    public void LoadNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
}
