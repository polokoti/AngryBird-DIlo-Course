using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public SlingShooter SlingShooter;
    public List<Bird> Birds;

    // Start is called before the first frame update
    void Start()
    {
        SlingShooter.InitiateBird(Birds[0]);
    }

}
