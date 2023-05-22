using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot1 : MonoBehaviour
{
    private Vector3 m_velocity; // ���x

    // ���t���[���Ăяo�����֐�
    private void Update()
    {
        // �ړ�����
        transform.localPosition += m_velocity;
    }

    // �e�𔭎˂��鎞�ɏ��������邽�߂̊֐�
    public void Init(float angle, float speed)
    {
        // �e�̔��ˊp�x���x�N�g���ɕϊ�����
        var direction = Utils.GetDirection(angle);

        // ���ˊp�x�Ƒ������瑬�x�����߂�
        m_velocity = direction * speed;

        // �e���i�s�����������悤�ɂ���
        var angles = transform.localEulerAngles;
        angles.z = angle - 90;
        transform.localEulerAngles = angles;

        // 2 �b��ɍ폜����
        Destroy(gameObject, 2);
    }
}
