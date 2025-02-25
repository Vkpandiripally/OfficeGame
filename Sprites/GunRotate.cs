using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotate : MonoBehaviour
{
    public GameObject charDown;
    public GameObject charUp;
    public GameObject charLeft;
    public GameObject charRight;
    public GameObject charLeftDiagonal;
    public GameObject charRightDiagonal;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        if(transform.eulerAngles.z >= 0 && transform.eulerAngles.z <= 29) //RIGHT 
        {
            charDown.SetActive(false);
            charUp.SetActive(false);
            charLeft.SetActive(false);
            charRight.SetActive(true);
            charLeftDiagonal.SetActive(false);
            charRightDiagonal.SetActive(false);
        }
        if(transform.eulerAngles.z >= 330 && transform.eulerAngles.z <= 359) //RIGHT 2
        {
            charDown.SetActive(false);
            charUp.SetActive(false);
            charLeft.SetActive(false);
            charRight.SetActive(true);
            charLeftDiagonal.SetActive(false);
            charRightDiagonal.SetActive(false);
        }
        if(transform.eulerAngles.z >= 30 && transform.eulerAngles.z <= 59) //RIGHT DIAGONAL
        {
            charDown.SetActive(false);
            charUp.SetActive(false);
            charLeft.SetActive(false);
            charRight.SetActive(false);
            charLeftDiagonal.SetActive(false);
            charRightDiagonal.SetActive(true);
        }
        if(transform.eulerAngles.z >= 60 && transform.eulerAngles.z <= 119) //UP
        {
            charDown.SetActive(false);
            charUp.SetActive(true);
            charLeft.SetActive(false);
            charRight.SetActive(false);
            charLeftDiagonal.SetActive(false);
            charRightDiagonal.SetActive(false);
        }
        if(transform.eulerAngles.z >= 120 && transform.eulerAngles.z <= 149) //LEFT DIAGONAL
        {
            charDown.SetActive(false);
            charUp.SetActive(false);
            charLeft.SetActive(false);
            charRight.SetActive(false);
            charLeftDiagonal.SetActive(true);
            charRightDiagonal.SetActive(false);
        }
        if(transform.eulerAngles.z >= 150 && transform.eulerAngles.z <= 209) //LEFT
        {
            charDown.SetActive(false);
            charUp.SetActive(false);
            charLeft.SetActive(true);
            charRight.SetActive(false);
            charLeftDiagonal.SetActive(false);
            charRightDiagonal.SetActive(false);
        }
        if(transform.eulerAngles.z >= 210 && transform.eulerAngles.z <= 329) //DOWN
        {
            charDown.SetActive(true);
            charUp.SetActive(false);
            charLeft.SetActive(false);
            charRight.SetActive(false);
            charLeftDiagonal.SetActive(false);
            charRightDiagonal.SetActive(false);
        }
    }
}
