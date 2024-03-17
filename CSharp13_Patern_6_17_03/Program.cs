namespace CSharp13_Patern_6_17_03
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    
    class ConcreteElementA : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
            
        }
    }

    class ConcreteElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
            
        }
    }

    
    interface IVisitor
    {
        void VisitConcreteElementA(ConcreteElementA elementA);
        void VisitConcreteElementB(ConcreteElementB elementB);
    }

    
    class ConcreteVisitor : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("Відвідувач обробляє елемент A");
            elementA.OperationA();
        }

        public void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("Відвідувач обробляє елемент B");
            elementB.OperationB();
        }
    }

    
    class Client
    {
        public void Main()
        {
            
            Element elementA = new ConcreteElementA();
            Element elementB = new ConcreteElementB();

            
            IVisitor visitor = new ConcreteVisitor();

            
            elementA.Accept(visitor);
            elementB.Accept(visitor);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Client client = new Client();
            client.Main();
        }
    }
}
