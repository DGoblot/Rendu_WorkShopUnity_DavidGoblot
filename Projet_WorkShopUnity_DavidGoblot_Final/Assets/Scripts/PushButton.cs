using UnityEngine;
using UnityEngine.Rendering;

public class PushButton : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        door.GetComponent<BoxCollider>().enabled = false;
        door.GetComponent<Animator>().SetTrigger("Open");
        anim.SetTrigger("On");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        door.GetComponent<BoxCollider>().enabled = true;
        door.GetComponent<Animator>().SetTrigger("Close");
        anim.SetTrigger("Off");
    }

}
