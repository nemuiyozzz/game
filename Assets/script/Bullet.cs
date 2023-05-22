using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public Transform playerTrans;  //�ǂ�������Ώۂ�Transform
    [SerializeField] public float bulletSpeed;       //�e�̑��x
    [SerializeField] public float limitSpeed;        //�e�̐������x
    private Rigidbody2D rb;                          //�e��Rigidbody2D
    private Transform bulletTrans;                   //�e��Transform

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        bulletTrans = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        Vector3 vector3 = playerTrans.position - bulletTrans.position;           //�e����ǂ�������Ώۂւ̕������v�Z
        rb.AddForce(vector3.normalized * bulletSpeed);                           //�����̒�����1�ɐ��K���A�C�ӂ̗͂�AddForce�ŉ�����

        float speedXTemp = Mathf.Clamp(rb.velocity.x, -limitSpeed, limitSpeed); //X�����̑��x�𐧌�
        float SpeedYTemp = Mathf.Clamp(rb.velocity.y, -limitSpeed, limitSpeed); //Y�����̑��x�𐧌�
        rb.velocity = new Vector3(speedXTemp, SpeedYTemp);                      //���ۂɐ��������l����
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
