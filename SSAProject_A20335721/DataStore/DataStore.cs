using SSAProject_A20335721.AbstractFactoryNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721.DataStores
{
    public abstract class DataStore
    {
        public static AbstractFactory abstractFactory;

        public virtual int getTemp_a () { return 0; }

        public virtual void setPrice(int price) { }

        public virtual int getPrice() { return 0; }

        public virtual int getW() { return 0; }

        public virtual void setW(int w) { }

        public virtual int getTemp_w() { return 0; }

        public virtual int getTemp_c() { return 0; }

        public virtual float getTempFloatc() { return 0; }

        public virtual void set_c(int c) { }

        public virtual int get_c() { return 0; }

        public virtual void setFloatCash(float c) { }

        public virtual float getFloatCash() { return 0; }

        public virtual void setActualPrice(int actualPrice) { }

        public virtual int getActualPrice() { return 0; }

        public virtual int getTempG() { return 0; }

        public virtual void setTempG(int tempG) { }

        public virtual void setG(int G) { }

        public virtual int getG() { return 0;}

        public virtual void setTotal(int total) { }

        public virtual int getTotal() { return 0; }

        //for gas pump 3
        public virtual void setL(int L) { }

        public virtual int getL() { return 0; }


        //for GasPump 2
        public virtual float getTempb() { return 0;}

        public virtual float getTempa() { return 0; }

        public virtual float getRPrice() { return 0; }

        public virtual float getSPrice() { return 0; }

        public virtual void setSPrice(float sPrice) { }

        public virtual void setRPrice(float rPrice) { }

        public virtual void setFloatPrice(float price) { }


        public virtual float getFloatPrice() { return 0; }

        public virtual void setFloatTotal(float total) { }


        public virtual float getFloatTotal() { return 0; }


    }
}
