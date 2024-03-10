using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialInstance : MonoBehaviour
{
    // ��Ƽ���� ������ �޽� ������
    private MeshRenderer m_MeshRenderer;

    // ������ ��
    [SerializeField]
    private Color _color;

    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>();
        // ����� �����ɴϴ�.

        m_MeshRenderer.material = Instantiate(m_MeshRenderer.material);
        // ������ ��Ƽ������ Instantiate�� �����մϴ�. (����)

        m_MeshRenderer.material.color = _color;
        // ��Ƽ������ ���� ������ ������ ����
    }
}
