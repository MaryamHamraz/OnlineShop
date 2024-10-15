using Model.DomainModels;


namespace Model.DataServices
{
    public class PersonDataService
    {
        #region [- SelectAll() -]
        public List<Person> SelectAll()
        {
            using (var context = new OnlineShopDbContext())
            {
                try
                {
                    var persons = context.Person.ToList();
                    return persons;
                }
                catch
                {
                    throw;
                }
            }
        }
        #endregion

        #region [- Insert() -]
        public void Insert(Person person)
        {
            try
            {
                using (var context = new OnlineShopDbContext())
                {
                    context.Person.Add(person);
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region [- Update() -]
        public void Update(int id, Person person)
        {
            try
            {
                using (var context = new OnlineShopDbContext())
                {
                    var personToModify = context.Person.SingleOrDefault(p => p.Id == id);
                    personToModify.FirstName = person.FirstName;
                    personToModify.LastName = person.LastName;
                    context.SaveChanges();

                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region [- Delete() -]
        public void Delete(int id)
        {
            try
            {
                using (var context = new OnlineShopDbContext())
                {
                    var personToDelete = context.Person.SingleOrDefault(p => p.Id == id);
                    context.Person.Remove(personToDelete);
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
