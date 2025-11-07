using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Scenes/Main");
    }
    public void GoToEnd()
    {
        SceneManager.LoadScene("Scenes/End");
    }
    public void GoToStart()
    {
        SceneManager.LoadScene("Scenes/Start");
    }

    public void GoToQuit()
    {
        Application.Quit();    
    }
}
