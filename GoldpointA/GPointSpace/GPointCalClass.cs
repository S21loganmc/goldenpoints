using System;
using System.Collections.Generic;
using System.Text;
using Aispace;
using database;
namespace GPointspace
{
    public class GPointCalClass
    {
        public double GPoint_Cal(string userName, int userPoint, int aiNum, ref string[] nameResult,ref int[] resultPoint,ref string[] allname)
        {
            AllAiClass allAiNum = new AllAiClass();//实例化ai调用类
            GameResultClass Result = new GameResultClass();//实例化游戏结果判定类
            add gameResultAdd = new add();//实例化游戏记录类
            string[] aiAllName = new string[aiNum];
            int[] aiAllPoint = new int[aiNum];
            string[] allName = new string[aiNum + 1];
            int[] allPoint = new int[aiNum + 1];
            int sumG = 0;
            double GPoint;
            bool ISGameResultAdd, ISGameWinerAdd, ISGameLloserAdd;
            allAiNum.GetAll_Ai(aiNum, ref aiAllName, ref aiAllPoint);//根据本轮ai数量调用ai逻辑模型，生成ai预测值
            sumG = userPoint;
            for (int i = 0; i < aiNum; i++)
            {
                sumG = sumG + aiAllPoint[i];
            }//计算ai及玩家预测值和值用于计算G值
            GPoint = sumG / (aiNum + 1) * 0.618;//计算本轮游戏G值             
            for (int i = 0; i < aiNum; i++)
            {
                allName[i] = aiAllName[i];
                allPoint[i] = aiAllPoint[i];
            }
            allName[aiNum] = userName;//存储本轮所有用户姓名
            allPoint[aiNum] = userPoint;//存储本轮所有预测值
            int userNum = allName.Length;//计算本轮所有用户数量
            nameResult = Result.GPointResult(GPoint, allName, allPoint, userNum);//得出本轮胜利及失败玩家名
            resultPoint = allPoint;
            allname = allName;
           ISGameResultAdd = gameResultAdd.add_usrgamedata(allname, resultPoint, (int)GPoint);//将本轮游戏所有用户名、预测值，G值存入数据库。
            ISGameWinerAdd=gameResultAdd.add_score(nameResult[0], userNum);//对本轮胜利玩家进行加分（参与用户数）
            ISGameLloserAdd=gameResultAdd.reduce_score(nameResult[1]);//对本轮失败玩家进行减分（-2）
            return GPoint;
        }//游戏G值计算核心逻辑（输入本轮游戏用户名，预测值，ai数量，输出游戏结果组<胜利者[0]，失败者[1]>，参与游戏预测值组，用户名组）
        public void text3(int[] allPoint, string[] allName, string[] nameResult)//输出测试
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(allName[i]);
                Console.WriteLine(allPoint[i]);
            }
            Console.WriteLine("失败{0}，胜利{1}", nameResult[1], nameResult[0]);
        }
    }
}
