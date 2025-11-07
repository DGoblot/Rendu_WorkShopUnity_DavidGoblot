using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Robot>() != null)
        {
            Robot player = (Robot)other.gameObject.GetComponent(typeof(Robot));
            player.coinCount += 1;
            Destroy(gameObject);
        }
    }
}
