using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Text textRadius;
    public Text textSpeed;

    public GameObject circlePrefab;
    GameObject go;

    float time;

    float theta;

    //半径
    public float radius = 1.0f;
    //スピード
    public float speedIndex = 1.0f;

    // Start is called before the first frame update
    void Start() {
        go = Instantiate(circlePrefab);
    }

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;
        theta = time * speedIndex;

        go.transform.position = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0);



        textRadius.text = radius.ToString();
        textSpeed.text = speedIndex.ToString();
    }
}