using System;
using System.Collections.Generic;
using System.Text;
using database;
namespace Aispace
{
    public class Ai_5Class
    {
        public int ModelAi_5()//均值增幅预测模型
        {
            select ReturnGofNrounds = new select();//实例化预测时期G值调用类
            int gPointN = 6;//预测时期
            double gPointSum_n = 0;
            double calAi5 = 0;
            double[] g = ReturnGofNrounds.returnGofNrounds(gPointN);//调用数字层方法获取最近gPointN轮G值
            for (int i = 0; i < gPointN; i++)
            {
                gPointSum_n += g[i];//前gPointN轮G值和
            }
            calAi5 = gPointSum_n / gPointN;
            calAi5 += 0.5;
            return (int)calAi5;
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
