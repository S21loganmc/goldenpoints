using System;
using System.Collections.Generic;
using System.Text;

namespace GPointspace
{
    public class GameResultClass
    {
        public string[] GPointResult(double gPoint, string[] allName, int[] allPoint, int userNum)
        {
            string[] nameResult = new string[2];
            double[] dValue = new double[userNum];
            double dValuemin = allPoint[0];
            double dValuemax = allPoint[0];
            int minNum = 0;
            int maxNum = 0;
            for (int i = 0; i < userNum; i++)
            {
                dValue[i] = Math.Abs(allPoint[i] - gPoint);
            }//计算所有用户预测值与G值相差的绝对值
            for (int i = 0; i < userNum; i++)
            {
                if (dValue[i] <= dValuemin)
                { dValuemin = dValue[i]; minNum = i; }
            }//比较预测值最近的分数，得到该值下标
            nameResult[0] = allName[minNum];//存储胜利玩家名


            for (int j = 1; j < userNum; j++)
            {
                if (dValue[j] >= dValuemax)
                { dValuemax = dValue[j]; maxNum = j; }
            }//比较预测值最远的分数，得到该值下标
            nameResult[1] = allName[maxNum];//存储失败玩家名
            return nameResult;
        }//比较得出胜利与失败玩家名
    }
}
