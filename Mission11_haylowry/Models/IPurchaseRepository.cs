using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission11_haylowry.Models
{
    public interface IPurchaseRepository
    {
        public IQueryable<Purchase> Purchase { get; }
        public void SavePurchase(Purchase purchase);
    }
}
