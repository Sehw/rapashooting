using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    // 머티리얼의 uv의 offset 값에서 y축을 증가시킨다
    // Material, meshRenderer, offset(vector2), 스크롤 속도

    public float scrollSpeed = 0.5f;

    MeshRenderer mr;
    Material mat;

    private void Start()
    {
        // 1. 매쉬 랜더러를 가져온다
        mr = GetComponent<MeshRenderer>();

        // 2. 매쉬 랜더러의 1번 머티리얼을 가져온다.
        mat = mr.materials[0];
    }

    private void Update()
    {
        // 머티리얼의 uv offset 값을 변경한다.
        mat.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
    }

}
