using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets
{
   public class Outils
    {
       public static float AppliquerPourcentagePrecision(float valeurSlide)
       {
           float res = 0;

           System.Random o_random = new System.Random();

           bool positif = Convert.ToBoolean(o_random.Next() % 2);

           if(valeurSlide<=0.5)
           {
               res = valeurSlide * 2;
               if(positif)
               {
                   res = 1 + (1 - res);
               }
               
           }
           else
           {
               res = (1 - res) * 2;
               if(positif)
               {
                   res = 1 + (1 - res);
               }
           }

           if (res < 0.85f)
               res = 0.85f;
           else
               if (res > 1.15f)
                   res = 1.15f;

           if (valeurSlide > 0.4 && valeurSlide < 0.6)
               res = 1;

           return res;
       }
    }
}
