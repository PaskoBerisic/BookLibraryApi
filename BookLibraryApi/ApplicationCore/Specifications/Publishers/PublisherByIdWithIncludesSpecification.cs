using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Publishers
{
    public class PublisherByIdWithIncludesSpecification : BaseSpecification<Publisher>
    {
        public PublisherByIdWithIncludesSpecification(int id) : base()
        {
            SetCriteria(x => x.Id == id);
        }
    }
}
