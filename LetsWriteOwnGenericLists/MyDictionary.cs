using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsWriteOwnGenericLists
{
    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;
        

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempKeyArray = keys;
            Value[] tempValueArray = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValueArray[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        /// <summary>
        /// return Keys count
        /// </summary>
        public int CountKey
        {
            get { return keys.Length; }
        }

        /// <summary>
        /// return Values count
        /// </summary>
        public int CountValue
        {
            get { return values.Length; }
        }

        /// <summary>
        /// return keys
        /// </summary>
        public Key[] ItemsKey
        {
            get { return keys; }
        }

        /// <summary>
        /// return values
        /// </summary>
        public Value[] ItemsValue
        {
            get { return values; }
        }

        

    }
}
