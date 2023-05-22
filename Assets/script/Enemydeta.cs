using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydeta : MonoBehaviour
{
    //弾丸用の変数
    [SerializeField] public GameObject BulletPrefab = null;
    [SerializeField] public GameObject ShotPoint = null;
    //パラメータ設定
    [SerializeField] protected float _moveSpped = 0.1f;
    [SerializeField] protected float ShotPower = 50f;
    //回転速度を設定する変数
    [SerializeField] protected float _rotateSpped = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shot()
    {
        //射撃
        //弾丸をコピー
        GameObject bullet = Instantiate(
            BulletPrefab,                 //弾丸をコピー
            ShotPoint.transform.position, //ポイントの座標
            ShotPoint.transform.rotation  //ポイントの向き
            );
        //Rigidbodyで発射
        bullet.GetComponent<Rigidbody2D>().AddForce(
            ShotPoint.transform.forward * ShotPower, //正面の方向
            ForceMode2D.Impulse);//一発でぶっ飛ばす

        //消去
        Destroy(bullet.gameObject, 5);
    }
}
