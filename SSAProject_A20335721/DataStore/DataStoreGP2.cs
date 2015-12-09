﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.DataStores
{
    public class DataStoreGP2 : DataStore
    {
        private int g;

        public int G
        {
            get { return g; }
            set { g = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private float tempa;

        public float Tempa
        {
            get { return tempa; }
            set { tempa = value; }
        }
        private float tempb;

        public float Tempb
        {
            get { return tempb; }
            set { tempb = value; }
        }

        public float floatTotal;

        private int temp_W;

        public int Temp_W
        {
            get { return temp_W; }
            set { temp_W = value; }
        }

        private int w;

        public int W
        {
            get { return w; }
            set { w = value; }
        }

        private float sPrice;

        public float SPrice
        {
            get { return sPrice; }
            set { sPrice = value; }
        }

        private float rPrice;

        public float RPrice
        {
            get { return rPrice; }
            set { rPrice = value; }
        }

        public override float getTempa()
        {
            return tempa;
        }

        public override float getTempb()
        {
            return tempb;
        }

        public override float getSPrice()
        {
            return sPrice;
        }

        public override float getRPrice()
        {
            return rPrice;
        }

        public override void setRPrice(float rPrice)
        {
            this.rPrice = rPrice;
        }

        public override void setSPrice(float sPrice)
        {
            this.sPrice = sPrice;
        }

        public override void setFloatPrice(float price)
        {
            this.price = price;
        }

        public override float getFloatPrice()
        {
            return price;
        }

        public override float getFloatTotal()
        {
            return floatTotal;
        }

        public override void setFloatTotal(float floatTotal)
        {
            this.floatTotal = floatTotal;
        }


        public override int getG()
        {
            return g;
        }

        public override void setG(int G)
        {
            this.g = G;
        }
    }
}
