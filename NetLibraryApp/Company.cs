namespace NetLibraryApp
{
    public class Company
    {
        protected string title;
    }

    class Person
    {
        public Company company;
        public void SetTitle(string title)
        {
            company.title = title;
        }
    }

    class Agency : Company
    {
        public void SetTitle(string title)
        {
            this.title = title;
        }
    }
}
