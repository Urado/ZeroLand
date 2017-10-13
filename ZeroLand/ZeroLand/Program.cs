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
        static public ZeroLandMainLogic mainLogic = new ZeroLandMainLogic();
        static void Main(string[] args)
        {
            DataKeeper.Init();
            var MainTread = new Thread(new ThreadStart(MainTreadWorker));
            var OutTread = new Thread(new ThreadStart(OutTreadWorker));
            MainTread.Start();
            OutTread.Start();
        }
        static void MainTreadWorker()
        {
            ///*
            while (true)
            {
                Thread.Sleep(1000);
                mainLogic.OneTact();
            }
            //*/

        }
        static void OutTreadWorker()
        {
            while (true)
            {
                Thread.Sleep(5000);
                mainLogic.OutNow();
            }
        }
    }
}
