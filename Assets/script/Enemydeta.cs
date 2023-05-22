using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydeta : MonoBehaviour
{
    //�e�ۗp�̕ϐ�
    [SerializeField] public GameObject BulletPrefab = null;
    [SerializeField] public GameObject ShotPoint = null;
    //�p�����[�^�ݒ�
    [SerializeField] protected float _moveSpped = 0.1f;
    [SerializeField] protected float ShotPower = 50f;
    //��]���x��ݒ肷��ϐ�
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
        //�ˌ�
        //�e�ۂ��R�s�[
        GameObject bullet = Instantiate(
            BulletPrefab,                 //�e�ۂ��R�s�[
            ShotPoint.transform.position, //�|�C���g�̍��W
            ShotPoint.transform.rotation  //�|�C���g�̌���
            );
        //Rigidbody�Ŕ���
        bullet.GetComponent<Rigidbody2D>().AddForce(
            ShotPoint.transform.forward * ShotPower, //���ʂ̕���
            ForceMode2D.Impulse);//�ꔭ�łԂ���΂�

        //����
        Destroy(bullet.gameObject, 5);
    }
}
