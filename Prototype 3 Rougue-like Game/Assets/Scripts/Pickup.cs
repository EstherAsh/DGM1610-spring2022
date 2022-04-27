using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum Pickuptype{Key, Coin, Gem};
    public Pickuptype currpickup;
    public int pickupAmt;//pick up quantity

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currpickup == Pickuptype.Key)
            {
                playerController.key = pickupAmt;
                Debug.Log("You have picked up a Golden Key!");
            }
            else if(currpickup == Pickuptype.Coin)
            {
                playerController.coins += pickupAmt;
                Debug.Log("You have picked up "+pickupAmt+" Golden Coin(s)");
            }
            else if(currpickup == Pickuptype.Gem)
            {
                playerController.gems += pickupAmt;
                Debug.Log("You picked up a shiny gem!");
            }
            Destroy(gameObject);
        }
    }
}
