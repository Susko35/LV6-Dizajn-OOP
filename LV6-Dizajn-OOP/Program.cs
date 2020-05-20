using LV6_Dizajn_OOP.Iterator;
using System;
using System.Text;
using LV6_Dizajn_OOP.Memento;

namespace LV6_Dizajn_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            note note = new note("Naslov","text, tijelo poruke");

            note.Show();

            StringBuilder sbTitle = new StringBuilder("Naslov p");
            StringBuilder sbBody = new StringBuilder("Text pp0");
            Notebook notebook = new Notebook();

            for (int i = 0; i<8; i++)
            {
                sbTitle.Append('w', i/2);
                sbBody.Append('b', i/3);
                notebook.AddNote(new note(sbTitle.ToString(), sbBody.ToString()));
            }


            CIterator iterator = new CIterator(notebook);
            iterator.First().Show();
            while(iterator.Next() != null)
            {
                iterator.Current.Show();
            }


            notebook.Clear();

            CareTaker careTaker = new CareTaker();
            ToDoItem tdi1 = new ToDoItem("naslov1", "text1", DateTime.Now);
            ToDoItem tdi2 = new ToDoItem("naslov12", "text12", DateTime.Now);
            ToDoItem tdi3 = new ToDoItem("naslov123", "text123", DateTime.MinValue);
            ToDoItem tdi4 = new ToDoItem("naslov1234", "text1234", DateTime.MaxValue);
            tdi1.AddStateCT(careTaker);
            tdi2.AddStateCT(careTaker);
            tdi3.AddStateCT(careTaker);
            tdi4.AddStateCT(careTaker);

           // tdi1.AddStateCT(careTaker); key mora biti unikatan, exception

            ToDoItem getStateTdi = new ToDoItem("", "", DateTime.MinValue);
            getStateTdi.RestoreState(careTaker.GetByTitle("naslov12")); // Case Sensitive

            Console.WriteLine(getStateTdi.ToString());

            }
    }
}
