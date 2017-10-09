using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroLand.DataClasses.MapEntities;
using System.Threading;
using ZeroLand.DataClasses;
using ZeroLand.Logic;

namespace ZeroLand
{
    class Program
    {
        static void Main(string[] args)
        {
            DataKeeper.Init();
            var MainTread= new Thread(new ThreadStart(MainTreadWorker));
            MainTread.Start();
        }
        static void MainTreadWorker()
        {
            var mainLogic = new ZeroLandMainLogic();
            ///*
            while(true)
            {
                Thread.Sleep(10000);
                mainLogic.OneTact();
            }
            //*/

        }
    }
}
