using System;
using System.Collections.Generic;
using System.Text;

namespace Aispace
{
    public class AllAiClass
    {
        Ai_1Class Ai_1 = new Ai_1Class();
        Ai_2Class Ai_2 = new Ai_2Class();
        Ai_3Class Ai_3 = new Ai_3Class();
        Ai_4Class Ai_4 = new Ai_4Class();
        Ai_5Class Ai_5 = new Ai_5Class();
        Ai_6Class Ai_6 = new Ai_6Class();
        public void GetAll_Ai(int aiNum, ref string[] allAiName, ref int[] allAiPoint)//接收本轮游戏Ai数量，输出本轮游戏所有单位（玩家、AI）用户名组及预测值组）
        {
            allAiName = new string[aiNum];
            allAiPoint = new int[aiNum];
            int[] k = GetRandomArray(aiNum, 1, 6);//接收本轮游戏AI抽取单位及顺序
            for (int i = 0; i < aiNum; i++)
            {
                switch (k[i])
                {
                    case 1:
                        allAiPoint[i] = Ai_1.ModelAi_1();
                        allAiName[i] = "Ai1";
                        break;
                    case 2:
                        allAiPoint[i] = Ai_2.ModelAi_2();
                        allAiName[i] = "Ai2";
                        break;
                    case 3:
                        allAiPoint[i] = Ai_3.ModelAi_3();
                        allAiName[i] = "Ai3";
                        break;
                    case 4:
                        allAiPoint[i] = Ai_4.ModelAi_4();
                        allAiName[i] = "Ai4";
                        break;
                    case 5:
                        allAiPoint[i] = Ai_5.ModelAi_5();
                        allAiName[i] = "Ai5";
                        break;
                    case 6:
                        allAiPoint[i] = Ai_6.ModelAi_6();
                        allAiName[i] = "Ai6";
                        break;
                }
            }//进行AI的调用，并接收AI预测值
            int[] GetRandomArray(int Number, int minNum, int maxNum)//接收本轮游戏数量aiNum
            {
                int j;
                int[] b = new int[Number];
                Random r = new Random();
                for (j = 0; j < Number; j++)
                {
                    int i = r.Next(minNum, maxNum + 1);
                    int num = 0;
                    for (int l = 0; l < j; l++)
                    {
                        if (b[l] == i)
                        {
                            num = num + 1;
                        }
                    }
                    if (num == 0)
                    {
                        b[j] = i;
                    }
                    else
                    {
                        j = j - 1;
                    }
                }
                return b;
            }//生成AI抽取单位及顺序

        }
    }
}
