using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    // ��Ƽ������ uv�� offset ������ y���� ������Ų��
    // Material, meshRenderer, offset(vector2), ��ũ�� �ӵ�

    public float scrollSpeed = 0.5f;

    MeshRenderer mr;
    Material mat;

    private void Start()
    {
        // 1. �Ž� �������� �����´�
        mr = GetComponent<MeshRenderer>();

        // 2. �Ž� �������� 1�� ��Ƽ������ �����´�.
        mat = mr.materials[0];
    }

    private void Update()
    {
        // ��Ƽ������ uv offset ���� �����Ѵ�.
        mat.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
    }

}
