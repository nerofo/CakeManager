using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Window;

namespace CakeManager.AsyncTask
{
    public class AsyncFactory
    {
        public async void TestItWithReturn()
        {
            Int32 result = await CountTo1000WithReturn();
        }

        /// <summary>
        /// Tache lancé en asynchrome
        /// </summary>
        public async void TestIt()
        {
            await CountTo10000();
        }

        /// <summary>
        /// Meme chose mais en version code plus court
        /// </summary>
        public void TestItFast()
        {
            Task.Factory.StartNew(() =>
            {
                //UTILISER CETTE PARTIE POUR MODIFIER LINTERFACE DEPUIS UN THREAD
                //Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, 
                //new ThreadStart(delegate 
                //{ 
                    //cette partie peut effectuer des changements sur l'interface
                //}))

                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }
            });//.Wait(milliseconde en timespan); attend que la tache se termine avec ou sans timeout
        }

        private Task CountTo10000()
        {
            Action count = new Action(() => 
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }
            });
            return Task.Run(count);
        }

        /// <summary>
        /// Tache executant un comptage retournant un numéro
        /// </summary>
        /// <returns></returns>
        private Task<Int32> CountTo1000WithReturn()
        {
            Func<Int32> count = new Func<Int32>(() =>
            {
                int i = 0;
                for (; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }
                return i;
            });
            return Task.Run(count);
        }
    }
}
