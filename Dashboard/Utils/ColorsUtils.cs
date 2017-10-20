using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Dashboard.Utils
{
    public class ColorsUtils
    {
        #region Singleton
        private static ColorsUtils instance;

        Random RandomGen;
        KnownColor[] Names;
        KnownColor RandomColorName;
        private ColorsUtils() {
            RandomGen = new Random();
            Names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            
        }

        public static ColorsUtils Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ColorsUtils();
                }
                return instance;
            }
        }
        #endregion

        public Color GetRandomColor()
        {
            RandomColorName = Names[RandomGen.Next(Names.Length)];
            Color randomColor = Color.FromKnownColor(RandomColorName);

            return randomColor;
        }
    }
}