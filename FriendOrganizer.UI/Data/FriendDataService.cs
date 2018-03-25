using FriendOrganizer.Model;
using System.Collections.Generic;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            yield return new Friend { FirstName = "Tomasz", LastName = "Huber" };
            yield return new Friend { FirstName = "Andrzej", LastName = "Konieczny" };
            yield return new Friend { FirstName = "Julia", LastName = "Konieczna" };
            yield return new Friend { FirstName = "Marcelina", LastName = "Huber" };
        }
    }
}
