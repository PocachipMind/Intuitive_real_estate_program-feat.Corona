using CoronaTrace.Model;
using CoronaTrace.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CoronaTrace.ViewModel
{
    public class InformationWindowVM 
    {
        public HouseInformation House { get; set; }

        //생성자
        public InformationWindowVM(int HouseId)
        {
            House = new HouseInformation();
            var house = HouseAPI.GetHouseInformation(HouseId);
            House.item = house.item;
            House.agent = house.agent;
            House.item.image_thumbnail += "?w=800";
            for (int i = 0; i < House.item.images.Count; i++)
            {
                House.item.images[i] += "?w=800";
            }
            House.ImageView = House.item.images[0];
        }

    }
}
