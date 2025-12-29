using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Seeding
{
    public static partial class ModelBuilderExtensions
    {
        public static void SeedPayments(ModelBuilder modelBuilder)
        {
            var payments = new List<Payment>();
            var baseDate = new DateTime(2024, 1, 1);
            int id = 1;

            // Payments for subscriptions: 1 -> 20
            for (int subId = 1; subId <= 20; subId++)
            {
                bool isBasic = (subId % 2 == 0);

                payments.Add(new Payment
                {
                    Id = id++,
                    SubscriptionId = subId,

                    Amount = isBasic ? 50m : 200m,
                    Currency = "EGP",

                    PaymentMethod = isBasic ? "VodafoneCash" : "CreditCard",
                    ProviderReference = $"TXN{subId:00000}",

                    Status = "Paid",

                    CreatedAt = baseDate.AddDays(subId),
                    UpdatedAt = baseDate.AddDays(subId)
                });
            }

            modelBuilder.Entity<Payment>().HasData(payments);
        }
    }
}
