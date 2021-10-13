using System.Collections.Generic;
using FileData;
using Models;

namespace Assignment1.Data
{
    public interface IPersonService
    {
        void AddPerson(Adult adult);
        void EditPerson(Adult adult);
        void RemovePerson(int AdultId);
        
        Adult Get(int id);
        IList<Adult> GetAll();
    }
}