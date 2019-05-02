using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private Vector2 targetPos;
    public float increment;
    public float speed;
    public float maxLength;
    public float minLength;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minLength )
        {
            targetPos = new Vector2(transform.position.x - increment , transform.position.y);

        } else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxLength)
        {
            targetPos = new Vector2(transform.position.x + increment, transform.position.y);

        }

    }
}
