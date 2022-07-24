using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaoRaChuongNgaiVat : MonoBehaviour

{
    public GameObject Chuong_Ngai_Vat;
    float thoigiantao=3f;
    float m_thoigiantao;
    // Start is called before the first frame update
    void Start()
    {
        m_thoigiantao=0;
    }

    // Update is called once per frame
    void Update()
    {
        m_thoigiantao = m_thoigiantao - Time.deltaTime;
        if(m_thoigiantao <= 0)
        {
            taorachuongngaivat();
            
            m_thoigiantao=thoigiantao;
        } 
    }
    public void taorachuongngaivat()
    {
        Vector3 themchuongngaivat = new Vector3(Random.Range(-3f, 15f), 1.48f , 0f);
        if (Chuong_Ngai_Vat)
        {
            Instantiate(Chuong_Ngai_Vat, themchuongngaivat, Quaternion.identity);
        }
    }
}
