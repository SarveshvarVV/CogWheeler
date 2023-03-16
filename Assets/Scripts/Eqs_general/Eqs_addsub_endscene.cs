using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Eqs_addsub_endscene : MonoBehaviour
{
    public TextMeshProUGUI[] timeTaken;
    public TextMeshProUGUI[] result;
    public TMP_Text avg;
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
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time1.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time2.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time3.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time4.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time5.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time6.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time7.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time8.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time9.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl1manager.time10.ToString());
                    result[i - 1].SetText(Eqs_addlvl1manager.result10);
                }
            }
            float average = (Eqs_addlvl1manager.time1 + Eqs_addlvl1manager.time2 + Eqs_addlvl1manager.time3 + Eqs_addlvl1manager.time4 + Eqs_addlvl1manager.time5 + Eqs_addlvl1manager.time6 + Eqs_addlvl1manager.time7 + Eqs_addlvl1manager.time8 + Eqs_addlvl1manager.time9 + Eqs_addlvl1manager.time10)/10;
            avg.text = "Average : " + average.ToString();

        }
        else if (lvldecider == 1.2f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time1.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time2.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time3.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time4.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time5.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time6.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time7.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time8.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time9.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl2manager.time10.ToString());
                    result[i - 1].SetText(Eqs_addlvl2manager.result10);
                }
            }
            float average = (Eqs_addlvl2manager.time1 + Eqs_addlvl2manager.time2 + Eqs_addlvl2manager.time3 + Eqs_addlvl2manager.time4 + Eqs_addlvl2manager.time5 + Eqs_addlvl2manager.time6 + Eqs_addlvl2manager.time7 + Eqs_addlvl2manager.time8 + Eqs_addlvl2manager.time9 + Eqs_addlvl2manager.time10) / 10;
            avg.text = "Average : " + average.ToString();
        }
        else if (lvldecider == 1.3f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time1.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time2.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time3.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time4.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time5.ToString());
                    result[i - 1].SetText (Eqs_addlvl3manager.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time6.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time7.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time8.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time9.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_addlvl3manager.time10.ToString());
                    result[i - 1].SetText(Eqs_addlvl3manager.result10);
                }
            }
            float average = (Eqs_addlvl3manager.time1 + Eqs_addlvl3manager.time2 + Eqs_addlvl3manager.time3 + Eqs_addlvl3manager.time4 + Eqs_addlvl3manager.time5 + Eqs_addlvl3manager.time6 + Eqs_addlvl3manager.time7 + Eqs_addlvl3manager.time8 + Eqs_addlvl3manager.time9 + Eqs_addlvl3manager.time10) / 10;
            avg.text = "Average : " + average.ToString();
        }
        else if (lvldecider == 1.4f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time1.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time2.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time3.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time4.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time5.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time6.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time7.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time8.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time9.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_sub1manager.time10.ToString());
                    result[i - 1].SetText(Eqs_sub1manager.result10);
                }
            }
            float average = (Eqs_sub1manager.time1 + Eqs_sub1manager.time2 + Eqs_sub1manager.time3 + Eqs_sub1manager.time4 + Eqs_sub1manager.time5 + Eqs_sub1manager.time6 + Eqs_sub1manager.time7 + Eqs_sub1manager.time8 + Eqs_sub1manager.time9 + Eqs_sub1manager.time10) / 10;
            avg.text = "Average : " + average.ToString();
        }
        else if (lvldecider == 1.5f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time1.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time2.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time3.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time4.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time5.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time6.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time7.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time8.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time9.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_sub2manager.time10.ToString());
                    result[i - 1].SetText(Eqs_sub2manager.result10);
                }
            }
            float average = (Eqs_sub2manager.time1 + Eqs_sub2manager.time2 + Eqs_sub2manager.time3 + Eqs_sub2manager.time4 + Eqs_sub2manager.time5 + Eqs_sub2manager.time6 + Eqs_sub2manager.time7 + Eqs_sub2manager.time8 + Eqs_sub2manager.time9 + Eqs_sub2manager.time10) / 10;
            avg.text = "Average : " + average.ToString();
        }
        else if (lvldecider == 1.6f)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time1.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result1);

                }
                else if (i == 2)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time2.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result2);
                }
                else if (i == 3)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time3.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result3);
                }
                else if (i == 4)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time4.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result4);
                }

                else if (i == 5)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time5.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result5);
                }
                else if (i == 6)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time6.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result6);
                }
                else if (i == 7)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time7.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result7);
                }
                else if (i == 8)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time8.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result8);
                }
                else if (i == 9)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time9.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result9);
                }
                else if (i == 10)
                {
                    timeTaken[i - 1].SetText(Eqs_sub3manager.time10.ToString());
                    result[i - 1].SetText(Eqs_sub3manager.result10);
                }
            }
            float average = (Eqs_sub3manager.time1 + Eqs_sub3manager.time2 + Eqs_sub3manager.time3 + Eqs_sub3manager.time4 + Eqs_sub3manager.time5 + Eqs_sub3manager.time6 + Eqs_sub3manager.time7 + Eqs_sub3manager.time8 + Eqs_sub3manager.time9 + Eqs_sub3manager.time10) / 10;
            avg.text = "Average : " + average.ToString();
        }        // Update is called once per frame
            //void Update()
            //{

            //}
        }
    }
