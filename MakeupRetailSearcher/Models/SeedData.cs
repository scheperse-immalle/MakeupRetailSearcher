using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeupRetailSearcher.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MakeupContext(
                serviceProvider.GetRequiredService<DbContextOptions<MakeupContext>>()))
            {
                // Look for any movies.
                if (context.Makeup.Any())
                {
                    return;   // DB has been seeded
                }

                context.Makeup.AddRange(
                     new Makeup
                     {
                         Product_Id = 1,
                         Product_Name = "DIORSHOW",
                         Brand = "Dior",
                         Price = 38.28,
                         Type = "MASCARA",
                         
                         Retailer_Id = 1,
                         Link = "https://www.dior.com/beauty/nl_be/parfum-en-beauty/make-up/ogen/mascara/pr-mascaras-y0697400-de-volumemascara-waarmee-het-lijkt-of-er-nieuwe-wimpers-ontstaan.html"
                     },
                       new Makeup
                       {
                           Product_Id = 1,
                           Product_Name = "DIORSHOW",
                           Brand = "Dior",
                           Price = 33.50,
                           Type = "MASCARA",
                           Retailer_Id = 2,                         
                           Link = "https://www.iciparisxl.be/nl/dior/diorshow-pro-black/mascara/p/BP_748850"
                       },
                        new Makeup
                        {
                            Product_Id = 1,
                            Product_Name = "DIORSHOW",
                            Brand = "Dior",
                            Price = 34.99,
                            Type = "MASCARA",
                            Retailer_Id = 3,
                            Link = "https://www.bol.com/nl/p/dior-diorshow-mascara-090-pro-black/9200000029322328/?country=BE"
                        },
                     new Makeup
                     {
                         Product_Id = 2,
                         Product_Name = "MSCRPRIMER",
                         Brand = "Dior",
                         Price = 34.43,
                         Type = "PRIMER",
                         Retailer_Id = 1,
                         Link= "https://www.dior.com/beauty/nl_be/parfum-en-beauty/make-up/ogen/eyes-primers/pr-eyeprimers-y0697970-serum-mascarabasis-booster-effect-volume-van-de-wimpers-x3.html"
                     },
                     new Makeup
                     {
                         Product_Id = 2,
                         Product_Name = "MSCRPRIMER",
                         Brand = "Dior",
                         Price = 32.90,
                         Type = "PRIMER",
                         Retailer_Id = 2,
                         Link = "https://www.iciparisxl.be/nl/dior/diorshow-maximizer-3d/plumping-lash-primer/p/BP_812557"
                     },
                     new Makeup
                     {
                         Product_Id = 2,
                         Product_Name = "MSCRPRIMER",
                         Brand = "Dior",
                         Price = 19.99,
                         Type = "PRIMER",
                         Retailer_Id = 4,
                         Link = "https://www.kruidvat.be/nl/dior-diorshow-maximizer-3d-lash-volume-x3-base-serum-de-mascara/p/4370220?country=BE"
                     }

                );
               

                
                context.SaveChanges();
                

            }
            using (var context1 = new RetailerContext(
               serviceProvider.GetRequiredService<DbContextOptions<RetailerContext>>()))
            {
                // Look for any movies.
                if (context1.Retailer.Any())
                {
                    return;   // DB has been seeded
                }

                context1.Retailer.AddRange(

                    new Retailer
                    {
                        Retailer_Name = "www.Dior.be",
                        Retailer_id = 1
                    },
                    new Retailer
                    {
                        Retailer_id = 2,
                        Retailer_Name="www.iciparisxl.be"

                    },
                    new Retailer
                    {
                        Retailer_id=3,
                        Retailer_Name="www.bol.com"
                    },
                    new Retailer
                    {
                        Retailer_id=4,
                        Retailer_Name="www.kruidvat.be"
                    }


                    );
                context1.SaveChanges();
            }

        }
    }
}
