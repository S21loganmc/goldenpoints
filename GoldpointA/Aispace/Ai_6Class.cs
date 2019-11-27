using System;
using System.Collections.Generic;
using System.Text;
using database;
namespace Aispace
{
    public class Ai_6Class
    {
        public int ModelAi_6()//一次线性回归预测模型
        {
            select ReturnGofNrounds = new select();//实例化预测时期G值调用类
            int gPointN = 6;//预测时期
            double calAi6;
            double kAvg = 0;
            double kSum = 0;
            double bAvg = 0;
            double bSum = 0;
            double[] g = ReturnGofNrounds.returnGofNrounds(gPointN);//调用数字层方法获取最近gPointN轮G值
            for (int i = 0; i < gPointN; i++)
            {
                for (int j = 0; j < gPointN; j++)
                {
                    double k = g[j] - g[i];//k=（y2-y1)/(x2-x1)
                    kSum = kSum + k;
                }
            }//一次线性回归系数和
            kAvg = kSum / (gPointN * (gPointN - 1));//一次线性回归截距平均值
            for (int i = 0; i < gPointN; i++)
            {
                double b = g[i] - kAvg * (i + 1);//b = y - kx
                bSum = bSum + b;
            }
            bAvg = bSum / (gPointN * (gPointN - 1));//一次线性回归截距平均值
            calAi6 = kAvg * (gPointN + 1) + bAvg;
            return (int)calAi6;
        }

        public double[] test6(int n)//Ai预测算法数据源模拟-（近n轮游戏G值）
        {
            Random rdAi1 = new Random();
            double[] gPointAll_n = new double[n];
            for (int i = 0; i < n; i++)
            {
                gPointAll_n[i] = rdAi1.Next(0, 100);
            }
            return gPointAll_n;
        }
    }



}

