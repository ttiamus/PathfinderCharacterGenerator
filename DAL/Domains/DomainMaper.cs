using Core.Domains;
using Core.Domains.Requests;
using Core.Domains.Responses;

namespace DAL.Domains
{
    public static class DomainMaper
    {
        public static DomainResponse ToDomainResponse(this Domain domain)
        {
            return new DomainResponse();
        }

        public static Domain ToDomain(this InsertDomainRequest request)
        {
            return new Domain();
        }

        public static Domain ToDomain(this UpdateDomainRequest request)
        {
            return new Domain();
        }
    }
}