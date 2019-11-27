using System;
using System.Collections.Generic;
using System.Text;
using database;
namespace Aispace
{
    public class Ai_3Class
    {
        public int ModelAi_3()//加权平均移动预测模型
        {
            select ReturnGofNrounds = new select();//实例化预测时期G值调用类
            int gPointN = 6;
            double gPointSum_n = 0;
            double calAi3 = 0;
            double gPointMul = 0;
            double[] g = ReturnGofNrounds.returnGofNrounds(gPointN);//调用数字层方法获取最近gPointN轮G值
            for (int i = 0; i < gPointN; i++)
            {
                gPointMul = (i + 1) * g[i];
                gPointSum_n += gPointMul;
            }
            for (int j = 1; j < gPointN + 1; j++) //Yn=(1*X1+2*X2+...+n*Xn)/(1+2+...+n)
            {
                gPointN += j;
            }
            calAi3 = gPointSum_n / gPointN;
            return (int)calAi3;
        }
        public double[] test4(int n)//Ai预测算法数据源模拟-（近n轮游戏G值）
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
