using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class BallCollector : MonoBehaviour
{
    public Text poinsText;
    public Material mat;
    public GameObject lvl1;
    int Points = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueBall") && mat.color==Color.blue)
        {
            Destroy(other.gameObject);
            Points++;
            Instantiate(other, new Vector3(Random.Range(-50, 50), 1, Random.Range(50, -50)), Quaternion.identity);
/*            poinsText.text = "Point: " + Points;*/
            Debug.Log("Point: " + Points);
            randomColor();
        }
        else if (other.gameObject.CompareTag("BlueBall") && mat.color != Color.blue)
        {
            Die();
        }

        if (other.gameObject.CompareTag("RedBall") && mat.color==Color.red)
        {
            Destroy(other.gameObject);
            Points++;
            Instantiate(other, new Vector3(Random.Range(-50, 50), 1, Random.Range(50, -50)), Quaternion.identity);
/*            poinsText.text = "Point: " + Points;*/
            Debug.Log("Point: " + Points);
            randomColor();
        }
        else if (other.gameObject.CompareTag("RedBall") && mat.color != Color.red)
        {
            Die();
        }

        if (other.gameObject.CompareTag("GreenBall") && mat.color==Color.green)
        {
            Destroy(other.gameObject);
            Points++;
            Instantiate(other, new Vector3(Random.Range(-50, 50), 1, Random.Range(50, -50)), Quaternion.identity);
/*            poinsText.text = "Point: " + Points;*/
            Debug.Log("Point: " + Points);
            randomColor();
        }
        else if(other.gameObject.CompareTag("GreenBall") && mat.color != Color.green)
        {
            Die();
        }
    }

    private void randomColor()
    {
        Color[] colors = new Color[3];
        colors[0] = Color.green;
        colors[1] = Color.red;
        colors[2] = Color.blue;

        mat.color = colors[Random.Range(0, colors.Length)];
    }

    private void Die()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<PlayerMovement>().enabled = false;
        Invoke(nameof(ReloadLvl), 1.3f);
    }

    void ReloadLvl()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

/*    void NextLvL(int Points)
    {
        if (Points == 10)
        {
            ReloadLvl();
        }
    }*/
}

//-50, 50
//50, -50*/
