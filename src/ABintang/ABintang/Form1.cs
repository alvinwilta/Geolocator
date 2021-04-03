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
        //private Button currentButton;
        private Input input;
        private Graph g;
        // private Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer;
        //private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private string filename;
        //private string algorithm = "null";
        private List<string> nodelist1;
        private List<string> nodelist2;
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            map.MapProvider = GMapProviders.BingOSMap;
            map2.MapProvider = GMapProviders.BingOSMap;
            map.DragButton = MouseButtons.Left;
            map2.DragButton = MouseButtons.Left;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map2.MinZoom = 5;
            map2.MaxZoom = 100;
            nodelist1 = new List<string>();
            nodelist2 = new List<string>();
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
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            map.Position = new PointLatLng(lat, longt);
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
            if (checkInputValid(txtLat.Text) && checkInputValid(txtLong.Text))
            {
                labelError1.Text = "";
                _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
            }
            else
            {
                labelError1.Text = "Wrong value";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnGetRouteInfo_Click(object sender, EventArgs e)
        {
            //var route = GoogleMapProvider.Instance.
            //    GetRoute(_points[0], _points[1], false, false, 14);
            //var r = new GMapRoute(route.Points, "My Route")
            //{
            //    Stroke = new Pen(Color.Red, 5)
            //};
            //var routes = new GMapOverlay("routes");
            //routes.Routes.Add(r);
            //map.Overlays.Add(routes);
            map.Overlays.Clear();
            foreach (var x in input.Kamus)
            {
                double lat2 = x.Value.Getlat();
                double longt2 = x.Value.Getlongt();
                PointLatLng point2 = new PointLatLng(lat2, longt2);
                GMarkerGoogle marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.blue_dot);
                marker2.ToolTipText = x.Value.Getname();
                //Create Overlay
                GMapOverlay markers2 = new GMapOverlay("markers");

                //Add all available markers to overlay
                markers2.Markers.Add(marker2);

                //Cover Map with Overlay
                map.Overlays.Add(markers2);

                GMaps.Instance.OptimizeMapDb(null);
                map.Refresh();

                //var labelMarker = new GmapMarkerWithLabel(point2, x.Value.Getname(), GMarkerGoogleType.blue_dot);
                //markers2.Markers.Add(labelMarker);
            }

            label3.Text = "";
            List<PointLatLng> points = new List<PointLatLng>();
            // buat variabel point, TranslatetoName() sama cek input
            List<Point> Solusi = g.ABintangShortestPath(input.Kamus, g.TranslatetoName(input.Kamus, comboStart.SelectedItem.ToString()), g.TranslatetoName(input.Kamus, comboFinish.SelectedItem.ToString()));
            double jarak = 0;
            for (int i = 0; i < Solusi.Count; i++)
            {
                label3.Text += Solusi[i].Getname();
                points.Add(new PointLatLng(Solusi[i].Getlat(), Solusi[i].Getlongt()));
                if (i != Solusi.Count - 1)
                {
                    label3.Text += " -> ";
                }
            }
            label3.Text += "\nJarak =";
            label3.Text += Convert.ToString(g.HitungJarak(input.Kamus, Solusi));
            label3.Text += " km";
            //points.Add(new PointLatLng(48.863868, 2.321554));
            //points.Add(new PointLatLng(48.861017, 2.330030));
            GMapOverlay routes = new GMapOverlay("routes");
            GMapRoute route = new GMapRoute(points, "A walk in the park");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            map.Overlays.Add(routes);

            //GMapProvider.GoogleMap.ApiKey = AppConfig.Key;
            map.DragButton = MouseButtons.Left;
            //map.MapProvider = GMapProviders.BingOSMap;
            double lat = input.Kamus.ElementAt(0).Value.Getlat();
            double longt = input.Kamus.ElementAt(0).Value.Getlongt();
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 16;
        }

        private void BtnInputDir_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName;
                this.FileDir.Text = filename;
                // parse input
                input = new Input(filename);
                // initialize graph
                g = new Graph(input.Node);
                g.InputGraph(input.DataNode, input.Kamus);
                //TODO
                //points.Add(_points[0]);
                //points.Add(_points[1]);
                foreach (var x in input.Kamus)
                {
                    double lat2 = x.Value.Getlat();
                    double longt2 = x.Value.Getlongt();
                    PointLatLng point2 = new PointLatLng(lat2, longt2);
                    GMarkerGoogle marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.blue_dot);
                    marker2.ToolTipText = x.Value.Getname();
                    //Create Overlay
                    GMapOverlay markers2 = new GMapOverlay("markers");

                    //Add all available markers to overlay
                    markers2.Markers.Add(marker2);

                    //Cover Map with Overlay
                    map.Overlays.Add(markers2);

                    GMaps.Instance.OptimizeMapDb(null);
                    map.Refresh();

                    //var labelMarker = new GmapMarkerWithLabel(point2, x.Value.Getname(), GMarkerGoogleType.blue_dot);
                    //markers2.Markers.Add(labelMarker);
                }
                //GMapProvider.GoogleMap.ApiKey = AppConfig.Key;
                map.DragButton = MouseButtons.Left;
                //map.MapProvider = GMapProviders.BingOSMap;
                double lat = input.Kamus.ElementAt(0).Value.Getlat();
                double longt = input.Kamus.ElementAt(0).Value.Getlongt();
                map.Position = new PointLatLng(lat, longt);
                map.MinZoom = 5;
                map.MaxZoom = 100;
                map.Zoom = 16;

                /*//Create Overlay
                GMapOverlay markers = new GMapOverlay("markers");

                //Cover Map with Overlay
                map.Overlays.Add(markers);*/

                //Create Combobox of nodes
                comboStart.Items.Clear();
                comboFinish.Items.Clear();
                foreach (var entry in input.Kamus)
                {
                    comboStart.Items.Add(entry.Value.Getname());
                    comboFinish.Items.Add(entry.Value.Getname());
                }
                //comboStart.DataSource = nodelist1;
                //comboFinish.DataSource = nodelist2;
            }
        }
        /*
        private void renderGraph()
        {
            // re-attach the graph to viewer
            // essentially, "update" the view with latest graph
            viewer.Graph = g.GetGraph();
        }*/

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //map2.DragButton = MouseButtons.Left;
            if (checkInputValid(txtLatitude.Text) && checkInputValid(txtLongitude.Text))
            {
                labelError2.Text = "";
                double lat = Convert.ToDouble(txtLatitude.Text);
                double lng = Convert.ToDouble(txtLongitude.Text);
                map2.Position = new PointLatLng(lat, lng);
                map2.MinZoom = 5;
                map2.MaxZoom = 100;
                map2.Zoom = 15;
            } 
            else
            {
                labelError2.Text = "Wrong input";
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // default Position
        private void button3_Click(object sender, EventArgs e)
        {         
            map2.Position = new PointLatLng(-6.891235014541753, 107.61071274138624);
            map2.Zoom = 15;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            map2.ShowCenter = false;
            GMapOverlay markers = new GMapOverlay("markers");
        }
        private Boolean checkInputValid(String input)
        {
            Double d;
            return Double.TryParse(input, out d);
        }

        private void comboStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboFinish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboFinish_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
