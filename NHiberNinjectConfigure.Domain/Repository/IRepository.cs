namespace NHiberNinjectConfigure.Domain.Repository
{
    using System.Collections.Generic;
    using NHiberNinjectConfigure.Domain.Entities;

    public interface IRepository
    {
        IList<Post> Posts();
    }
}