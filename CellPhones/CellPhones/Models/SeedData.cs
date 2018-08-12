
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace CellPhones.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProviderFactory serviceProvider)
        {
            using (var context = new CellPhonesContext(serviceProvider.GetRequiredService<DbContextOptions<CellPhonesContext>>()))
            {
                //Look for any cellphones.
                if(context.Cellphone.Any())
                {
                    return; //DBhas been seeded
                }
                context.Cellphone.AddRange(
                    new Cellphone
                    {
                        Make = "iPhone",
                        Model = "5s",
                        OS = "MacOS",
                        ScreenSize = "1240 x 1560"

                    },

                           new Cellphone
                           {
                               Make = "iPhone",
                               Model = "6",
                               OS = "MacOS",
                               ScreenSize = "1240 x 1560"

                           },

                                  new Cellphone
                                  {
                                      Make = "iPhone",
                                      Model = "X",
                                      OS = "MacOS",
                                      ScreenSize = "2560 x 4000"
                                  }
                                  },

                                  context.SaveChanges();









                    )

            }
        }

    }
}
