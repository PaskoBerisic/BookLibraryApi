using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Specifications.Languages
{
    public class LanguageByIdWithIncludesSpecification : BaseSpecification<Language>
    {
        public LanguageByIdWithIncludesSpecification(int id) : base()
        {
            SetCriteria(x => x.Id == id);
        }
    }
}
