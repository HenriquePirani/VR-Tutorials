using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerWalk : MonoBehaviour {


    public TextMesh totalCoins;
    public float playerSpeed;
    public GameObject wall;
    public int count;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            count++;
            totalCoins.text = count.ToString();
            if (count == 4)
            {
                wall.SetActive(false);
            }
        }
    }
}
