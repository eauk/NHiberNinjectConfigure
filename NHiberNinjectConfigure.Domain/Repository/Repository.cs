namespace NHiberNinjectConfigure.Domain.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentNHibernate.Utils;
    using NHibernate;
    using NHibernate.Linq;
    using NHiberNinjectConfigure.Domain.Entities;

    public class Repository : IRepository
    {
        readonly ISession _session;

        public Repository(ISession session)
        {
            _session = session;
        }
        public IList<Post> Posts()
        {
            return _session.Query<Post>().ToList();
        }
    }
}