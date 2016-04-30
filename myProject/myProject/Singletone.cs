using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myProject
{
    public class Singletone
    {
        protected Singletone()
        {
                
        }

        private static Singletone instanse;
        
        public static Singletone Instance
        {
            get
            {
                if (instanse == null)
                    instanse = new Singletone();
                return instanse;
            }                       
        }
    }
}
