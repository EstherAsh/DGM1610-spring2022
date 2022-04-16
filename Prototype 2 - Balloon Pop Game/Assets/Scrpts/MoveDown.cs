using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerbound = -10.0f;

    public scoremanager scoreManager; //a variable to ref the ScoreManager
     private Balloons balloon;
    //Start is called before the first frame update
    void Start()
    {
        //reff scormanager component
        scoreManager = GameObject.Find("scoremanager").GetComponent<scoremanager>();
        balloon = GetComponent<Balloons>();
    }

    // Update is called once per frame
    void Update()
    {
        //move ballon down
        transform.Translate(Vector3.down *Time.deltaTime);

        //destroy balloon after it passes lowerbound
        if(transform.position.y < lowerbound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
        }
    }
}
