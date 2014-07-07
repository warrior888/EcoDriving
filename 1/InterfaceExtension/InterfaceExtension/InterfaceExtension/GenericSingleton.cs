using System;

namespace InterfaceExtension
{
    public class GenericSingleton<TDominika> where TDominika : new()
    {
        private static TDominika instance;

        protected GenericSingleton()
        {

        }

        public static TDominika GetInstance()
        {
            if (instance == null)
            {
                instance = new TDominika();
            }

            return instance;
        }
    }
}
