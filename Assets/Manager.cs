using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
public GameObject Sup, Kue, Potongan, Roti, Ayam, Pisang, SupB, KueB, PotonganB, RotiB, AyamB, PisangB;

   Vector3 SupInitialPos, KueInitialPos, PotonganInitialPos, RotiInitialPos, AyamInitialPos, PisangInitialPos;

   void start ()
   {
    SupInitialPos       = Sup.transform.position;
    KueInitialPos       = Kue.transform.position;
    PotonganInitialPos  = Potongan.transform.position;
    RotiInitialPos      = Roti.transform.position;
    AyamInitialPos      = Ayam.transform.position;
    PisangInitialPos    = Pisang.transform.position;
   }
    public void DragSup()
    {
        Sup.transform.position = Input.mousePosition;
    }
    public void DragKue()
    {
        Kue.transform.position = Input.mousePosition;
    }
    public void DragPotongan()
    {
        Potongan.transform.position = Input.mousePosition;
    }
    public void DragRoti()
    {
        Roti.transform.position = Input.mousePosition;
    }
    public void DragAyam()
    {
        Ayam.transform.position = Input.mousePosition;
    }
    public void DragPisang()
    {
        Pisang.transform.position = Input.mousePosition;
    }

    public void DropSup()
    {
        float Distance = Vector3.Distance(Sup.transform.position, SupB.transform.position);
        if(Distance<50)
        {
            Sup.transform.position = SupB.transform.position;
        }
        else
        {
            Sup.transform.position = SupInitialPos;
        }
    }
    public void DropKue()
    {
        float Distance = Vector3.Distance(Kue.transform.position, KueB.transform.position);
        if(Distance<50)
        {
            Kue.transform.position = KueB.transform.position;
        }
        else
        {
            Kue.transform.position = KueInitialPos;
        }
    }
    public void DropPotongan()
    {
        float Distance = Vector3.Distance(Potongan.transform.position, PotonganB.transform.position);
        if(Distance<1)
        {
            Potongan.transform.position = PotonganB.transform.position;
        }
        else
        {
            Potongan.transform.position = PotonganInitialPos;
        }
    }
    public void DropRoti()
    {
        float Distance = Vector3.Distance(Roti.transform.position, RotiB.transform.position);
        if(Distance<50)
        {
            Roti.transform.position = RotiB.transform.position;
        }
        else
        {
            Roti.transform.position = RotiInitialPos;
        }
    }
    public void DropAyam()
    {
        float Distance = Vector3.Distance(Ayam.transform.position, AyamB.transform.position);
        if(Distance<50)
        {
            Ayam.transform.position = AyamB.transform.position;
        }
        else
        {
            Ayam.transform.position = AyamInitialPos;
        }
    }
    public void DropPisang()
    {
        float Distance = Vector3.Distance(Pisang.transform.position, PisangB.transform.position);
        if(Distance<50)
        {
            Pisang.transform.position = PisangB.transform.position;
        }
        else
        {
            Pisang.transform.position = PisangInitialPos;
        }
    }
}