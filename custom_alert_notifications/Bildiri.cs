using Rent_A_Car;
using System;
using System.Windows.Forms;

namespace custom_alert_notifications
{
    internal class Bildiri: Rent_A_Car.Bildiri
    {
       

        public Bildiri(string message, AlertType type) : base(message, type)
        {
           
        }
    }
}