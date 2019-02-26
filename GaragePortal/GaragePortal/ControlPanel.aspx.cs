using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GaragePortal;



namespace GaragePortal
{
    public partial class ControlPanel : System.Web.UI.Page
    {
        List<App_Code.CarData> CarsList;
        protected void Page_Load(object sender, EventArgs e)
        {
            HandleGui();
        }

        private void HandleGui()
        {
            CarsList = new List<App_Code.CarData>()
            {
                new App_Code.CarData{Brand="Reno", Model="2015", Price=0, Reason="Engine error", Id=1},
                new App_Code.CarData{Brand="Reno", Model="2016", Price=0, Reason="Gear error", Id=2},
                new App_Code.CarData{Brand="Reno", Model="2017", Price=0, Reason="Electric error", Id=3},
                new App_Code.CarData{Brand="Reno", Model="2018", Price=0, Reason="Vantile error", Id=4},
                new App_Code.CarData{Brand="Reno", Model="2019", Price=0, Reason="Door error", Id=5}
            };

            grid__carsTable.DataSource = CarsList;
            grid__carsTable.DataBind();
            //sql_grage.DataSourceMode = SqlDataSourceMode.DataSet;
        }
    }

}