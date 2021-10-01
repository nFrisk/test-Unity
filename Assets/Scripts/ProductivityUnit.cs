using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductivityUnit : Unit // replace Monobehaviour with Unit
{
    // keep track of resource pile that the user has selected
    private ResourcePile m_CurrentPile = null;
    public float ProductivityMultiplier = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void BuildingInRange()
    {
        // When the productivity unit is in range of a pile the production speed increases during that frame
        if (m_CurrentPile = null)
        {
            ResourcePile pile = m_Target as ResourcePile;

            if (pile != null)
            {
                m_CurrentPile = pile;
                m_CurrentPile.ProductionSpeed *= ProductivityMultiplier;
            }
        }
        
        
    }
}
