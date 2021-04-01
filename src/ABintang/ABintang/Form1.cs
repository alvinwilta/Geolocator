using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace ABintang
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points;
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GMapProvider.GoogleMap.ApiKey = AppConfig.Key;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.BingOSMap;
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;

            PointLatLng point = new PointLatLng(lat,longt);
            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);

            //Create Overlay
            GMapOverlay markers = new GMapOverlay("markers");

            //Add all available markers to overlay
            markers.Markers.Add(marker);

            //Cover Map with Overlay
            map.Overlays.Add(markers);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void map_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnGetRouteInfo_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.
                GetRoute(_points[0], _points[1], false, false, 14);
            var r = new GMapRoute(route.Points, "My Route")
            {
                Stroke = new Pen(Color.Red, 5)
            };
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
        }
    }
}
