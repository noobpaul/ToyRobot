using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReportObject : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Robot;
    public TMP_Text x;
    public TMP_Text y;
    public TMP_Text direction;
    public void showReport()
    {
        float currentXPosition = Robot.transform.position.x;
        float currentZPosition = Robot.transform.position.z;
        Quaternion currentDirectionFacing = Robot.transform.rotation;

        // Direction variables
        Quaternion north = new Quaternion(0, 0, 0, 1);
        Quaternion east = new Quaternion(0, 0.7071068f, 0, 0.7071068f);
        Quaternion south = new Quaternion(0, 1, 0, 0);
        Quaternion west = new Quaternion(0, 0.7071068f, 0, -0.7071068f);

        x.text = ((currentXPosition/125) + 1).ToString();
        y.text = ((currentZPosition/-125) + 1).ToString();

        if (currentDirectionFacing == north) {
            direction.text = "NORTH";
        }

        if (currentDirectionFacing == east)
        {
            direction.text = "EAST";
        }

        if (currentDirectionFacing == south)
        {
            direction.text = "SOUTH";
        }

        if (currentDirectionFacing == west)
        {
            direction.text = "WEST";
        }

        Panel.SetActive(true);
    }

    public void hideReport()
    {
        Panel.SetActive(false);
    }
}
