using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsConsole
{
    //Creational Pattern
    //Factory Method
    class FactoryMethod
    {

        public void start()
        {
            //
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            //
            foreach(Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "---");
                foreach(Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }

    //a 'ConcreteProduct' class
    abstract class Page 
    {
    }
    //a 'ConcreteProduct' class
    class SkillsPage : Page 
    {
    }
    //a 'ConcreteProduct' class
    class EducationPage : Page 
    {
    }
    //a 'ConcreteProduct' class
    class ExperincePage : Page 
    {
    }
    //a 'ConcreteProduct' class
    class IntroductionPage : Page 
    {
    }
    //a 'ConcreteProduct' class
    class ResultPage : Page 
    {
    }
    //a 'ConcreteProduct' class
    class ConclusionPage : Page 
    {
    }
    //a 'ConcreteProduct' class
    class SummaryPage : Page 
    {
    }
    //a 'ConcreteProduct' class
    class BibliographyPage : Page 
    {
    }

    //the 'Creator' class
    abstract class Document 
    {
        private List<Page> _pages = new List<Page>();

        //constructor calls abstract factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        //Factory Method
        public abstract void CreatePages();
    }

    //a 'ConcreteCreator' class
    class Resume : Document 
    {
        //Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperincePage());
        }
    }


    //a 'ConcreteCreator' class
    class Report : Document 
    {
        //Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
