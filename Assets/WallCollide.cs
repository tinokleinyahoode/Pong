using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WallCollide : MonoBehaviour
{

    public Text scoreLeft;
    public Text scoreRight;

    public int[] points = new int[]{0,0};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.otherCollider.name == "scoreLeft")
        {
            points[0]++;
            scoreRight.text = points[0].ToString();
        }
        if (col.otherCollider.name == "scoreRight")
        {
            points[1]++;
            scoreLeft.text = points[1].ToString();
        }
    }

//     void OnCollisionEnter2D(Collision2D coll)
// {
//   Debug.Log("Left");
// }
}
