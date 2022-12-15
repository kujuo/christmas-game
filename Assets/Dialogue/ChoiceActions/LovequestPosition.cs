using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LovequestPosition : Action
{
    public GameObject Postman;
    public GameObject ReindeerFarmer;
    public override void DoAction()
    {
        Vector3 distanceToPostman = Postman.transform.position - ReindeerFarmer.transform.position;
        Vector3 Offset = new Vector3(30.0f, 30.0f);
        Vector3 NewPosition = distanceToPostman + Offset;
        ReindeerFarmer.transform.position += NewPosition;
    }
}
