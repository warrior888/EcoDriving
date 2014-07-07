namespace GenericList
{
    public class MyList<TGenList>
    {
        private TGenList[] list;

        private int size = 4;

        private int current;

        public int Count { get; private set; }

        // add

        public void Add(TGenList item)
        {
            current = Count;

            if (list == null)
            {
                list = new TGenList[this.size];
            }

            // sprAWDZENIE czy nie wyszlismy poza zakres
            // przepisania danych - prywatna metoda

            list[current] = item;
            Count++;
        }

        //removeAt

        //removeAll
    }
}
