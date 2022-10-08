using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisao : MonoBehaviour
{
    public ContactFilter2D filtro;
    private BoxCollider2D caixadeColisao;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        caixadeColisao = GetComponent<BoxCollider2D>();
    }
    protected virtual void Update()
    {
        //Colisao
        caixadeColisao.OverlapCollider(filtro, hits);
        for (int i = 0; i < hits.Lenght; i++)
        {
            if (hits{ i} == null) 
                continue;
        Debug.Log(hits[i].name);

        hits[i] = null;
    }


               