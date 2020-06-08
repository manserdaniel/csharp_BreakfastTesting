using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace BreakfastTesting

{
    public class Breakfast
    {

        public static Coffee PourCoffee()
        {
            Coffee coffee = new Coffee();
            
            return coffee;
        }


        public static List<Eggs> FryEggs(int v)
        {
            var fryedEggs = new List<Eggs>();

            for (int i = 0; i < v; i++)
            {
                fryedEggs.Add(new Eggs());
            }
            return fryedEggs;

        }
        public static List<Bacon> FryBacon(int v)
        {
            var fryedEggs = new List<Bacon>();

            for (int i = 0; i < v; i++)
            {
                fryedEggs.Add(new Bacon());
            }
            return fryedEggs;
        }

        public static void EatBacon(List<Bacon> bacon, int v)
        {
            bacon.RemoveRange(0, v);
        }

        public static List<Toast> ToastBread(int v)
        {
            var toasts = new List<Toast>();

            for (int i = 0; i < v; i++)
            {
                toasts.Add(new Toast());
            }
            return toasts;
        }

        public static void ApplyButter(Toast toast)
        {
            toast.ButterApplied = true;
        }
        public static void ApplyJam(Toast toast)
        {
            toast.JamApplied = true;
        }

        
    }
}
