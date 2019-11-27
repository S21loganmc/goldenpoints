using System;
using System.Collections.Generic;
using System.Text;

namespace Aispace
{
    public class Ai_1Class
    {
        public int ModelAi_1()//随机扰动预测模型模型
        {
            Random rdAi1 = new Random();
            int calAi1 = rdAi1.Next(0, 100);
            return calAi1;
        }
    }


}
