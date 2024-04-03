using UnityEngine;
using UnityEngine.SceneManagement;


public class ObjectDestroyer : MonoBehaviour
{
    private bool isTrueObjectActive1 = false;
    private bool isTrueObjectActive2 = false;
    private bool isTrueObjectActive3 = false;
    private bool isTrueObjectActive4 = false;
    private bool isTrueObjectActive5 = false;
    private bool isTrueObjectActive6 = false;
    private bool isTrueObjectActive7 = false;
    private bool isTrueObjectActive8 = false;
    private bool isTrueObjectActive9 = false;
    private bool isTrueObjectActive10 = false;

    private bool isTrueObjectActive11 = false;
    private bool isTrueObjectActive12 = false;
    private bool isTrueObjectActive13 = false;
    private bool isTrueObjectActive14 = false;
    private bool isTrueObjectActive15 = false;
    private bool isTrueObjectActive16 = false;
    private bool isTrueObjectActive17 = false;
    private bool isTrueObjectActive18 = false;
    private bool isTrueObjectActive19 = false;
    private bool isTrueObjectActive20 = false;

    private bool isTrueObjectActive21 = false;
    private bool isTrueObjectActive22 = false;
    private bool isTrueObjectActive23 = false;
    private bool isTrueObjectActive24 = false;
    private bool isTrueObjectActive25 = false;
    private bool isTrueObjectActive26 = false;
    private bool isTrueObjectActive27 = false;
    private bool isTrueObjectActive28 = false;
    private bool isTrueObjectActive29 = false;
    private bool isTrueObjectActive30 = false;

    private bool isTrueObjectActive31 = false;
    private bool isTrueObjectActive32 = false;
    private bool isTrueObjectActive33 = false;
    private bool isTrueObjectActive34 = false;
    private bool isTrueObjectActive35 = false;
    private bool isTrueObjectActive36 = false;
    private bool isTrueObjectActive37 = false;
    private bool isTrueObjectActive38 = false;
    private bool isTrueObjectActive39 = false;
    private bool isTrueObjectActive40 = false;

    private bool isTrueObjectActive41 = false;
    private bool isTrueObjectActive42 = false;
    private bool isTrueObjectActive43 = false;
    private bool isTrueObjectActive44 = false;
    private bool isTrueObjectActive45 = false;
    private bool isTrueObjectActive46 = false;
    private bool isTrueObjectActive47 = false;
    private bool isTrueObjectActive48 = false;
    private bool isTrueObjectActive49 = false;
    private bool isTrueObjectActive50 = false;


    void Update()
    {
        CheckAndDestroy("True1", "Q1", ref isTrueObjectActive1);
        CheckAndDestroy("True2", "Q2", ref isTrueObjectActive2);
        CheckAndDestroy("True3", "Q3", ref isTrueObjectActive3);
        CheckAndDestroy("True4", "Q4", ref isTrueObjectActive4);
        CheckAndDestroy("True5", "Q5", ref isTrueObjectActive5);
        CheckAndDestroy("True6", "Q6", ref isTrueObjectActive6);
        CheckAndDestroy("True7", "Q7", ref isTrueObjectActive7);
        CheckAndDestroy("True8", "Q8", ref isTrueObjectActive8);
        CheckAndDestroy("True9", "Q9", ref isTrueObjectActive9);
        CheckAndDestroy("True10", "Q10", ref isTrueObjectActive10);

        CheckAndDestroy("True11", "Q11", ref isTrueObjectActive11);
        CheckAndDestroy("True12", "Q12", ref isTrueObjectActive12);
        CheckAndDestroy("True13", "Q13", ref isTrueObjectActive13);
        CheckAndDestroy("True14", "Q14", ref isTrueObjectActive14);
        CheckAndDestroy("True15", "Q15", ref isTrueObjectActive15);
        CheckAndDestroy("True16", "Q16", ref isTrueObjectActive16);
        CheckAndDestroy("True17", "Q17", ref isTrueObjectActive17);
        CheckAndDestroy("True18", "Q18", ref isTrueObjectActive18);
        CheckAndDestroy("True19", "Q19", ref isTrueObjectActive19);
        CheckAndDestroy("True20", "Q20", ref isTrueObjectActive20);

        CheckAndDestroy("True21", "Q21", ref isTrueObjectActive21);
        CheckAndDestroy("True22", "Q22", ref isTrueObjectActive22);
        CheckAndDestroy("True23", "Q23", ref isTrueObjectActive23);
        CheckAndDestroy("True24", "Q24", ref isTrueObjectActive24);
        CheckAndDestroy("True25", "Q25", ref isTrueObjectActive25);
        CheckAndDestroy("True26", "Q26", ref isTrueObjectActive26);
        CheckAndDestroy("True27", "Q27", ref isTrueObjectActive27);
        CheckAndDestroy("True28", "Q28", ref isTrueObjectActive28);
        CheckAndDestroy("True29", "Q29", ref isTrueObjectActive29);
        CheckAndDestroy("True30", "Q30", ref isTrueObjectActive30);

        CheckAndDestroy("True31", "Q31", ref isTrueObjectActive31);
        CheckAndDestroy("True32", "Q32", ref isTrueObjectActive32);
        CheckAndDestroy("True33", "Q33", ref isTrueObjectActive33);
        CheckAndDestroy("True34", "Q34", ref isTrueObjectActive34);
        CheckAndDestroy("True35", "Q35", ref isTrueObjectActive35);
        CheckAndDestroy("True36", "Q36", ref isTrueObjectActive36);
        CheckAndDestroy("True37", "Q37", ref isTrueObjectActive37);
        CheckAndDestroy("True38", "Q38", ref isTrueObjectActive38);
        CheckAndDestroy("True39", "Q39", ref isTrueObjectActive39);
        CheckAndDestroy("True40", "Q40", ref isTrueObjectActive40);

        CheckAndDestroy("True41", "Q41", ref isTrueObjectActive41);
        CheckAndDestroy("True42", "Q42", ref isTrueObjectActive42);
        CheckAndDestroy("True43", "Q43", ref isTrueObjectActive43);
        CheckAndDestroy("True44", "Q44", ref isTrueObjectActive44);
        CheckAndDestroy("True45", "Q45", ref isTrueObjectActive45);
        CheckAndDestroy("True46", "Q46", ref isTrueObjectActive46);
        CheckAndDestroy("True47", "Q47", ref isTrueObjectActive47);
        CheckAndDestroy("True48", "Q48", ref isTrueObjectActive48);
        CheckAndDestroy("True49", "Q49", ref isTrueObjectActive49);
        CheckAndDestroy("True50", "Q50", ref isTrueObjectActive50);
    }

    private void CheckAndDestroy(string trueObjectName, string qObjectName, ref bool isTrueObjectActive)
    {
        GameObject trueObject = GameObject.Find(trueObjectName);

        if (trueObject != null && trueObject.activeSelf)
        {
            isTrueObjectActive = true;
        }

        if (isTrueObjectActive)
        {
            GameObject qObject = GameObject.Find(qObjectName);
            if (qObject != null)
            {
                Destroy(qObject);
            }
        }
    }
}