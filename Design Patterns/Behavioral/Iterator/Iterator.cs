using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Behavioral.Iterator
{
    public abstract class Iterator
    {
        abstract public object First();
        abstract public object Next();
        abstract public object Current();
        abstract public bool IsDone();

    }

    public class ConcreteIterator : Iterator
    {
        private int _current;
        private readonly ConcreteAggregate _aggregate;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
            _current = 0;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            if((_current + 1) == _aggregate.Count)
            {
                return true;
            }
            return false;
        }

        public override object Next()
        {
            return _aggregate[++_current];
        }

        public override object Current()
        {
            return _aggregate[_current];
        }

    }

    public abstract class Aggregate
    {
        abstract public Iterator CreateIterator();
        abstract public int Count { get; }
    }

    public class ConcreteAggregate : Aggregate
    {
        public List<int> _items;
        public ConcreteAggregate()
        {
            _items = new List<int>();
        }
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items.Insert(index, (int)value);
            }
        }

        public override int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public void Insert(int index, int value)
        {
            _items.Insert(index, value);
        }

        public void PushBack(int value)
        {
            _items.Add(value);
        }

    }

}
