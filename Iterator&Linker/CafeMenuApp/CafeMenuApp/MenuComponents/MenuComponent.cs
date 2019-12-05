using System.Collections;

namespace CafeMenuApp.MenuComponents
{
    public abstract class MenuComponent: IEnumerable
    {
        public virtual void Add(MenuComponent menuComponent) {}

        public abstract string Name { get; }

        public abstract string Description { get; }

        public virtual double Price { get; }

        public virtual bool Vegetarian { get; }

        public abstract void Print();

        public abstract IEnumerator GetEnumerator();
    }
}