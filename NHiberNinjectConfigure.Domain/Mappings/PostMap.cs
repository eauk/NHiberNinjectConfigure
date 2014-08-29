namespace NHiberNinjectConfigure.Domain.Mappings
{
    using FluentNHibernate.Mapping;
    using NHiberNinjectConfigure.Domain.Entities;

    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(r => r.Id);
            Map(r => r.Text).Nullable();
            Map(r => r.Title).Nullable();
        }
    }
}