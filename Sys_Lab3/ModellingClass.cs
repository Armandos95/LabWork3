using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys_Lab3
{
    class ModellingClass
    {
        private int sizeX;
        private int sizeY;
        private int preyAmount;
        private int predatorAmount;

        public ModellingClass(int sizeX, int sizeY, int preyAmount, int predatorAmount)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.preyAmount = preyAmount;
            this.predatorAmount = predatorAmount;
        }
    }
}
