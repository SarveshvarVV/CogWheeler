using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Unity.Burst.Intrinsics.X86;
using UnityEngine.UI;

public class Eqs_endscene : MonoBehaviour
{
    public TextMeshProUGUI[] timeTaken;
    public TextMeshProUGUI[] result;
    public TextMeshProUGUI avg;
    //public TextMeshProUGUI[] score;
    //public static float[] timearray1;
    public static float lvldecider;
    //public static float[] timearray2;
    //public static float[] timearray3;
    //public static float[] timearray4;
    //public static string[] resultarr1;
    //public static string[] resultarr2;
    //public static string[] resultarr3;
    //public static string[] resultarr4;
    // Start is called before the first frame update
    void Start()
    {
        if (lvldecider == 1.1f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time1.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time2.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time3.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time4.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time5.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time6.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time7.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time8.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time9.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager1.time10.ToString());
                    result[i - 1].SetText(Eqs_mulmanager1.result10);
                }
            }
            float average = (Eqs_mulmanager1.time1 + Eqs_mulmanager1.time2 + Eqs_mulmanager1.time3 + Eqs_mulmanager1.time4 + Eqs_mulmanager1.time5 + Eqs_mulmanager1.time6 + Eqs_mulmanager1.time7 + Eqs_mulmanager1.time8 + Eqs_mulmanager1.time9 + Eqs_mulmanager1.time10) / 10;
            avg.text = "Average : " + average.ToString();


        }
        else if (lvldecider == 1.2f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i-1].SetText(Eqs_mulmanager2.time1.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result1);
              
                }
                else if (i == 2)
                {
                    timeTaken[i-1].SetText(Eqs_mulmanager2.time2.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i-1].SetText(Eqs_mulmanager2.time3.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i-1].SetText(Eqs_mulmanager2.time4.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager2.time5.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_mulmanager2.time6.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i-1].SetText(Eqs_mulmanager2.time7.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i-1].SetText(Eqs_mulmanager2.time8.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i-1].SetText(Eqs_mulmanager2.time9.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i-1].SetText(Eqs_mulmanager2.time10.ToString());
                    result[i - 1].SetText(Eqs_mulmanager2.result10);
                }

            }
            float average = (Eqs_mulmanager2.time1 + Eqs_mulmanager2.time2 + Eqs_mulmanager2.time3 + Eqs_mulmanager2.time4 + Eqs_mulmanager2.time5 + Eqs_mulmanager2.time6 + Eqs_mulmanager2.time7 + Eqs_mulmanager2.time8 + Eqs_mulmanager2.time9 + Eqs_mulmanager2.time10) / 10;
            avg.text = "Average : " + average.ToString();
        }
        else if (lvldecider == 1.3f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time1.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time2.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time3.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time4.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time5.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time6.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time7.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time8.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time9.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl1_GameManager.time10.ToString());
                    result[i - 1].SetText(Eqs_lvl1_GameManager.result10);
                }
            }
            float average = (Eqs_lvl1_GameManager.time1 + Eqs_lvl1_GameManager.time2 + Eqs_lvl1_GameManager.time3 + Eqs_lvl1_GameManager.time4 + Eqs_lvl1_GameManager.time5 + Eqs_lvl1_GameManager.time6 + Eqs_lvl1_GameManager.time7 + Eqs_lvl1_GameManager.time8 + Eqs_lvl1_GameManager.time9 + Eqs_lvl1_GameManager.time10) / 10;
            avg.text = "Average : " + average.ToString();



        }
        else if (lvldecider == 1.4f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time1.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time2.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time3.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time4.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time5.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time6.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time7.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time8.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time9.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_lvl2_GameManager.time10.ToString());
                    result[i - 1].SetText(Eqs_lvl2_GameManager.result10);
                }
            }
            float average = (Eqs_lvl2_GameManager.time1 + Eqs_lvl2_GameManager.time2 + Eqs_lvl2_GameManager.time3 + Eqs_lvl2_GameManager.time4 + Eqs_lvl2_GameManager.time5 + Eqs_lvl2_GameManager.time6 + Eqs_lvl2_GameManager.time7 + Eqs_lvl2_GameManager.time8 + Eqs_lvl2_GameManager.time9 + Eqs_lvl2_GameManager.time10) / 10;
            avg.text = "Average : " + average.ToString();
        }
    }        // Update is called once per frame
            void Update()
    {
        
    }
}
