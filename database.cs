using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rent_A_Car
{
    class database
    {
        static string conString = @"Data Source=DESKTOP-KP1PN0G\BASE_SQL;Initial Catalog=RentACar;Integrated Security=True";
       // static string conString = @"Server=DESKTOP-KP1PN0G\BASE_SQL;Database=RentACar;";

        


        public static  SqlConnection veriBaglan = new SqlConnection(conString);
        public static SqlConnection baglan()
            {
                SqlConnection veriBaglan = new SqlConnection(conString);
                try
                {
                    veriBaglan.Open();


                }
                catch (Exception hata)
                {
                     MessageBox.Show("Hata Bulundu ->  " + hata.Message);
                }
                return veriBaglan;
            }




        
    }
}
