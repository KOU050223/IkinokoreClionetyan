using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using JetBrains.Annotations;
using UnityEngine;

public class PillarGenerator : MonoBehaviour
{
    [SerializeField] GameObject PillarPrefab;
    //[SerializeField] GameObject UpperPrefab;
    //[SerializeField] GameObject LowerPrefab;
    float delta = 0f;
    float span = 2.0f;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //deltaがスパンを超えたらランダムな場所に出現させる
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject Pillar = Instantiate(PillarPrefab);
            float x = Waku.RightPos + 1.0f;
            float y = Random.Range(Waku.BottomPos,Waku.TopPos);
            Pillar.transform.position = new Vector3(x,y,0f);
        }
    }



}
