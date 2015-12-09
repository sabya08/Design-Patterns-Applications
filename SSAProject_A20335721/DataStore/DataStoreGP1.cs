using SSAProject_A20335721.AbstractFactoryNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SSAProject_A20335721.DataStores
{
    public class DataStoreGP1 : DataStore
    {
        private int temp_a;

        public int Temp_a
        {
            get { return temp_a; }
            set { temp_a = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

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

        private int c;

        public int C
        {
            get { return c; }
            set { c = value; }
        }


        private int temp_c;

        public int Temp_c
        {
            get { return temp_c; }
            set { temp_c = value; }
        }

        private int actualPrice;

        public int ActualPrice
        {
            get { return actualPrice; }
            set { actualPrice = value; }
        }

        public override void setPrice(int price) { this.price = price; }

        private int temp_G;

        public int Temp_G
        {
            get { return temp_G; }
            set { temp_G = value; }
        }

        private int g;

        public int G
        {
            get { return g; }
            set { g = value; }
        }

        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        
        
        public override int getPrice()
        {
            return this.price;
        }

        

        public override int getTemp_a()
        {
            return temp_a;
        }

        public override int getTemp_w()
        {
            return temp_W;
        }

        public override int getW()
        {
            return w;
        }

        public override void setW(int w)
        {
            this.W = w;
        }

        public override void set_c(int c)
        {
            this.c = c;
        }

        public override int get_c()
        {
            return c;
        }
        public override int getTemp_c()
        {
            return temp_c;
        }

        public override int getActualPrice()
        {
            return actualPrice;

        }

        public override void setActualPrice(int actualPrice)
        {
            this.actualPrice = actualPrice;
        }

        public override void setTempG(int tempG)
        {
            this.temp_G = tempG;
        }

        public override int getTempG()
        {
            return temp_G;
        }

        public override int getG()
        {
            return g;
        }

        public override void setG(int G)
        {
            this.g = G;
        }

        public override int getTotal()
        {
            return total;
        }

        public override void setTotal(int total)
        {
            this.total = total;
        }

    }
}
