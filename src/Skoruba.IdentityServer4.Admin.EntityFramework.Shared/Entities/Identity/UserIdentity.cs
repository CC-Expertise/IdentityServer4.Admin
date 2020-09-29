using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Identity;

namespace Skoruba.IdentityServer4.Admin.EntityFramework.Shared.Entities.Identity
{
	public class UserIdentity : IdentityUser
	{
        public bool SystemAdmin { get; set; }
        public bool OrganisationAdmin { get; set; }
        public string UpdatedById { get; set; }

        [ForeignKey("UpdatedById")]
        [IgnoreDataMember]
        public UserIdentity UpdatedBy { get; set; }
    }
}