using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCartEF.Domain.Model.Core
{
    public abstract class BaseEntity : IEquatable<BaseEntity>//, IAuditable
    {
        [Key]
        public int Id { get; set; }
        //public string CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public string ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }

        public bool Equals(BaseEntity other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other is null)
                return false;
            return other.GetHashCode() == GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BaseEntity);
        }

        public static bool operator ==(BaseEntity e1, BaseEntity e2)
        {
            if (e1 is null)
                return e2 is null;

            return e1.Equals(e2);
        }

        public static bool operator !=(BaseEntity e1, BaseEntity e2)
        {
            return !(e1 == e2);
        }

        public override int GetHashCode()
        {
            int hash = 25;
            return hash * 59 + this.Id.GetHashCode();
        }

    }
}
