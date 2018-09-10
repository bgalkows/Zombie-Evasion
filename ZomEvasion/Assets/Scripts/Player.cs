using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Transform playerSpawnPoints;
    public bool respawning = false;
    public GameObject landingAreaPrefab;
    public GameObject zombiePrefab;

    public AudioClip whatHappened;

    private Transform[] spawnPoints;
    private bool lastToggle = false;

	// Use this for initialization
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
        Debug.Log(spawnPoints.Length);

	}
	
	// Update is called once per frame
	void Update () {
		if(lastToggle != respawning)
        {
            respawn();
            respawning = false;
        }
        else
        {
            lastToggle = respawning;
        }
	}

    private void respawn()
    {
        int spawnInt = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[spawnInt].position;
    }




    void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }

    void DropFlare()
    {
        Instantiate(landingAreaPrefab, transform.position, transform.rotation);
        StartCoroutine("zomSpawning");
    }

    IEnumerator zomSpawning()
    {
        yield return new WaitForSeconds(1.0f);
        int sp = Random.Range(1, 5);
        Instantiate(zombiePrefab, spawnPoints[sp].position, this.transform.rotation);
        yield return new WaitForSeconds(59.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(59.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(25.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(25.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(11.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(11.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(11.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(11.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(8.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(7.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(6.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(5.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(20.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        yield return new WaitForSeconds(20.0f);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);
        Instantiate(zombiePrefab, spawnPoints[Random.Range(1, 5)].position, this.transform.rotation);



    }

}
