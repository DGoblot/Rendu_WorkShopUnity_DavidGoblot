using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Robot : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] GameObject coins;
    AudioSource coinSound;
    public int coinCount = 0;
    int previousCoinCount = 0;
    int totalCoinCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        totalCoinCount = coins.transform.childCount;
        coinSound = GetComponent<AudioSource>();
        text.text = coinCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(previousCoinCount != coinCount)
        {
            text.text = coinCount.ToString();
            previousCoinCount = coinCount;
            coinSound.Play();
        }

        if(coinCount == totalCoinCount)
        {
            //UnityEngine.Cursor.lockState = CursorLockMode.None;
            //SceneManager.LoadScene("Scenes/End");
        }
    }
}
