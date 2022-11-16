using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public static bool initiateMove = false;
    public static bool initiateRotateLeft = false;
    public static bool initiateRotateRight = false;
    public static bool initiatePlace = false;
    private const int eastFacingMaxMovement = 375;
    private const int southFacingMaxMovement = -375;
    public static GameObject robot;

    // Update is called once per frame
    void Update()
    {
        robot = GameObject.Find("Robot Kyle");

        // Current position variables
        float currentXPosition = robot.transform.position.x;
        float currentZPosition = robot.transform.position.z;
        Quaternion currentDirectionFacing = robot.transform.rotation;

        // Direction variables
        Quaternion north = new Quaternion(0, 0, 0, 1);
        Quaternion east = new Quaternion(0, 0.7071068f, 0, 0.7071068f);
        Quaternion south = new Quaternion(0, 1, 0, 0);
        Quaternion west = new Quaternion(0, 0.7071068f, 0, -0.7071068f);

        // Moves based on the direction the robot currently facing at
        if (initiateMove) {
            if (currentDirectionFacing == east && currentXPosition <= eastFacingMaxMovement)
            {
                // Moves the box
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition + 125, 2, currentZPosition), currentDirectionFacing);
            }

            if (currentDirectionFacing == west && currentXPosition > 0)
            {
                // Moves the box
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition - 125, 2, currentZPosition), currentDirectionFacing);
            }

            if (currentDirectionFacing == north && currentZPosition < 0)
            {
                // Moves the box
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition + 125), currentDirectionFacing);
            }

            if (currentDirectionFacing == south && currentZPosition >= southFacingMaxMovement)
            {
                // Moves the box
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition - 125), currentDirectionFacing);
            }

            initiateMove = false;
        }

        // Rotates the robot to left
        if (initiateRotateLeft)
        {
            if (currentDirectionFacing == north)
            {
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition), west);
            }

            if (currentDirectionFacing == east)
            {
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition), north);
            }

            if (currentDirectionFacing == south)
            {
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition), east);
            }

            if (currentDirectionFacing == west)
            {
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition), south);
            }

            initiateRotateLeft = false;
        }

        // Rotates the robot to right
        if (initiateRotateRight)
        {
            if (currentDirectionFacing == north)
            {
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition), east);
            }

            if (currentDirectionFacing == east)
            {
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition), south);
            }

            if (currentDirectionFacing == south)
            {
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition), west);
            }

            if (currentDirectionFacing == west)
            {
                GetComponent<Transform>().SetPositionAndRotation(new Vector3(currentXPosition, 2, currentZPosition), north);
            }

            initiateRotateRight = false;
        }

        // Places the robot using the given x, y and direction data from dropdown
        if (initiatePlace)
        {
            int x = XInputHandler.xInputValue;
            int y = YInputHandler.yInputValue;
            string direction = DirectionInputHandler.directionInputValue;
            Quaternion redirectTo = north;

            if (direction == "NORTH") {
                redirectTo = north;
            }

            if (direction == "EAST")
            {
                redirectTo = east;
            }

            if (direction == "WEST")
            {
                redirectTo = west;
            }

            if (direction == "SOUTH")
            {
                redirectTo = south;
            }

            GetComponent<Transform>().SetPositionAndRotation(new Vector3(x * 125, 2, y * -125), redirectTo);

            initiatePlace = false;
        }
    }
}
